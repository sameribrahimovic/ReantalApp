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

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmClientList frm = new frmClientList();
            frm.TopLevel = false;
            mainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            frmRental frm = new frmRental();
            frm.TopLevel = false;
            mainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmReturn frm = new frmReturn();
            frm.TopLevel = false;
            mainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            frmIncome frm = new frmIncome();
            frm.TopLevel = false;
            mainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
