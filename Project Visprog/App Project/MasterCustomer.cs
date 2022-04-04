using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUASVisprog
{
    public partial class MasterCustomer : Form
    {
        public MasterCustomer()
        {
            InitializeComponent();
        }

        private void MasterCustomer_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var tampil = (from a in db.Transaksis select new { a.NoResi, a.Cust_Name, a.Cust_Phone, a.Cust_Address, a.Cust_Zip, a.Cust_City, a.Cust_Country}).ToList();

            dataGridView1.DataSource = tampil;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var search = (from a in db.Transaksis
                          where a.NoResi.Contains(textBox1.Text.ToString())
                          select new { a.NoResi, a.Cust_Name, a.Cust_Phone, a.Cust_Address, a.Cust_Zip, a.Cust_City, a.Cust_Country }).ToList();
            dataGridView1.DataSource = search;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
