using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataAccess
    {
        private string connectionString;
        private SqlConnection con;
        private SqlCommand command;
        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public DataAccess()
        {
            connectionString = @"Server=CV-PC-S-02\SQLEXPRESS;Database=SimpleClientServerDB;Trusted_Connection=True;";
        }
        protected void SetCon(string strSqlCon)
        {
            connectionString = strSqlCon;
            con = new SqlConnection(this.connectionString);
        }
        private void CloseDB()
        {
            try
            {
                if (this.con != null)
                {
                    this.con.Close();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                this.con = null;
            }
        }
        private void OpenDB()
        {
            try
            {
                if (con != null && con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                else
                {
                    CloseDB();
                    OpenDB();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

            }
        }
        protected int ExecuteNonQuery(string sql)
        {
            int result = 0;
            this.con = new SqlConnection(this.connectionString);
            this.command = new SqlCommand(sql, this.con);
            try
            {

            }
            catch (Exception)
            {

            }
            finally
            {
                this.CloseDB();
            }
            return result;
        }
        protected SqlDataReader ExecuteReader(string sql)
        {
            SqlDataReader reader = null;
            this.con = new SqlConnection(this.connectionString);
            this.command = new SqlCommand(sql, this.con);
            try
            {
                OpenDB();
                reader = this.command.ExecuteReader();
            }
            catch (Exception)
            {

            }
            return reader;
        }
        protected DataTable DbReturnDataTable(string strSql)
        {
            DataTable dtRes = new DataTable();
            try
            {
                OpenDB();
                using (var command = new SqlCommand(strSql, this.con))
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dtRes);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CloseDB();
            }
            return dtRes;
        }
        protected List<string> DbReturnListString(string strSql)
        {
            List<string> strList = new List<string>();
            try
            {
                using (var cmd = con.CreateCommand())
                {
                    OpenDB();
                    cmd.CommandText = strSql;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                strList.Add(reader.GetValue(i).ToString());
                            }
                        }
                    }

                    CloseDB();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return strList;
        }
    }
}
