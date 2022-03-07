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
    public partial class frmIncome : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DbConnection dbcon = new DbConnection();
        public frmIncome()
        {
            InitializeComponent();
            cn = new MySqlConnection(dbcon.MyConnection());
        }

        private void frmIncome_Load(object sender, EventArgs e)
        {
            dt1.Value = DateTime.Now;
            dt2.Value = DateTime.Now;
            loadIncome();
        }

        private void loadIncome()
        {
            string sdate1 = dt1.Value.ToString("yyyy-MM-dd");
            string sdate2 = dt2.Value.ToString("yyyy-MM-dd");
            var income = default(double);
            dgvIncome.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("SELECT * FROM tblpayment WHERE cash > 0 AND sdate BETWEEN '" + sdate1 + "' and '" + sdate2 + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvIncome.Rows.Add(dr["transno"], dr["name"], Double.Parse(dr["cash"].ToString()).ToString("#,##0.00"), DateTime.Parse(dr["sdate"].ToString()).ToShortDateString());
                income += Convert.ToDouble(dr["cash"]);
            }
            dr.Close();
            cn.Close();
            lblCount.Text = dgvIncome.Rows.Count.ToString() + "  RECORDS";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            loadIncome();
        }
    }
}
