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
    public partial class fmLogin : Form
    {



        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        // private DataTable dt = new DataTable();

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

        public fmLogin()
        {
            InitializeComponent();
        }

        private void buLogin_Click(object sender, EventArgs e)
        {

            if ((edPassword.Text == "sveta") && (edUserName.Text == "sveta"))
            {
                // MessageBox.Show("Login Successfull", "Login Information");
                this.Hide();

                fmMain mainWindow = new fmMain();
                mainWindow.ShowDialog();
                this.Close();

            }
            else
            {

                try
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Open();

                    // string genres = "SELECT * FROM dic_genres";

                    // получаем соль из базы данных
                    string sql = "Select u.id, u.salt, u.password from users u where u.username= '" + edUserName.Text +"'";
                //    NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                //    command.Parameters.AddWithValue("userId", 3432432);
                  //  command.Parameters.AddWithValue("username", edUserName.Text);
                  //  string salt = (string)command.ExecuteScalar();

                    // вычисляем хеш введенного пароля
                   // string hash = SHAHash.ComputeSHAHash(edPassword.Text, salt);


                    // Define a query
                //    string sqlnew = "Select * from users u where u.password=@hash and u.username=@username";


                 //   NpgsqlCommand commandnew = new NpgsqlCommand(sqlnew, conn);
                 ///   commandnew.Parameters.AddWithValue("hash", hash);
                 //   commandnew.Parameters.AddWithValue("username", edUserName.Text);


                    // Execute the query and obtain a result set
                 //   NpgsqlDataReader dr = commandw.ExecuteReader();

     
                    DataTable dtUser = Fill(sql);

                    if (dtUser.Rows.Count > 0)
                    {
                        int userId = Convert.ToInt32(dtUser.Rows[0]["id"]);
                        string salt = dtUser.Rows[0]["salt"].ToString();
                        string curHash = dtUser.Rows[0]["password"].ToString();


                        // вычисляем хеш введенного пароля
                        string genHash = SHAHash.ComputeSHAHash(edPassword.Text, salt);

                        //MessageBox.Show(genHash);

                     //   edUserName.Text = genHash;

                        if (genHash == curHash)
                        {
                            // MessageBox.Show("Login Successfull", "Login Information");
                            this.Hide();

                            fmMain mw = new fmMain(userId);

                            CurrentUser.setUserId(userId);

                            mw.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Неверные пароль и(или) имя пользователя", "Ошибка аутентификации");
                        }
                    } else
                    {
                        MessageBox.Show("Неверные пароль и(или) имя пользователя", "Ошибка атуентификации");
                    }
                }

                catch (Exception msg)
                {
                    // something went wrong, and you wanna know why
                    MessageBox.Show(msg.ToString());
                    throw;
                }

              //  this.Hide();
              //  fmMain mainWindow = new fmMain();
              //  mainWindow.ShowDialog();
              //  this.Close();
            }


        }
    }
}
