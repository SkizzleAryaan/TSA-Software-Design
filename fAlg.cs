using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSA
{
    public partial class fAlg : Form
    {
        public fAlg()
        {
            InitializeComponent();

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 2;

            quadButton.FlatStyle = FlatStyle.Flat;
            quadButton.FlatAppearance.BorderSize = 2;

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 2;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                String str = textBox1.Text; //5x=40
                String numstr = str.Substring(0, str.IndexOf('x'));
                String numstr1 = str.Substring(str.IndexOf('=') + 1);
                Double x = Double.Parse(numstr);
                Double y = Double.Parse(numstr1);
                Double z = y / x;
                MessageBox.Show("x = " + z);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter in correct format");
                textBox1.Text = ""; 
            }
            
        }

        private void quadButton_Click(object sender, EventArgs e)
        {
            try
            {
                String str = quadBox.Text;
                String a = str.Substring(0, 1);
                String b = str.Substring(2, 1);
                String c = str.Substring(4,1);
                Double x = Double.Parse(a);
                Double y = Double.Parse(b);
                Double z = Double.Parse(c);

                Double discriminant = Math.Sqrt((y*y) - 4 * x * z);
                Double bottom = 2 * x;
                Double xpos = (-1 * y + discriminant) / bottom;
                Double xneg = (-1 * y - discriminant) / bottom;
                MessageBox.Show("The x values are: " + xpos.ToString() + " and " + xneg.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter in correct format");
                textBox1.Text = "";
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculator fm0 = new Calculator();
            fm0.Show();
            this.Hide();
        }
    }
}
