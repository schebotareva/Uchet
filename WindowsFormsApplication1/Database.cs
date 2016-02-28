using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;





namespace WindowsFormsApplication1
{
    class Database
    {

        NpgsqlConnection conn = new NpgsqlConnection();
    
        public void OpenConn()
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                //сообщение
            }
        }

        public void CloseConn()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                // сообщение
            }
        }


        public List<Object> QueryAllOnTable(string table)
        {
            try
            {
                this.OpenConn();

                List<Object> lstSelect = new List<Object>();
                string SQL = "SELECT * FROM " + table + ";";

                NpgsqlCommand command = new NpgsqlCommand(SQL, conn);
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        lstSelect.Add(dr[i]);
                    }
                }

                this.CloseConn();

                return lstSelect;
            }
            catch (Exception)
            {
                //MessageBox.Show("Errr on query!");
                return null;
            }
        }


        public List<Object> QueryOnTableWithParams(string table, string[] paramName, string[] paramValue)
        {
            try
            {
                if (paramName.Count() != paramValue.Count())
                {
                    //MessageBox.Show("Wrong number of params");
                    return null;
                }

                this.OpenConn();

                List<Object> lstSelect = new List<Object>();
                string SQL = "SELECT * FROM " + table + " WHERE ";

                // get params
                for (int i = 0; i < paramName.Count() - 1; i++)
                {
                    SQL += paramName[i] + " = " + paramValue[i] + " AND ";
                }

                // get last param
                SQL += paramName[paramName.Count() - 1] + " = " + paramValue[paramValue.Count() - 1] + ";";

                NpgsqlCommand command = new NpgsqlCommand(SQL, conn);
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        lstSelect.Add(dr[i]);
                    }
                }

                this.CloseConn();

                return lstSelect;
            }
            catch (Exception)
            {
                //MessageBox.Show("Errr on query!");
                return null;
            }
        }




    }
}
