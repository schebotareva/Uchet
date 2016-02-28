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
    public partial class fmAutorList : Form
    {

        private int curBookId;
        public static int selAuthorId;    
    
    static string connstring = String.Format("Server={0};Port={1};" +
 "User Id={2};Password={3};Database={4};",
 "localhost",
 "5432",
 "postgres",
 "enterprisedb",
 "postgres");
        // Making connection with Npgsql provider
        NpgsqlConnection conn = new NpgsqlConnection(connstring);


        public fmAutorList()
        {
            InitializeComponent();
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

        public fmAutorList(int bookId)
        {
            InitializeComponent();

            string authors = "SELECT a.id, a.f || ' ' || a.i || ' ' || COALESCE(a.o, '') as ФИО, a.date_of_birth as \"Дата рождения\" FROM authors a ";
            DataTable dtAuthors = Fill(authors);
            dataGridAuthors.DataSource = dtAuthors;
            dataGridAuthors.Columns["id"].Visible = false;

            fmBook bookzz = (fmBook)this.Owner;
            
        //    bookzz.dataGridAuthors.


        }

        private void buSelect_Click(object sender, EventArgs e)
        {
            //dataGridAuthors.SelectedRows;



             fmBook bookzz = (fmBook)this.Owner;

             bookzz.insertRowsId.Add(Convert.ToInt32( dataGridAuthors.CurrentRow.Cells["id"].Value));

            bookzz.selectedAuthorsId.Add(Convert.ToInt32(dataGridAuthors.CurrentRow.Cells["id"].Value));
          
           //  bookzz.insertingRowsFio.Add(dataGridAuthors.CurrentRow.Cells["ФИО"].Value.ToString());

           //  bookzz.dataGridAuthors.Rows.AddRange()
            

          //  bookzz.dataGridAuthors.DataSource = dataGridAuthors.CurrentRow.Cells["id"].Value;

            //    bookzz.nonids.Add

            //    DataTable dt = ((DataTable) dataGridAuthors.DataSource).Clone();
            //   foreach (DataGridViewRow row in dataGridAuthors.SelectedRows)
            //   {
            //   dt.ImportRow(((DataTable)dataGridAuthors.DataSource).Rows[row.Index]);
            //   }
            //  dt.AcceptChanges();

            // bookzz.dataGridAuthors.DataSource = dt;

        }

        private void buFindAuthor_Click(object sender, EventArgs e)
        {
            
        }
    }
}
