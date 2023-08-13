using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueOrFalse
{
    public partial class Form1 : Form
    {
        pt1 p1;
        public Form1()
        {
            InitializeComponent();
            p1 = new pt1();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p1.ShowDialog();
        }
    }
}
