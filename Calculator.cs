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
    public partial class Calculator : Form
    {
        
        public Calculator()
        {
            InitializeComponent();

            arithmetic.FlatStyle = FlatStyle.Flat;
            arithmetic.FlatAppearance.BorderSize = 1;

            Geometry.FlatStyle = FlatStyle.Flat;
            Geometry.FlatAppearance.BorderSize = 2;

            Statistics.FlatStyle = FlatStyle.Flat;
            Statistics.FlatAppearance.BorderSize = 2;

            Algebra.FlatStyle = FlatStyle.Flat;
            Algebra.FlatAppearance.BorderSize = 2;

            Exit.FlatStyle = FlatStyle.Flat;
            Exit.FlatAppearance.BorderSize = 2;
        }

        private void Algebra_Click(object sender, EventArgs e)
        {
            fAlg fm1 = new fAlg();
            fm1.Show();
            this.Hide();
        }

        

        private void fournum_Click(object sender, EventArgs e)
        {
            fArith fm2 = new fArith();
            fm2.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Statistics_Click(object sender, EventArgs e)
        {
            fStat fm3 = new fStat();
            fm3.Show();
            this.Hide();
        }

        private void Geometry_Click(object sender, EventArgs e)
        {
            fGeo fm4 = new fGeo();
            fm4.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
