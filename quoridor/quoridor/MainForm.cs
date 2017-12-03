using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quoridor
{
    public partial class MainForm : Form
    {
        enum Player { Noplayer, Player1, Player2 };
        enum Type { Invalid, Hor, Ver, Move };
        public struct Point
        {
            public int x, y;
            public Point(int xx, int yy)
            {
                x = xx;
                y = yy;
            }
        }
        struct Decision
        {
            public Type type;
            public Point p1, p2, p;
            public Decision(Type tp)
            {
                type = tp;
                p1 = p2 = p = new Point(0, 0);
            }
            public Decision(Type tp, Point pp1, Point pp2)
            {
                type = tp;
                p1 = pp1;
                p2 = pp2;
                p = new Point(0, 0);
            }
            public Decision(Type tp, Point pp)
            {
                type = tp;
                p = pp;
                p1 = p2 = new Point(0, 0);
            }
        }

        const int d = 60;
        const int s = 12;
        const int r = 5;
        int width, height;

        int currentTime;
        Player currentPlayer;
        int[] remainBlock;
        int[] remainTime;
        int[] score;
        bool[,] vBoard, hBoard;
        Point pos1, pos2;
        Decision currentDecision;

        BufferedGraphicsContext bufferedGraphicsContext;
        BufferedGraphics bufferedGraphics;

        public MainForm()
        {
            InitializeComponent();

            bufferedGraphicsContext = BufferedGraphicsManager.Current;
            bufferedGraphics = bufferedGraphicsContext.Allocate(canvas.CreateGraphics(), canvas.DisplayRectangle);
            width = canvas.Width;
            height = canvas.Height;

            currentTime = 0;
            currentPlayer = Player.Noplayer;
            remainBlock = new int[2];
            remainTime = new int[2];
            score = new int[2];
            vBoard = new bool[9, 9];
            hBoard = new bool[9, 9];
            visited = new bool[9, 9];

            remainBlock[0] = remainBlock[1] = 10;
            remainTime[0] = remainTime[1] = 10 * 60;
            score[0] = score[1] = 0;
            pos1 = new Point(4, 0);
            pos2 = new Point(4, 8);

            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    vBoard[i,j] = hBoard[i,j] = false;
            RefrashInfo();
        }

        int abs(int x)
        {
            return x < 0 ? -x : x;
        }
        int min(int a, int b)
        {
            return a < b ? a : b;
        }
        int max(int a, int b)
        {
            return a > b ? a : b;
        }
        bool[,] visited;
        bool dfs(int x, int y, Player srcPlayer)
        {
            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };
            visited[x, y] = true;
            if(srcPlayer == Player.Player1)
            {
                if (y == 8) return true;
            }
            else
            {
                if (y == 0) return true;
            }
            for(int d = 0; d < 4; d++)
            {
                int xx = x + dx[d];
                int yy = y + dy[d];
                if(0 <= xx && xx < 9 && 0 <= yy && yy < 9 && !visited[xx,yy] 
                    && CanJump(new Point(x,y), new Point(xx,yy)))
                {
                    if (dfs(xx, yy, srcPlayer)) return true;
                }
            }
            return false;
        }
        bool AccessValid()
        {
            bool res1, res2;
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    visited[i, j] = false;
            res1 = dfs(pos1.x, pos1.y, Player.Player1);
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    visited[i, j] = false;
            res2 = dfs(pos2.x, pos2.y, Player.Player2);
            return res1 && res2;
        }
        bool CanJump(Point p1, Point p2)
        {
            int dis = abs(p1.x - p2.x) + abs(p1.y - p2.y);
            if (dis != 1) return false;
            if (p1.x == p2.x)
            {
                int ymin = min(p1.y, p2.y);
                int ymax = max(p1.y, p2.y);
                return !hBoard[p1.x, ymin];
            }
            else
            {
                int xmin = min(p1.x, p2.x);
                int xmax = max(p1.x, p2.x);
                return !vBoard[xmin, p1.y];
            }
        }
        bool MoveValid(Point src, Point dst, Point other)
        {
            if (dst.x == other.x && dst.y == other.y) return false;
            if (CanJump(src, dst)) return true;
            if (CanJump(src, other) && CanJump(other, dst)) return true;
            return false;
        }
        Decision DetectDecision(int x, int y)
        {
            if (currentPlayer == Player.Noplayer || x < s || y < s || x > width - s || y > height - s)
            {
                return new Decision(Type.Invalid);
            }
            else
            {
                int mx = (x - s) % (d + s);
                int my = (y - s) % (d + s);
                int px = (x - s) / (d + s);
                int py = (y - s) / (d + s);
                if(mx < d && my < d)
                {
                    Point src, dst, other;
                    if(currentPlayer == Player.Player1)
                    {
                        src = pos1;
                        other = pos2;
                    } 
                    else
                    {
                        src = pos2;
                        other = pos1;
                    }
                    dst = new Point(px, py);
                    
                    if(MoveValid(src,dst,other))
                    {
                        return new Decision(Type.Move, new Point(px, py));
                    } 
                    else
                    {
                        return new Decision(Type.Invalid);
                    }
                }
                else if(mx < d && my >= d)
                {
                    if (currentPlayer == Player.Player1 && remainBlock[0] == 0
                       || currentPlayer == Player.Player2 && remainBlock[1] == 0)
                        return new Decision(Type.Invalid);
                    if (px < 9 && px + 1 < 9 && !hBoard[px,py] && !hBoard[px+1,py])
                    {

                        hBoard[px, py] = hBoard[px + 1, py] = true;
                        bool result = AccessValid();
                        hBoard[px, py] = hBoard[px + 1, py] = false;
                        if (result == true)
                            return new Decision(Type.Hor, new Point(px, py), new Point(px + 1, py));
                        else
                            return new Decision(Type.Invalid);
                    }
                    else
                    {
                        return new Decision(Type.Invalid);
                    }
                }
                else if(mx >= d && my < d)
                {
                    if (currentPlayer == Player.Player1 && remainBlock[0] == 0
                         || currentPlayer == Player.Player2 && remainBlock[1] == 0)
                        return new Decision(Type.Invalid);
                    if (py < 9 && py + 1 < 9 && !vBoard[px,py] && !vBoard[px,py+1])
                    {
                        vBoard[px, py] = vBoard[px, py + 1] = true;
                        bool result = AccessValid();
                        vBoard[px, py] = vBoard[px, py + 1] = false;
                        if (result == true)
                            return new Decision(Type.Ver, new Point(px, py), new Point(px, py + 1));
                        else
                            return new Decision(Type.Invalid);
                    }
                    else
                    {
                        return new Decision(Type.Invalid);
                    }
                }
                else
                {
                    return new Decision(Type.Invalid);
                }
            }
        }
        private void RefrashInfo()
        {
            labelCurrentTime.Text 
                = (currentTime / (60 * 60)).ToString("D2") 
                + ":" + ((currentTime % (60 * 60)) / 60).ToString("D2") 
                + ":" + (currentTime % 60).ToString("D2");
            if (currentPlayer == Player.Noplayer)
                labelCurrentPlayer.Text = "Noplayer";
            else if (currentPlayer == Player.Player1)
                labelCurrentPlayer.Text = "Player 1";
            else
                labelCurrentPlayer.Text = "Player 2";
            labelBlocks1.Text = remainBlock[0].ToString("D2");
            labelBlocks2.Text = remainBlock[1].ToString("D2");
            labelRemainTime1.Text = (remainTime[0] / 60).ToString("D2") + ":" + (remainTime[0] % 60).ToString("D2");
            labelRemainTime2.Text = (remainTime[1] / 60).ToString("D2") + ":" + (remainTime[1] % 60).ToString("D2");
            labelScore1.Text = score[0].ToString();
            labelScore2.Text = score[1].ToString();
        }
        

        private void DrawBoard(Graphics gg)
        {
            double alpha = 0.7;
            Graphics g = bufferedGraphics.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Color canvasBackColor = buttonCanvasColor.BackColor;
            Color squareBackColor = buttonSquareColor.BackColor;
            Color blockColor = buttonBlockColor.BackColor;
            Color playerColor1 = buttonColor1.BackColor;
            Color playerColor2 = buttonColor2.BackColor;
            SolidBrush canvasBrush = new SolidBrush(canvasBackColor);
            SolidBrush squareBrush = new SolidBrush(squareBackColor);
            SolidBrush blockBrush = new SolidBrush(blockColor);
            SolidBrush playerBrush1 = new SolidBrush(playerColor1);
            SolidBrush playerBrush2 = new SolidBrush(playerColor2);

            g.FillRectangle(canvasBrush, 0, 0, canvas.Width, canvas.Height);
            for(int x = 12; x < canvas.Width; x += d + s)
                for(int y = 12; y < canvas.Height; y += d + s)
                {
                    g.FillRectangle(squareBrush, x, y, d, d);
                }
            for(int px = 0; px < 9; px++)
                for(int py = 0; py < 9; py++)
                {
                    if(py < 8 && hBoard[px,py])
                    {
                        g.FillRectangle(blockBrush, 12 + px * (d + s), 12 + py * (d + s) + d, d, s);
                    }
                    if(px < 8 && vBoard[px,py])
                    {
                        g.FillRectangle(blockBrush, 12 + px * (d + s) + d, 12 + py * (d + s), s, d);
                    }
                }
            
            g.FillEllipse(playerBrush1, 12 + r + (d + s) * pos1.x, 12 + r + (d + s) * pos1.y, d - r - r, d - r - r);
            g.FillEllipse(playerBrush2, 12 + r + (d + s) * pos2.x, 12 + r + (d + s) * pos2.y, d - r - r, d - r - r);
            if(currentDecision.type == Type.Move)
            {
                Point p = currentDecision.p;
                Color oldColor = (currentPlayer == Player.Player1) ? playerColor1 : playerColor2;
                Color newColor = Color.FromArgb((int)(alpha * 255), oldColor);
                SolidBrush newBrush = new SolidBrush(newColor);
                g.FillEllipse(newBrush, 12 + r + (d + s) * p.x, 12 + r + (d + s) * p.y, d - r - r, d - r - r);
            }
            else if(currentDecision.type == Type.Ver)
            {
                Point p1 = currentDecision.p1;
                Point p2 = currentDecision.p2;
                Color newColor = Color.FromArgb((int)(alpha * 255), blockColor);
                SolidBrush newBrush = new SolidBrush(newColor);
                g.FillRectangle(newBrush, 12 + p1.x * (d + s) + d, 12 + p1.y * (d + s), s, d);
                g.FillRectangle(newBrush, 12 + p2.x * (d + s) + d, 12 + p2.y * (d + s), s, d);
            }
            else if(currentDecision.type == Type.Hor)
            {
                Point p1 = currentDecision.p1;
                Point p2 = currentDecision.p2;
                Color newColor = Color.FromArgb((int)(alpha * 255), blockColor);
                SolidBrush newBrush = new SolidBrush(newColor);
                g.FillRectangle(newBrush, 12 + p1.x * (d + s), 12 + p1.y * (d + s) + d, d, s);
                g.FillRectangle(newBrush, 12 + p2.x * (d + s), 12 + p2.y * (d + s) + d, d, s);
            }
            bufferedGraphics.Render(gg);
        }

        private void DrawBoard()
        {
            Graphics g = canvas.CreateGraphics();
            DrawBoard(g);
            g.Dispose();
        }

        private void StartNewGame()
        {
            currentPlayer = (score[0] + score[1]) % 2 == 0 ? Player.Player1 : Player.Player2;
            remainBlock[0] = remainBlock[1] = 10;
            remainTime[0] = remainTime[1] = 10 * 60;
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    vBoard[i, j] = hBoard[i, j] = false;//((i+j) & 2) == 0;
            buttonStart.Enabled = false;
            pos1 = new Point(4, 0);
            pos2 = new Point(4, 8);
            DrawBoard();
        }

        Player GetWinner()
        {
            if (pos1.y == 8) return Player.Player1;
            if (pos2.y == 0) return Player.Player2;
            return Player.Noplayer;
        }

        private void PlayerWin(Player player)
        {
            string info = "Player " + (player == Player.Player1 ? "1" : "2") + " wins";
            MessageBox.Show(info, "Congratulations");

            currentPlayer = Player.Noplayer;
            if(player == Player.Player1)
            {
                score[1]++;
            }
            else
            {
                score[0]++;
            }
            buttonStart.Enabled = true;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            DrawBoard(e.Graphics);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void buttonColor1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.Color = buttonColor1.BackColor;
            if(colorDialog.ShowDialog() == DialogResult.OK)
                buttonColor1.BackColor = colorDialog.Color;
            colorDialog.Dispose();
            DrawBoard();
        }

        private void buttonColor2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.Color = buttonColor2.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
                buttonColor2.BackColor = colorDialog.Color;
            colorDialog.Dispose();
            DrawBoard();
        }

        private void buttonCanvasColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.Color = buttonCanvasColor.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
                buttonCanvasColor.BackColor = colorDialog.Color;
            colorDialog.Dispose();
            DrawBoard();
        }

        private void buttonSquareColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.Color = buttonSquareColor.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
                buttonSquareColor.BackColor = colorDialog.Color;
            colorDialog.Dispose();
            DrawBoard();
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            currentDecision = DetectDecision(e.X, e.Y);
            DrawBoard();
        }

        private void canvas_Click(object sender, EventArgs e)
        {
            bool isplayer1 = currentPlayer == Player.Player1;
            Point p1 = currentDecision.p1;
            Point p2 = currentDecision.p2;
            if (currentDecision.type == Type.Move)
            {
                if (isplayer1)
                    pos1 = currentDecision.p;
                else
                    pos2 = currentDecision.p;
            }
            else if(currentDecision.type == Type.Hor)
            {
                hBoard[p1.x, p1.y] = hBoard[p2.x, p2.y] = true;
                if (isplayer1) remainBlock[0]--;
                else remainBlock[1]--;
            }
            else if(currentDecision.type == Type.Ver)
            {
                vBoard[p1.x, p1.y] = vBoard[p2.x, p2.y] = true;
                if (isplayer1) remainBlock[0]--;
                else remainBlock[1]--;
            }
            if (isplayer1) currentPlayer = Player.Player2;
            else currentPlayer = Player.Player1;
            DrawBoard();
            RefrashInfo();
            Player winner = GetWinner();
            if (winner != Player.Noplayer)
                PlayerWin(winner);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            bufferedGraphics.Dispose();
        }

        private void buttonBlockColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.Color = buttonBlockColor.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
                buttonBlockColor.BackColor = colorDialog.Color;
            colorDialog.Dispose();
            DrawBoard();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime++;
            if (currentPlayer == Player.Noplayer)
            {
                //  do nothing
            } 
            else if(currentPlayer == Player.Player1)
            {
                remainTime[0]--;
                if(remainTime[0] == 0)
                {
                    PlayerWin(Player.Player2);
                }
            }
            else if(currentPlayer == Player.Player2)
            {
                remainTime[1]--;
                if(remainTime[1] == 0)
                {
                    PlayerWin(Player.Player1);
                }
            }
            RefrashInfo();
        }
    }
}
