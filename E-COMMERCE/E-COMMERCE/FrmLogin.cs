using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using E_COMMERCE.Model;

namespace E_COMMERCE
{
    public partial class FrmLogin : Form
    {
        private Context Initialize = new Context();
        private Context ctx;
        public FrmLogin(Context passer)
        {
            ctx = passer;
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean chekc = Checekr();
            if (chekc == true)
            {
                FrmHome frm = new FrmHome(Initialize,textBox1.Text);
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please check the Username and Password!");
            }

        }
        public bool Checekr()
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            var chk = from cheker in ctx.Accounts
                      where cheker.UserName == username && cheker.Password == password
                      select cheker;

            return chk.Any();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Account acc = new Account();
                acc.UserName = textBox1.Text;
                acc.Password = textBox2.Text;

                ctx.Accounts.Add(acc);
                ctx.SaveChanges();

                MessageBox.Show("You have registered succesfully!");

                Form1_Load(null, null);
            }
            else
                MessageBox.Show("Please fill in the Username and Password Fields!");

        }
    }
}
