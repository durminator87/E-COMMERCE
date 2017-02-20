using E_COMMERCE.Model;
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
    public partial class FrmAddCity : Form
    {
        private Context Initialize = new Context();
        Context ctx;
        public string a;
        public FrmAddCity(Context passer, string msg)
        {
            ctx = passer;
            a = msg;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome(Initialize, a);
            frm.Show();
            this.Hide();
        }

        private void FrmAddCity_Load(object sender, EventArgs e)
        {
            LoadFunc();
        }
        private void LoadFunc()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ctx.Cities.ToList();
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            City c = new City();
            c.Name = textBox1.Text;
            ctx.Cities.Add(c);
            ctx.SaveChanges();
            LoadFunc();
        }
    }
}
