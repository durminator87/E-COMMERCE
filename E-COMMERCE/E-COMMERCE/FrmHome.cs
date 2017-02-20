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
    public partial class FrmHome : Form
    {
        private Context Initialize = new Context();
        private Context ctx;
        public string a;
        public FrmHome(Context passer, string msg)   //passing parameter
        {
            ctx = passer;
            InitializeComponent();
            lblWelcome.Text = "Welcome " + msg;
            a = msg;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();  //hiding form2
            Main f1 = new Main();
            f1.Show();  //showing form1
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAddProduct f3 = new FrmAddProduct(Initialize);
            f3.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAddCategory frm = new FrmAddCategory(Initialize, a);
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAddCity frm = new FrmAddCity(Initialize, a);
            frm.Show();
            this.Hide();
        }
    }
}
