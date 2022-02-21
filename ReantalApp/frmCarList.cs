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
    public partial class frmCarList : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DbConnection dbcon = new DbConnection();
        public frmCarList()
        {
            InitializeComponent();
            cn = new MySqlConnection(dbcon.MyConnection());
            LoadData();
        }

        private void dgvCarList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCarList.Columns[e.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                frmAddCar frm = new frmAddCar(this);
                frm.txtPlateNo.Enabled = false;
                frm.txtPlateNo.Text = dgvCarList[1, e.RowIndex].Value.ToString();
                frm.cbBrand.Text = dgvCarList[2, e.RowIndex].Value.ToString();
                frm.txtModel.Text = dgvCarList[3, e.RowIndex].Value.ToString();
                frm.txtColor.Text = dgvCarList[4, e.RowIndex].Value.ToString();
                frm.txtRental.Text = dgvCarList[5, e.RowIndex].Value.ToString();
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
                    cm = new MySqlCommand("DELETE FROM tblcar WHERE plate = '" + dgvCarList[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record successfully Deleted!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }

        public void LoadData()
        {
            int i = 0;
            dgvCarList.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("SELECT * FROM tblcar ORDER BY brand", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCarList.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            cn.Close();
            lblCount.Text = dgvCarList.Rows.Count.ToString() + "  RECORDS";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddCar frm = new frmAddCar(this);
            frm.btnUpdate.Enabled = false;
            frm.txtPlateNo.Enabled = true;
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
