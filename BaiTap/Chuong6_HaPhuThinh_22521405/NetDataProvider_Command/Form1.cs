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

namespace NetDataProvider_Command
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

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "USE QLBH; SELECT COUNT(*) FROM KHACHHANG";
            DataTable dataTable = this.dataAccess.GetDataFromDatabase(query);
            dataGridView1.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            // Tạo một số ngẫu nhiên từ 0 đến 99
            int randomNumber = random.Next(0, 100);

            // Chuyển số ngẫu nhiên thành chuỗi có định dạng 'KHxx'
            string formattedString = $"KH{randomNumber:D2}";

            string query = "USE QLBH;SET DATEFORMAT DMY;INSERT INTO KHACHHANG VALUES ('"+formattedString+"', 'Nguyen Van Teo', '731 Tran Hung Dao, Q5, TpHCM', '8823451', '22/10/1960', 13060000, '22/07/2006')";
            this.dataAccess.InsertDataToDatabase(query);
            this.LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Random random = new Random();

            // Tạo một số ngẫu nhiên từ 0 đến 99
            int randomNumber = random.Next(0, 100);

            // Chuyển số ngẫu nhiên thành chuỗi có định dạng 'KHxx'
            string formattedString = $"KH{randomNumber:D2}";

            string query = "USE QLBH;SET DATEFORMAT DMY;INSERT INTO KHACHHANG VALUES (@MAKH, @TEN, @DIACHI, @SDT, @NGSINH, @TIEN, @NGMUA)";
            SqlParameter[] parameters = {
                new SqlParameter("@MAKH", "KH33"),
                new SqlParameter("@TEN", "Ha Thinh"),
                new SqlParameter("@DIACHI", "123/16"),
                new SqlParameter("@SDT", "09012312"),
                new SqlParameter("@NGSINH", "12/03/2001"),
                new SqlParameter("@TIEN", 123000),
                new SqlParameter("@NGMUA", "12/09/2021")
            };
            this.dataAccess.InsertDataToDatabaseWithParamenters(query, parameters);
            this.LoadData();
        }
    }
}
