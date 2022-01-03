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
    public partial class f3D : Form
    {
        public f3D()
        {
            InitializeComponent();

            CuSaButton.FlatStyle = FlatStyle.Flat;
            CuSaButton.FlatAppearance.BorderSize = 2;

            CuVolButton.FlatStyle = FlatStyle.Flat;
            CuVolButton.FlatAppearance.BorderSize = 2;

            SpSaButton.FlatStyle = FlatStyle.Flat;
            SpSaButton.FlatAppearance.BorderSize = 2;

            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 2;

            RCSaButton.FlatStyle = FlatStyle.Flat;
            RCSaButton.FlatAppearance.BorderSize = 2;

            RCVolButton.FlatStyle = FlatStyle.Flat;
            RCVolButton.FlatAppearance.BorderSize = 2;

            threedback.FlatStyle = FlatStyle.Flat;
            threedback.FlatAppearance.BorderSize = 2;

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 2;

        }

        private void CuSaButton_Click(object sender, EventArgs e)
        {
            int Cu = Convert.ToInt32(CuSaText.Text);
            double Ca = 6 * (Math.Pow(Cu, 2));
            String t = Ca.ToString();
            CuSAAns.Text = t;
        }

        private void CuVolButton_Click(object sender, EventArgs e)
        {
            int tu = Convert.ToInt32(CuVolText.Text);
            double i = Math.Pow(tu, 3);
            String o = i.ToString();
            CuVolAns.Text = o;
        }

        private void SpSaButton_Click(object sender, EventArgs e)
        {
            int Sp = Convert.ToInt32(SpSaText.Text);
            double v = 4 * Math.PI * Math.Pow(Sp, 2);
            String l = v.ToString();
            SpSaAns.Text = l;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int yu = Convert.ToInt32(SpVolText.Text);
            double g = (4 / 3) * Math.PI * Math.Pow(yu, 3);
            String a = g.ToString();
            SpVolAns.Text = a;
        }

        private void RCSaButton_Click(object sender, EventArgs e)
        {
            int ss = Convert.ToInt32(RCSar.Text);
            int sh = Convert.ToInt32(RCSash.Text);
            double f = (Math.PI * ss * sh) + (Math.PI * Math.Pow(ss, 2));
            String p = f.ToString();
            RCSaAns.Text = p;
        }

        private void RCVolButton_Click(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(RCVolr.Text);
            int r = Convert.ToInt32(RCVolh.Text);
            double u = (r / 3) * Math.PI * Math.Pow(q, 2);
            String eo = u.ToString();
            RCVolAns.Text = eo;
        }

        private void threedback_Click(object sender, EventArgs e)
        {
            fGeo fm0 = new fGeo();
            fm0.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CuSaText.Text = "";
            RCVolr.Text = "";
            RCVolh.Text = "";
            RCSar.Text = "";
            RCSash.Text = "";
            RCSar.Text = "";
            SpVolText.Text = "";
            SpSaText.Text = "";
            CuVolText.Text = "";
            RCVolAns.Text = "";
            RCSaAns.Text = "";
            SpVolAns.Text = "";
            CuVolAns.Text = "";
            SpSaAns.Text = "";
            CuSAAns.Text = "";

        }
    }
}
