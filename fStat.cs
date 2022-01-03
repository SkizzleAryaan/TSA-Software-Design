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
    public partial class fStat : Form
    {
        public fStat()
        {
            InitializeComponent();

            Clear.FlatStyle = FlatStyle.Flat;
            Clear.FlatAppearance.BorderSize = 2;

            statback.FlatStyle = FlatStyle.Flat;
            statback.FlatAppearance.BorderSize = 2;

            Compute.FlatStyle = FlatStyle.Flat;
            Compute.FlatAppearance.BorderSize = 2;
        }

        private void statback_Click(object sender, EventArgs e)
        {
            Calculator fm0 = new Calculator();
            fm0.Show();
            this.Hide();
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ar = new string[int.Parse(DefNum.Text)];
                string str = Nums.Text;
                string h = str.Replace(",", "");
                int spaceCounter = 0;
                string temp = "";

                for (int i = 0; i < str.Length; i++)
                {
                    if (str.Substring(i, 1) == " ")
                    {
                        spaceCounter++;
                    }
                }
                ar = h.Split(' ');

                if (ar.Length != int.Parse(DefNum.Text))
                {
                    MessageBox.Show("Please enter the amount of numbers you specified in the first field and make sure everything is formatted properly.");
                }
                else
                {
                    for (int y = 0; y < ar.Length; y++)
                    {
                        for (int x = 0; x < ar.Length; x++)
                        {
                            if (double.Parse(ar[y]) < double.Parse(ar[x]))
                            {
                                temp = ar[y];
                                ar[y] = ar[x];
                                ar[x] = temp;
                            }
                        }
                    }

                    double range = double.Parse(ar[ar.Length - 1]) - double.Parse(ar[0]);



                    var mod = "";


                    int Counter = 0;
                    for (int w = 0; w < ar.Length - 1; w++)
                    {
                        if (double.Parse(ar[w]) == double.Parse(ar[w + 1]))
                        {
                            Counter++;
                        }
                    }
                    if (Counter == 0)
                    {
                        mod = "NA";
                    }
                    else if (getMode(ar) == "")
                    {
                        mod = ar.GroupBy(n => n).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
                    }
                    else if (getMode(ar) == "Multimodal")
                    {
                        mod = "Multimodal";
                    }
                    MessageBox.Show("Mean: " + getMean(ar) + "\n" + "Median: " + getMedian(ar) + "\n" + "range: " + range + "\n" + "mode: " + mod);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please enter numbers in the proper format and make sure all fields are filled.");
            }
        }
        private string getMode(string[] array)
        {

            string[] disnt = new string[array.Distinct().Count()];
            disnt = array.Distinct().ToArray();
            double[] countNum = new double[disnt.Length];
            int Counter = 0;
            int finC = 0;
            for (int i = 0; i < disnt.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (double.Parse(disnt[i]) == double.Parse(array[j]))
                    {
                        Counter++;
                    }
                }
                countNum[i] = Counter;
                Counter = 0;

            }
            for (int k = 0; k < countNum.Length; k++)
            {
                if (countNum[k] == countNum.Max())
                {
                    finC++;
                }
            }
            if (finC == 1)
            {
                return "";
            }
            else
            {
                return "Multimodal";
            }
        }
        private double getMean(string[] array)
        {
            double mean = 0;

            for (int g = 0; g < array.Length; g++)
            {
                mean = mean + double.Parse(array[g]);
            }
            mean = mean / array.Length;
            return mean;

        }
        private double getMedian(string[] array)
        {
            double mid = 0;

            if (array.Length % 2 != 0)
            {
                mid = double.Parse(array[array.Length / 2]);
            }
            else
            {
                mid = double.Parse(array[(array.Length / 2) - 1]) + double.Parse(array[array.Length / 2]);
                mid = mid / 2;
            }
            return mid;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            DefNum.Text = "";
            Nums.Text = "";
        }
    }
}
