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
    public partial class FrmSearch : Form
    {
        public Context ctx;

        public FrmSearch(Context passer)
        {
            ctx = passer;
            InitializeComponent();
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCategories();

        }
        private void LoadData()
        {
            dataGridView1.DataSource = ctx.Products.ToList();
        
        }

        private void LoadCategories()
        {
            comboBox1.DataSource = ctx.Categories.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox2.DataSource = ctx.Cities.ToList();
            comboBox2.DisplayMember = "Name";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                var list1 = from product in ctx.Products
                            where product.Name.Contains(textBox1.Text)
                            select product;
                var list2 = from cat in list1
                            where cat.Category.Name.Contains(comboBox1.Text)
                            select cat;
                var list3 = from final in list2
                            where final.City.Name.Contains(comboBox2.Text)
                            select final;

                dataGridView1.DataSource = list3.ToList();

                LoadCategories();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Hide();
        }
    }
}
