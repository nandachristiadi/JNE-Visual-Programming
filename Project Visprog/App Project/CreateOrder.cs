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
    public partial class CreateOrder : Form
    {
        public CreateOrder()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.Parent = parent;

        }
        HomePage parent;
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear All Values?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                comboBox2.Text = "";
                textBox16.Clear();
                textBox13.Clear();
                comboBox1.Text = "";
                textBox15.Clear();
                textBox14.Clear();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment1 Py = new Payment1();
           
            int weight = Convert.ToInt32(textBox13.Text);
            
       
            string shiptype = comboBox1.Text;
            int dist;
            int ship_fee;
            int dist_fee = 5000;
            int subtotal = 0;
            string staffid = "";

            if (shiptype == "KLT1")
            {
                staffid = "004";
                dist = 20;
                ship_fee = 2500;
                subtotal = (dist * dist_fee) + (weight * ship_fee);
                label21.Text = subtotal.ToString();

            }
            else if (shiptype == "KLT2")
            {
                staffid = "005";
                dist = 10;
                ship_fee = 1500;
                subtotal = (dist * dist_fee) + (weight * ship_fee);
                label21.Text = subtotal.ToString();
            }
            else if (shiptype == "Reg1")
            {
                staffid = "001";
                dist = 20;
                ship_fee = 1000;
                subtotal = (dist * dist_fee) + (weight * ship_fee);
                label21.Text = subtotal.ToString();
            }
            else if (shiptype == "Reg2")
            {
                staffid = "002";
                dist = 16;
                ship_fee = 1000;
                subtotal = (dist * dist_fee) + (weight * ship_fee);
                label21.Text = subtotal.ToString();
            }
            else if (shiptype == "Reg3")
            {
                staffid = "003";
                dist = 10;
                ship_fee = 1000;
                subtotal = (dist * dist_fee) + (weight * ship_fee);
                label21.Text = subtotal.ToString();
            }
            else
            {
                MessageBox.Show("Please Choose Delivery Service ");
            }
            
            label22.Text = staffid;
            

            Transaksi Trans = new Transaksi
            {
                Cust_Name = textBox1.Text,
                Cust_Phone = textBox2.Text,
                Cust_Address = textBox3.Text,
                Cust_Zip = textBox4.Text,
                Cust_City = textBox5.Text,
                Cust_Country = textBox6.Text,
                Rec_Name = textBox12.Text,
                Rec_Phone = textBox11.Text,
                Rec_Address = textBox10.Text,
                Rec_Zip = textBox9.Text,
                Rec_City = textBox8.Text,
                Rec_Country = textBox7.Text,                
                Item_Type = comboBox2.Text,
                Item_Desc = textBox16.Text,
                Item_Weight = weight,
                timeLimit = dateTimePicker2.Value,
                Staff_Id = staffid,
                Ship_Type = comboBox1.Text,
                Ship_Date = dateTimePicker1.Value,
                ReceivedBy = textBox12.Text

            };
            db.Transaksis.InsertOnSubmit(Trans);
            try
            {
                db.SubmitChanges();
                button1.Enabled = false;
                button2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Simpan Transaksi Gagal");
                button1.Enabled = true;
                button2.Enabled = true;
            }
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2E3LG5H\\SQLEXPRESS01;Initial Catalog=TestingVisprogFinal;Integrated Security=True");

            string sl = "select Max(NoResi) from Transaksi";
            SqlCommand comd = new SqlCommand(sl, connection);
            comd = new SqlCommand(sl, connection);
            connection.Open();
            string cout;
            cout = Convert.ToString(comd.ExecuteScalar());
            connection.Close();
            textBox14.Text = cout;


            string s = "select Max(No_Resi) from Transaksi";
            SqlCommand comm = new SqlCommand(s, connection);
            comm = new SqlCommand(s, connection);
            connection.Open();
            int cord;

            cord = Convert.ToInt16(comm.ExecuteScalar());
            connection.Close();            

            
            string crod = Convert.ToString(cord);
            label23.Text = crod;
            


            string status_ord = "On Process";
            Order Or = new Order
            {
                Ship_Type = comboBox1.Text,
                Orders_Date = dateTimePicker1.Value,
                No_Resi = Convert.ToInt16(label23.Text),
                Status_Order = status_ord
                                
            };
            db.Orders.InsertOnSubmit(Or);
            try
            {
                db.SubmitChanges();
                button1.Enabled = false;
                button2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Simpan Order Gagal");
                button1.Enabled = true;
                button2.Enabled = true;
            }

             string i = "select Max(NoOrder) from Orders";
            SqlCommand command = new SqlCommand(i, connection);
            command = new SqlCommand(i, connection);
            connection.Open();
            string count;

            count = Convert.ToString(command.ExecuteScalar());
            connection.Close();
            textBox15.Text = count;
            

            if (MessageBox.Show("Silahkan Lanjutkan Ke Menu Payment", "Proses Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Py.textBox3.Text = textBox13.Text;
                Py.textBox5.Text = comboBox1.Text;
                Py.textBox2.Text = label23.Text;
                Py.textBox4.Text = label21.Text;
                Py.textBox2.Text = cout;
                Py.label7.Text = crod;
                Py.Show();
                this.Refresh();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                comboBox2.Text = "";
                textBox16.Clear();
                textBox13.Clear();
                comboBox1.Text = "";
                textBox15.Clear();
                textBox14.Clear();
                button1.Enabled = true;
                button2.Enabled = true;



            }


        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            /**
            Payment1 Py = new Payment1();
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2E3LG5H\\SQLEXPRESS01;Initial Catalog=TestingVisprog6;Integrated Security=True");
            string i = "select Max(NoOrder) from Orders";
            SqlCommand command = new SqlCommand(i, connection);
            command = new SqlCommand(i, connection);
            connection.Open();
            string count;
            
            count = Convert.ToString(command.ExecuteScalar());
            connection.Close();
            textBox15.Text =  count;


            string sl = "select Max(NoResi) from Transaksi";
            SqlCommand comd = new SqlCommand(sl, connection);
            comd = new SqlCommand(sl, connection);
            connection.Open();
            string cout;
            cout = Convert.ToString(comd.ExecuteScalar());
            connection.Close();
            textBox14.Text = cout;


            string s = "select Max(No_Resi) from Transaksi";
            SqlCommand comm = new SqlCommand(s, connection);
            comm = new SqlCommand(s, connection);
            connection.Open();
            int cord;

            cord = Convert.ToInt16(comm.ExecuteScalar());
            connection.Close();

            
            
            Py.textBox2.Text = cout;
            Py.label7.Text = cout;
            string crod = Convert.ToString(cord);
            label23.Text = crod;
            **/

        }
    }
}
