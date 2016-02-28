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
    public partial class fmBookList : Form
    {

        private DataSet dsBooks = new DataSet();
        private DataTable dtBooks = new DataTable();

        static string connstring = String.Format("Server={0};Port={1};" +
"User Id={2};Password={3};Database={4};",
"localhost",
"5432",
"postgres",
"enterprisedb",
"postgres");
        // Making connection with Npgsql provider
        NpgsqlConnection conn = new NpgsqlConnection(connstring);

        public fmBookList()
        {
            InitializeComponent();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            // Making connection with Npgsql provider
            //    NpgsqlConnection conn = new NpgsqlConnection(connstring);

            // quite complex sql statement
            //  string sql = "SELECT id, f as \"Фамилия\", i as Имя, o as Отчество  FROM users";
            // string sql = "SELECT id, array_to_string(ARRAY(select a.f + ' ' + left(a.i) + '. ' + left(a.o) + '.' from authors a LEFT JOIN ref_books_authors rba ON rba.author_id = a.id WHERE rba.book_id = b.id), ',') ,b.name as \"Название книги\"  FROM books b";

            string books = "SELECT b.id, b.article as Артикул, array_to_string(ARRAY(select a.f || ' ' || left(a.i, 1) || '.' || COALESCE(left(a.o, 1)|| '.', '')  from authors a LEFT JOIN ref_books_authors rba ON rba.r_authors_id = a.id WHERE rba.r_books_id = b.id), ',') as \"Авторы\" ,b.name as \"Название книги\", p.name as \"Издательство\", b.isbn FROM books b LEFT JOIN publishers p ON p.id = b.r_publishers_id";
            // data adapter making request from our connection
            NpgsqlDataAdapter daBooks = new NpgsqlDataAdapter(books, conn);
            // i always reset DataSet before i do
            // something with it.... i don't know why :-)
            dsBooks.Reset();
            // filling DataSet with result from NpgsqlDataAdapter
            daBooks.Fill(dsBooks);
            // since it C# DataSet can handle multiple tables, we will select first
            dtBooks = dsBooks.Tables[0];
            // connect grid to DataTable
            dataGridBooks.DataSource = dtBooks;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int id =  Convert.ToInt32( dataGridBooks.CurrentRow.Cells["id"].Value);

            OrderingBooks ob = new OrderingBooks();
            ob.bookId = id;
            ob.bookQuantity = Convert.ToInt32( nudQuantity.Value );


        //    MessageBox.Show(ids.ToString());
            fmOrderCard oc = (fmOrderCard)this.Owner;


            oc.selectedBooksId.Add(id);
            oc.selectedBooks.Add(ob);
        }
    }
}
