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
    public partial class f2D : Form
    {
        public f2D()
        {
            InitializeComponent();

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 2;

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 2;

            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 2;

            button10.FlatStyle = FlatStyle.Flat;
            button10.FlatAppearance.BorderSize = 2;

            button10.FlatStyle = FlatStyle.Flat;
            button10.FlatAppearance.BorderSize = 2;

            button10.FlatStyle = FlatStyle.Flat;
            button10.FlatAppearance.BorderSize = 2;

            button10.FlatStyle = FlatStyle.Flat;
            button10.FlatAppearance.BorderSize = 2;

            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 2;

            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 2;

            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 2;

            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 2;

            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 2;

            button9.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderSize = 2;

            twodback.FlatStyle = FlatStyle.Flat;
            twodback.FlatAppearance.BorderSize = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Sc = Convert.ToInt32(SCBox.Text);
            int Sb = Convert.ToInt32(textBox1.Text);
            int Sa = (int)Math.Sqrt(Math.Pow(Sc, 2) - Math.Pow(Sb, 2));
            String f = Sa.ToString();
            Side1.Text = f;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Sc = Convert.ToInt32(SCBox.Text);
            int Sa = Convert.ToInt32(Side1.Text);
            int Sb = (int)Math.Sqrt(Math.Pow(Sc, 2) - Math.Pow(Sa, 2));
            String f = Sb.ToString();
            textBox1.Text = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Sa = Convert.ToInt32(Side1.Text);
            int Sb = Convert.ToInt32(textBox1.Text);
            int Sc = (int)Math.Sqrt(Math.Pow(Sa, 2) + Math.Pow(Sb, 2));
            String p = Sc.ToString();
            SCBox.Text = p;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Sq = Convert.ToInt32(SqArea.Text);
            int Sqa = (int)Math.Pow(Sq, 2);
            String t = Sqa.ToString();
            SqAreaAnswer.Text = t;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int Rl = Convert.ToInt32(LengthBox.Text);
            int Rw = Convert.ToInt32(WidthBox.Text);
            int Ra = Rl * Rw;
            String a = Ra.ToString();
            RecAreaAnswer.Text = a;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int Cr = Convert.ToInt32(CircText.Text);
            double Ca = Math.PI * Cr * Cr;
            String l = Ca.ToString();
            CircAnswer.Text = l;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int Ss = Convert.ToInt32(SqPeriText.Text);
            int Saq = 4 * Ss;
            String i = Saq.ToString();
            SqPeriAns.Text = i;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int Rp = Convert.ToInt32(RlPeriText.Text);
            int Ro = Convert.ToInt32(RwPeriText.Text);
            int Ri = (2 * Rp) + (2 * Ro);
            String q = Ri.ToString();
            RaPeriAns.Text = q;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int Ct = Convert.ToInt32(CircPeriText.Text);
            double Ca = 2 * Math.PI * Ct;
            String l = Ca.ToString();
            circPeriAnswer.Text = l;
        }

        private void twodback_Click(object sender, EventArgs e)
        {
            fGeo fm = new fGeo();
            fm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Side1.Text = "";
            textBox1.Text = "";
            SCBox.Text = "";
            SqArea.Text = "";
            SqAreaAnswer.Text = "";
            LengthBox.Text = "";
            WidthBox.Text = "";
            RecAreaAnswer.Text = "";
            CircText.Text = "";
            CircAnswer.Text = "";
            SqPeriText.Text = "";
            SqPeriAns.Text = "";
            RlPeriText.Text = "";
            RwPeriText.Text = "";
            RaPeriAns.Text = "";
            CircPeriText.Text = "";
            circPeriAnswer.Text = "";

        }

        private void f2D_Load(object sender, EventArgs e)
        {

        }
    }
}
