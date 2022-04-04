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
    public partial class InvoiceOrder : Form
    {
        public InvoiceOrder()
        {
            InitializeComponent();
        }

        private void InvoiceOrder_Load(object sender, EventArgs e)
        {
            //CrystalReport1 vcr = new CrystalReport1();
            //crystalReportViewer1.SelectionFormula = "{Transaksi.No_Resi} = '" + textBox1.Text + "'";
            //crystalReportViewer1.ReportSource = vcr;
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CrystalReport1 vcr = new CrystalReport1();
            vcr.SetParameterValue("InvoiceNoResi", textBox2.Text);
            crystalReportViewer1.ReportSource = vcr;
    

        }
    }
}
