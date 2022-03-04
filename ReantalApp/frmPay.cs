using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
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
    public partial class frmPay : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        DbConnection dbcon = new DbConnection();
        frmRental frm = new frmRental();
        public frmPay()
        {
            InitializeComponent();
            cn = new MySqlConnection(dbcon.MyConnection());
        }

        public void GetChange()
        {
            try
            {
                if (Convert.ToDouble(txtCash.Text) >= Convert.ToDouble(lblTotal.Text))
                {
                    lblChange.Text = Strings.Format((object)(Convert.ToDouble(txtCash.Text) - Convert.ToDouble(lblTotal.Text)), "#,##0.00");
                }
            }
            catch (Exception)
            {
                this.lblChange.Text = "0.00";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {

            GetChange();
            //todo
            //make only number input
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtCash.Text) < Convert.ToDouble(lblTotal.Text))
            {
                MessageBox.Show("Insuffecient cash!");
                return;
            }
            else if (MessageBox.Show("Accept Payment?", "Payment", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sdate = DateTime.Now.Date.ToString("yyyy-MM-dd");
                cn.Open();
                cm = new MySqlCommand("INSERT INTO tblpayment(transno, name, cash, sdate) VALUES('" + lblTransNo.Text + "','" + lblName.Text + "','" + Convert.ToDouble(txtCash.Text) + "','" + sdate + "')", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                Interaction.MsgBox("Payment successfully Completed!");
                this.txtCash.Text = "0";
                this.lblTotal.Text = "0";
                this.Dispose();
                frm.LoadAutoNo();
                frm.txtCustomer.Clear();
                frm.txtPlateNo.Clear();
                frm.LoadCart();
                frm.Reset();
            }
        }
    }
}
