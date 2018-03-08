using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vendors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void getData_Click(object sender, EventArgs e)
        {
            const string connString = @"Server=PL09\MTCDB;Database=AdventureWorks2012;Trusted_Connection=True;";

            SqlConnection sqlConn = new SqlConnection(connString);
            SqlDataAdapter sqlDA = new SqlDataAdapter("spVendorAddresses", sqlConn);
            DataTable dtVendors = new DataTable();
            sqlDA.Fill(dtVendors);
            dgVendors.DataSource = dtVendors;
            
        }

        private void dgVendors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
