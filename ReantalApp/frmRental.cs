using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ReantalApp
{
    public partial class frmRental : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DbConnection dbcon = new DbConnection();

        string _id, _plate;
        public frmRental()
        {
            InitializeComponent();
            cn = new MySqlConnection(dbcon.MyConnection());
            LoadAutoNo();
        }

        public void Reset()
        {
            txtCustomer.Clear();
            txtCustomer.Focus();
            txtTransNo.Clear();
            txtName.Clear();
            txtContact.Clear();
            txtRemarks.Clear();

            txtPlateNo.Clear();
            txtPlate.Clear();
            txtDetails.Clear();
            txtRate.Clear();
            dtReturn.Value = DateTime.Now;
            txtTotal.Clear();

        }
        public void LoadClientData()
        {
            cn.Open();
            cm = new MySqlCommand("SELECT * FROM tblcustomer WHERE fullname like '" + txtCustomer.Text + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtID.Text = dr["id"].ToString();
                txtName.Text = dr["fullname"].ToString();
                txtContact.Text = dr["contact"].ToString();
            }
            else
            {
                txtID.Clear();
                txtName.Clear();
                txtContact.Clear();
            }
            dr.Close();
            cn.Close();
        }
        public void LoadCarData()
        {
            cn.Open();
            cm = new MySqlCommand("SELECT * FROM tblcar WHERE plate like '" + txtPlateNo.Text + "' AND status LIKE 'Available'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtPlate.Text = dr["plate"].ToString();
                txtDetails.Text = dr["brand"].ToString();
                txtRate.Text = dr["rental"].ToString();
            }
            else
            {
                txtPlate.Clear();
                txtDetails.Clear();
                txtRate.Clear();
            }
            dr.Close();
            cn.Close();
        }

        //Auto add rental No on form opening
        public void LoadAutoNo()
        {
            var rand = new Random();
            txtTransNo.Text = rand.Next(11111111, 99999999).ToString();
        }

        public void AutoSuggestClient()
        {
            try
            {
                cn.Open();
                cm = new MySqlCommand("SELECT * FROM tblcustomer", cn);
                DataTable data = new DataTable();
                da = new MySqlDataAdapter(cm);
                da.Fill(data);
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    col.Add(data.Rows[i]["fullname"].ToString());
                }
                cn.Close();
                
                txtCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtCustomer.AutoCompleteCustomSource = col;
                txtCustomer.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
            catch (Exception)
            {
                cn.Close();
            }
        }
        public void AutoSuggestCar()
        {
            try
            {
                cn.Open();
                cm = new MySqlCommand("SELECT * FROM tblcar WHERE status LIKE 'Available'", cn);
                DataTable data = new DataTable();
                da = new MySqlDataAdapter(cm);
                da.Fill(data);
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    col.Add(data.Rows[i]["plate"].ToString());
                }
                cn.Close();
                txtPlateNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtPlateNo.AutoCompleteCustomSource = col;
                txtPlateNo.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
            catch (Exception)
            {
                cn.Close();
            }
        }


        private void frmRental_Load(object sender, EventArgs e)
        {
            AutoSuggestClient();
            AutoSuggestCar();
            txtCustomer.Focus();
            //btnRent.Enabled = false;
            btnPay.Enabled = false;
            //LoadCart();
        }


        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            LoadClientData();
        }

        private void txtPlateNo_TextChanged(object sender, EventArgs e)
        {
            LoadCarData();
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            GetTotal();
        }

        private void GetTotal()
        {
            //one way to get no between two dates
            //DateTime d1 = DateTime.Now;
            //DateTime d2 = dtReturn.Value;
            //double NoOfDays = (d2 - d1).TotalDays;
            //lblDay.Text = NoOfDays.ToString("0");

            //this also works!
            //DateTime d1 = DateTime.Now;
            //int total = Convert.ToInt32(txtRate.Text);

            //int noOfDays = ((TimeSpan)(dtReturn.Value.Date - d1.Date)).Days;
            //lblDay.Text = noOfDays.ToString("0");

            //txtTotal.Text = Convert.ToInt32(noOfDays * total).ToString();


            try
            {
                int day;
                day = (int)DateAndTime.DateDiff("d", DateTime.Now.Date.ToString("MM-dd-yyyy"), dtReturn.Value.ToString("MM-dd-yyyy"));
                day += 1;
                lblDay.Text = day.ToString();
                txtTotal.Text = Strings.Format((object)(day * Convert.ToDouble(txtRate.Text)), "#,##0.00");
            }
            catch (Exception)
            {
                txtTotal.Text = "0.00";
            }
        }

        private void dtReturn_ValueChanged(object sender, EventArgs e)
        {
            GetTotal();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == null)
                    {
                        return;
                    }
                    if (txtPlateNo.Text == null)
                    {
                        return;
                    }
                    string sdate1 = DateTime.Now.ToString("yyyy-MM-dd");
                    string sdate2 = dtReturn.Value.ToString("yyyy-MM-dd");

                    if (MessageBox.Show("Rent this Car?", "Rental information", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new MySqlCommand("INSERT INTO tblrent (transno, cid, plateno, dborrowed, dreturned, rental, noofdays, rentalpay, remarks)" +
                            "VALUES ('" + txtTransNo.Text + "','" + txtID.Text + "','" + txtPlate.Text + "','" + sdate1 + "','" + sdate2 + "','" + Convert.ToDouble(txtRate.Text) + "','" + lblDay.Text + "','" + Convert.ToDouble(txtTotal.Text) + "','" + txtRemarks.Text + "')", cn);
                        cm.ExecuteNonQuery();

                        MessageBox.Show("Car successfully Rented! Proceed to Payment.");
                        cn.Close();
                        LoadCart();

                        cn.Open();  
                        cm = new MySqlCommand("UPDATE tblcar SET status ='Borrowed' WHERE plate LIKE '" + txtPlate.Text + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        AutoSuggestCar();
                        txtPlateNo.Clear();
                        txtPlate.Clear();
                        txtDetails.Clear();
                        txtRate.Clear();
                        dtReturn.Value = DateTime.Now;
                        txtTotal.Clear();
                        btnPay.Enabled = true;
                        GroupBox1.Enabled = false;
                    }
            }
            catch (Exception)
                {
                    cn.Close();
                }
        }

        private void dgvRent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvRent.Columns[e.ColumnIndex].Name;
            if (colName == "colDelete")
            {
                if (MessageBox.Show("Delete from list?", "Delete", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new MySqlCommand("DELETE FROM tblrent WHERE id LIKE '" + _id + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    Reset();

                    cn.Open();
                    cm = new MySqlCommand("UPDATE tblcar SET status = 'Available' WHERE plate LIKE '" + _plate + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Record successfully Deleted from list!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GroupBox1.Enabled = true;
                    txtCustomer.Focus();
                    LoadCart();
                    AutoSuggestCar();
                }
            }
        }

        public void LoadCart()
        {
            try
            {
                int i = 0;
                double tot = 0;
                dgvRent.Rows.Clear();
                cn.Open();
                cm = new MySqlCommand("SELECT * FROM tblrent WHERE transno LIKE '" + txtTransNo.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dgvRent.Rows.Add(dr["id"].ToString(), dr["plateno"].ToString(), Convert.ToDecimal(dr["rentalpay"].ToString()).ToString("#,##0.00"), Convert.ToDateTime(dr["dborrowed"].ToString()).ToShortDateString(), Convert.ToDateTime(dr["dreturned"].ToString()).ToShortDateString());
                    tot += Convert.ToDouble(dr["rentalpay"].ToString());
                    i += 1;
                }
                dr.Close();
                cn.Close();
                //lblTotal.Text = (tot/*, "#,##0.00"*/).ToString();
                lblTotal.Text = Strings.Format(tot, "#,##0.00");
                dgvRent.ClearSelection();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }


        //this is important when you delete rented car, give status back to available
        private void dgvRent_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvRent.CurrentRow.Index;
            _id = dgvRent[0, i].Value.ToString();
            _plate = dgvRent[1, i].Value.ToString();
            btnRent.Enabled = true;
            //AutoSuggestCar();
            //AutoSuggestClient();

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            frmPay frm = new frmPay(this);
            frm.lblTransNo.Text = txtTransNo.Text;
            frm.lblName.Text = txtCustomer.Text;
            frm.lblTotal.Text = lblTotal.Text;
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (dgvRent.Rows.Count > 0)
            {
                MessageBox.Show("Please settle payment!");
            }
            else
            {
                this.Close();
            }
        }



    }
}
