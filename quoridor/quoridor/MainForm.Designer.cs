namespace quoridor
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.canvas = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelScore1 = new System.Windows.Forms.Label();
            this.labelRemainTime1 = new System.Windows.Forms.Label();
            this.labelBlocks1 = new System.Windows.Forms.Label();
            this.buttonColor1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelScore2 = new System.Windows.Forms.Label();
            this.labelRemainTime2 = new System.Windows.Forms.Label();
            this.labelBlocks2 = new System.Windows.Forms.Label();
            this.buttonColor2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.buttonBlockColor = new System.Windows.Forms.Button();
            this.buttonSquareColor = new System.Windows.Forms.Button();
            this.buttonCanvasColor = new System.Windows.Forms.Button();
            this.labelCurrentPlayer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(12, 14);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(660, 660);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelScore1);
            this.groupBox1.Controls.Add(this.labelRemainTime1);
            this.groupBox1.Controls.Add(this.labelBlocks1);
            this.groupBox1.Controls.Add(this.buttonColor1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(691, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 128);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 1";
            // 
            // labelScore1
            // 
            this.labelScore1.AutoSize = true;
            this.labelScore1.Location = new System.Drawing.Point(109, 75);
            this.labelScore1.Name = "labelScore1";
            this.labelScore1.Size = new System.Drawing.Size(11, 12);
            this.labelScore1.TabIndex = 4;
            this.labelScore1.Text = "0";
            // 
            // labelRemainTime1
            // 
            this.labelRemainTime1.AutoSize = true;
            this.labelRemainTime1.Location = new System.Drawing.Point(109, 49);
            this.labelRemainTime1.Name = "labelRemainTime1";
            this.labelRemainTime1.Size = new System.Drawing.Size(35, 12);
            this.labelRemainTime1.TabIndex = 4;
            this.labelRemainTime1.Text = "10:00";
            // 
            // labelBlocks1
            // 
            this.labelBlocks1.AutoSize = true;
            this.labelBlocks1.Location = new System.Drawing.Point(109, 23);
            this.labelBlocks1.Name = "labelBlocks1";
            this.labelBlocks1.Size = new System.Drawing.Size(17, 12);
            this.labelBlocks1.TabIndex = 4;
            this.labelBlocks1.Text = "10";
            // 
            // buttonColor1
            // 
            this.buttonColor1.BackColor = System.Drawing.Color.Maroon;
            this.buttonColor1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonColor1.Location = new System.Drawing.Point(111, 96);
            this.buttonColor1.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColor1.Name = "buttonColor1";
            this.buttonColor1.Size = new System.Drawing.Size(26, 23);
            this.buttonColor1.TabIndex = 3;
            this.buttonColor1.UseVisualStyleBackColor = false;
            this.buttonColor1.Click += new System.EventHandler(this.buttonColor1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Remain Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remain Blocks:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(757, 507);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(105, 41);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start New Game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelScore2);
            this.groupBox2.Controls.Add(this.labelRemainTime2);
            this.groupBox2.Controls.Add(this.labelBlocks2);
            this.groupBox2.Controls.Add(this.buttonColor2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(692, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 1";
            // 
            // labelScore2
            // 
            this.labelScore2.AutoSize = true;
            this.labelScore2.Location = new System.Drawing.Point(109, 75);
            this.labelScore2.Name = "labelScore2";
            this.labelScore2.Size = new System.Drawing.Size(11, 12);
            this.labelScore2.TabIndex = 4;
            this.labelScore2.Text = "0";
            // 
            // labelRemainTime2
            // 
            this.labelRemainTime2.AutoSize = true;
            this.labelRemainTime2.Location = new System.Drawing.Point(109, 49);
            this.labelRemainTime2.Name = "labelRemainTime2";
            this.labelRemainTime2.Size = new System.Drawing.Size(35, 12);
            this.labelRemainTime2.TabIndex = 4;
            this.labelRemainTime2.Text = "10:00";
            // 
            // labelBlocks2
            // 
            this.labelBlocks2.AutoSize = true;
            this.labelBlocks2.Location = new System.Drawing.Point(109, 23);
            this.labelBlocks2.Name = "labelBlocks2";
            this.labelBlocks2.Size = new System.Drawing.Size(17, 12);
            this.labelBlocks2.TabIndex = 4;
            this.labelBlocks2.Text = "10";
            // 
            // buttonColor2
            // 
            this.buttonColor2.BackColor = System.Drawing.Color.Indigo;
            this.buttonColor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonColor2.Location = new System.Drawing.Point(111, 96);
            this.buttonColor2.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColor2.Name = "buttonColor2";
            this.buttonColor2.Size = new System.Drawing.Size(26, 23);
            this.buttonColor2.TabIndex = 3;
            this.buttonColor2.UseVisualStyleBackColor = false;
            this.buttonColor2.Click += new System.EventHandler(this.buttonColor2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Score:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Remain Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Remain Blocks:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.labelCurrentTime);
            this.groupBox3.Controls.Add(this.buttonBlockColor);
            this.groupBox3.Controls.Add(this.buttonSquareColor);
            this.groupBox3.Controls.Add(this.buttonCanvasColor);
            this.groupBox3.Controls.Add(this.labelCurrentPlayer);
            this.groupBox3.Location = new System.Drawing.Point(692, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 155);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "Block Color:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "Square Color:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "Canvas Color:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "Current Time:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "Current Player:";
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Location = new System.Drawing.Point(109, 47);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(53, 12);
            this.labelCurrentTime.TabIndex = 4;
            this.labelCurrentTime.Text = "00:00:00";
            // 
            // buttonBlockColor
            // 
            this.buttonBlockColor.BackColor = System.Drawing.Color.Olive;
            this.buttonBlockColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBlockColor.Location = new System.Drawing.Point(110, 125);
            this.buttonBlockColor.Margin = new System.Windows.Forms.Padding(1);
            this.buttonBlockColor.Name = "buttonBlockColor";
            this.buttonBlockColor.Size = new System.Drawing.Size(26, 23);
            this.buttonBlockColor.TabIndex = 3;
            this.buttonBlockColor.UseVisualStyleBackColor = false;
            this.buttonBlockColor.Click += new System.EventHandler(this.buttonBlockColor_Click);
            // 
            // buttonSquareColor
            // 
            this.buttonSquareColor.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonSquareColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSquareColor.Location = new System.Drawing.Point(110, 98);
            this.buttonSquareColor.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSquareColor.Name = "buttonSquareColor";
            this.buttonSquareColor.Size = new System.Drawing.Size(26, 23);
            this.buttonSquareColor.TabIndex = 3;
            this.buttonSquareColor.UseVisualStyleBackColor = false;
            this.buttonSquareColor.Click += new System.EventHandler(this.buttonSquareColor_Click);
            // 
            // buttonCanvasColor
            // 
            this.buttonCanvasColor.BackColor = System.Drawing.Color.LightGray;
            this.buttonCanvasColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCanvasColor.Location = new System.Drawing.Point(110, 70);
            this.buttonCanvasColor.Margin = new System.Windows.Forms.Padding(1);
            this.buttonCanvasColor.Name = "buttonCanvasColor";
            this.buttonCanvasColor.Size = new System.Drawing.Size(26, 23);
            this.buttonCanvasColor.TabIndex = 3;
            this.buttonCanvasColor.UseVisualStyleBackColor = false;
            this.buttonCanvasColor.Click += new System.EventHandler(this.buttonCanvasColor_Click);
            // 
            // labelCurrentPlayer
            // 
            this.labelCurrentPlayer.AutoSize = true;
            this.labelCurrentPlayer.Location = new System.Drawing.Point(109, 20);
            this.labelCurrentPlayer.Name = "labelCurrentPlayer";
            this.labelCurrentPlayer.Size = new System.Drawing.Size(53, 12);
            this.labelCurrentPlayer.TabIndex = 4;
            this.labelCurrentPlayer.Text = "Player 1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(757, 644);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(924, 686);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.canvas);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Quoridor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelScore1;
        private System.Windows.Forms.Label labelRemainTime1;
        private System.Windows.Forms.Label labelBlocks1;
        private System.Windows.Forms.Button buttonColor1;
        private System.Windows.Forms.Label labelScore2;
        private System.Windows.Forms.Label labelRemainTime2;
        private System.Windows.Forms.Label labelBlocks2;
        private System.Windows.Forms.Button buttonColor2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Label labelCurrentPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSquareColor;
        private System.Windows.Forms.Button buttonCanvasColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonBlockColor;
        private System.Windows.Forms.Button button1;
    }
}

