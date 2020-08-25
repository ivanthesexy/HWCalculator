using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace IvansSexyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double inches = Convert.ToDouble(numericUpDown1.Value) / 2.54;
            double feet = Math.Floor(inches / 12);
            double extrainches = inches - (feet * 12);
            MessageBox.Show(this, "Your height is " + numericUpDown1.Value + " cm!" + Environment.NewLine + "(" + (numericUpDown1.Value / 100) + "m, " + inches + " inch, " + feet + " ft " + extrainches + " inch)", "Done!", MessageBoxButtons.OK);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Process.Start(Application.ExecutablePath, "-w");
                Close();
            }
        }
    }
}