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
    public partial class frmAddClient : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DbConnection dbcon = new DbConnection();
        frmClientList frmclist;
        public frmAddClient(frmClientList flist)
        {
            InitializeComponent();
            cn = new MySqlConnection(dbcon.MyConnection());
            frmclist = flist;
            btnUpdate.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validation
            if (txtFullname.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter Clients Name!");
                txtFullname.Focus();
                return;
            }
            if (txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter Clients Address!");
                txtAddress.Focus();
                return;
            }
            if (txtContact.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter Clients Contact!");
                txtContact.Focus();
                return;
            }
            if (cboID.SelectedIndex == 0)
            {
                MessageBox.Show("Please enter Type of ID!");
                cboID.Focus();
                return;
            }
            if (txtID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter ID Number!");
                txtID.Focus();
                return;
            }
            try
            {
                //private sdate =  dtBdate.Value.ToString("yyyy-MM-dd");
                cn.Open();
                cm = new MySqlCommand("INSERT INTO tblcustomer (fullname, address, bdate, contact, idtype, idno) values('" + txtFullname.Text + "','" + txtAddress.Text + "','" + dtBdate.Value.ToString("yyyy/MM/dd") + "','" + txtContact.Text + "','" + cboID.Text + "','" + txtID.Text + "')", cn);
                
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Successfully Added!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                frmclist.LoadData();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Clear()
        {
            txtFullname.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtID.Clear();
            dtBdate.Value = DateTime.Now;
            cboID.SelectedIndex = 0;
        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {
            cboID.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Validation
            if (txtFullname.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter Clients Name!");
                txtFullname.Focus();
                return;
            }
            if (txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter Clients Address!");
                txtAddress.Focus();
                return;
            }
            if (txtContact.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter Clients Contact!");
                txtContact.Focus();
                return;
            }
            if (cboID.SelectedIndex == 0)
            {
                MessageBox.Show("Please enter Type of ID!");
                cboID.Focus();
                return;
            }
            if (txtID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter ID Number!");
                txtID.Focus();
                return;
            }
            try
            {
                cn.Open();
                cm = new MySqlCommand("UPDATE tblcustomer  SET fullname = '" + txtFullname.Text + "', address = '" + txtAddress.Text + "', bdate = '" + dtBdate.Value.ToString("yyyy/MM/dd") + "', contact = '" + txtContact.Text + "', idtype = '" + cboID.Text + "', idno = '" + txtID.Text + "' where id like '" + lblID.Text + "'", cn);

                cm.ExecuteNonQuery();
                cn.Close();
                Clear();
                MessageBox.Show("Successfully Updated!", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmclist.LoadData();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
