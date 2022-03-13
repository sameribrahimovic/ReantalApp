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
    public partial class frmReturn : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DbConnection dbcon = new DbConnection();
        string _id, _cid, _transaction, _fullname, _plateno, _ddue, _rent;

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            GetChange();
        }

        private void GetChange()
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

                lblChange.Text = "0.00";
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCash.Text == String.Empty)
                {
                    return;
                }
                if (/*Convert.ToDouble(lblDue.Text) > 0 || */Convert.ToDouble(txtCash.Text) < Convert.ToDouble(lblTotal.Text))
                    {
                        MessageBox.Show("Insuffecient cash.");
                    }
               
                else if (MessageBox.Show("Return this Car?", "Return information", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sdate = DateTime.Now.Date.ToString("yyyy-MM-dd");
                    cn.Open();
                    cm = new MySqlCommand("INSERT INTO tblpayment(transno, name, cash, sdate) values('" + lblTransNo.Text + "','" + lblCustomer.Text + "','" + Convert.ToDouble(txtCash.Text) + "','" + sdate + "')", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    cn.Open();
                    cm = new MySqlCommand("UPDATE tblrent SET status = 'Returned' WHERE id LIKE '" + _id + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    cn.Open();
                    cm = new MySqlCommand("UPDATE tblcar SET status = 'Available' WHERE plate LIKE '" + lblPlate.Text + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Successfully returned!");
                    lblCustomer.Text = "";
                    lblPlate.Text = "";
                    lblTransNo.Text = "";
                    lblDateReturn.Text = DateTime.Now.ToString("MMM-dd-yyyy");
                    lblDue.Text = "0";
                    lblRent.Text = "0.00";
                    lblTotal.Text = "0.00";
                    LoadRental();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void lblDue_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(lblDue.Text) > 0)
            {
                txtCash.Enabled = true;
                txtCash.Text = "0.00";
            }
            else
            {
                txtCash.Text = "0.00";
                txtCash.Enabled = false;
            }
        }

        private void dgvReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvReturn.Columns[e.ColumnIndex].Name;
                if (colName == "colSelect")
                {
                    _id = dgvReturn.Rows[e.RowIndex].Cells[0].Value.ToString();
                    _transaction = dgvReturn.Rows[e.RowIndex].Cells[1].Value.ToString();
                    _cid = dgvReturn.Rows[e.RowIndex].Cells[2].Value.ToString();
                    _fullname = dgvReturn.Rows[e.RowIndex].Cells[3].Value.ToString();
                    _plateno = dgvReturn.Rows[e.RowIndex].Cells[4].Value.ToString();
                    _ddue = dgvReturn.Rows[e.RowIndex].Cells[6].Value.ToString();
                    _rent = dgvReturn.Rows[e.RowIndex].Cells[7].Value.ToString();
                    lblCustomer.Text = _fullname;
                    lblDateDue.Text = _ddue;
                    lblDateReturn.Text = DateTime.Now.Date.ToString("MMM-dd-yyyy");
                    lblDue.Text = DateAndTime.DateDiff("d", lblDateDue.Text, lblDateReturn.Text).ToString();
                    lblPlate.Text = _plateno;
                    lblTransNo.Text = _transaction;
                    lblRent.Text = _rent;
                    lblTotal.Text = (Convert.ToDouble(lblRent.Text) * Convert.ToDouble(lblDue.Text)).ToString();
                    
                }
            }
            catch (Exception ex)
            {
               cn.Close();
                MessageBox.Show(ex.Message);
            }
            

        }

        private void frmReturn_Load(object sender, EventArgs e)
        {
            LoadRental();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
                LoadRental();
        }

        private void LoadRental()
        {
            dgvReturn.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("SELECT * FROM qrental WHERE status LIKE 'Borrowed' AND fullname LIKE '" + txtSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvReturn.Rows.Add(dr["id"], dr["transno"], dr["cid"], dr["fullname"], dr["plateno"], Convert.ToDateTime(dr["dborrowed"].ToString()).ToShortDateString(), Convert.ToDateTime(dr["dreturned"].ToString()).ToShortDateString(), Convert.ToDecimal(dr["rentalpay"].ToString()).ToString("#,##0.00"));
            }
            dr.Close();
            cn.Close();
        }

        public frmReturn()
        {
            InitializeComponent();
            cn = new MySqlConnection(dbcon.MyConnection());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
