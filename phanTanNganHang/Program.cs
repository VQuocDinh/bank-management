using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace phanTanNganHang
{
    internal static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static SqlDataReader myReader;
        public static String connstr;
        public static String connstr_publibsher = "Data Source=VOQUOCDINH;Initial Catalog=NganHang;Integrated Security=True";
        public static BindingSource bds_dspm = new BindingSource(); //giữ bdsPM khi đăng nhập
        public static String servername = "";
        public static String mlogin = "";
        public static String password = "";
        public static String username = "";
        public static String database = "NganHang";
        public static String remotelogin = "htkn";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mHoTen = "";
        public static String mGroup = "";
        public static int mChiNhanh = 0;
        public static frmMain frmChinh;
        public static int KetNoi()
        {
            if(Program.conn != null && Program.conn.State == ConnectionState.Open) //State: trạng thái hiện tại của kết nối
            { Program.conn.Close(); }
            try
            {
                Program.connstr = "Data Source =" + Program.servername + ";Initial Catalog=" +
                    Program.database + ";User ID=" + Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL. \nBạn hãy kiểm tra lại username và passwork.\n" + ex.Message,"",MessageBoxButtons.OK);
                return 0;

            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if(Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader(); return myReader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if(Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int ExecSqlNoneQuery(String strLenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strLenh,conn);
            Sqlcmd.CommandType=CommandType.Text;
            Sqlcmd.CommandTimeout = 600; //10phut
            if(conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Program.myReader.Close();

                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;   
            }
            catch(SqlException ex)
            {
                conn.Close();
                return ex.State; // trạng thái lỗi gởi từ RAISERROR trong sql server
            }

        }
        internal static object frmMain;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
