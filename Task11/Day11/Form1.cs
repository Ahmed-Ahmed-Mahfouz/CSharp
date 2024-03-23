namespace Day11
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusOne;

        void Enable_False()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;
        }

        void score()
        {
            //Player X
            if (btnTic1.Text == "X" && btnTic2.Text == "X" && btnTic3.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.CadetBlue;
                btnTic2.BackColor = System.Drawing.Color.CadetBlue;
                btnTic3.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("Player X Won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerXtxt.Text);
                lblPlayerXtxt.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic1.Text == "X" && btnTic4.Text == "X" && btnTic7.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.CadetBlue;
                btnTic4.BackColor = System.Drawing.Color.CadetBlue;
                btnTic7.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("Player X Won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerXtxt.Text);
                lblPlayerXtxt.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic1.Text == "X" && btnTic5.Text == "X" && btnTic9.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.CadetBlue;
                btnTic5.BackColor = System.Drawing.Color.CadetBlue;
                btnTic9.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("Player X Won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerXtxt.Text);
                lblPlayerXtxt.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic2.Text == "X" && btnTic5.Text == "X" && btnTic8.Text == "X")
            {
                btnTic2.BackColor = System.Drawing.Color.CadetBlue;
                btnTic5.BackColor = System.Drawing.Color.CadetBlue;
                btnTic8.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("Player X Won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerXtxt.Text);
                lblPlayerXtxt.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic3.Text == "X" && btnTic6.Text == "X" && btnTic9.Text == "X")
            {
                btnTic3.BackColor = System.Drawing.Color.CadetBlue;
                btnTic6.BackColor = System.Drawing.Color.CadetBlue;
                btnTic9.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("Player X Won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerXtxt.Text);
                lblPlayerXtxt.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic3.Text == "X" && btnTic5.Text == "X" && btnTic7.Text == "X")
            {
                btnTic3.BackColor = System.Drawing.Color.CadetBlue;
                btnTic5.BackColor = System.Drawing.Color.CadetBlue;
                btnTic7.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("Player X Won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerXtxt.Text);
                lblPlayerXtxt.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic4.Text == "X" && btnTic5.Text == "X" && btnTic6.Text == "X")
            {
                btnTic4.BackColor = System.Drawing.Color.CadetBlue;
                btnTic5.BackColor = System.Drawing.Color.CadetBlue;
                btnTic6.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("Player X Won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerXtxt.Text);
                lblPlayerXtxt.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic7.Text == "X" && btnTic8.Text == "X" && btnTic9.Text == "X")
            {
                btnTic7.BackColor = System.Drawing.Color.CadetBlue;
                btnTic8.BackColor = System.Drawing.Color.CadetBlue;
                btnTic9.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("Player X Won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerXtxt.Text);
                lblPlayerXtxt.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            //Player O
            if (btnTic1.Text == "O" && btnTic2.Text == "O" && btnTic3.Text == "O")
            {
                btnTic1.BackColor = System.Drawing.Color.CadetBlue;
                btnTic2.BackColor = System.Drawing.Color.CadetBlue;
                btnTic3.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("Player O Won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerOtxt.Text);
                lblPlayerOtxt.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic1.Text == "O" && btnTic4.Text == "O" && btnTic7.Text == "O")
            {
                btnTic1.BackColor = System.Drawing.Color.CadetBlue;
                btnTic4.BackColor = System.Drawing.Color.CadetBlue;
                btnTic7.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("Player O Won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerOtxt.Text);
                lblPlayerOtxt.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic1.Text == "O" && btnTic5.Text == "O" && btnTic9.Text == "O")
            {
                btnTic1.BackColor = System.Drawing.Color.CadetBlue;
                btnTic5.BackColor = System.Drawing.Color.CadetBlue;
                btnTic9.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("Player O Won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerOtxt.Text);
                lblPlayerOtxt.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic2.Text == "O" && btnTic5.Text == "O" && btnTic8.Text == "O")
            {
                btnTic2.BackColor = System.Drawing.Color.CadetBlue;
                btnTic5.BackColor = System.Drawing.Color.CadetBlue;
                btnTic8.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("Player O Won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerOtxt.Text);
                lblPlayerOtxt.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic3.Text == "O" && btnTic6.Text == "O" && btnTic9.Text == "O")
            {
                btnTic3.BackColor = System.Drawing.Color.CadetBlue;
                btnTic6.BackColor = System.Drawing.Color.CadetBlue;
                btnTic9.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("Player O Won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerOtxt.Text);
                lblPlayerOtxt.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic3.Text == "O" && btnTic5.Text == "O" && btnTic7.Text == "O")
            {
                btnTic3.BackColor = System.Drawing.Color.CadetBlue;
                btnTic5.BackColor = System.Drawing.Color.CadetBlue;
                btnTic7.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("Player O Won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerOtxt.Text);
                lblPlayerOtxt.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic4.Text == "O" && btnTic5.Text == "O" && btnTic6.Text == "O")
            {
                btnTic4.BackColor = System.Drawing.Color.CadetBlue;
                btnTic5.BackColor = System.Drawing.Color.CadetBlue;
                btnTic6.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("Player O Won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerOtxt.Text);
                lblPlayerOtxt.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTic7.Text == "O" && btnTic8.Text == "O" && btnTic9.Text == "O")
            {
                btnTic7.BackColor = System.Drawing.Color.CadetBlue;
                btnTic8.BackColor = System.Drawing.Color.CadetBlue;
                btnTic9.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("Player O Won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerOtxt.Text);
                lblPlayerOtxt.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTic1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic1.Text = "X";
                checker = true;
            }
            else
            {
                btnTic1.Text = "O";
                checker = false;
            }
            score();
            btnTic1.Enabled = false;
        }

        private void btnTic2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic2.Text = "X";
                checker = true;
            }
            else
            {
                btnTic2.Text = "O";
                checker = false;
            }
            score();
            btnTic2.Enabled = false;
        }

        private void btnTic3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic3.Text = "X";
                checker = true;
            }
            else
            {
                btnTic3.Text = "O";
                checker = false;
            }
            score();
            btnTic3.Enabled = false;
        }

        private void btnTic4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic4.Text = "X";
                checker = true;
            }
            else
            {
                btnTic4.Text = "O";
                checker = false;
            }
            score();
            btnTic4.Enabled = false;
        }

        private void btnTic5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic5.Text = "X";
                checker = true;
            }
            else
            {
                btnTic5.Text = "O";
                checker = false;
            }
            score();
            btnTic5.Enabled = false;
        }

        private void btnTic6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic6.Text = "X";
                checker = true;
            }
            else
            {
                btnTic6.Text = "O";
                checker = false;
            }
            score();
            btnTic6.Enabled = false;
        }

        private void btnTic7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic7.Text = "X";
                checker = true;
            }
            else
            {
                btnTic7.Text = "O";
                checker = false;
            }
            score();
            btnTic7.Enabled = false;
        }

        private void btnTic8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic8.Text = "X";
                checker = true;
            }
            else
            {
                btnTic8.Text = "O";
                checker = false;
            }
            score();
            btnTic8.Enabled = false;
        }

        private void btnTic9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic9.Text = "X";
                checker = true;
            }
            else
            {
                btnTic9.Text = "O";
                checker = false;
            }
            score();
            btnTic9.Enabled = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic4.Enabled = true;
                btnTic5.Enabled = true;
                btnTic6.Enabled = true;
                btnTic7.Enabled = true;
                btnTic8.Enabled = true;
                btnTic9.Enabled = true;

                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";

                lblPlayerXtxt.Text = "0";
                lblPlayerOtxt.Text = "0";

                btnTic1.BackColor = System.Drawing.Color.WhiteSmoke;
                btnTic2.BackColor = System.Drawing.Color.WhiteSmoke;
                btnTic3.BackColor = System.Drawing.Color.WhiteSmoke;
                btnTic4.BackColor = System.Drawing.Color.WhiteSmoke;
                btnTic5.BackColor = System.Drawing.Color.WhiteSmoke;
                btnTic6.BackColor = System.Drawing.Color.WhiteSmoke;
                btnTic7.BackColor = System.Drawing.Color.WhiteSmoke;
                btnTic8.BackColor = System.Drawing.Color.WhiteSmoke;
                btnTic9.BackColor = System.Drawing.Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic4.Enabled = true;
                btnTic5.Enabled = true;
                btnTic6.Enabled = true;
                btnTic7.Enabled = true;
                btnTic8.Enabled = true;
                btnTic9.Enabled = true;

                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";

                btnTic1.BackColor = System.Drawing.Color.WhiteSmoke;
                btnTic2.BackColor = System.Drawing.Color.WhiteSmoke;
                btnTic3.BackColor = System.Drawing.Color.WhiteSmoke;
                btnTic4.BackColor = System.Drawing.Color.WhiteSmoke;
                btnTic5.BackColor = System.Drawing.Color.WhiteSmoke;
                btnTic6.BackColor = System.Drawing.Color.WhiteSmoke;
                btnTic7.BackColor = System.Drawing.Color.WhiteSmoke;
                btnTic8.BackColor = System.Drawing.Color.WhiteSmoke;
                btnTic9.BackColor = System.Drawing.Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "TicTacToe", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
