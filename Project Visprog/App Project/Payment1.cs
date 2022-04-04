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

namespace ProjectUASVisprog
{
    public partial class Payment1 : Form
    {
        public Payment1()
        {
            InitializeComponent();
            

        }

        
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Payment1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int weight = Convert.ToInt32(textBox3.Text);
            int subtotals = Convert.ToInt32(textBox4.Text);
            
            int resi = Convert.ToInt16(label7.Text);

            Payment pay = new Payment
            {
                No_Resi = resi,
                Item_Weight = weight,
                Ship_Type = textBox5.Text,
                SubTotal = subtotals,
                Pay_Method = textBox6.Text
            };
            db.Payments.InsertOnSubmit(pay);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Simpan Payment Berhasil");
                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Simpan Payment Gagal");
                button1.Enabled = true;
            }
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2E3LG5H\\SQLEXPRESS01;Initial Catalog=TestingVisprogFinal;Integrated Security=True");

            string sl = "select Max(NoPayment) from Payment";
            SqlCommand comd = new SqlCommand(sl, connection);
            comd = new SqlCommand(sl, connection);
            connection.Open();
            string cout;
            cout = Convert.ToString(comd.ExecuteScalar());
            connection.Close();
            textBox1.Text = cout;


        }

        private void button2_Click(object sender, EventArgs e)
        {



            InvoiceOrder IO = new InvoiceOrder();
            IO.Show();
            IO.textBox1.Text = label7.Text;
            IO.textBox2.Text = textBox2.Text;
       
            CreateOrder CO = new CreateOrder();
            CO.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Membuat Order Baru?", "New Order", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }

        }
    }
}
