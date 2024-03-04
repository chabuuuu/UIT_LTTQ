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

namespace NetDataProvider_DataReader
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        public void ReadData()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("USE QLBH; Select * From KHACHHANG", conn);
            SqlDataReader reader;
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
                listBox1.Items.Add(reader["HOTEN"]);
            reader.Close();
            conn.Close();
        }
    }
}
