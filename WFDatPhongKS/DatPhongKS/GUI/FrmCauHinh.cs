using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmCauHinh : DevExpress.XtraEditors.XtraForm
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        public FrmCauHinh()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CauHinh.ChangeConnectionString(cmbSever.Text, cmbDatabase.Text, txtUser.Text, txtPass.Text);
            String conn = @"Data Source=" + cmbSever.Text + ";Initial Catalog=" + cmbDatabase.Text + ";Integrated Security=True";
            XtraMessageBox.Show("Cấu hình thành công ?", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FrmCauHinh_Load(object sender, EventArgs e)
        {
            cmbAuth.SelectedText = "Windows Authantication";
            labelControl3.Enabled = false;
            labelControl4.Enabled = false;
            txtUser.Enabled = false;
            txtPass.Enabled = false;
        }

        private void cmbSever_DropDown(object sender, EventArgs e)
        {
            DataTable dt = CauHinh.GetServerName();
            cmbSever.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                foreach (System.Data.DataColumn col in dt.Columns)
                {
                    cmbSever.Items.Add(row[col]);
                }
            }
        }

        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance =
            SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;
        }

        public bool CheckedBeforSearchNameDB()
        {
            DataTable dt = CauHinh.GetServerName();
            if (dt != null)
                return true;
            return false;

        }

        private void cmbDatabase_DropDown(object sender, EventArgs e)
        {
            if (CheckedBeforSearchNameDB())
            {
                cmbDatabase.Items.Clear();
                List<string> _list = new List<string>();
                if (cmbAuth.Text == "Windows Authentication")
                {
                    _list = CauHinh.GetDatabaseNameWindows(cmbSever.Text);
                }
                else
                {
                    _list = CauHinh.GetDatabaseName(cmbSever.Text, txtUser.Text, txtPass.Text);
                }
                if (_list == null)
                {
                    MessageBox.Show("Thông tin cấu hình chưa chính xác");
                    return;
                }
                foreach (string item in _list)
                {
                    cmbDatabase.Items.Add(item);
                }
            }
        }

        private void cmbAuth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuth.Text == "Windows Authentication")
            {
                labelControl3.Enabled = false;
                labelControl4.Enabled = false;
                txtUser.Enabled = false;
                txtPass.Enabled = false;

            }
            else
            {
                labelControl3.Enabled = true;
                labelControl4.Enabled = true;
                txtUser.Enabled = true;
                txtPass.Enabled = true;
            }
        }

        public List<string> GetDatabaseName(string pServerName, string pUser, string pPass)
        {
            List<string> _list = new List<string>();
            DataTable dt = new DataTable();
            if (cmbAuth.Text == "Windows Authentication")
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM sys.databases", "Data Source=" + pServerName + ";Initial Catalog=" + "master" + ";Integrated Security=True");
                    da.Fill(dt);
                    foreach (System.Data.DataRow row in dt.Rows)
                    {
                        foreach (System.Data.DataColumn col in dt.Columns)
                        {
                            _list.Add(row[col].ToString());
                        }
                    }
                }
                catch
                {
                    return null;
                }
                return _list;
            }
            else
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM sys.databases", "Data Source=" + pServerName + ";Initial Catalog=" + "master" + ";User ID=" + pUser + ";Password = " + pPass + "");
                    da.Fill(dt);
                    foreach (System.Data.DataRow row in dt.Rows)
                    {
                        foreach (System.Data.DataColumn col in dt.Columns)
                        {
                            _list.Add(row[col].ToString());
                        }
                    }
                }
                catch
                {
                    return null;
                }
                return _list;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCauHinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dia = XtraMessageBox.Show("Bạn có muốn thoát không ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
                e.Cancel = true;
        }
    }
}