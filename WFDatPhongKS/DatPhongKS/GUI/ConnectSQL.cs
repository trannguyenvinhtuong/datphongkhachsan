using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class ConnectSQL
    {
        #region Availible
        private SqlConnection Conn;
        private SqlCommand cmd = new SqlCommand();
        private string StrCon = null;

        public SqlConnection Conn1 { get => Conn; set => Conn = value; }
        public SqlCommand Cmd { get => cmd; set => cmd = value; }
        #endregion
        #region Contrustor
        public ConnectSQL()
        {
<<<<<<< HEAD
            StrCon = @"Data Source = DOUBLESHIT; Initial Catalog = QLDPKS; Integrated Security = True";
            //StrCon = @"Data Source=B902702E395D455\WIN2K; ;Initial Catalog = QLDPKS; User = sa; Password=sa2012";
=======
            StrCon = @"Data Source=B902702E395D455\WIN2K; ;Initial Catalog = QLDPKS; User = sa; Password=sa2012";
>>>>>>> 471b3102bc25857bb13ca30876b7ba2f7bcb9fcf
            Conn1 = new SqlConnection(StrCon);
        }
        #endregion



        #region Methods
        public bool OpenConn()
        {
            try
            {
                if (Conn1.State == ConnectionState.Closed)
                    Conn1.Open();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool CloseConn()
        {
            try
            {
                if (Conn1.State == ConnectionState.Open)
                    Conn1.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            Cmd.CommandText = sql;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn1;
            try
            {
                this.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(Cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                Cmd.Dispose();
                this.CloseConn();
            }
            return dt;
        }

        public bool SetData(string sql)
        {
            Cmd.CommandText = sql;
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Conn1;
            try
            {
                this.OpenConn();
                Cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                Cmd.Dispose();
                this.CloseConn();
            }
            return false;
        }
        #endregion
    }
}
