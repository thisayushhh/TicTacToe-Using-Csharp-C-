using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinD_Zero_Kata
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;

        void Enable_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        void score()
        {
            //top row
            if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.Teal;
                button2.BackColor = Color.Teal;
                button3.BackColor = Color.Teal;

                MessageBox.Show("The winner is Player X", "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(X_score.Text);
                X_score.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //second row
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.Teal;
                button5.BackColor = Color.Teal;
                button6.BackColor = Color.Teal;

                MessageBox.Show("The winner is Player X", "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(X_score.Text);
                X_score.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //third row
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Teal;
                button8.BackColor = Color.Teal;
                button9.BackColor = Color.Teal;

                MessageBox.Show("The winner is Player X", "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(X_score.Text);
                X_score.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            // first column
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Teal;
                button4.BackColor = Color.Teal;
                button7.BackColor = Color.Teal;

                MessageBox.Show("The winner is Player X", "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(X_score.Text);
                X_score.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            // second column
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.Teal;
                button5.BackColor = Color.Teal;
                button8.BackColor = Color.Teal;

                MessageBox.Show("The winner is Player X", "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(X_score.Text);
                X_score.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            // third column
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.Teal;
                button6.BackColor = Color.Teal;
                button9.BackColor = Color.Teal;

                MessageBox.Show("The winner is Player X", "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(X_score.Text);
                X_score.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            // first diagonal
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Gold;
                button5.BackColor = Color.Gold;
                button9.BackColor = Color.Gold;

                MessageBox.Show("The winner is Player X", "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(X_score.Text);
                X_score.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //second diagonal
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.Gold;
                button5.BackColor = Color.Gold;
                button7.BackColor = Color.Gold;

                MessageBox.Show("The winner is Player X", "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(X_score.Text);
                X_score.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //-----------------------------------------------------------------------------------------------------------------
            //top row
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.Teal;
                button2.BackColor = Color.Teal;
                button3.BackColor = Color.Teal;

                MessageBox.Show("The winner is Player O", "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(O_score.Text);
                O_score.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //second row
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.Teal;
                button5.BackColor = Color.Teal;
                button6.BackColor = Color.Teal;

                MessageBox.Show("The winner is Player O", "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(O_score.Text);
                O_score.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //third row
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.Teal;
                button8.BackColor = Color.Teal;
                button9.BackColor = Color.Teal;

                MessageBox.Show("The winner is Player O", "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(O_score.Text);
                O_score.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            // first column
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.Teal;
                button4.BackColor = Color.Teal;
                button7.BackColor = Color.Teal;

                MessageBox.Show("The winner is Player O", "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(O_score.Text);
                O_score.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            // second column
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.Teal;
                button5.BackColor = Color.Teal;
                button8.BackColor = Color.Teal;

                MessageBox.Show("The winner is Player O", "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(O_score.Text);
                O_score.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            // third column
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = Color.Teal;
                button6.BackColor = Color.Teal;
                button9.BackColor = Color.Teal;

                MessageBox.Show("The winner is Player O", "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(O_score.Text);
                O_score.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            // first diagonal
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.Gold;
                button5.BackColor = Color.Gold;
                button9.BackColor = Color.Gold;

                MessageBox.Show("The winner is Player O", "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(O_score.Text);
                O_score.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //second diagonal
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.Gold;
                button5.BackColor = Color.Gold;
                button7.BackColor = Color.Gold;

                MessageBox.Show("The winner is Player O", "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(O_score.Text);
                O_score.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button1.Text = "X";
                checker = true;
            }
            else
            {
                button1.Text = "O";
                checker = false;
            }
            score();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "O";
                checker = false;
            }
            score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "O";
                checker = false;
            }
            score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "O";
                checker = false;
            }
            score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "O";
                checker = false;
            }
            score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "O";
                checker = false;
            }
            score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "O";
                checker = false;
            }
            score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "O";
                checker = false;
            }
            score();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "O";
                checker = false;
            }
            score();
            button9.Enabled = false;
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            try { 
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

            //clear prev marked 
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            X_score.Text = "0";
            O_score.Text = "0";

            // color of the buttons also need to be fixed.
            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.WhiteSmoke;
            button5.BackColor = Color.WhiteSmoke;
            button6.BackColor = Color.WhiteSmoke;
            button7.BackColor = Color.WhiteSmoke;
            button8.BackColor = Color.WhiteSmoke;
            button9.BackColor = Color.WhiteSmoke;
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
}

        private void ResetButton_Click(object sender, EventArgs e)
        {
            try { 
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            NewGame.Enabled = true;



            //clear prev marked 
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";


            // color of the buttons also need to be fixed.
            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.WhiteSmoke;
            button5.BackColor = Color.WhiteSmoke;
            button6.BackColor = Color.WhiteSmoke;
            button7.BackColor = Color.WhiteSmoke;
            button8.BackColor = Color.WhiteSmoke;
            button9.BackColor = Color.WhiteSmoke;
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Zero Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
}

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
