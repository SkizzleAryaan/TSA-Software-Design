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
    public partial class fGeo : Form
    {
        public fGeo()
        {
            InitializeComponent();

            twod.FlatStyle = FlatStyle.Flat;
            twod.FlatAppearance.BorderSize = 1;

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 2;

            geoback.FlatStyle = FlatStyle.Flat;
            geoback.FlatAppearance.BorderSize = 2;
        }

        

        private void geoback_Click(object sender, EventArgs e)
        {
            Calculator fm0 = new Calculator();
            fm0.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f3D fm1 = new f3D();
            fm1.Show();
            this.Hide();
        }

        private void twod_Click(object sender, EventArgs e)
        {
            f2D fm3 = new f2D();
            fm3.Show();
            this.Hide();
        }
    }
}
