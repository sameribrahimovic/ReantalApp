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
    public partial class frmLogs : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DbConnection dbcon = new DbConnection();
        public frmLogs()
        {
            InitializeComponent();
            cn = new MySqlConnection(dbcon.MyConnection());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogs_Load(object sender, EventArgs e)
        {
            dt1.Value = DateTime.Now;
            dt2.Value = DateTime.Now;
            LoadAllLogs();
        }

        private void LoadAllLogs()
        {
            string sdate1 = dt1.Value.ToString("yyyy-MM-dd");
            string sdate2 = dt2.Value.ToString("yyyy-MM-dd");
            dgvLogs.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("SELECT * FROM qrental WHERE dborrowed BETWEEN '" + sdate1 + "' AND '" + sdate2 + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvLogs.Rows.Add(dr["transno"], dr["fullname"], dr["plateno"], Double.Parse(dr["rentalpay"].ToString()).ToString("#,##0.00"), dr["status"], DateTime.Parse(dr["dborrowed"].ToString()).ToShortDateString());
            }
            dr.Close();
            cn.Close();
        }
    }
}
