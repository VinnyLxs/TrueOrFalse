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
    public partial class pt1 : Form
    {
        pt2 p2;
        public pt1()
        {
            InitializeComponent();
            p2 = new pt2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p2.ShowDialog();
        }
    }
}
