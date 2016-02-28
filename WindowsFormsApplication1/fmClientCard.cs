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
    public partial class fmClientCard : Form
    {
        private int curClientId = -1;

        static string connstring = String.Format("Server={0};Port={1};" +
"User Id={2};Password={3};Database={4};",
"localhost",
"5432",
"postgres",
"enterprisedb",
"postgres");
        // Making connection with Npgsql provider
        NpgsqlConnection conn = new NpgsqlConnection(connstring);

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

        public fmClientCard()
        {
            InitializeComponent();

            string genders = "SELECT * FROM dic_genders";
            DataTable dtGender = Fill(genders);
            cbGender.DisplayMember = "name";
            cbGender.ValueMember = "id";
            cbGender.DataSource = dtGender;


        }

        public fmClientCard(int clientId)
        {
            InitializeComponent();
            curClientId = clientId;


            string sql = "SELECT * from clients WHERE id = " + clientId;
            DataTable dt = Fill(sql);
            tbLastName.Text = dt.Rows[0]["f"].ToString();
            tbFirstName.Text = dt.Rows[0]["i"].ToString();
            tbMiddleName.Text = dt.Rows[0]["o"].ToString();
            tbAddress.Text = dt.Rows[0]["address"].ToString();
            mtbPhone.Text = dt.Rows[0]["phone"].ToString();
            dtDoB.Value = Convert.ToDateTime( dt.Rows[0]["date_of_birth"].ToString() );
            tbDSC.Text = dt.Rows[0]["dsc"].ToString();


            string genders = "SELECT * FROM dic_genders";
            DataTable dtGender = Fill(genders);
            cbGender.DisplayMember = "name";
            cbGender.ValueMember = "id";
            cbGender.DataSource = dtGender;
            cbGender.SelectedValue = dt.Rows[0]["r_dic_genders_id"];
















        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buOK_Click(object sender, EventArgs e)
        {
            string sql;
            // MessageBox.Show(curBookId.ToString());
            if (curClientId == -1)
            {
                sql = "INSERT INTO clients (id, f, i, o, address, date_of_birth, r_dic_genders_id, phone, dsc, r_user_add_id, dt) VALUES (nextval('clients_seq'), @last_name, @first_name, @middle_name, @address, @date_of_birth, @gender, @phone, @dsc, @user_add, (SELECT CURRENT_TIMESTAMP));";

            }
            else
            {
                sql = "UPDATE clients SET f = @last_name, i = @first_name, o = @middle_name, address = @address, date_of_birth = @date_of_birth, r_dic_genders_id = @gender, phone = @phone, dsc = @dsc WHERE id = @id;";

            }


            int res;
            using (NpgsqlCommand command = new NpgsqlCommand(sql, conn))
            {
                if (curClientId != -1)
                {
                    command.Parameters.AddWithValue("id", curClientId);
                }
                else
                {
                    command.Parameters.AddWithValue("user_add", CurrentUser.getUserId());
                };
                command.Parameters.AddWithValue("last_name", tbLastName.Text);
                command.Parameters.AddWithValue("first_name", tbFirstName.Text);
                command.Parameters.AddWithValue("middle_name", tbMiddleName.Text);
                command.Parameters.AddWithValue("address", tbAddress.Text);
                command.Parameters.AddWithValue("date_of_birth", dtDoB.Value);
                command.Parameters.AddWithValue("gender", cbGender.SelectedValue);

                command.Parameters.AddWithValue("phone", mtbPhone.Text);
                command.Parameters.AddWithValue("dsc", tbDSC.Text);
                res = Convert.ToInt32(command.ExecuteNonQuery());

            }






            //  MessageBox.Show(authSql);
            this.Close();





        }
    }
}
