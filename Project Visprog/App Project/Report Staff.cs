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
    public partial class Report_Staff : Form
    {
        public Report_Staff()
        {
            InitializeComponent();
        }

        private void Report_Staff_Load(object sender, EventArgs e)
        {
            CrystalReport2 vcr = new CrystalReport2();
            crystalReportViewer1.ReportSource = vcr;
        }
    }
}
