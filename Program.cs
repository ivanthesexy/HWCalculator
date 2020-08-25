using System;
using System.Linq;
using System.Windows.Forms;

namespace IvansSexyCalculator
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Contains("-h"))
            {
                Application.Run(new Form1());
            }
            else if (args.Contains("-w"))
            {
                Application.Run(new Form2());
            }
            else
            {
                bool hMode = (new Random().Next(0, int.MaxValue) % 2) == 0;
                if (hMode) { Application.Run(new Form1()); } else { Application.Run(new Form2()); }
            }
        }
    }
}