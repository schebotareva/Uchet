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
    public partial class fmBookExampleCard : Form
    {

        private int curBookExId = -1;



        public List<int> selectedAuthorsId = new List<int>();


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

        public fmBookExampleCard()
        {
            InitializeComponent();

            string genres = "SELECT * FROM books WHERE on_sale = true";
            DataTable dtBooks = Fill(genres);
            cbBooks.DisplayMember = "name";
            cbBooks.ValueMember = "id";
            cbBooks.DataSource = dtBooks;

        }

        private void fmBookExampleCard_Load(object sender, EventArgs e)
        {


        }

        private void buOK_Click(object sender, EventArgs e)
        {



            int selBookId = Convert.ToInt32( cbBooks.SelectedValue.ToString() );
            string bookEx = "";


            MessageBox.Show(nudQuantity.Value.ToString());


            for (int i = 0; i < nudQuantity.Value; i++ )
            {

                bookEx += "INSERT INTO book_examples (id, r_books_id, dt_from, dt_to ) VALUES (nextval('book_examples_seq'), " + selBookId + ", '" + dtDelivery.Value.ToString("yyyy-MM-dd") + "' , '2099-12-31');";

            }

            this.Close();


            using (NpgsqlCommand command = new NpgsqlCommand(bookEx, conn))
            {
                command.ExecuteNonQuery();
            }



        }
    }
}
