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
    public partial class fmUser : Form
    {

        private int curUserId = -1;
        public string usalt = "";
        public string uhash = "";

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

        public fmUser()
        {
            InitializeComponent();

            
            
            lblPasswordStatus.Text = "(пароль отсутствует)";
            lblPasswordStatus.ForeColor = Color.Red;



            string roles = "SELECT * FROM user_roles";
            DataTable dtRole = Fill(roles);
            cbUserRole.DisplayMember = "name";
            cbUserRole.ValueMember = "id";
            cbUserRole.DataSource = dtRole;


        }

        public fmUser(int userId)
        {
            InitializeComponent();
            // string sql = String.Format("SELECT * FROM users WHERE id = {0}",userId);

            //DataTable dt = new DataTable();
            //  NpgsqlDataAdapter da = new NpgsqlDataAdapter();

            //   da.Fill(dt);


            curUserId = userId;

            string sql = "SELECT * FROM users u WHERE u.id = " + curUserId;
            DataTable dt = Fill(sql);

            edFirstName.Text = dt.Rows[0]["i"].ToString();
            edLastName.Text = dt.Rows[0]["f"].ToString();
            edMiddleName.Text = dt.Rows[0]["o"].ToString();
            edPosition.Text = dt.Rows[0]["position"].ToString();
            edPhone.Text = dt.Rows[0]["phone"].ToString();
            edUserName.Text = dt.Rows[0]["username"].ToString();

            if ((dt.Rows[0]["is_blocked"]) != DBNull.Value)
            {
                cxBlocked.Checked = Convert.ToBoolean(dt.Rows[0]["is_blocked"]);
            } else
            {
                cxBlocked.Checked = false;
            } ;

         
      

            if ((dt.Rows[0]["salt"] != DBNull.Value) && (dt.Rows[0]["password"] != DBNull.Value)) 
            {
                lblPasswordStatus.Text = "(пароль установелен)";
                lblPasswordStatus.ForeColor = SystemColors.WindowText;

                usalt = dt.Rows[0]["salt"].ToString();
                uhash = dt.Rows[0]["password"].ToString();

            } else
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


           // conn.Close();

        }


        private void buOK_Click(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            string sql;
            if (curUserId == -1)
            {
                sql = "INSERT INTO users (id, f, i, o, username, phone, is_blocked, position, r_user_roles_id, salt, password) VALUES (nextval('users_seq'), @f, @i, @o, @username, @phone, @is_blocked, @position, @user_role_id, @salt, @password)";

            }
            else
            {
                sql = "UPDATE users SET f = @f, i = @i, o = @o, username = @username, phone = @phone, is_blocked = @is_blocked, position = @position, r_user_roles_id = @user_role_id, salt = @salt, password = @password WHERE id = @id";

            }


            using (NpgsqlCommand command = new NpgsqlCommand(sql, conn))
            {
                if (curUserId != -1) { command.Parameters.AddWithValue("id", curUserId); };
                command.Parameters.AddWithValue("f", edLastName.Text);
                command.Parameters.AddWithValue("i", edFirstName.Text);
                command.Parameters.AddWithValue("o", edMiddleName.Text);
                command.Parameters.AddWithValue("username", edUserName.Text);
                command.Parameters.AddWithValue("phone", edPhone.Text);
                command.Parameters.AddWithValue("is_blocked", cxBlocked.Checked);
                command.Parameters.AddWithValue("position", edPosition.Text);
                command.Parameters.AddWithValue("user_role_id", cbUserRole.SelectedValue);


                command.Parameters.AddWithValue("salt", usalt);
                command.Parameters.AddWithValue("password", uhash);

                command.ExecuteNonQuery();
            }

        }


        private void buSetPassword_Click(object sender, EventArgs e)
        {
            fmSetPassword sp = new fmSetPassword();
            sp.ShowDialog(this);
        }

        private void buCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
