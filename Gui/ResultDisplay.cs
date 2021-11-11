using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KvadratnaJedndzba;

namespace VsiteCSharpKvadratnaJednadzbaGui
{
    public partial class ResultDisplay : UserControl
    {
        public event EventHandler CoefficientsChanged;
        public ResultDisplay()
        {
            InitializeComponent();
        }

        public readonly QuadraticEquation qe = new QuadraticEquation();

        public void FillResults()
        {
            qe.A = (double) numericUpDowna.Value;
            qe.B = (double) numericUpDownb.Value;
            qe.C = (double) numericUpDownc.Value;

            double discriminant = qe.Discriminant;
            textBoxDiscriminant.Text = discriminant.ToString();
            textBoxRoot1.Text = qe.Roots[0].ToString();
            textBoxRoot2.Text = qe.Roots[1].ToString();

        }

        private void ResultDisplay_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.FillResults();
            if (CoefficientsChanged != null)
            {
                CoefficientsChanged(this, EventArgs.Empty);
            }
        }
    }
}
