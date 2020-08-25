using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace IvansSexyCalculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lb = 2.205;

            MessageBox.Show(this, "Your weight is " + numericUpDown1.Value + " kg!" + Environment.NewLine + "(" + (numericUpDown1.Value * 1000) + "g, " + (numericUpDown1.Value / 1000) + " ton, " + (Convert.ToDouble(numericUpDown1.Value) * lb) + " lb)", "Done!", MessageBoxButtons.OK);
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Process.Start(Application.ExecutablePath, "-h");
                Close();
            }
        }
    }
}