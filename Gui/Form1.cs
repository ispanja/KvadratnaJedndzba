using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VsiteCSharpKvadratnaJednadzbaGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            functionPanel1.Function = resultDisplay1.qe.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultDisplay1.FillResults();
        }

        private void resultDisplay1_CoefficientsChanged(object sender, EventArgs e)
        {
            functionPanel1.Invalidate();
        }
    }
}
