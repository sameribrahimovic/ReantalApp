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
