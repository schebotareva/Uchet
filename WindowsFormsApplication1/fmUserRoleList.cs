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
    public partial class fmUserRoleList : Form
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

        public fmUserRoleList()
        {
            InitializeComponent();
        }

        private void buAdd_Click(object sender, EventArgs e)
        {
            fmUserRoleCard urc = new fmUserRoleCard();
            urc.ShowDialog();


            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            string sql = "SELECT *  FROM user_roles";
            // data adapter making request from our connection
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            // i always reset DataSet before i do
            // something with it.... i don't know why :-)
            ds.Reset();
            // filling DataSet with result from NpgsqlDataAdapter
            da.Fill(ds);
            // since it C# DataSet can handle multiple tables, we will select first
            dt = ds.Tables[0];

            //dt.Columns["id"].;

            dt.Columns["name"].ColumnName = "Название роли";

            dt.Columns["order_view"].ColumnName = "Просмотр реестра заказов";
            dt.Columns["order_create"].ColumnName = "Создание новых заказов";
            dt.Columns["order_edit"].ColumnName = "Редактирование заказов";
            dt.Columns["order_delete"].ColumnName = "Удаление заказов";

            dt.Columns["book_view"].ColumnName = "Просмотр реестра книг";
            dt.Columns["book_create"].ColumnName = "Добавление новых книг";
            dt.Columns["book_edit"].ColumnName = "Редактирование книг";
            dt.Columns["book_delete"].ColumnName = "Удаление книг";

            dt.Columns["client_view"].ColumnName = "Просмотр реестра клиентов";
            dt.Columns["client_create"].ColumnName = "Добавление новых клиентов";
            dt.Columns["client_edit"].ColumnName = "Редактирование клиентов";
            dt.Columns["client_delete"].ColumnName = "Удаление клиентов";



            // connect grid to DataTable
            dataGridView1.DataSource = dt;
            // since we only showing the result we don't need connection anymore

            conn.Close();

        }

        private void buEdit_Click(object sender, EventArgs e)
        {
            int roleId = Convert.ToInt32( dataGridView1.CurrentRow.Cells["id"].Value );
            fmUserRoleCard urc = new fmUserRoleCard(roleId);
            urc.ShowDialog();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            string sql = "SELECT *  FROM user_roles";
            // data adapter making request from our connection
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            // i always reset DataSet before i do
            // something with it.... i don't know why :-)
            ds.Reset();
            // filling DataSet with result from NpgsqlDataAdapter
            da.Fill(ds);
            // since it C# DataSet can handle multiple tables, we will select first
            dt = ds.Tables[0];

            //dt.Columns["id"].;

            dt.Columns["name"].ColumnName = "Название роли";

            dt.Columns["order_view"].ColumnName = "Просмотр реестра заказов";
            dt.Columns["order_create"].ColumnName = "Создание новых заказов";
            dt.Columns["order_edit"].ColumnName = "Редактирование заказов";
            dt.Columns["order_delete"].ColumnName = "Удаление заказов";

            dt.Columns["book_view"].ColumnName = "Просмотр реестра книг";
            dt.Columns["book_create"].ColumnName = "Добавление новых книг";
            dt.Columns["book_edit"].ColumnName = "Редактирование книг";
            dt.Columns["book_delete"].ColumnName = "Удаление книг";

            dt.Columns["client_view"].ColumnName = "Просмотр реестра клиентов";
            dt.Columns["client_create"].ColumnName = "Добавление новых клиентов";
            dt.Columns["client_edit"].ColumnName = "Редактирование клиентов";
            dt.Columns["client_delete"].ColumnName = "Удаление клиентов";



            // connect grid to DataTable
            dataGridView1.DataSource = dt;
            // since we only showing the result we don't need connection anymore

            conn.Close();

        }

        private void fmUserRoleList_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                string sql = "SELECT *  FROM user_roles";
             // data adapter making request from our connection
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                // i always reset DataSet before i do
                // something with it.... i don't know why :-)
                ds.Reset();
                // filling DataSet with result from NpgsqlDataAdapter
                da.Fill(ds);
                // since it C# DataSet can handle multiple tables, we will select first
                dt = ds.Tables[0];

                //dt.Columns["id"].;

                dt.Columns["name"].ColumnName = "Название роли";

                dt.Columns["order_view"].ColumnName = "Просмотр реестра заказов";
                dt.Columns["order_create"].ColumnName = "Создание новых заказов";
                dt.Columns["order_edit"].ColumnName = "Редактирование заказов";
                dt.Columns["order_delete"].ColumnName = "Удаление заказов";

                dt.Columns["book_view"].ColumnName = "Просмотр реестра книг";
                dt.Columns["book_create"].ColumnName = "Добавление новых книг";
                dt.Columns["book_edit"].ColumnName = "Редактирование книг";
                dt.Columns["book_delete"].ColumnName = "Удаление книг";

                dt.Columns["client_view"].ColumnName = "Просмотр реестра клиентов";
                dt.Columns["client_create"].ColumnName = "Добавление новых клиентов";
                dt.Columns["client_edit"].ColumnName = "Редактирование клиентов";
                dt.Columns["client_delete"].ColumnName = "Удаление клиентов";



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

            int userRoleId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            // quite complex sql statement
            string sqlremove = String.Format("DELETE FROM user_roles ur WHERE ur.id = {0}", userRoleId);


            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sqlremove;
            cmd.ExecuteNonQuery();


            DataTable dt = new DataTable();
            //  NpgsqlDataAdapter da = new NpgsqlDataAdapter();

            //   da.Fill(dt);



            string sqlselect = "SELECT *  FROM user_roles";
            // data adapter making request from our connection
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sqlselect, conn);
            // i always reset DataSet before i do
            // something with it.... i don't know why :-)
            ds.Reset();
            // filling DataSet with result from NpgsqlDataAdapter
            da.Fill(ds);
            // since it C# DataSet can handle multiple tables, we will select first
            dt = ds.Tables[0];

            //dt.Columns["id"].;

            dt.Columns["name"].ColumnName = "Название роли";

            dt.Columns["order_view"].ColumnName = "Просмотр реестра заказов";
            dt.Columns["order_create"].ColumnName = "Создание новых заказов";
            dt.Columns["order_edit"].ColumnName = "Редактирование заказов";
            dt.Columns["order_delete"].ColumnName = "Удаление заказов";

            dt.Columns["book_view"].ColumnName = "Просмотр реестра книг";
            dt.Columns["book_create"].ColumnName = "Добавление новых книг";
            dt.Columns["book_edit"].ColumnName = "Редактирование книг";
            dt.Columns["book_delete"].ColumnName = "Удаление книг";

            dt.Columns["client_view"].ColumnName = "Просмотр реестра клиентов";
            dt.Columns["client_create"].ColumnName = "Добавление новых клиентов";
            dt.Columns["client_edit"].ColumnName = "Редактирование клиентов";
            dt.Columns["client_delete"].ColumnName = "Удаление клиентов";



            // connect grid to DataTable
            dataGridView1.DataSource = dt;
            // since we only showing the result we don't need connection anymore

            conn.Close();
        }
    }
}
