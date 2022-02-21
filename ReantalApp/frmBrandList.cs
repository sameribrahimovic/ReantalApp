using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReantalApp
{
    public partial class frmBrandList : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DbConnection dbcon = new DbConnection();
        public frmBrandList()
        {
            InitializeComponent();
            cn = new MySqlConnection(dbcon.MyConnection());
            LoadData();
        }

        public void LoadData()
        {
            int i = 0;
            dgvBrandList.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("SELECT * FROM tblbrand ORDER BY brand", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvBrandList.Rows.Add(i, dr["brand"].ToString());
            }
            dr.Close();
            cn.Close();
            //todo lblCount to display number of brands from datagridview!
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddBrand frm = new frmAddBrand(this);
            frm.btnUpdate.Enabled = false;
            frm.ShowDialog();
        }

        private void dgvBrandList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvBrandList.Columns[e.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                frmAddBrand frm = new frmAddBrand(this);
                frm.lblBrand.Text = dgvBrandList[1, e.RowIndex].Value.ToString();
                frm.txtBrand.Text = dgvBrandList[1, e.RowIndex].Value.ToString();
                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;
                frm.ShowDialog();
            }
            else if (colName == "colDelete")
            {
                if (MessageBox.Show("Delete record?", "Delete", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new MySqlCommand("DELETE FROM tblBrand WHERE brand = '" + dgvBrandList[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record successfully Deleted!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }
    }
}
