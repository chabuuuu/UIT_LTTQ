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

namespace NetDataAdapter
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
            loadDataAdapter();
        }
        public void loadDataAdapter()
        {
            string strConn = connectionString; 
            SqlDataAdapter adapter = new SqlDataAdapter("USE QLBH; Select * From KHACHHANG", strConn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            adapter.Update(ds);
        }
    }
}
