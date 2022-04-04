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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            
            MasterStaff MS = new MasterStaff();
            MS.MdiParent = this;
            MS.Show();

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            
            MasterCustomer MCs = new MasterCustomer();
            MCs.MdiParent = this;
            MCs.Show();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            if (MessageBox.Show("Do you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Close();
            }
        }

        private void orderToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            
            ShipmentEdit SE = new ShipmentEdit();
            SE.MdiParent = this;
            SE.Show();

        }

        private void createOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            CreateOrder CO = new CreateOrder();
            CO.MdiParent = this;
            CO.Show();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
      
        }

        private void reportItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Item RI = new Report_Item();
            RI.Show();
            
        }

        private void reportCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerReport CR = new CustomerReport();
            CR.Show();
        }

        private void reportStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Staff RS = new Report_Staff();
            RS.Show();
        }
    }
}
