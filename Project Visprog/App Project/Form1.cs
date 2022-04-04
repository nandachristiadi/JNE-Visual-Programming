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
using System.Text;
using System.IO;

namespace ProjectUASVisprog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void Tulis(string kata)
        {
            FileStream fs = new FileStream("D:\\SEMESTER 3\\VisualProg\\Kelompok\\App\\ProjectUASNew\\ProjectUASVisprog\\Riwayat_Login.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(kata);
            sw.Close();
            fs.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Data Source=DESKTOP-2E3LG5H\SQLEXPRESS01;Initial Catalog=ProjectVisualProgramming;Integrated Security=True
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-2E3LG5H\\SQLEXPRESS01;Initial Catalog=TestingVisprogFinal;Integrated Security=True");
           SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Login_User where Username = '" + textBox1.Text + "' and Passwords = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                HomePage acc = new HomePage();
                acc.Show();
                this.Hide();
                lblerror.Visible = false;
                DateTime now = DateTime.Now;
                Tulis(textBox1.Text + "\n" + now + "\n--------------------------------------------------");

            }
            else
            {
                lblerror.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
