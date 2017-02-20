using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_COMMERCE
{
    public partial class Main : Form
    {
        public Context Initialize = new Context();
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSearch frm = new FrmSearch(Initialize);
            frm.Show();
            this.Hide();

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin(Initialize);
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
