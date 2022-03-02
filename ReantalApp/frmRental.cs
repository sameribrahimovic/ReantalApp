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
        DataSet ds;
        MySqlDataAdapter da;
        DbConnection dbcon = new DbConnection();

        string _id, _plate;
        public frmRental()
        {
            InitializeComponent();
            cn = new MySqlConnection(dbcon.MyConnection());
            LoadAutoNo();
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
            catch (Exception ex)
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
            catch (Exception ex)
            {
                cn.Close();
            }
        }


        private void frmRental_Load(object sender, EventArgs e)
        {
            AutoSuggestClient();
            AutoSuggestCar();
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

            DateTime d1 = DateTime.Now;
            int total = Convert.ToInt32(txtRate.Text);

            int noOfDays = ((TimeSpan)(dtReturn.Value.Date - d1.Date)).Days;
            lblDay.Text = noOfDays.ToString("0");

            txtTotal.Text = Convert.ToInt32(noOfDays * total).ToString();
        }

        private void dtReturn_ValueChanged(object sender, EventArgs e)
        {
            GetTotal();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
