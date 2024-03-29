﻿using MySql.Data.MySqlClient;
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
    public partial class frmAddBrand : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        DbConnection dbcon = new DbConnection();
        frmBrandList frmblist;
        public frmAddBrand(frmBrandList flist)
        {
            InitializeComponent();
            cn = new MySqlConnection(dbcon.MyConnection());
            frmblist = flist;
            btnUpdate.Enabled = false;
        }

        //Helper methods
        private void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtBrand.Clear();
            txtBrand.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to SAVE this brand?", "Save Record", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new MySqlCommand("INSERT INTO tblBrand(brand) VALUES(@brand)", cn);
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Successfully Added!");
                    Clear();
                    frmblist.LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                cn.Close();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to Update this Record?", "Update Record", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new MySqlCommand("UPDATE tblBrand SET brand = @brand WHERE brand = @b", cn);
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cm.Parameters.AddWithValue("@b", lblBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Car brand successfully Updated!");
                    Clear();
                    frmblist.LoadData();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ", ex.Message);
                cn.Close();
            }
        }


        //Clear button
        private void Button3_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
