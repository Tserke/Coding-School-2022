using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_06
{
    public partial class Form1 : Form
    {
        string firstNumber,secondNumber,operation;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //----------Clear------------------------------

        private void buttonClean_Click(object sender, EventArgs e)
        {
            this.textBox.Text = null;
            buttonDot.Enabled = true;
        }


        //----------Numbers----------------------------

        private void buttonZero_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "0";
             
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "2";
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "3";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "5";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "9";
        }

        //---------------Operators------------

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "X";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "/";
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "Sqrt";
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "Pow";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            this.textBox.Text += ".";
            buttonDot.Enabled = false;
        }

        private void buttonPlus_Click_1(object sender, EventArgs e)
        {
            Button b=(Button)sender;
            firstNumber = this.textBox.Text;
            operation = b.Text;
            textBox.Text = null;
            buttonDot.Enabled = true;
        }


        //--------- Execution---------------
        private void textBox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            secondNumber = this.textBox.Text;
            Manager manager = new Manager();
            this.textBox.Text = manager.Manage(firstNumber, secondNumber, operation);
        }

         
    }
}
