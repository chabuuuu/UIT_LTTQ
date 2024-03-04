using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetDataProvider_Connection
{
    public partial class Form1 : Form
    {
        private DataAccess dataAccess;
        public Form1()
        {
            InitializeComponent();
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            this.dataAccess = new DataAccess(connectionString);
            LoadData();
        }
        private void LoadData()
        {
            string query = "USE QLBH; SELECT * FROM KHACHHANG";
            DataTable dataTable = this.dataAccess.GetDataFromDatabase(query);
            dataGridView1.DataSource = dataTable;
        }
    }
}
