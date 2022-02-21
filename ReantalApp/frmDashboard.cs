using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReantalApp
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            frmBrandList frm = new frmBrandList();
            frm.TopLevel = false;
            mainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            frmCarList frm = new frmCarList();
            frm.TopLevel = false;
            mainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
