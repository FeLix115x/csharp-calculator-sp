using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kalkulators
{

    public partial class Form1 : Form
    {
        string input = string.Empty; //ievada mainigais ar string tipu
        string operand1 = string.Empty; // 1ais operands
        string operand2 = string.Empty; // 2ais operands
        char operation;
        double result = 0.0;

        bool logOperations = false;

        private const string logPath = @"C:\Users\Felix\Downloads\Kalkulators\calc_log.txt";

        public Form1()
        {
            InitializeComponent();
        }


        private void logFileWrite(string operation)
        { 

            using (StreamWriter sw = File.AppendText(logPath))
            {
                sw.WriteLine(operation);
            }
        }

        private void plusPoga_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void reizinatPoga_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void dalitPoga_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void saknePoga_Click(object sender, EventArgs e)
        {
            operand1 = input;
            double num;
            double.TryParse(operand1, out num);
            result = Math.Sqrt(num);
            operand1 = result.ToString();
            tekstaLaukums.Text = result.ToString();

            if (logOperations)
                logFileWrite("sqrt(" + input + ") = " + result.ToString());
        }

        private void pakapePoga_Click(object sender, EventArgs e)
        {
            operand1 = input;
            double num;
            double.TryParse(operand1, out num);
            result = Math.Pow(num, 2);
            operand1 = result.ToString();
            tekstaLaukums.Text = result.ToString();

            if (logOperations)
                logFileWrite(input + "^2 = " + result.ToString());
        }

        private void vienadsPoga_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                tekstaLaukums.Text = result.ToString();
            }

            else if (operation == '-')
            {
                result = num1 - num2;
                tekstaLaukums.Text = result.ToString();
            }

            else if (operation == '*')
            {
                result = num1 * num2;
                tekstaLaukums.Text = result.ToString();

            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    tekstaLaukums.Text = result.ToString();

                }
                else
                {
                    tekstaLaukums.Text = "DIV/Zero!";

                    DialogResult res = MessageBox.Show("You cannot divide by zero here!", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (res == DialogResult.OK)
                    {
                        MessageBox.Show("Jūs nospiedat OK pogu!");
                        // kāda darbība
                    }
                    if (res == DialogResult.Cancel)
                    {
                        MessageBox.Show("Jūs nospiedat Cancel pogu!");
                        // kāda darbība
                    }
                }
            }
            if (logOperations)
                logFileWrite(operand1 + " " + operation + " " + operand2 + " = " + result.ToString());
        }

        private void trisPoga_Click(object sender, EventArgs e)
        {
            this.tekstaLaukums.Text = "";
            input += "3";
            this.tekstaLaukums.Text += input;
        }

        private void diviPoga_Click(object sender, EventArgs e)
        {
            this.tekstaLaukums.Text = "";
            input += "2";
            this.tekstaLaukums.Text += input;
        }
 

        private void nullesPoga_Click(object sender, EventArgs e)
        {
            this.tekstaLaukums.Text = "";
            input += "0";
            this.tekstaLaukums.Text += input;
        }

        private void septiniPoga_Click(object sender, EventArgs e)
        {
            this.tekstaLaukums.Text = "";
            input += "7";
            this.tekstaLaukums.Text += input;
        }

        private void astoniPoga_Click(object sender, EventArgs e)
        {
            this.tekstaLaukums.Text = "";
            input += "8";
            this.tekstaLaukums.Text += input;
        }

        private void deviniPoga_Click(object sender, EventArgs e)
        {
            this.tekstaLaukums.Text = "";
            input += "9";
            this.tekstaLaukums.Text += input;
        }

        private void cetriPoga_Click(object sender, EventArgs e)
        {
            this.tekstaLaukums.Text = "";
            input += "4";
            this.tekstaLaukums.Text += input;
        }

        private void pieciPoga_Click(object sender, EventArgs e)
        {
            this.tekstaLaukums.Text = "";
            input += "5";
            this.tekstaLaukums.Text += input;
        }

        private void sesiPoga_Click(object sender, EventArgs e)
        {
            this.tekstaLaukums.Text = "";
            input += "6";
            this.tekstaLaukums.Text += input;
        }

        private void viensPoga_Click(object sender, EventArgs e)
        {
            this.tekstaLaukums.Text = "";
            input += "1";
            this.tekstaLaukums.Text += input;
        }

        private void minusPoga_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void punktaPoga_Click(object sender, EventArgs e)
        {
            this.tekstaLaukums.Text = "";
            input += ",";
            this.tekstaLaukums.Text += input;
        }

        private void CPoga_Click(object sender, EventArgs e)
        {
            this.tekstaLaukums.Text = "";
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void logCheckBox_Checked(object sender, EventArgs e)
        {
            Console.WriteLine(this.checkBoxLog.Checked + " " + this.logOperations);

            if (this.checkBoxLog.Checked)
                this.logOperations = true;
            else
                this.logOperations = false;
        }


        private void EUR_Click(object sender, EventArgs e)
        { 
            const double usd = 1.14, lvl = 0.71; // coef
            double eur;
            this.textBox1.Text = this.tekstaLaukums.Text;
            double.TryParse(this.textBox1.Text, out eur);
            this.textBox2.Text = (eur * usd).ToString();
            this.textBox3.Text = (eur * lvl).ToString();

            if(logOperations)
                logFileWrite(eur + " EUR = " + usd * eur + " USD or " + lvl * eur + " LVL");
        }

        private void USD_Click(object sender, EventArgs e)
        {
            const double eur = 0.88, lvl = 0.81; // 
            double usd;
            this.textBox2.Text = this.tekstaLaukums.Text;
            double.TryParse(this.textBox2.Text, out usd);
            this.textBox1.Text = (usd * eur).ToString();
            this.textBox3.Text = (usd * lvl).ToString();
            if(logOperations)
                logFileWrite(usd + " USD = " + eur * usd + " EUR or " + lvl * usd + " LVL");
        }

        private void LV_Click(object sender, EventArgs e)
        {
            const double usd = 1.24, eur = 1.42; // 
            double lvl;
            this.textBox3.Text = this.tekstaLaukums.Text;
            double.TryParse(this.textBox3.Text, out lvl);
            this.textBox1.Text = (lvl * eur).ToString();
            this.textBox2.Text = (lvl * usd).ToString();

            if (logOperations)
                logFileWrite(lvl + " LVL = " + usd * lvl + " USD or " + eur * lvl + " EUR");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
