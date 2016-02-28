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
    public partial class fmCompany : Form
    {

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

        public fmCompany()
        {
            InitializeComponent();

            string sql = "SELECT * FROM company WHERE id = 1";
            DataTable dt = Fill(sql);

            tbLegalName.Text = dt.Rows[0]["legal_name"].ToString();
            tbLegalAddress.Text = dt.Rows[0]["legal_address"].ToString();
            tbPhone.Text = dt.Rows[0]["phone"].ToString();
            tbINN.Text = dt.Rows[0]["inn"].ToString();
            tbKPP.Text = dt.Rows[0]["kpp"].ToString();
            tbCorrespondentAccount.Text = dt.Rows[0]["correspondent_account"].ToString();
            tbClearingAccount.Text = dt.Rows[0]["clearing_account"].ToString();

            

        }

        private void fmCompany_Load(object sender, EventArgs e)
        {

        }

        private void buOK_Click(object sender, EventArgs e)
        {
    //        if (tbPrice.Text == "") { tbPrice.BackColor = Color.Red; lblPrice.Visible = true; } else { tbPrice.BackColor = SystemColors.Window; lblPrice.Visible = false; }
    //        if (tbName.Text == "") { tbName.BackColor = Color.Red; lblName.Visible = true; } else { tbName.BackColor = SystemColors.Window; lblName.Visible = false; }
    //        if (mtbISBN.Text == "") { mtbISBN.BackColor = Color.Red; lblISBN.Visible = true; } else { mtbISBN.BackColor = SystemColors.Window; lblISBN.Visible = false; }
    //        if (tbPrice.Text != "" && tbName.Text != "" && mtbISBN.Text != "")
    //        {

                string sql = "UPDATE company SET legal_name=@legal_name, legal_address=@legal_address, phone=@phone, inn=@inn, kpp=@kpp, correspondent_account=@correspondent_account, clearing_account=@clearing_account WHERE id = 1";


                using (NpgsqlCommand command = new NpgsqlCommand(sql, conn))
                {

                    command.Parameters.AddWithValue("legal_name", tbLegalName.Text);
                    command.Parameters.AddWithValue("legal_address", tbLegalAddress.Text);
                    command.Parameters.AddWithValue("phone", tbPhone.Text);
                    command.Parameters.AddWithValue("inn", tbINN.Text);
                    command.Parameters.AddWithValue("kpp", tbKPP.Text);

                    command.Parameters.AddWithValue("correspondent_account", tbCorrespondentAccount.Text);
                    command.Parameters.AddWithValue("clearing_account", tbClearingAccount.Text);


                    command.ExecuteNonQuery();

            }






            }
    }
}
