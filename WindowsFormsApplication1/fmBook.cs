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
    public partial class fmBook : Form
    {

        private int curBookId = -1;
        public List<int> insertRowsId = new List<int>();
        public List<string> insertingRowsFio = new List<string>();
        public List<int> deletingRowsId = new List<int>();


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

        public fmBook()
        {
            InitializeComponent();


            string genres = "SELECT * FROM dic_genres";
            DataTable dtGenre = Fill(genres);
            cbGenre.DisplayMember = "name";
            cbGenre.ValueMember = "id";
            cbGenre.DataSource = dtGenre;
        //    cbGenre.SelectedValue = dt.Rows[0]["genre_id"];


            string years = "SELECT * FROM dic_years WHERE name <= EXTRACT(YEAR FROM CURRENT_TIMESTAMP)  order by name desc";
            DataTable dtYear = Fill(years);
            cbYear.DisplayMember = "name";
            cbYear.ValueMember = "id";
            cbYear.DataSource = dtYear;
          //  cbYear.SelectedValue = 2;

            string publisher = "SELECT * FROM publishers";
            DataTable dtPublisher = Fill(publisher);
            cbPublisher.DisplayMember = "name";
            cbPublisher.ValueMember = "id";
            cbPublisher.DataSource = dtPublisher;
         //   cbPublisher.SelectedValue = dt.Rows[0]["publishers_id"];

        }

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


        public fmBook(int bookId)
        {

            InitializeComponent();

            curBookId = bookId;

            string sql = "SELECT b.id as book_id, b.name as book_name, b.original_name, b.dsc, b.r_publishers_id as publishers_id, p.name as publisher_name, b.price, b.isbn, b.r_dic_genres_id as genre_id, dg.name as genre_name, b.r_years_id  FROM books b LEFT JOIN dic_genres dg ON dg.id = b.r_dic_genres_id LEFT JOIN publishers p ON p.id = b.r_publishers_id WHERE b.id = " + bookId;
            DataTable dt = Fill(sql);

            tbPrice.Text = dt.Rows[0]["price"].ToString();
            tbName.Text = dt.Rows[0]["book_name"].ToString();
            tbOriginalName.Text = dt.Rows[0]["original_name"].ToString();
            tbDSC.Text = dt.Rows[0]["dsc"].ToString();
            mtbISBN.Text = dt.Rows[0]["isbn"].ToString();


            string authors = "SELECT a.id, a.f || ' ' || a.i || ' ' || COALESCE(a.o, '') as ФИО, a.date_of_birth, rba.id as rba_id FROM authors a LEFT JOIN ref_books_authors rba ON rba.r_authors_id = a.id WHERE rba.r_books_id = " + bookId;
            DataTable dtAuthors = Fill(authors);
            dataGridAuthors.DataSource = dtAuthors;
            dataGridAuthors.Columns["id"].Visible = false;
            dataGridAuthors.Columns["rba_id"].Visible = false;

          //  string[] columnArray = new string[dataGridAuthors.Rows.Count];

            int i = 0;
            foreach (DataGridViewRow row in dataGridAuthors.Rows)
            {
                //columnArray[i] = row.Cells["id"].Value != null ? row.Cells["id"].Value.ToString() : string.Empty;
                selectedAuthorsId.Add(Convert.ToInt32( row.Cells["id"].Value.ToString() ));
              //  MessageBox.Show(columnArray[row.Cells["id"].Value.ToString());
                i++;

            }



            string genres = "SELECT * FROM dic_genres";
            DataTable dtGenre = Fill(genres);
            cbGenre.DisplayMember = "name";
            cbGenre.ValueMember = "id";
            cbGenre.DataSource = dtGenre;
            cbGenre.SelectedValue = dt.Rows[0]["genre_id"];


            string years = "SELECT * FROM dic_years WHERE name <= EXTRACT(YEAR FROM CURRENT_TIMESTAMP)  order by name desc";
            DataTable dtYear = Fill(years);
            cbYear.DisplayMember = "name";
            cbYear.ValueMember = "id";
            cbYear.DataSource = dtYear;
            cbYear.SelectedValue = dt.Rows[0]["r_years_id"];

            string publisher = "SELECT * FROM publishers";
            DataTable dtPublisher = Fill(publisher);
            cbPublisher.DisplayMember = "name";
            cbPublisher.ValueMember = "id";
            cbPublisher.DataSource = dtPublisher;
            cbPublisher.SelectedValue = dt.Rows[0]["publishers_id"];












            //   conn.Close();
        }

        private void fmBook_Load(object sender, EventArgs e)
        {

        }

        private void buOK_Click(object sender, EventArgs e)
        {
            if (tbPrice.Text == "") { tbPrice.BackColor = Color.Red; lblPrice.Visible = true; } else { tbPrice.BackColor = SystemColors.Window; lblPrice.Visible = false; }
            if (tbName.Text == "") { tbName.BackColor = Color.Red; lblName.Visible = true;  } else { tbName.BackColor = SystemColors.Window; lblName.Visible = false; }
            if (mtbISBN.Text == "") { mtbISBN.BackColor = Color.Red; lblISBN.Visible = true; } else { mtbISBN.BackColor = SystemColors.Window; lblISBN.Visible = false; }
            if (tbPrice.Text != "" && tbName.Text != "" && mtbISBN.Text != "") {

                string sql;
                // MessageBox.Show(curBookId.ToString());
                if (curBookId == -1)
                {
                    sql = "INSERT INTO books (id, name, original_name, r_publishers_id, r_years_id, r_dic_genres_id, dsc, price, isbn, r_user_add_id, dt) VALUES (nextval('books_seq'), @name, @original_name, @publisher_id, @year_id, @genre_id, @dsc, @price, @isbn, @user_add, (SELECT CURRENT_TIMESTAMP)); SELECT last_value FROM books_seq;";

                }
                else
                {
                    sql = "UPDATE books SET name = @name, original_name = @original_name, r_publishers_id = @publisher_id, r_years_id = @year_id, r_dic_genres_id = @genre_id, dsc = @dsc, price = @price, isbn = @isbn WHERE id = @id; SELECT -100;";

                }


                int res;
                using (NpgsqlCommand command = new NpgsqlCommand(sql, conn))
                {
                    if (curBookId != -1) 
                    {
                        command.Parameters.AddWithValue("id", curBookId);

                    }
                    else
                    {
                        command.Parameters.AddWithValue("user_add", CurrentUser.getUserId());
                    }
  
                    command.Parameters.AddWithValue("name", tbName.Text);
                    command.Parameters.AddWithValue("original_name", tbOriginalName.Text);
                    command.Parameters.AddWithValue("publisher_id", cbPublisher.SelectedValue);
                    command.Parameters.AddWithValue("year_id", cbYear.SelectedValue);
                    command.Parameters.AddWithValue("genre_id", cbGenre.SelectedValue);

                    command.Parameters.AddWithValue("price", Convert.ToInt64(tbPrice.Text));
                    command.Parameters.AddWithValue("dsc", tbDSC.Text);
                    command.Parameters.AddWithValue("isbn", mtbISBN.Text);




                    res = Convert.ToInt32(command.ExecuteScalar());

                }





                string[] authorsIds = new string[dataGridAuthors.Rows.Count];

                string authSql = "";
                int bookId = curBookId == -1 ? res : curBookId;

                int i = 0;
                foreach (DataGridViewRow row in dataGridAuthors.Rows)
                {
                    authorsIds[i] = row.Cells["id"].Value != null ? row.Cells["id"].Value.ToString() : string.Empty;
                    authSql += "INSERT INTO ref_books_authors (id, r_authors_id, r_books_id ) VALUES (nextval('books_seq'), " + authorsIds[i] + ", " + bookId + "); ";
                    i++;

                }

                //  MessageBox.Show(authSql);
                this.Close();


                using (NpgsqlCommand command = new NpgsqlCommand(authSql, conn))
                {
                    command.ExecuteNonQuery();
                }


            }
        }

        private void buAddAuthor_Click(object sender, EventArgs e)
        {
            fmAutorList authors = new fmAutorList(curBookId);
            authors.Owner = this;
            DialogResult result = authors.ShowDialog();
            if (result == DialogResult.OK)
            {

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                int[] selAuthorsArray = selectedAuthorsId.ToArray();
                //string sql = "SELECT a.id, a.f || ' ' || a.i || ' ' || a.o as ФИО, a.date_of_birth, rba.id as rba_id FROM authors a LEFT JOIN ref_books_authors rba ON rba.r_authors_id = a.id WHERE a.id = ANY(:selected_authors) OR rba.r_books_id = " + curBookId;
                string sql = "SELECT a.id, a.f || ' ' || a.i || ' ' || COALESCE(a.o, '') as ФИО, a.date_of_birth FROM authors a WHERE a.id = ANY(:selected_authors)";

                NpgsqlCommand cmd = new NpgsqlCommand(sql,conn);
                NpgsqlParameter p = new NpgsqlParameter("selected_authors", NpgsqlDbType.Array | NpgsqlDbType.Integer);
                p.Value = selAuthorsArray;
                cmd.Parameters.Add(p);

                NpgsqlDataAdapter authorAdapter = new NpgsqlDataAdapter(cmd);
                DataTable dtAuthors = new DataTable();
                authorAdapter.Fill(dtAuthors);

                dataGridAuthors.DataSource = dtAuthors;
                dataGridAuthors.Columns["id"].Visible = false;
               // dataGridAuthors.Columns["rba_id"].Visible = false;
                
            }
            
        }

        private void buDeleteAuthor_Click(object sender, EventArgs e)
        {
             int id = Convert.ToInt32(dataGridAuthors.CurrentRow.Cells["id"].Value);
             deletingRowsId.Add(id);
             dataGridAuthors.Rows.Remove(dataGridAuthors.CurrentRow);
            selectedAuthorsId.Remove(id);

        }
    }
}
