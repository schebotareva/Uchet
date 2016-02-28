using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Npgsql;

namespace WindowsFormsApplication1
{
    public partial class fmUserList : Form
    {


        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        // PostgeSQL-style connection string
        static string connstring = String.Format("Server={0};Port={1};" +
              "User Id={2};Password={3};Database={4};"
              , "localhost"
              , "5432"
              , "postgres"
              , "enterprisedb"
              , "postgres");

        // Making connection with Npgsql provider
        NpgsqlConnection conn = new NpgsqlConnection(connstring);


        public fmUserList()
        {
            InitializeComponent();
        }

        private void buAdd_Click(object sender, EventArgs e)
        {
            fmUser user = new fmUser();
            user.ShowDialog();

            // quite complex sql statement
            string sqlnew = "SELECT id, f as Фамилия, i as Имя, o as Отчество  FROM users";
            // data adapter making request from our connection
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sqlnew, conn);
            // i always reset DataSet before i do
            // something with it.... i don't know why :-)
            ds.Reset();
            // filling DataSet with result from NpgsqlDataAdapter
            da.Fill(ds);
            // since it C# DataSet can handle multiple tables, we will select first
            dt = ds.Tables[0];
            // connect grid to DataTable
            dataGridView1.DataSource = dt;
            // since we only showing the result we don't need connection anymore
            conn.Close();

        }

        private void buEdit_Click(object sender, EventArgs e)
        {


            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

 
            int userId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());


            fmUser user = new fmUser(userId);
            user.ShowDialog();

            // quite complex sql statement
            string sqlnew = "SELECT id, f as Фамилия, i as Имя, o as Отчество  FROM users";
            // data adapter making request from our connection
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sqlnew, conn);
            // i always reset DataSet before i do
            // something with it.... i don't know why :-)
            ds.Reset();
            // filling DataSet with result from NpgsqlDataAdapter
            da.Fill(ds);
            // since it C# DataSet can handle multiple tables, we will select first
            dt = ds.Tables[0];
            // connect grid to DataTable
            dataGridView1.DataSource = dt;
            // since we only showing the result we don't need connection anymore
            conn.Close();
        }

        private void buRemove_Click(object sender, EventArgs e)
        {
            
             
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

            // data adapter making request from our connection
            /*NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            // i always reset DataSet before i do
            // something with it.... i don't know why :-)
            ds.Reset();
            // filling DataSet with result from NpgsqlDataAdapter
            da.Fill(ds);
            // since it C# DataSet can handle multiple tables, we will select first
            dt = ds.Tables[0];
            // connect grid to DataTable
            dataGridView1.DataSource = dt;
            // since we only showing the result we don't need connection anymore
            conn.Close();
            */

          //  dataGridView1.CurrentRow.Cells["id"].Value;

            int userId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            // quite complex sql statement
            string sql = String.Format("DELETE FROM users u WHERE u.id = {0}", userId);


            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();


            DataTable dt = new DataTable();
          //  NpgsqlDataAdapter da = new NpgsqlDataAdapter();

         //   da.Fill(dt);


            // quite complex sql statement
            string sqlnew = "SELECT id, f as Фамилия, i as Имя, o as Отчество  FROM users";
            // data adapter making request from our connection
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sqlnew, conn);
            // i always reset DataSet before i do
            // something with it.... i don't know why :-)
            ds.Reset();
            // filling DataSet with result from NpgsqlDataAdapter
            da.Fill(ds);
            // since it C# DataSet can handle multiple tables, we will select first
            dt = ds.Tables[0];
            // connect grid to DataTable
            dataGridView1.DataSource = dt;
            // since we only showing the result we don't need connection anymore
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void fmUserList_Load(object sender, EventArgs e)
        {
                    

         try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                string sql;
                // quite complex sql statement
                if (cxShowBlocked.Checked)
                {
                    sql = "SELECT id, f as Фамилия, i as Имя, o as Отчество  FROM users";
                }
                else
                {
                    
                    sql = "SELECT id, f as Фамилия, i as Имя, o as Отчество  FROM users WHERE is_blocked = false OR is_blocked = null";
                }
        // data adapter making request from our connection
        NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
        // i always reset DataSet before i do
        // something with it.... i don't know why :-)
        ds.Reset();
                // filling DataSet with result from NpgsqlDataAdapter
                da.Fill(ds);
                // since it C# DataSet can handle multiple tables, we will select first
                dt = ds.Tables[0];
                // connect grid to DataTable
                dataGridView1.DataSource = dt;
                // since we only showing the result we don't need connection anymore
                conn.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }


    }

        private void cxShowBlocked_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                string sql;
                // quite complex sql statement
                if (cxShowBlocked.Checked)
                {
                    sql = "SELECT id, f as Фамилия, i as Имя, o as Отчество  FROM users";
                }
                else
                {

                    sql = "SELECT id, f as Фамилия, i as Имя, o as Отчество  FROM users WHERE is_blocked = false OR is_blocked = null";
                }
                // data adapter making request from our connection
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                // i always reset DataSet before i do
                // something with it.... i don't know why :-)
                ds.Reset();
                // filling DataSet with result from NpgsqlDataAdapter
                da.Fill(ds);
                // since it C# DataSet can handle multiple tables, we will select first
                dt = ds.Tables[0];
                // connect grid to DataTable
                dataGridView1.DataSource = dt;
                // since we only showing the result we don't need connection anymore
                conn.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }
    }
}
