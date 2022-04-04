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
    public partial class ShipmentEdit : Form
    {
        public ShipmentEdit()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void ShipmentEdit_Load(object sender, EventArgs e)
        {
            //join br in db.Orders on a.No_Resi equals br.No_Resi (taro setelah sb.transaksis)
            var tampil = (from a in db.Transaksis join br in db.Orders on a.No_Resi equals br.No_Resi
                          where br.Status_Order.Contains("on process")
                          select new { br.NoOrder,a.NoResi, a.Staff_Id, a.Ship_Type, a.Ship_Date, br.Status_Order, br.No_Order }).ToList();
            dataGridView1.DataSource = tampil;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label7.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox7.Visible = true;
            textBox4.Visible = true;
            checkBox1.Visible = true;
            button2.Visible = true;
            button2.Enabled = true;

            textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox4.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            label5.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var search = (from a in db.Transaksis
                          join br in db.Orders on a.No_Resi equals br.No_Resi
                          where a.NoResi.Contains(textBox1.Text.ToString())
                          where br.Status_Order.Contains("On Process")
                          select new { br.NoOrder,a.NoResi,a.Staff_Id, a.Ship_Type, a.Ship_Date, a.ReceivedBy, br.Status_Order ,br.No_Order }).ToList();
            dataGridView1.DataSource = search;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            int INoOrd = Convert.ToInt16(label5.Text);
            DataClasses1DataContext db = new DataClasses1DataContext();
            var ubah = (from a in db.Orders where a.No_Order == INoOrd select a).Single();

            if(checkBox1.Checked = true)
            {
                ubah.Status_Order = "Received";
                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Update Berhasil");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Update Gagal");
                }
            }
            var tampil = (from a in db.Transaksis
                          join br in db.Orders on a.No_Resi equals br.No_Resi
                          where br.Status_Order.Contains("on process")
                          select new { br.NoOrder, a.NoResi, a.Staff_Id, a.Ship_Type, a.Ship_Date, br.Status_Order, br.No_Order }).ToList();
            dataGridView1.DataSource = tampil;

            checkBox1.Checked = false;
            button2.Enabled = false;
        }
    }
}
