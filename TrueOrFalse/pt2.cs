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
    public partial class pt2 : Form
    {
        Form2 fim;
        public pt2()
        {
            InitializeComponent();
            fim = new Form2();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fim.ShowDialog();
        }
    }
}
