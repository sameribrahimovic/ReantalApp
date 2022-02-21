using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ReantalApp
{
    public partial class frmAddCar : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DbConnection dbcon = new DbConnection();
        frmCarList frmclist;
        public frmAddCar(frmCarList flist)
        {
            InitializeComponent();
            cn = new MySqlConnection(dbcon.MyConnection());
            LoadBrand();
            frmclist = flist;
            btnUpdate.Enabled = false;
        }

        private void Clear()
        {
            txtColor.Clear();
            txtModel.Clear();
            txtPlateNo.Clear();
            txtRental.Clear();
            cbBrand.Text = "";
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtPlateNo.Enabled = true;
        }
        public void LoadBrand()
        {
            cbBrand.Items.Clear();
            cbBrand.Items.Add("Select Brand");
            cn.Open();
            cm = new MySqlCommand("SELECT * FROM tblbrand", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cbBrand.Items.Add(dr[0].ToString());
            }
            cbBrand.SelectedIndex = 0;
            dr.Close();
            cn.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validation
            if (txtPlateNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter Plate Number!");
                txtPlateNo.Focus();
                return;
            }
            if (cbBrand.SelectedIndex == 0)
            {
                MessageBox.Show("Please enter Car Brand!");
                cbBrand.Focus();
                return;
            }
            if (txtModel.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter Car Model!");
                txtModel.Focus();
                return;
            }
            if (txtColor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter Color!");
                txtColor.Focus();
                return;
            }
            if (txtRental.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter Rental Price!");
                txtRental.Focus();
                return;
            }
            try
            {
                string bid = "";
                cn.Open();
                cm = new MySqlCommand("SELECT brand FROM tblbrand where brand like '" + cbBrand.Text + "'", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    bid = dr[0].ToString();
                }
                dr.Close();
                cn.Close();

                cn.Open();
                cm = new MySqlCommand("INSERT INTO tblcar(plate, brand, model, color, rental) values(@plate, @brand, @model, @color, @rental)", cn);
                cm.Parameters.AddWithValue("@plate", txtPlateNo.Text);
                cm.Parameters.AddWithValue("@brand", bid);
                cm.Parameters.AddWithValue("@model", txtModel.Text);
                cm.Parameters.AddWithValue("@color", txtColor.Text);
                cm.Parameters.AddWithValue("@rental", double.Parse(txtRental.Text));
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

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Validation
            if (txtPlateNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter Plate Number!");
                txtPlateNo.Focus();
                return;
            }
            if (cbBrand.SelectedIndex == 0)
            {
                MessageBox.Show("Please enter Car Brand!");
                cbBrand.Focus();
                return;
            }
            if (txtModel.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter Car Model!");
                txtModel.Focus();
                return;
            }
            if (txtColor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter Color!");
                txtColor.Focus();
                return;
            }
            if (txtRental.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter Rental Price!");
                txtRental.Focus();
                return;
            }
            try
            {
                if (MessageBox.Show("Are you sure to Update this Record?", "Update Record", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string bid = "";
                    cn.Open();
                    cm = new MySqlCommand("SELECT * FROM tblbrand where brand like '" + cbBrand.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        bid = dr[0].ToString();
                    }
                    dr.Close();
                    cn.Close();

                    cn.Open();
                    cm = new MySqlCommand("UPDATE tblcar SET brand=@brand, model=@model, color=@color, rental=@rental WHERE plate LIKE @plate", cn);
                    cm.Parameters.AddWithValue("@brand", bid);
                    cm.Parameters.AddWithValue("@model", txtModel.Text);
                    cm.Parameters.AddWithValue("@color", txtColor.Text);
                    cm.Parameters.AddWithValue("@rental", double.Parse(txtRental.Text));
                    cm.Parameters.AddWithValue("@plate", txtPlateNo.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Successfully Updated!", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    frmclist.LoadData();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRental_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
