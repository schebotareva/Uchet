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
using NpgsqlTypes;

namespace WindowsFormsApplication1
{
    public partial class fmOrderCard : Form
    {

        private int curOrderId = -1;
        public List<int> insertRowsId = new List<int>();
        //    public List<string> insertingRowsFio = new List<string>();
        public List<int> deletingRowsId = new List<int>();

        public List<int> selectedBooksId = new List<int>();
        public List<OrderingBooks> selectedBooks = new List<OrderingBooks>();



        public int selClientId = -1;



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

        public fmOrderCard()
        {
            InitializeComponent();
        }

        public fmOrderCard(int orderId)
        {
            InitializeComponent();



            curOrderId = orderId;


            // наименование - количество цена сумма ндс,% сумма_ндс
            string sql = "SELECT order_number, r_client_id, COALESCE(c.f || ' ' || c.i || ' ' || COALESCE(c.o,''), '(не выбран)') as client_fio FROM orders o LEFT JOIN clients c ON o.r_client_id = c.id WHERE o.id = " + orderId;
            DataTable dt = Fill(sql);

            selClientId = Convert.ToInt32(dt.Rows[0]["r_client_id"].ToString());
            medOrderNumber.Text = dt.Rows[0]["order_number"].ToString();
            lblFIO.Text = dt.Rows[0]["client_fio"].ToString();

            string books = "SELECT b.name, rob.books_quantity, b.price, b.price*rob.books_quantity as book_sum, 10 as nds, 0.1*b.price*rob.books_quantity nds_sum  FROM books b LEFT JOIN ref_orders_books rob ON rob.r_books_id = b.id WHERE rob.r_orders_id = " + orderId;
            DataTable dtBooks = Fill(books);
            dataGridBooks.DataSource = dtBooks;

        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // заказан, оплачен, доставлен
        }

        private void buSelectClient_Click(object sender, EventArgs e)
        {
            fmClientList cl = new fmClientList();
            cl.ShowDialog(this);
        }

        private void buAdd_Click(object sender, EventArgs e)
        {
            fmBookList bl = new fmBookList();

            DialogResult result = bl.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                //  MessageBox.Show("fsdfsdfsdf");
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                //   int[] selBooksArray = selectedBooksId.ToArray();

                int[] selBooksArray = selectedBooksId.ToArray();
                

                //     MessageBox.Show(selBooksArray[0].ToString());

                //string sql = "SELECT a.id, a.f || ' ' || a.i || ' ' || a.o as ФИО, a.date_of_birth, rba.id as rba_id FROM authors a LEFT JOIN ref_books_authors rba ON rba.r_authors_id = a.id WHERE a.id = ANY(:selected_authors) OR rba.r_books_id = " + curBookId;
                //                string sql = "SELECT a.id, a.f || ' ' || a.i || ' ' || COALESCE(a.o, '') as ФИО, a.date_of_birth FROM authors a WHERE a.id = ANY(:selected_authors)";

                //   string books = "SELECT b.name, rob.books_quantity, b.price, b.price*rob.books_quantity as book_sum, 10 as nds, 0.1*b.price*rob.books_quantity nds_sum  FROM books b LEFT JOIN ref_orders_books rob ON rob.r_books_id = b.id WHERE b.id = ANY(:selected_books)";



                // Making connection with Npgsql provider
                //    NpgsqlConnection conn = new NpgsqlConnection(connstring);

                // quite complex sql statement
                //  string sql = "SELECT id, f as \"Фамилия\", i as Имя, o as Отчество  FROM users";
                // string sql = "SELECT id, array_to_string(ARRAY(select a.f + ' ' + left(a.i) + '. ' + left(a.o) + '.' from authors a LEFT JOIN ref_books_authors rba ON rba.author_id = a.id WHERE rba.book_id = b.id), ',') ,b.name as \"Название книги\"  FROM books b";

                string books = "SELECT b.id, b.article as Артикул, array_to_string(ARRAY(select a.f || ' ' || left(a.i, 1) || '.' || COALESCE(left(a.o, 1)|| '.', '')  from authors a LEFT JOIN ref_books_authors rba ON rba.r_authors_id = a.id WHERE rba.r_books_id = b.id), ',') as \"Авторы\" ,b.name as \"Название книги\", p.name as \"Издательство\", b.isbn FROM books b LEFT JOIN publishers p ON p.id = b.r_publishers_id";



              //  string books = "SELECT b.name  FROM books b WHERE b.id = ANY(:selected_books)";
              books = books + " WHERE b.id = ANY(:selected_books)";



                // DataTable dtBooks = Fill(books);
                //  dataGridView1.DataSource = dtBooks;

                NpgsqlCommand cmd = new NpgsqlCommand(books, conn);
                NpgsqlParameter p = new NpgsqlParameter("selected_books", NpgsqlDbType.Array | NpgsqlDbType.Integer);
                p.Value = selBooksArray;
                cmd.Parameters.Add(p);

                NpgsqlDataAdapter bookAdapter = new NpgsqlDataAdapter(cmd);
                // DataTable dtBooks = new DataTable();
                DataTable dtBooks = new DataTable();
                bookAdapter.Fill(dtBooks);

                dataGridBooks.DataSource = dtBooks;
                //dataGridView1.Columns["id"].Visible = false;
                // dataGridAuthors.Columns["rba_id"].Visible = false;
            }
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            string sql;
            // MessageBox.Show(curBookId.ToString());
            if (curOrderId == -1)
            {
                sql = "INSERT INTO orders (id, order_number, dt, r_user_add_id, r_client_id) VALUES (nextval('books_seq'), @order_number, (SELECT CURRENT_TIMESTAMP), @user_add, @client); SELECT last_value FROM books_seq;";

            }
            else
            {
                sql = "UPDATE orders SET order_number = @order_number, r_client_id = @client WHERE id = @id; SELECT -100;";

            }


            int res;
            using (NpgsqlCommand command = new NpgsqlCommand(sql, conn))
            {
                if (curOrderId != -1)
                {
                    command.Parameters.AddWithValue("id", curOrderId);

                }
                else
                {
                    command.Parameters.AddWithValue("user_add", CurrentUser.getUserId());
                }

                command.Parameters.AddWithValue("order_number", medOrderNumber.Text);
                command.Parameters.AddWithValue("client", selClientId);





                res = Convert.ToInt32(command.ExecuteScalar());

            }

                string[] booksIds = new string[dataGridBooks.Rows.Count];

                string sqlOrder = "DELETE FROM ref_orders_books WHERE r_orders_id = " + curOrderId + "; ";
                int orderId = curOrderId == -1 ? res : curOrderId;

                int i = 0;
                
                
                
                foreach (DataGridViewRow row in dataGridBooks.Rows)
                {
                    booksIds[i] = row.Cells["id"].Value != null ? row.Cells["id"].Value.ToString() : string.Empty;
                    sqlOrder += "INSERT INTO ref_orders_books (id, r_orders_id, r_books_id ) VALUES (nextval('books_seq'), " + orderId + ", " + booksIds[i] + "); ";
                    i++;

                }

                //  MessageBox.Show(authSql);
                this.Close();


                using (NpgsqlCommand command = new NpgsqlCommand(sqlOrder, conn))
                {
                    command.ExecuteNonQuery();
                }


         
        }

        private void buDelete_Click(object sender, EventArgs e)
        {
            dataGridBooks.Rows.Remove(dataGridBooks.CurrentRow);
        }
    }
}
