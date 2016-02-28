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
    public partial class fmUserRoleCard : Form
    {




        private int curUserRoleId = -1;

        // PostgeSQL-style connection string
        static string connstring = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4};",
            "localhost",
            "5432",
            "postgres",
            "enterprisedb",
            "postgres");
        // Making connection with Npgsql provider
        NpgsqlConnection conn = new NpgsqlConnection(connstring);

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        // private DataTable dt = new DataTable();

        public DataTable Fill(string sql)
        {

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            // string genres = "SELECT * FROM dic_genres";


            NpgsqlDataAdapter genreAdapter = new NpgsqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            genreAdapter.Fill(dt);
            return dt;

        }

        public fmUserRoleCard()
        {
            InitializeComponent();

            cxOrderView.Checked = true;
            cxOrderCreate.Checked = true;
            cxOrderEdit.Checked = true;
            cxOrderDelete.Checked = true;


            cxBookView.Checked = true;
            cxBookCreate.Checked = true;
            cxBookEdit.Checked = true;
            cxBookDelete.Checked = true;

            cxClientView.Checked = true;
            cxClientCreate.Checked = true;
            cxClientEdit.Checked = true;
            cxClientDelete.Checked = true;




        }



        public fmUserRoleCard(int userRoleId)
        {
            InitializeComponent();
            // string sql = String.Format("SELECT * FROM users WHERE id = {0}",userId);

            //DataTable dt = new DataTable();
            //  NpgsqlDataAdapter da = new NpgsqlDataAdapter();

            //   da.Fill(dt);


            curUserRoleId = userRoleId;

            string sql = "SELECT * FROM user_roles ur WHERE ur.id = " + curUserRoleId;
            DataTable dt = Fill(sql);


            edUserRoleName.Text = dt.Rows[0]["name"].ToString();

            cxOrderView.Checked = Convert.ToBoolean(dt.Rows[0]["order_view"]);
            cxOrderCreate.Checked = Convert.ToBoolean(dt.Rows[0]["order_create"]);
            cxOrderEdit.Checked = Convert.ToBoolean(dt.Rows[0]["order_edit"]);
            cxOrderDelete.Checked = Convert.ToBoolean(dt.Rows[0]["order_delete"]);


            cxBookView.Checked = Convert.ToBoolean(dt.Rows[0]["book_view"]);
            cxBookCreate.Checked = Convert.ToBoolean(dt.Rows[0]["book_create"]);
            cxBookEdit.Checked = Convert.ToBoolean(dt.Rows[0]["book_edit"]);
            cxBookDelete.Checked = Convert.ToBoolean(dt.Rows[0]["book_delete"]);

            cxClientView.Checked = Convert.ToBoolean(dt.Rows[0]["client_view"]);
            cxClientCreate.Checked = Convert.ToBoolean(dt.Rows[0]["client_create"]);
            cxClientEdit.Checked = Convert.ToBoolean(dt.Rows[0]["client_edit"]);
            cxClientDelete.Checked = Convert.ToBoolean(dt.Rows[0]["client_delete"]);


            /*
                        if ((dt.Rows[0]["is_blocked"]) != DBNull.Value)
                        {
                            cxBlocked.Checked = Convert.ToBoolean(dt.Rows[0]["is_blocked"]);
                        }
                        else
                        {
                            cxBlocked.Checked = false;
                        };




                        if ((dt.Rows[0]["salt"] != DBNull.Value) && (dt.Rows[0]["password"] != DBNull.Value))
                        {
                            lblPasswordStatus.Text = "(пароль установелен)";
                            lblPasswordStatus.ForeColor = SystemColors.WindowText;
                        }
                        else
                        {
                            lblPasswordStatus.Text = "(пароль отсутствует)";
                            lblPasswordStatus.ForeColor = Color.Red;
                        }


                        string roles = "SELECT * FROM user_roles";
                        DataTable dtRole = Fill(roles);
                        cbUserRole.DisplayMember = "name";
                        cbUserRole.ValueMember = "id";
                        cbUserRole.DataSource = dtRole;
                        cbUserRole.SelectedValue = dt.Rows[0]["r_user_roles_id"];

                */
            // conn.Close();

        }

        private void buOK_Click(object sender, EventArgs e)
        {
            string sql;
            // MessageBox.Show(curBookId.ToString());
            if (curUserRoleId == -1)
            {
                sql = "INSERT INTO user_roles (id, name, order_view, order_create, order_edit, order_delete, book_view, book_create, book_edit, book_delete, client_view, client_create, client_edit, client_delete) VALUES (nextval('books_seq'), @name, @order_view, @order_create, @order_edit, @order_delete, @book_view, @book_create, @book_edit, @book_delete, @client_view, @client_create, @client_edit, @client_delete);";

            }
            else
            {
                sql = "UPDATE user_roles SET name = @name, order_view = @order_view, order_create = @order_create, order_edit = @order_edit, order_delete = @order_delete, book_view = @book_view, book_create = @book_create, book_edit = @book_edit, book_delete = @book_delete, client_view = @client_view, client_create = @client_create, client_edit = @client_edit, client_delete = @client_delete WHERE id = @id;";

            }


            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();


            using (NpgsqlCommand command = new NpgsqlCommand(sql, conn))
            {


                if (curUserRoleId != -1) { command.Parameters.AddWithValue("id", curUserRoleId); };

                command.Parameters.AddWithValue("name", edUserRoleName.Text);

                command.Parameters.AddWithValue("order_view", cxOrderView.Checked);
                command.Parameters.AddWithValue("order_create", cxOrderCreate.Checked);
                command.Parameters.AddWithValue("order_edit", cxClientEdit.Checked);
                command.Parameters.AddWithValue("order_delete", cxClientDelete.Checked);

                command.Parameters.AddWithValue("book_view", cxBookView.Checked);
                command.Parameters.AddWithValue("book_create", cxBookCreate.Checked);
                command.Parameters.AddWithValue("book_edit", cxBookEdit.Checked);
                command.Parameters.AddWithValue("book_delete", cxBookDelete.Checked);

                command.Parameters.AddWithValue("client_view", cxClientView.Checked);
                command.Parameters.AddWithValue("client_create", cxClientCreate.Checked);
                command.Parameters.AddWithValue("client_edit", cxClientEdit.Checked);
                command.Parameters.AddWithValue("client_delete", cxClientDelete.Checked);

                command.ExecuteNonQuery();

            }
        }
    }
}
