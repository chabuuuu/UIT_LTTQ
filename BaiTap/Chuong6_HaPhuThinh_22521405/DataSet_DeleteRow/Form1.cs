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

namespace DataSet_DeleteRow
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;\r\n";

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

        public void DeleteRow()
        {
            string strConn = connectionString;
            string strCmd = "USE QLBH; Select * From KHACHHANG";
            SqlDataAdapter da = new SqlDataAdapter(strCmd, strConn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable table = ds.Tables[0];
            DataRow[] rows = table.Select("NGSINH<'1/1/1980'");
            foreach (DataRow r in rows)
                r.Delete();
            da.Update(ds);
            loadDataAdapter();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DeleteRow();
        }
    }
}
