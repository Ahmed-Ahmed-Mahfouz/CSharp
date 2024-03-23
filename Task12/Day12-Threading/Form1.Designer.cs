namespace Day12_Threading
{
    partial class ThreadingTask
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
            btnOne = new Button();
            btnTwo = new Button();
            richTextBoxOne = new RichTextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.WhiteSmoke;
            btnOne.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOne.Location = new Point(450, 103);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(400, 66);
            btnOne.TabIndex = 0;
            btnOne.Text = "Download";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.WhiteSmoke;
            btnTwo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTwo.Location = new Point(37, 103);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(400, 66);
            btnTwo.TabIndex = 1;
            btnTwo.Text = "Get Information";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btnTwo_Click;
            // 
            // richTextBoxOne
            // 
            richTextBoxOne.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBoxOne.Location = new Point(37, 184);
            richTextBoxOne.Name = "richTextBoxOne";
            richTextBoxOne.Size = new Size(813, 321);
            richTextBoxOne.TabIndex = 2;
            richTextBoxOne.Text = "";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(37, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(813, 61);
            textBox1.TabIndex = 3;
            textBox1.Text = "Your URL";
            textBox1.Click += textBox1_Click;
            // 
            // ThreadingTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(890, 520);
            Controls.Add(textBox1);
            Controls.Add(richTextBoxOne);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Name = "ThreadingTask";
            Text = "Threading Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOne;
        private Button btnTwo;
        private RichTextBox richTextBoxOne;
        private TextBox textBox1;
    }
}
