namespace Day11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            btnNewGame = new Button();
            btnExit = new Button();
            btnReset = new Button();
            panel4 = new Panel();
            lblPlayerOtxt = new Label();
            lblPlayerXtxt = new Label();
            lblPlayerO = new Label();
            lblPlayerX = new Label();
            panel3 = new Panel();
            btnTic9 = new Button();
            btnTic8 = new Button();
            btnTic7 = new Button();
            btnTic6 = new Button();
            btnTic5 = new Button();
            btnTic4 = new Button();
            btnTic3 = new Button();
            btnTic2 = new Button();
            btnTic1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 125);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(317, -5);
            label1.Name = "label1";
            label1.Size = new Size(714, 159);
            label1.TabIndex = 0;
            label1.Text = "Tic Tac Toe!";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(1344, 548);
            panel2.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnNewGame);
            panel5.Controls.Add(btnExit);
            panel5.Controls.Add(btnReset);
            panel5.Location = new Point(678, 275);
            panel5.Name = "panel5";
            panel5.Size = new Size(648, 255);
            panel5.TabIndex = 16;
            // 
            // btnNewGame
            // 
            btnNewGame.BackColor = Color.WhiteSmoke;
            btnNewGame.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewGame.ForeColor = SystemColors.ActiveCaptionText;
            btnNewGame.Location = new Point(13, 14);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(616, 113);
            btnNewGame.TabIndex = 12;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = false;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.WhiteSmoke;
            btnExit.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(318, 133);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(311, 111);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.WhiteSmoke;
            btnReset.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.ActiveCaptionText;
            btnReset.Location = new Point(13, 133);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(299, 111);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblPlayerOtxt);
            panel4.Controls.Add(lblPlayerXtxt);
            panel4.Controls.Add(lblPlayerO);
            panel4.Controls.Add(lblPlayerX);
            panel4.Location = new Point(678, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(648, 243);
            panel4.TabIndex = 15;
            // 
            // lblPlayerOtxt
            // 
            lblPlayerOtxt.BackColor = Color.CadetBlue;
            lblPlayerOtxt.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerOtxt.ForeColor = Color.Black;
            lblPlayerOtxt.Location = new Point(352, 139);
            lblPlayerOtxt.Name = "lblPlayerOtxt";
            lblPlayerOtxt.Size = new Size(293, 106);
            lblPlayerOtxt.TabIndex = 4;
            lblPlayerOtxt.Text = "0";
            lblPlayerOtxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayerXtxt
            // 
            lblPlayerXtxt.BackColor = Color.CadetBlue;
            lblPlayerXtxt.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerXtxt.ForeColor = Color.Black;
            lblPlayerXtxt.Location = new Point(352, 19);
            lblPlayerXtxt.Name = "lblPlayerXtxt";
            lblPlayerXtxt.Size = new Size(293, 106);
            lblPlayerXtxt.TabIndex = 3;
            lblPlayerXtxt.Text = "0";
            lblPlayerXtxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayerO
            // 
            lblPlayerO.AutoSize = true;
            lblPlayerO.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerO.ForeColor = Color.Black;
            lblPlayerO.Location = new Point(0, 139);
            lblPlayerO.Name = "lblPlayerO";
            lblPlayerO.Size = new Size(382, 106);
            lblPlayerO.TabIndex = 2;
            lblPlayerO.Text = "Player O:";
            // 
            // lblPlayerX
            // 
            lblPlayerX.AutoSize = true;
            lblPlayerX.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerX.ForeColor = Color.Black;
            lblPlayerX.Location = new Point(0, 19);
            lblPlayerX.Name = "lblPlayerX";
            lblPlayerX.Size = new Size(373, 106);
            lblPlayerX.TabIndex = 1;
            lblPlayerX.Text = "Player X:";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnTic9);
            panel3.Controls.Add(btnTic8);
            panel3.Controls.Add(btnTic7);
            panel3.Controls.Add(btnTic6);
            panel3.Controls.Add(btnTic5);
            panel3.Controls.Add(btnTic4);
            panel3.Controls.Add(btnTic3);
            panel3.Controls.Add(btnTic2);
            panel3.Controls.Add(btnTic1);
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(18, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(637, 516);
            panel3.TabIndex = 14;
            // 
            // btnTic9
            // 
            btnTic9.BackColor = Color.WhiteSmoke;
            btnTic9.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            btnTic9.ForeColor = SystemColors.ActiveCaptionText;
            btnTic9.Location = new Point(426, 347);
            btnTic9.Name = "btnTic9";
            btnTic9.Size = new Size(200, 158);
            btnTic9.TabIndex = 9;
            btnTic9.UseVisualStyleBackColor = false;
            btnTic9.Click += btnTic9_Click;
            // 
            // btnTic8
            // 
            btnTic8.BackColor = Color.WhiteSmoke;
            btnTic8.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            btnTic8.ForeColor = SystemColors.ActiveCaptionText;
            btnTic8.Location = new Point(220, 347);
            btnTic8.Name = "btnTic8";
            btnTic8.Size = new Size(200, 158);
            btnTic8.TabIndex = 8;
            btnTic8.UseVisualStyleBackColor = false;
            btnTic8.Click += btnTic8_Click;
            // 
            // btnTic7
            // 
            btnTic7.BackColor = Color.WhiteSmoke;
            btnTic7.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            btnTic7.ForeColor = SystemColors.ActiveCaptionText;
            btnTic7.Location = new Point(14, 347);
            btnTic7.Name = "btnTic7";
            btnTic7.Size = new Size(200, 158);
            btnTic7.TabIndex = 7;
            btnTic7.UseVisualStyleBackColor = false;
            btnTic7.Click += btnTic7_Click;
            // 
            // btnTic6
            // 
            btnTic6.BackColor = Color.WhiteSmoke;
            btnTic6.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            btnTic6.ForeColor = SystemColors.ActiveCaptionText;
            btnTic6.Location = new Point(426, 183);
            btnTic6.Name = "btnTic6";
            btnTic6.Size = new Size(200, 158);
            btnTic6.TabIndex = 6;
            btnTic6.UseVisualStyleBackColor = false;
            btnTic6.Click += btnTic6_Click;
            // 
            // btnTic5
            // 
            btnTic5.BackColor = Color.WhiteSmoke;
            btnTic5.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            btnTic5.ForeColor = SystemColors.ActiveCaptionText;
            btnTic5.Location = new Point(220, 183);
            btnTic5.Name = "btnTic5";
            btnTic5.Size = new Size(200, 158);
            btnTic5.TabIndex = 5;
            btnTic5.UseVisualStyleBackColor = false;
            btnTic5.Click += btnTic5_Click;
            // 
            // btnTic4
            // 
            btnTic4.BackColor = Color.WhiteSmoke;
            btnTic4.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            btnTic4.ForeColor = SystemColors.ActiveCaptionText;
            btnTic4.Location = new Point(14, 183);
            btnTic4.Name = "btnTic4";
            btnTic4.Size = new Size(200, 158);
            btnTic4.TabIndex = 4;
            btnTic4.UseVisualStyleBackColor = false;
            btnTic4.Click += btnTic4_Click;
            // 
            // btnTic3
            // 
            btnTic3.BackColor = Color.WhiteSmoke;
            btnTic3.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            btnTic3.ForeColor = SystemColors.ActiveCaptionText;
            btnTic3.Location = new Point(426, 19);
            btnTic3.Name = "btnTic3";
            btnTic3.Size = new Size(200, 158);
            btnTic3.TabIndex = 3;
            btnTic3.UseVisualStyleBackColor = false;
            btnTic3.Click += btnTic3_Click;
            // 
            // btnTic2
            // 
            btnTic2.BackColor = Color.WhiteSmoke;
            btnTic2.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            btnTic2.ForeColor = SystemColors.ActiveCaptionText;
            btnTic2.Location = new Point(220, 19);
            btnTic2.Name = "btnTic2";
            btnTic2.Size = new Size(200, 158);
            btnTic2.TabIndex = 2;
            btnTic2.UseVisualStyleBackColor = false;
            btnTic2.Click += btnTic2_Click;
            // 
            // btnTic1
            // 
            btnTic1.BackColor = Color.WhiteSmoke;
            btnTic1.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            btnTic1.ForeColor = SystemColors.ActiveCaptionText;
            btnTic1.Location = new Point(14, 19);
            btnTic1.Name = "btnTic1";
            btnTic1.Size = new Size(200, 158);
            btnTic1.TabIndex = 1;
            btnTic1.UseVisualStyleBackColor = false;
            btnTic1.Click += btnTic1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1368, 741);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Tic Tac Toe";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnTic1;
        private Label label1;
        private Button btnTic3;
        private Button btnTic2;
        private Button btnTic7;
        private Button btnTic6;
        private Button btnTic5;
        private Button btnTic4;
        private Button btnTic9;
        private Button btnTic8;
        private Label lblPlayerX;
        private Label lblPlayerO;
        private Label lblPlayerOtxt;
        private Label lblPlayerXtxt;
        private Panel panel5;
        private Button btnNewGame;
        private Button btnExit;
        private Button btnReset;
    }
}
