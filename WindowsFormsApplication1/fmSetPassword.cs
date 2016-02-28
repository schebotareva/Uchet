using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using Npgsql;

namespace WindowsFormsApplication1
{
    public partial class fmSetPassword : Form
    {




        public fmSetPassword()
        {
            InitializeComponent();
        }




        static readonly char[] AvailableCharacters = {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', '_'
        };

        internal static string GenerateIdentifier(int length)
        {
            char[] identifier = new char[length];
            byte[] randomData = new byte[length];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(randomData);
            }

            for (int idx = 0; idx < identifier.Length; idx++)
            {
                int pos = randomData[idx] % AvailableCharacters.Length;
                identifier[idx] = AvailableCharacters[pos];
            }

            return new string(identifier);
        }

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


        private void buOK_Click(object sender, EventArgs e)
        {
            if (edNewPassword.Text == edRepeatPassword.Text)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                string password = edNewPassword.Text;

                // генерируем соль
                string saltGen = GenerateIdentifier(30);
                
                

                //Генерируем хэш в соответствии с SHA-512 на основе введенного пользователем
                // пароля и сгенерированной соли.
                string hash = SHAHash.ComputeSHAHash(password,saltGen);

                
             //   fmUser user = (fmUser)this.Owner;

                ((fmUser)this.Owner).usalt = saltGen;
                ((fmUser)this.Owner).uhash = hash;

                

                //занесение в базу данных
         /*       string UpdateCmd = "update users set salt = @salt, password = @hash where id = @id;";

                using (NpgsqlCommand command = new NpgsqlCommand(UpdateCmd, conn))
                {
                    command.Parameters.AddWithValue("salt", saltGen);
                    command.Parameters.AddWithValue("hash", hash);
                    command.Parameters.AddWithValue("id", 3432432);
                    command.ExecuteNonQuery();
                }*/
            }
            else
            {
                MessageBox.Show("Пароли не совпадают! Попробуйте ввести еще раз", "Предупреждение");
            }
        }
    }
}
