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
    public partial class FrmAddCategory : Form
    {
        private Context Initialize = new Context();
        private Context ctx;
        public string a;
        public FrmAddCategory(Context passer, string msg)
        {
            a = msg;
            ctx = passer;
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome(Initialize,a);
            frm.Show();
            this.Hide();
        }

        private void FrmAddCategory_Load(object sender, EventArgs e)
        {
            LoadFunc();
        }
        private void LoadFunc() 
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ctx.Categories.ToList();
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.Name = textBox1.Text;
            ctx.Categories.Add(c);
            ctx.SaveChanges();
            LoadFunc();
        }
    }
}
