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
    public partial class frmClientList : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DbConnection dbcon = new DbConnection();
        public frmClientList()
        {
            InitializeComponent();
            cn = new MySqlConnection(dbcon.MyConnection());
            LoadData();
        }

        public void LoadData()
        {
            int i = 0;
            dgvClientList.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("SELECT * FROM tblcustomer WHERE fullname like '"+txtSearch.Text+"%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvClientList.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), DateTime.Parse(dr[3].ToString()).ToShortDateString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
            lblCount.Text = dgvClientList.Rows.Count.ToString() + "  RECORDS";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddClient frm = new frmAddClient(this);
            frm.btnUpdate.Enabled = false;
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvClientList.Columns[e.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                frmAddClient frm = new frmAddClient(this);
                frm.lblID.Text = dgvClientList[1, e.RowIndex].Value.ToString();
                frm.txtFullname.Text = dgvClientList[2, e.RowIndex].Value.ToString();
                frm.txtAddress.Text = dgvClientList[3, e.RowIndex].Value.ToString();
                frm.dtBdate.Text = DateTime.Parse(dgvClientList[4, e.RowIndex].Value.ToString()).ToShortDateString();
                frm.txtContact.Text = dgvClientList[5, e.RowIndex].Value.ToString();
                frm.cboID.Text = dgvClientList[6, e.RowIndex].Value.ToString();
                frm.txtID.Text = dgvClientList[7, e.RowIndex].Value.ToString();
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
                    cm = new MySqlCommand("DELETE FROM tblcustomer WHERE id like '" + dgvClientList[1, e.RowIndex].Value.ToString() +"'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record successfully Deleted!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
