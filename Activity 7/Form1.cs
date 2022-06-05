using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double pi = 4;
            double circumference = 3;
            double denominator = 3;

            int input = int.Parse(userInput.Text);
            
            while (denominator <= 200)
            {
                if (circumference % 2 != 0)
                {
                    pi -= Convert.ToDouble(4) / denominator;
                    circumference++;
                }
                else
                {
                    pi += Convert.ToDouble(4) / denominator;
                    circumference++;
                }
                denominator += 2;
            }
            numTerms.Text = "Approximate value of pi after " + input + " terms.";
            calculate.Text = " = " + pi;
        }
    }
}
