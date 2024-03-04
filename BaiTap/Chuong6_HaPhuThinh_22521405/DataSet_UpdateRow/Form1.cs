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

namespace DataSet_UpdateRow
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;\r\n";

        public Form1()
        {
            InitializeComponent();
            loadDataAdapter();
        }
        public void UpdateRow()
        {
            string strConn = connectionString;
            string strCmd = "USE QLBH; Select * From KHACHHANG";
            SqlDataAdapter da = new SqlDataAdapter(strCmd, strConn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                //MessageBox.Show(dr["NGSINH"].ToString());
                dr["NGDK"] = DateTime.Now;
                loadDataAdapter();
            }

            da.Update(ds);
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

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateRow();
        }
    }
}
