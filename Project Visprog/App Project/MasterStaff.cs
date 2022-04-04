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
    public partial class MasterStaff : Form
    {
        public MasterStaff()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void MasterStaff_Load(object sender, EventArgs e)
        {
            var tampil = (from a in db.Staffs select new {a.Staff_ID,a.Staff_Name,a.Staff_Gender,a.Staff_DOB,a.Staff_Position,a.Staff_Phone,a.Staff_Email}).ToList();

            dataGridView1.DataSource = tampil;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            var search = (from a in db.Staffs
                          where a.Staff_Name.Contains(textBox1.Text.ToString())
                          select new { a.Staff_ID, a.Staff_Name, a.Staff_Gender, a.Staff_DOB, a.Staff_Position, a.Staff_Phone, a.Staff_Email }).ToList();
            dataGridView1.DataSource = search;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox7.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox8.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

    }
}
