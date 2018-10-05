using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndProjectCalculatorSlin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlusSlin_Click(object sender, EventArgs e) //Button that adds 2 numbers
        {
            pgbCalculatorSlin.Value = pgbCalculatorSlin.Value = 10; //this makes the value from the progressbar 10
            methodPlus();
        }

        private void btnPlusSLin_click() //Button that adds 2 numbers
        {
             //this is a method
        }

        private void methodPlus() //this is a method of the plus button
        {
            try
            {
                int numberOneSLin = Convert.ToInt32(txbInput1Slin.Text); //this makes it so you can put in numbers
                int numberTwoSlin = Convert.ToInt32(txbInput2Slin.Text); //this makes it so you can put in numbers
                txbOutputSlin.Text = Convert.ToString(numberOneSLin + numberTwoSlin); //this makes it so you can put in text
                lbl2MessageSlin.Text = txbInput1Slin.Text + "+" + txbInput2Slin.Text + "=" + txbOutputSlin.Text; //this shows a message of the calculation
            }

            catch
            {
                MessageBox.Show("calculation invalid");
            }
        }

        private void btnMinSlin_Click(object sender, EventArgs e) //Button that subtract 2 numbers
        {
            methodMin(); //this is a method
            pgbCalculatorSlin.Value = pgbCalculatorSlin.Value = 20; //this makes the progressbar value 20
        }

        private void methodMin() //this is a method of the min button
        {
            try
            {
                int numberOneSLin = Convert.ToInt32(txbInput1Slin.Text); //this makes it so you can put in numbers
                int numberTwoSlin = Convert.ToInt32(txbInput2Slin.Text); //this makes it so you can put in numbers
                txbOutputSlin.Text = Convert.ToString(numberOneSLin - numberTwoSlin); //this makes it so you can put in text
                lbl2MessageSlin.Text = txbInput1Slin.Text + "-" + txbInput2Slin.Text + "=" + txbOutputSlin.Text; //this shows a message of the calculation
            }

            catch
            {
                MessageBox.Show("calculation invalid");
            }
        }

        private void btnDivideSlin_Click(object sender, EventArgs e) //Button that divide 2 numbers
        {
            methodDivide(); //this is a method
            pgbCalculatorSlin.Value = pgbCalculatorSlin.Value = 30; //this makes the progressbar value 30
        }

        private void methodDivide() //this is a method of the divide button
        {
            try
            {
                int numberOneSLin = Convert.ToInt32(txbInput1Slin.Text); //this makes it so you can put in numbers
                int numberTwoSlin = Convert.ToInt32(txbInput2Slin.Text); //this makes it so you can put in numbers
                txbOutputSlin.Text = Convert.ToString(numberOneSLin / numberTwoSlin); //this makes it so you can put in text
                lbl2MessageSlin.Text = txbInput1Slin.Text + ":" + txbInput2Slin.Text + "=" + txbOutputSlin.Text; //this shows a message of the calculation
            }

            catch
            {
                MessageBox.Show("calculation invalid");
            }
        }

        private void btnMultiplySlin_Click(object sender, EventArgs e) //Button that multiply's 2 numbers
        {
            methodMultiply(); //this is a method
            pgbCalculatorSlin.Value = pgbCalculatorSlin.Value = 40; //this makes the progressbar value 40
        }

        private void methodMultiply() //this is a method of the multiply button
        {
            try
            {
                int numberOneSLin = Convert.ToInt32(txbInput1Slin.Text); //this makes it so you can put in numbers
                int numberTwoSlin = Convert.ToInt32(txbInput2Slin.Text); //this makes it so you can put in numbers
                txbOutputSlin.Text = Convert.ToString(numberOneSLin * numberTwoSlin); //this makes it so you can put in text
                lbl2MessageSlin.Text = txbInput1Slin.Text + "x" + txbInput2Slin.Text + "=" + txbOutputSlin.Text; //this shows a message of the calculation
            }

            catch
            {
                MessageBox.Show("calculation invalid");
            }
        }

        private void btnRootSlin_Click(object sender, EventArgs e) //Button that that gives the sqrt of number 1
        {
            methodRoot(); //this is a method
            pgbCalculatorSlin.Value = pgbCalculatorSlin.Value = 50; //this makes the progressbar value 50
        }

        private void methodRoot() //this is a method of the root button
        {
            try
            {
                int numberOneSLin = Convert.ToInt32(txbInput1Slin.Text); //this makes it so you can put in numbers
                double anwserSlin = Math.Sqrt(numberOneSLin); //this is the calculation for root
                txbOutputSlin.Text = Convert.ToString(anwserSlin); //this makes it so you can put in text
                lbl2MessageSlin.Text = "√" + txbInput1Slin.Text + "=" + txbOutputSlin.Text; //this shows a message of the calculation
            }

            catch
            {
                MessageBox.Show("calculation invalid");
            }
        }

        private void btnPowerSlin_Click(object sender, EventArgs e) //Button that gives the power of 2 numbers
        {
            methodPower(); //this is a method
            pgbCalculatorSlin.Value = pgbCalculatorSlin.Value = 60; //this makes the progressbar value 60
        }

        private void methodPower() //this is a method of the power button
        {
            try
            {
                int numberOneSLin = Convert.ToInt32(txbInput1Slin.Text); //this makes it so you can put in numbers
                int numberTwoSlin = Convert.ToInt32(txbInput2Slin.Text); //this makes it so you can put in numbers
                double anwserSlin = Math.Pow(numberOneSLin, numberTwoSlin); //this is the calculation for power
                txbOutputSlin.Text = Convert.ToString(anwserSlin); //this makes it so you can put in text
                lbl2MessageSlin.Text = txbInput1Slin.Text + "^" + txbInput2Slin.Text + "=" + txbOutputSlin.Text; //this shows a message of the calculation
            }

            catch
            {
                MessageBox.Show("calculation invalid");
            }
        }

        private void btnLocateSlin_Click(object sender, EventArgs e) //This button locates the project 
        {
            MessageBox.Show(Application.ExecutablePath); //this shows a messagebox with the info where the project is stored
        }

        private void btnAboutSlin_Click(object sender, EventArgs e) //This button gives a messagebox of who the document made
        {
            MessageBox.Show("\t Gemaakt door: \n \t Sam Lindhout"); //shows a messagebox with text: "Gemaakt door: Sam Lindhout"
        }

        private void btnColorSlin_Click(object sender, EventArgs e) //This button gives the option to change the backcolor
        {
            DialogResult resultColorSlin = cldColorDialogSlin.ShowDialog(); //shows a colordialog
            this.BackColor = cldColorDialogSlin.Color; //changes the color you choose
        }

        private void btnResetSlin_Click(object sender, EventArgs e) //This button resets everything
        {
            txbInput1Slin.Clear(); //clears the first input
            txbInput2Slin.Clear(); //clears the second input
            txbOutputSlin.Clear(); //clears the output
            this.BackColor = Color.Silver; //resets the backcolor
            lbl2MessageSlin.Text = "..."; //resets the calculation message
            pgbCalculatorSlin.Value = 0; //sets the value of the progressbar back to 0
        }

        private void btnStepSlin_Click(object sender, EventArgs e) //This button adds a step to the progressbar
        {
            if (pgbCalculatorSlin.Value == 60) //if the value is 60 the value resets to 0
            {
                pgbCalculatorSlin.Value = 0; //sets the value of the progressbar to 0
            }
            else if(pgbCalculatorSlin.Value != 60) //if the value is not 60 it adds 10 every time you click the button
            {
                pgbCalculatorSlin.Value = pgbCalculatorSlin.Value + 10; //adds a value of 10 each time to the progressbar
            }
            
            if (pgbCalculatorSlin.Value == 10) //when the value is 10 it wil activate the plus button
            {
                methodPlus(); //this is a method
            }

            if (pgbCalculatorSlin.Value == 20) //when the value is 20 it wil activate the min button
            {
                methodMin(); //this is a method
            }

            if (pgbCalculatorSlin.Value == 30) //when the value is 30 it wil activate the divide button
            {
                methodDivide(); //this is a method
            }

            if (pgbCalculatorSlin.Value == 40) //when the value is 40 it wil activate the multiply button
            {
                methodMultiply(); //this is a method
            }

            if (pgbCalculatorSlin.Value == 50) //when the value is 50 it wil activate the root button
            {
                methodRoot(); //this is a method
            }

            if (pgbCalculatorSlin.Value == 60) //when the value is 60 it wil activate the power button
            {
                methodPower(); //this is a method
            } 
        }

    }
}
