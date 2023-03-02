using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatrice
{
    public partial class TarikCalculatrice : Form
    {
        private decimal term1 = 0.0m;
        private decimal term2 = 0.0m;
        private decimal resultat = 0.0m;
        private string operation = "+";
        public TarikCalculatrice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") { result.Text = "1"; }
            else result.Text+="1";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") { result.Text = "0"; }
            else result.Text += "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") { result.Text = "2"; }
            else result.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") { result.Text = "3"; }
            else result.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") { result.Text = "4"; }
            else result.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") { result.Text = "5"; }
            else result.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") { result.Text = "6"; }
            else result.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") { result.Text = "7"; }
            else result.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") { result.Text = "8"; }
            else result.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") { result.Text = "9"; }
            else result.Text += "9";
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            result.Text = "0";      }

        private void btnpls_Click(object sender, EventArgs e)
        {
            term1 = decimal.Parse(result.Text);
            result.Clear();
            operation = "+";
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            term1 = decimal.Parse(result.Text);
            result.Clear();
            operation = "-";
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            term1 = decimal.Parse(result.Text);
            result.Clear();
            operation = "*";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            term1 = decimal.Parse(result.Text);
            result.Clear();
            operation = "/";
        }

        private void btnequa_Click(object sender, EventArgs e)
        {
            switch (operation)
            
                
            {
                case "+":
                    term2 = decimal.Parse(result.Text);
                    resultat = term1 + term2;
                            result.Text = resultat.ToString();
                    break;

                case "-":
                    term2 = decimal.Parse(result.Text);
                    resultat = term1 - term2;
                            result.Text = resultat.ToString();
                    break;

                case "*":
                    term2 = decimal.Parse(result.Text);
                    resultat = term1 * term2;
                    result.Text = resultat.ToString();
                    break;

                case "/":
                    term2 = decimal.Parse(result.Text);
                    resultat = term1 / term2;
                            result.Text = resultat.ToString();
                    break;
            }
        }
    }
}
