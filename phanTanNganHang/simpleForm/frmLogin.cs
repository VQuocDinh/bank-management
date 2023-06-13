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

namespace phanTanNganHang
{
    public partial class frmLogin : Form
    {
        private SqlConnection conn_publisher = new SqlConnection(); // khi đóng form login biến này sẽ biến mất

        public frmLogin()
        {
            InitializeComponent();
        }
        private int KetNoi_CSDLGOC() {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open) {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publibsher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e) {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu gốc. \nBạn hãy xem lại tên Server của publisher và tên CSDL trong chuỗi kết nối" + e.Message);
                return 0;
            }
        }
        private void LayDSPM(String cmd) {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd,conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN"; cmbChiNhanh.ValueMember = "TENSERVER";
        }
        private void DNThanhCong()
        {
            lblDNThanhCong.Visible = true;
            Timer timer = new Timer();
            timer.Interval = 3000; // 3 giây
            timer.Tick += (s, es) =>
            {
                lblDNThanhCong.Visible = false;
                timer.Stop();
            };
            timer.Start();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return; {
                LayDSPM("SELECT * FROM Get_Subscribes");
                cmbChiNhanh.SelectedIndex = 1; cmbChiNhanh.SelectedIndex = 0;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "") {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống","", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin=txtLogin.Text; Program.password =txtPass.Text;
            if (Program.KetNoi() == 0) return;

            //lưu lại thông tin đăng nhập
            Program.mChiNhanh = cmbChiNhanh.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "sp_Lay_Thong_Tin_NV_Tu_Login '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read(); // nếu trả về nhiều dòng phải dùng vòng lập

            Program.username = Program.myReader.GetString(0); //lấy username
            if(Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu.\nVui lòng kiểm tra lại username và passwork", "", MessageBoxButtons.OK);
                return;

            }
            Program.mHoTen=Program.myReader.GetString(1);
            Program.mGroup=Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh.HienThiMenu();
            DNThanhCong();
            Close();

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
