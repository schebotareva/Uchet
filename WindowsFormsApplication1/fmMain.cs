using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// база данных PostgreSQL
using Npgsql;
using FastReport.Export.Pdf;

using FastReport;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;


namespace WindowsFormsApplication1
{
    public partial class fmMain : Form
    {

        private DataSet dsBooks = new DataSet();
        private DataTable dtBooks = new DataTable();
        private DataSet dsOrders = new DataSet();
        private DataTable dtOrders = new DataTable();

        private DataSet dsClients = new DataSet();
        private DataTable dtClients = new DataTable();


        private DataSet dsServices = new DataSet();
        private DataTable dtServices = new DataTable();


        private DataSet dsWh = new DataSet();
        private DataTable dtWh = new DataTable();


        private DataSet FDataSet;

        private int curUserId = -1;

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

        public void setPrivlegies()
        {
            string sql = "SELECT * FROM users u LEFT JOIN user_roles ur ON ur.id = u.r_user_roles_id AND u.id=" + curUserId;
            DataTable dt = Fill(sql);

            this.Text = "Пользователь: " + dt.Rows[0]["f"].ToString() + " " + dt.Rows[0]["i"] + " " + dt.Rows[0]["o"];

            if (Convert.ToBoolean(dt.Rows[0]["order_view"]) == false)
            {
                tab.TabPages.Remove(tabpOrders);
            }
            buAddOrder.Visible = Convert.ToBoolean(dt.Rows[0]["order_create"]);
            buEditOrder.Visible = Convert.ToBoolean(dt.Rows[0]["order_edit"]);
            buDeleteOrder.Visible = Convert.ToBoolean(dt.Rows[0]["order_delete"]);




            if (Convert.ToBoolean(dt.Rows[0]["book_view"]) == false)
            {
                tab.TabPages.Remove(tabpBooks);
            }
            buAddBook.Visible = Convert.ToBoolean(dt.Rows[0]["book_create"]);
            buEditBook.Visible = Convert.ToBoolean(dt.Rows[0]["book_edit"]);
            buDeleteBook.Visible = Convert.ToBoolean(dt.Rows[0]["book_delete"]);

            if (Convert.ToBoolean(dt.Rows[0]["client_view"]) == false)
            {
                tab.TabPages.Remove(tabpClients);
            }

            tab.TabPages.Remove(tabpServices);

        }


        public void ShowBooksList()
        {
            ShowBooksListWhere(null);
        }

        public void ShowBooksListWhere(string strWhere)
        {

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            string books = "SELECT b.id, b.article, array_to_string(ARRAY(select a.f || ' ' || left(a.i, 1) || '.' || COALESCE(left(a.o, 1)|| '.', '')  from authors a LEFT JOIN ref_books_authors rba ON rba.r_authors_id = a.id WHERE rba.r_books_id = b.id), ',') as authors ,b.name as book_name, p.name as publisher_name, b.isbn, (u.f || ' ' || u.i || ' ' || COALESCE(u.o,'')) as user_add_fio, b.dt FROM books b LEFT JOIN publishers p ON p.id = b.r_publishers_id LEFT JOIN users u ON u.id = b.r_user_add_id";
            string orderby = " ORDER BY dt, book_name";


            if (strWhere != null)
            {
                books = books + ' ' + strWhere + ' ' + orderby;
            }


            // data adapter making request from our connection
            NpgsqlDataAdapter daBooks = new NpgsqlDataAdapter(books, conn);
            // i always reset DataSet before i do
            // something with it.... i don't know why :-)
            dsBooks.Reset();
            // filling DataSet with result from NpgsqlDataAdapter
            daBooks.Fill(dsBooks);
            // since it C# DataSet can handle multiple tables, we will select first
            dtBooks = dsBooks.Tables[0];

            dtBooks.Columns["article"].ColumnName = "Артикул";
            dtBooks.Columns["authors"].ColumnName = "Авторы";
            dtBooks.Columns["book_name"].ColumnName = "Название книги";
            dtBooks.Columns["publisher_name"].ColumnName = "Издательство";
            dtBooks.Columns["user_add_fio"].ColumnName = "Сотрудник, добавивший книгу";
            dtBooks.Columns["dt"].ColumnName = "Дата добавления";

            dataGridBooks.DataSource = dtBooks;
            dataGridBooks.Columns["id"].Visible = false;

            conn.Close();
        }

        public void ShowClientsList()
        {

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            string clients = "SELECT c.id, f || ' ' || i || ' ' || o as fio, dg.name as gender, date_of_birth, phone, address, dsc FROM clients c LEFT JOIN dic_genders dg ON dg.id = c.r_dic_genders_id";
            NpgsqlDataAdapter daClients = new NpgsqlDataAdapter(clients, conn);
            dsClients.Reset();
            daClients.Fill(dsClients);
            dtClients = dsClients.Tables[0];

            dtClients.Columns["fio"].ColumnName = "ФИО";
            dtClients.Columns["address"].ColumnName = "Адрес";
            dtClients.Columns["gender"].ColumnName = "Пол";
            dtClients.Columns["date_of_birth"].ColumnName = "Дата рождения";
            dtClients.Columns["phone"].ColumnName = "Телефон";
            dtClients.Columns["dsc"].ColumnName = "Комментарий";


            dataGridClients.DataSource = dtClients;

            conn.Close();
        }




        public void ShowOrdersList()
        {
            ShowOrdersListWhere(null);
        }


        public void ShowOrdersListWhere(string strWhere)
        {

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            string orders = "SELECT o.id, o.order_number, opr.order_price, u.f || ' ' || u.i || ' ' || COALESCE(u.o, '') as user_add_fio, o.dt FROM orders o " +
                "LEFT JOIN users u ON u.id = o.r_user_add_id " +
                "LEFT JOIN" +
                "(SELECT rob.r_orders_id, SUM(b.price) as order_price FROM ref_orders_books rob " +
                "LEFT JOIN books b ON b.id = rob.r_books_id " +
                "GROUP BY rob.r_orders_id) opr ON opr.r_orders_id = o.id";
            
                if (strWhere != null)
                {
                orders = orders + ' ' + strWhere;
                }


            NpgsqlDataAdapter daOrders = new NpgsqlDataAdapter(orders, conn);
            dsOrders.Reset();
            daOrders.Fill(dsOrders);
            dtOrders = dsOrders.Tables[0];

            dtOrders.Columns["dt"].ColumnName = "Дата регистрации заказа";
            dtOrders.Columns["order_number"].ColumnName = "Номер заказа";
            dtOrders.Columns["order_price"].ColumnName = "Сумма заказа";
            dtOrders.Columns["user_add_fio"].ColumnName = "Сотрудник, который добавил";

            dataGridOrders.DataSource = dtOrders;

            conn.Close();
        }


        public void ShowServicesList()
        {
            ShowServicesListWhere(null);
        }


        public void ShowServicesListWhere(string strWhere)
        {

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            string services = "SELECT id, name, price FROM services";

            if (strWhere != null)
            {
                services = services + ' ' + strWhere;
            }


            NpgsqlDataAdapter daServices = new NpgsqlDataAdapter(services, conn);
            dsServices.Reset();
            daServices.Fill(dsServices);
            dtServices = dsServices.Tables[0];

            dtServices.Columns["name"].ColumnName = "Название услуги";
            dtServices.Columns["price"].ColumnName = "Цена услуги";


            dataGridServices.DataSource = dtServices;

            conn.Close();
        }


        public void ShowWhList()
        {
            ShowWhListWhere(null);
        }


        public void ShowWhListWhere(string strWhere)
        {

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            string wh = "select b.id as book_id, b.name as book_name, b.price as book_price, count(b.id) as book_quantity from book_examples be "
                                + "LEFT JOIN books b ON b.id = be.r_books_id "
                                + "WHERE current_timestamp between be.dt_from and be.dt_to "
                                + "group by book_id";

            if (strWhere != null)
            {
                wh = wh + ' ' + strWhere;
            }


            NpgsqlDataAdapter daWh = new NpgsqlDataAdapter(wh, conn);
            dsWh.Reset();
            daWh.Fill(dsWh);
            dtWh = dsWh.Tables[0];

            dtWh.Columns["book_name"].ColumnName = "Название книги";
            dtWh.Columns["book_price"].ColumnName = "Цена книги";
            dtWh.Columns["book_quantity"].ColumnName = "Количество книг";



           dataGridWarehouse.DataSource = dtWh;

            conn.Close();
        }





        public fmMain()
        {
            InitializeComponent();

        }





        public fmMain(int userId)
        {
            InitializeComponent();

            curUserId = userId;
            setPrivlegies();

            ShowBooksList();
            ShowOrdersList();
            ShowClientsList();
            ShowServicesList();
            ShowWhList();

        }



        private void miAbout_Click(object sender, EventArgs e)
        {
            fmAboutBox about = new fmAboutBox();
            about.ShowDialog();
        }

        private void miUsers_Click(object sender, EventArgs e)
        {
            fmUserList users = new fmUserList();
            users.ShowDialog();
        }

        private void miSettings_Click(object sender, EventArgs e)
        {
            fmSettings settings = new fmSettings();
            settings.ShowDialog();
        }

        private void tbuAdd_Click(object sender, EventArgs e)
        {
            fmOrderCard order = new fmOrderCard();
            order.ShowDialog();
            ShowOrdersList();
        }

        private void tbuFindByAuthor_Click(object sender, EventArgs e)
        {

        }

        private void tbuFind_Click(object sender, EventArgs e)
        {
            try
            {
                // PostgeSQL-style connection string
                string connstring = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    "localhost",
                    "5432",
                    "postgres",
                    "enterprisedb",
                    "postgres");
                // Making connection with Npgsql provider
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                // quite complex sql statement
                // string sql = "SELECT id, array_to_string(ARRAY(select a.f + ' ' + left(a.i) + '. ' + left(a.o) + '.' from authors a LEFT JOIN ref_books_authors rba ON rba.author_id = a.id WHERE rba.book_id = b.id), ',') ,b.name as \"Название книги\",  FROM books b"; //WHERE a.first_name LIKE = %@author% OR a.middle_name LIKE = %@author% OR a.last_name = %@author%";
                string sql = "SELECT b.id, array_to_string(ARRAY(select a.f || ' ' || left(a.i, 1) || '.' || COALESCE(left(a.o, 1) || '.','')  from authors a LEFT JOIN ref_books_authors rba ON rba.r_authors_id = a.id WHERE rba.r_books_id = b.id), ',') as \"Авторы\" ,b.name as \"Название книги\", p.name as \"Издательство\", b.publishing_date as \"Год издания\"  FROM books b LEFT JOIN publishers p ON p.id = b.r_publishers_id";


                // data adapter making request from our connection
                NpgsqlDataAdapter daBooks = new NpgsqlDataAdapter(sql, conn);
                // i always reset DataSet before i do
                // something with it.... i don't know why :-)
                dsBooks.Reset();
                // filling DataSet with result from NpgsqlDataAdapter
                daBooks.Fill(dsBooks);
                // since it C# DataSet can handle multiple tables, we will select first
                dtBooks = dsBooks.Tables[0];
                // connect grid to DataTable
                dataGridBooks.DataSource = dtBooks;
                // since we only showing the result we don't need connection anymore
                conn.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void buEdit_Click(object sender, EventArgs e)
        {

            if (dataGridOrders.Rows.Count > 0)
            {
                int orderId = Convert.ToInt32(dataGridOrders.CurrentRow.Cells["id"].Value.ToString());
                fmOrderCard order = new fmOrderCard(orderId);
                order.ShowDialog();
                ShowOrdersList();
            }
            else
            {
                MessageBox.Show("Нет");
            }
        }

        private void buEditBook_Click(object sender, EventArgs e)
        {

            if (dataGridBooks.Rows.Count > 0)
            {
                int bookId = Convert.ToInt32(dataGridBooks.CurrentRow.Cells["id"].Value.ToString());
                int rowIndex = dataGridBooks.CurrentRow.Index;

                fmBook book = new fmBook(bookId);
                book.ShowDialog();
                ShowBooksList();

                // dataGridBooks.CurrentCell = dataGridBooks.Rows[rowIndex].Cells[0];


            }
            else
            {
                MessageBox.Show("Нет строки для редактирования");
            }
        }

        private void buAddBook_Click(object sender, EventArgs e)
        {
            fmBook book = new fmBook();
            book.ShowDialog();

            ShowBooksList();


        }

        private void CreateDataSet()
        {
            // create simple dataset with one table
            FDataSet = new DataSet();

            DataTable table = new DataTable();
            table.TableName = "Employees";
            FDataSet.Tables.Add(table);

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));

            table.Rows.Add(1, "Andrew Fuller");
            table.Rows.Add(2, "Nancy Davolio");
            table.Rows.Add(3, "Margaret Peacock");
        }

        private void miReports_Click(object sender, EventArgs e)
        {

            CreateDataSet();
            // Form8 frm = new Form8();
            //  frm.ShowDialog();
            // create report instance
            Report report = new Report();

            // load the existing report
            report.Load(@"..\..\..\report.frx");

            // register the dataset
            report.RegisterData(FDataSet);

            // run the report
            report.Prepare();

            // create export instance
            PDFExport export = new PDFExport();
            export.Export(report);

            // free resources used by report
            report.Dispose();
        }

        private void miUserRoles_Click(object sender, EventArgs e)
        {
            fmUserRoleList ur = new fmUserRoleList();
            ur.ShowDialog();
        }

        private void buFindBook_Click(object sender, EventArgs e)
        {


            string strWhere = "WHERE"
                                + " lower(b.name) LIKE '%" + edFindBookByName.Text.ToLower() + "%'"
                                + " AND b.id IN "
                                + " (SELECT rba.r_books_id FROM ref_books_authors rba WHERE rba.r_authors_id IN "
                                + " (SELECT a.id FROM authors a WHERE lower(a.f) LIKE '%" 
                                + edFindBookByAuthor.Text.ToLower() 
                                + "%' OR lower(a.i) LIKE '%" 
                                + edFindBookByAuthor.Text.ToLower() 
                                + "%' OR COALESCE(lower(a.o),'') LIKE '%" 
                                + edFindBookByAuthor.Text.ToLower() 
                                + "%') );";

            ShowBooksListWhere(strWhere);

        }

        private void buAddClient_Click(object sender, EventArgs e)
        {
            fmClientCard cc = new fmClientCard();
            cc.ShowDialog();
            ShowClientsList();
        }

        private void buEditClient_Click(object sender, EventArgs e)
        {
            int clientId = Convert.ToInt32(dataGridClients.CurrentRow.Cells["id"].Value);
            fmClientCard cc = new fmClientCard(clientId);
            cc.ShowDialog();
            ShowClientsList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buDeleteBook_Click(object sender, EventArgs e)
        {
            ShowBooksList();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {

        }

        private void tabpClients_Click(object sender, EventArgs e)
        {

        }

        private void buDeleteClient_Click(object sender, EventArgs e)
        {
            ShowClientsList();
        }

        private void buDeleteOrder_Click(object sender, EventArgs e)
        {
            ShowOrdersList();
        }

        private void buFindBookReset_Click(object sender, EventArgs e)
        {
            edFindBookByAuthor.Text = "";
            edFindBookByName.Text = "";
            ShowBooksList();
        }

        private void dataGridOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buFindOrderReset_Click(object sender, EventArgs e)
        {
             ShowOrdersList();
             dtOrderFrom.Value = dtOrderFrom.MinDate;
             dtOrderTo.Value = DateTime.Now;
        }

        private void buExportBooks_Click(object sender, EventArgs e)
        {

            ExportToFile(dataGridBooks, "Список книг");

        }

        private void buClientsExport_Click(object sender, EventArgs e)
        {
            ExportToFile(dataGridClients, "Список клиентов");
        }

        private void buOrdersExport_Click(object sender, EventArgs e)
        {
            ExportToFile(dataGridOrders, "Список продаж");
        }


        private void ExportToFile(DataGridView dg, string worksheetName)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XLS files (*.xls)|*.xls|XLT files (*.xlt)|*.xlt|XLSX files (*.xlsx)|*.xlsx|XLSM files (*.xlsm)|*.xlsm|XLTX (*.xltx)|*.xltx|XLTM (*.xltm)|*.xltm|ODS (*.ods)|*.ods|OTS (*.ots)|*.ots|CSV (*.csv)|*.csv|TSV (*.tsv)|*.tsv|HTML (*.html)|*.html|MHTML (.mhtml)|*.mhtml|PDF (*.pdf)|*.pdf|XPS (*.xps)|*.xps|BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif|WMP (*.wdp)|*.wdp";
            saveFileDialog.FilterIndex = 3;
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                ExcelFile ef = new ExcelFile();
                ExcelWorksheet ws = ef.Worksheets.Add(worksheetName);

                DataGridViewConverter.ImportFromDataGridView(
                    ef.Worksheets[0],
                    dg,
                    new ImportFromDataGridViewOptions() { ColumnHeaders = true }
                );

                ws.PrintOptions.FitWorksheetWidthToPages = 1;
                ef.Save(saveFileDialog.FileName);
                
            }

        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dtOrderFrom_ValueChanged(object sender, EventArgs e)
        {
            string strWhere = " WHERE o.dt BETWEEN '" + dtOrderFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtOrderTo.Value.ToString("yyyy-MM-dd") + " 23:59:59'";

            ShowOrdersListWhere(strWhere);
        }

        private void miCompany_Click(object sender, EventArgs e)
        {
            fmCompany co = new fmCompany();
            co.ShowDialog();
        }

        private void buServiceAdd_Click(object sender, EventArgs e)
        {
            fmServiceCard src = new fmServiceCard();
            src.ShowDialog();

        }

        private void buServiceEdit_Click(object sender, EventArgs e)
        {
            fmServiceCard src = new fmServiceCard();
            src.ShowDialog();
        }

        private void buServiceExport_Click(object sender, EventArgs e)
        {
            ExportToFile(dataGridServices, "Список услуг");
        }

        private void buWhExport_Click(object sender, EventArgs e)
        {
            ExportToFile(dataGridWarehouse, "Список товаров на складе");
        }

        private void buWhEdit_Click(object sender, EventArgs e)
        {
            fmBookExampleCard bec = new fmBookExampleCard();
            bec.ShowDialog();
        }

        private void buWhAdd_Click(object sender, EventArgs e)
        {
            fmBookExampleCard bec = new fmBookExampleCard();
            bec.ShowDialog();
        }
    }
}
