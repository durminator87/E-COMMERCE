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
    public partial class FrmAddProduct : Form
    {
        private Context ctx;        
        public FrmAddProduct(Context passer)
        {
            ctx = passer;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadFunction();
        }

        public void LoadFunction() 
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = ctx.Categories.ToList();
            comboBox2.DataSource = null;
            comboBox2.DataSource = ctx.Cities.ToList();
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Please enter the name of the product!");
            else if (textBox2.Text == "")
                MessageBox.Show("Please enter the price of the product!");
            else if (textBox3.Text == "")
                MessageBox.Show("Please enter the details about the product!");
            else if (comboBox1.SelectedItem.ToString() == "")
                MessageBox.Show("Please choose a category!");
            else if (comboBox2.SelectedItem.ToString() == "")
                MessageBox.Show("Please select a city!");

            else 
            {
                Category cat = ((Category)comboBox1.SelectedItem);
                City city = ((City)comboBox2.SelectedItem);
                Product p = new Product();

                p.Name = textBox1.Text;
                p.Price = textBox2.Text;
                p.Details = textBox3.Text;
                p.Category = cat;
                p.City = city;
                p.Date = dateTimePicker1.Value;

                ctx.Products.Add(p);
                ctx.SaveChanges();

                MessageBox.Show("You added the product succesfully!");
                Done();
            }

            
        }
        public void Done()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && textBox2.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Close();
        }
    }
}
