namespace WindowsFormsApplication1
{
    partial class fmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab = new System.Windows.Forms.TabControl();
            this.tabpOrders = new System.Windows.Forms.TabPage();
            this.buOrdersExport = new System.Windows.Forms.Button();
            this.buFindOrderReset = new System.Windows.Forms.Button();
            this.dtOrderTo = new System.Windows.Forms.DateTimePicker();
            this.dtOrderFrom = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buDeleteOrder = new System.Windows.Forms.Button();
            this.buEditOrder = new System.Windows.Forms.Button();
            this.buAddOrder = new System.Windows.Forms.Button();
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.tabpBooks = new System.Windows.Forms.TabPage();
            this.buExportBooks = new System.Windows.Forms.Button();
            this.buFindBookReset = new System.Windows.Forms.Button();
            this.buDeleteBook = new System.Windows.Forms.Button();
            this.buEditBook = new System.Windows.Forms.Button();
            this.buAddBook = new System.Windows.Forms.Button();
            this.dataGridBooks = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.edFindBookByName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edFindBookByAuthor = new System.Windows.Forms.TextBox();
            this.tabpServices = new System.Windows.Forms.TabPage();
            this.tabpClients = new System.Windows.Forms.TabPage();
            this.buClientsExport = new System.Windows.Forms.Button();
            this.buDeleteClient = new System.Windows.Forms.Button();
            this.buEditClient = new System.Windows.Forms.Button();
            this.buAddClient = new System.Windows.Forms.Button();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.tabpSklad = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.miUserRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miReports = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridServices = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.buServiceAdd = new System.Windows.Forms.Button();
            this.buServiceExport = new System.Windows.Forms.Button();
            this.buServiceEdit = new System.Windows.Forms.Button();
            this.buServiceDelete = new System.Windows.Forms.Button();
            this.dataGridWarehouse = new System.Windows.Forms.DataGridView();
            this.buWhExport = new System.Windows.Forms.Button();
            this.buWhAdd = new System.Windows.Forms.Button();
            this.buWhEdit = new System.Windows.Forms.Button();
            this.buWhDelete = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            this.tabpBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).BeginInit();
            this.tabpServices.SuspendLayout();
            this.tabpClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            this.tabpSklad.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabpOrders);
            this.tab.Controls.Add(this.tabpBooks);
            this.tab.Controls.Add(this.tabpServices);
            this.tab.Controls.Add(this.tabpClients);
            this.tab.Controls.Add(this.tabpSklad);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 24);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(788, 616);
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tabpOrders
            // 
            this.tabpOrders.Controls.Add(this.buOrdersExport);
            this.tabpOrders.Controls.Add(this.buFindOrderReset);
            this.tabpOrders.Controls.Add(this.dtOrderTo);
            this.tabpOrders.Controls.Add(this.dtOrderFrom);
            this.tabpOrders.Controls.Add(this.label12);
            this.tabpOrders.Controls.Add(this.label11);
            this.tabpOrders.Controls.Add(this.buDeleteOrder);
            this.tabpOrders.Controls.Add(this.buEditOrder);
            this.tabpOrders.Controls.Add(this.buAddOrder);
            this.tabpOrders.Controls.Add(this.dataGridOrders);
            this.tabpOrders.Location = new System.Drawing.Point(4, 22);
            this.tabpOrders.Name = "tabpOrders";
            this.tabpOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabpOrders.Size = new System.Drawing.Size(780, 590);
            this.tabpOrders.TabIndex = 0;
            this.tabpOrders.Text = "Продажи";
            this.tabpOrders.UseVisualStyleBackColor = true;
            // 
            // buOrdersExport
            // 
            this.buOrdersExport.Location = new System.Drawing.Point(3, 561);
            this.buOrdersExport.Name = "buOrdersExport";
            this.buOrdersExport.Size = new System.Drawing.Size(75, 23);
            this.buOrdersExport.TabIndex = 15;
            this.buOrdersExport.Text = "Экспорт";
            this.buOrdersExport.UseVisualStyleBackColor = true;
            this.buOrdersExport.Click += new System.EventHandler(this.buOrdersExport_Click);
            // 
            // buFindOrderReset
            // 
            this.buFindOrderReset.Location = new System.Drawing.Point(697, 13);
            this.buFindOrderReset.Name = "buFindOrderReset";
            this.buFindOrderReset.Size = new System.Drawing.Size(75, 42);
            this.buFindOrderReset.TabIndex = 14;
            this.buFindOrderReset.Text = "Сбросить фильтр";
            this.buFindOrderReset.UseVisualStyleBackColor = true;
            this.buFindOrderReset.Click += new System.EventHandler(this.buFindOrderReset_Click);
            // 
            // dtOrderTo
            // 
            this.dtOrderTo.Location = new System.Drawing.Point(486, 40);
            this.dtOrderTo.Name = "dtOrderTo";
            this.dtOrderTo.Size = new System.Drawing.Size(200, 20);
            this.dtOrderTo.TabIndex = 13;
            // 
            // dtOrderFrom
            // 
            this.dtOrderFrom.Location = new System.Drawing.Point(486, 14);
            this.dtOrderFrom.Name = "dtOrderFrom";
            this.dtOrderFrom.Size = new System.Drawing.Size(200, 20);
            this.dtOrderFrom.TabIndex = 12;
            this.dtOrderFrom.ValueChanged += new System.EventHandler(this.dtOrderFrom_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(365, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Дата регистрации с:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(458, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "по:";
            // 
            // buDeleteOrder
            // 
            this.buDeleteOrder.Location = new System.Drawing.Point(702, 561);
            this.buDeleteOrder.Name = "buDeleteOrder";
            this.buDeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.buDeleteOrder.TabIndex = 5;
            this.buDeleteOrder.Text = "Удалить";
            this.buDeleteOrder.UseVisualStyleBackColor = true;
            this.buDeleteOrder.Click += new System.EventHandler(this.buDeleteOrder_Click);
            // 
            // buEditOrder
            // 
            this.buEditOrder.Location = new System.Drawing.Point(598, 561);
            this.buEditOrder.Name = "buEditOrder";
            this.buEditOrder.Size = new System.Drawing.Size(98, 23);
            this.buEditOrder.TabIndex = 4;
            this.buEditOrder.Text = "Редактировать";
            this.buEditOrder.UseVisualStyleBackColor = true;
            this.buEditOrder.Click += new System.EventHandler(this.buEdit_Click);
            // 
            // buAddOrder
            // 
            this.buAddOrder.Location = new System.Drawing.Point(517, 561);
            this.buAddOrder.Name = "buAddOrder";
            this.buAddOrder.Size = new System.Drawing.Size(75, 23);
            this.buAddOrder.TabIndex = 3;
            this.buAddOrder.Text = "Добавить";
            this.buAddOrder.UseVisualStyleBackColor = true;
            this.buAddOrder.Click += new System.EventHandler(this.tbuAdd_Click);
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.AllowUserToAddRows = false;
            this.dataGridOrders.AllowUserToDeleteRows = false;
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(3, 66);
            this.dataGridOrders.MultiSelect = false;
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.ReadOnly = true;
            this.dataGridOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrders.Size = new System.Drawing.Size(774, 489);
            this.dataGridOrders.TabIndex = 0;
            this.dataGridOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrders_CellContentClick);
            // 
            // tabpBooks
            // 
            this.tabpBooks.Controls.Add(this.buExportBooks);
            this.tabpBooks.Controls.Add(this.buFindBookReset);
            this.tabpBooks.Controls.Add(this.buDeleteBook);
            this.tabpBooks.Controls.Add(this.buEditBook);
            this.tabpBooks.Controls.Add(this.buAddBook);
            this.tabpBooks.Controls.Add(this.dataGridBooks);
            this.tabpBooks.Controls.Add(this.label6);
            this.tabpBooks.Controls.Add(this.edFindBookByName);
            this.tabpBooks.Controls.Add(this.label5);
            this.tabpBooks.Controls.Add(this.edFindBookByAuthor);
            this.tabpBooks.Location = new System.Drawing.Point(4, 22);
            this.tabpBooks.Name = "tabpBooks";
            this.tabpBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabpBooks.Size = new System.Drawing.Size(780, 590);
            this.tabpBooks.TabIndex = 1;
            this.tabpBooks.Text = "Товары";
            this.tabpBooks.UseVisualStyleBackColor = true;
            // 
            // buExportBooks
            // 
            this.buExportBooks.Location = new System.Drawing.Point(8, 561);
            this.buExportBooks.Name = "buExportBooks";
            this.buExportBooks.Size = new System.Drawing.Size(84, 23);
            this.buExportBooks.TabIndex = 16;
            this.buExportBooks.Text = "Экспорт";
            this.buExportBooks.UseVisualStyleBackColor = true;
            this.buExportBooks.Click += new System.EventHandler(this.buExportBooks_Click);
            // 
            // buFindBookReset
            // 
            this.buFindBookReset.Location = new System.Drawing.Point(697, 13);
            this.buFindBookReset.Name = "buFindBookReset";
            this.buFindBookReset.Size = new System.Drawing.Size(75, 44);
            this.buFindBookReset.TabIndex = 15;
            this.buFindBookReset.Text = "Сбросить фильтр";
            this.buFindBookReset.UseVisualStyleBackColor = true;
            this.buFindBookReset.Click += new System.EventHandler(this.buFindBookReset_Click);
            // 
            // buDeleteBook
            // 
            this.buDeleteBook.Location = new System.Drawing.Point(697, 561);
            this.buDeleteBook.Name = "buDeleteBook";
            this.buDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.buDeleteBook.TabIndex = 14;
            this.buDeleteBook.Text = "Удалить";
            this.buDeleteBook.UseVisualStyleBackColor = true;
            this.buDeleteBook.Click += new System.EventHandler(this.buDeleteBook_Click);
            // 
            // buEditBook
            // 
            this.buEditBook.Location = new System.Drawing.Point(594, 561);
            this.buEditBook.Name = "buEditBook";
            this.buEditBook.Size = new System.Drawing.Size(97, 23);
            this.buEditBook.TabIndex = 13;
            this.buEditBook.Text = "Редактировать";
            this.buEditBook.UseVisualStyleBackColor = true;
            this.buEditBook.Click += new System.EventHandler(this.buEditBook_Click);
            // 
            // buAddBook
            // 
            this.buAddBook.Location = new System.Drawing.Point(513, 561);
            this.buAddBook.Name = "buAddBook";
            this.buAddBook.Size = new System.Drawing.Size(75, 23);
            this.buAddBook.TabIndex = 12;
            this.buAddBook.Text = "Добавить";
            this.buAddBook.UseVisualStyleBackColor = true;
            this.buAddBook.Click += new System.EventHandler(this.buAddBook_Click);
            // 
            // dataGridBooks
            // 
            this.dataGridBooks.AllowUserToAddRows = false;
            this.dataGridBooks.AllowUserToDeleteRows = false;
            this.dataGridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBooks.Location = new System.Drawing.Point(0, 67);
            this.dataGridBooks.MultiSelect = false;
            this.dataGridBooks.Name = "dataGridBooks";
            this.dataGridBooks.ReadOnly = true;
            this.dataGridBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBooks.Size = new System.Drawing.Size(780, 488);
            this.dataGridBooks.TabIndex = 11;
            this.dataGridBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBooks_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Название книги:";
            // 
            // edFindBookByName
            // 
            this.edFindBookByName.Location = new System.Drawing.Point(435, 41);
            this.edFindBookByName.Name = "edFindBookByName";
            this.edFindBookByName.Size = new System.Drawing.Size(242, 20);
            this.edFindBookByName.TabIndex = 7;
            this.edFindBookByName.TextChanged += new System.EventHandler(this.buFindBook_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Автор:";
            // 
            // edFindBookByAuthor
            // 
            this.edFindBookByAuthor.Location = new System.Drawing.Point(435, 13);
            this.edFindBookByAuthor.Name = "edFindBookByAuthor";
            this.edFindBookByAuthor.Size = new System.Drawing.Size(242, 20);
            this.edFindBookByAuthor.TabIndex = 0;
            this.edFindBookByAuthor.TextChanged += new System.EventHandler(this.buFindBook_Click);
            // 
            // tabpServices
            // 
            this.tabpServices.Controls.Add(this.buServiceDelete);
            this.tabpServices.Controls.Add(this.buServiceEdit);
            this.tabpServices.Controls.Add(this.buServiceExport);
            this.tabpServices.Controls.Add(this.buServiceAdd);
            this.tabpServices.Controls.Add(this.dataGridServices);
            this.tabpServices.Location = new System.Drawing.Point(4, 22);
            this.tabpServices.Name = "tabpServices";
            this.tabpServices.Size = new System.Drawing.Size(780, 590);
            this.tabpServices.TabIndex = 3;
            this.tabpServices.Text = "Услуги";
            this.tabpServices.UseVisualStyleBackColor = true;
            // 
            // tabpClients
            // 
            this.tabpClients.Controls.Add(this.buClientsExport);
            this.tabpClients.Controls.Add(this.buDeleteClient);
            this.tabpClients.Controls.Add(this.buEditClient);
            this.tabpClients.Controls.Add(this.buAddClient);
            this.tabpClients.Controls.Add(this.dataGridClients);
            this.tabpClients.Location = new System.Drawing.Point(4, 22);
            this.tabpClients.Name = "tabpClients";
            this.tabpClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabpClients.Size = new System.Drawing.Size(780, 590);
            this.tabpClients.TabIndex = 2;
            this.tabpClients.Text = "Клиенты";
            this.tabpClients.UseVisualStyleBackColor = true;
            this.tabpClients.Click += new System.EventHandler(this.tabpClients_Click);
            // 
            // buClientsExport
            // 
            this.buClientsExport.Location = new System.Drawing.Point(8, 553);
            this.buClientsExport.Name = "buClientsExport";
            this.buClientsExport.Size = new System.Drawing.Size(75, 23);
            this.buClientsExport.TabIndex = 4;
            this.buClientsExport.Text = "Экспорт";
            this.buClientsExport.UseVisualStyleBackColor = true;
            this.buClientsExport.Click += new System.EventHandler(this.buClientsExport_Click);
            // 
            // buDeleteClient
            // 
            this.buDeleteClient.Location = new System.Drawing.Point(697, 553);
            this.buDeleteClient.Name = "buDeleteClient";
            this.buDeleteClient.Size = new System.Drawing.Size(75, 23);
            this.buDeleteClient.TabIndex = 3;
            this.buDeleteClient.Text = "Удалить";
            this.buDeleteClient.UseVisualStyleBackColor = true;
            this.buDeleteClient.Click += new System.EventHandler(this.buDeleteClient_Click);
            // 
            // buEditClient
            // 
            this.buEditClient.Location = new System.Drawing.Point(598, 553);
            this.buEditClient.Name = "buEditClient";
            this.buEditClient.Size = new System.Drawing.Size(93, 23);
            this.buEditClient.TabIndex = 2;
            this.buEditClient.Text = "Редактировать";
            this.buEditClient.UseVisualStyleBackColor = true;
            this.buEditClient.Click += new System.EventHandler(this.buEditClient_Click);
            // 
            // buAddClient
            // 
            this.buAddClient.Location = new System.Drawing.Point(517, 553);
            this.buAddClient.Name = "buAddClient";
            this.buAddClient.Size = new System.Drawing.Size(75, 23);
            this.buAddClient.TabIndex = 1;
            this.buAddClient.Text = "Добавить";
            this.buAddClient.UseVisualStyleBackColor = true;
            this.buAddClient.Click += new System.EventHandler(this.buAddClient_Click);
            // 
            // dataGridClients
            // 
            this.dataGridClients.AllowUserToAddRows = false;
            this.dataGridClients.AllowUserToDeleteRows = false;
            this.dataGridClients.AllowUserToOrderColumns = true;
            this.dataGridClients.AllowUserToResizeRows = false;
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Location = new System.Drawing.Point(0, 47);
            this.dataGridClients.MultiSelect = false;
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.ReadOnly = true;
            this.dataGridClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClients.Size = new System.Drawing.Size(780, 500);
            this.dataGridClients.TabIndex = 0;
            // 
            // tabpSklad
            // 
            this.tabpSklad.Controls.Add(this.buWhDelete);
            this.tabpSklad.Controls.Add(this.buWhEdit);
            this.tabpSklad.Controls.Add(this.buWhAdd);
            this.tabpSklad.Controls.Add(this.buWhExport);
            this.tabpSklad.Controls.Add(this.dataGridWarehouse);
            this.tabpSklad.Location = new System.Drawing.Point(4, 22);
            this.tabpSklad.Name = "tabpSklad";
            this.tabpSklad.Size = new System.Drawing.Size(780, 590);
            this.tabpSklad.TabIndex = 4;
            this.tabpSklad.Text = "Склад";
            this.tabpSklad.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUsers,
            this.miUserRoles,
            this.toolStripSeparator1,
            this.miCompany});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.файлToolStripMenuItem.Text = "Администрирование";
            // 
            // miUsers
            // 
            this.miUsers.Name = "miUsers";
            this.miUsers.Size = new System.Drawing.Size(200, 22);
            this.miUsers.Text = "Пользователи...";
            this.miUsers.Click += new System.EventHandler(this.miUsers_Click);
            // 
            // miUserRoles
            // 
            this.miUserRoles.Name = "miUserRoles";
            this.miUserRoles.Size = new System.Drawing.Size(200, 22);
            this.miUserRoles.Text = "Роли...";
            this.miUserRoles.Click += new System.EventHandler(this.miUserRoles_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miReports});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // miReports
            // 
            this.miReports.Name = "miReports";
            this.miReports.Size = new System.Drawing.Size(164, 22);
            this.miReports.Text = "Выгрузить в PDF";
            this.miReports.Click += new System.EventHandler(this.miReports_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(149, 22);
            this.miAbout.Text = "О программе";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // dataGridServices
            // 
            this.dataGridServices.AllowUserToAddRows = false;
            this.dataGridServices.AllowUserToDeleteRows = false;
            this.dataGridServices.AllowUserToResizeRows = false;
            this.dataGridServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServices.Location = new System.Drawing.Point(0, 44);
            this.dataGridServices.MultiSelect = false;
            this.dataGridServices.Name = "dataGridServices";
            this.dataGridServices.ReadOnly = true;
            this.dataGridServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridServices.Size = new System.Drawing.Size(784, 506);
            this.dataGridServices.TabIndex = 0;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // miCompany
            // 
            this.miCompany.Name = "miCompany";
            this.miCompany.Size = new System.Drawing.Size(200, 22);
            this.miCompany.Text = "Реквизиты компании...";
            this.miCompany.Click += new System.EventHandler(this.miCompany_Click);
            // 
            // buServiceAdd
            // 
            this.buServiceAdd.Location = new System.Drawing.Point(535, 559);
            this.buServiceAdd.Name = "buServiceAdd";
            this.buServiceAdd.Size = new System.Drawing.Size(75, 23);
            this.buServiceAdd.TabIndex = 2;
            this.buServiceAdd.Text = "Добавить";
            this.buServiceAdd.UseVisualStyleBackColor = true;
            this.buServiceAdd.Click += new System.EventHandler(this.buServiceAdd_Click);
            // 
            // buServiceExport
            // 
            this.buServiceExport.Location = new System.Drawing.Point(3, 559);
            this.buServiceExport.Name = "buServiceExport";
            this.buServiceExport.Size = new System.Drawing.Size(75, 23);
            this.buServiceExport.TabIndex = 3;
            this.buServiceExport.Text = "Экспорт";
            this.buServiceExport.UseVisualStyleBackColor = true;
            this.buServiceExport.Click += new System.EventHandler(this.buServiceExport_Click);
            // 
            // buServiceEdit
            // 
            this.buServiceEdit.Location = new System.Drawing.Point(616, 559);
            this.buServiceEdit.Name = "buServiceEdit";
            this.buServiceEdit.Size = new System.Drawing.Size(75, 23);
            this.buServiceEdit.TabIndex = 4;
            this.buServiceEdit.Text = "Редактировать";
            this.buServiceEdit.UseVisualStyleBackColor = true;
            this.buServiceEdit.Click += new System.EventHandler(this.buServiceEdit_Click);
            // 
            // buServiceDelete
            // 
            this.buServiceDelete.Location = new System.Drawing.Point(697, 559);
            this.buServiceDelete.Name = "buServiceDelete";
            this.buServiceDelete.Size = new System.Drawing.Size(75, 23);
            this.buServiceDelete.TabIndex = 5;
            this.buServiceDelete.Text = "Удалить";
            this.buServiceDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridWarehouse
            // 
            this.dataGridWarehouse.AllowUserToAddRows = false;
            this.dataGridWarehouse.AllowUserToDeleteRows = false;
            this.dataGridWarehouse.AllowUserToResizeRows = false;
            this.dataGridWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWarehouse.Location = new System.Drawing.Point(0, 48);
            this.dataGridWarehouse.MultiSelect = false;
            this.dataGridWarehouse.Name = "dataGridWarehouse";
            this.dataGridWarehouse.ReadOnly = true;
            this.dataGridWarehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWarehouse.Size = new System.Drawing.Size(780, 505);
            this.dataGridWarehouse.TabIndex = 0;
            // 
            // buWhExport
            // 
            this.buWhExport.Location = new System.Drawing.Point(3, 559);
            this.buWhExport.Name = "buWhExport";
            this.buWhExport.Size = new System.Drawing.Size(75, 23);
            this.buWhExport.TabIndex = 1;
            this.buWhExport.Text = "Экспорт";
            this.buWhExport.UseVisualStyleBackColor = true;
            this.buWhExport.Click += new System.EventHandler(this.buWhExport_Click);
            // 
            // buWhAdd
            // 
            this.buWhAdd.Location = new System.Drawing.Point(507, 559);
            this.buWhAdd.Name = "buWhAdd";
            this.buWhAdd.Size = new System.Drawing.Size(75, 23);
            this.buWhAdd.TabIndex = 2;
            this.buWhAdd.Text = "Добавить";
            this.buWhAdd.UseVisualStyleBackColor = true;
            this.buWhAdd.Click += new System.EventHandler(this.buWhAdd_Click);
            // 
            // buWhEdit
            // 
            this.buWhEdit.Location = new System.Drawing.Point(588, 559);
            this.buWhEdit.Name = "buWhEdit";
            this.buWhEdit.Size = new System.Drawing.Size(103, 23);
            this.buWhEdit.TabIndex = 3;
            this.buWhEdit.Text = "Редактировать";
            this.buWhEdit.UseVisualStyleBackColor = true;
            this.buWhEdit.Click += new System.EventHandler(this.buWhEdit_Click);
            // 
            // buWhDelete
            // 
            this.buWhDelete.Location = new System.Drawing.Point(697, 559);
            this.buWhDelete.Name = "buWhDelete";
            this.buWhDelete.Size = new System.Drawing.Size(75, 23);
            this.buWhDelete.TabIndex = 4;
            this.buWhDelete.Text = "Удалить";
            this.buWhDelete.UseVisualStyleBackColor = true;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 640);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.tab.ResumeLayout(false);
            this.tabpOrders.ResumeLayout(false);
            this.tabpOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            this.tabpBooks.ResumeLayout(false);
            this.tabpBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).EndInit();
            this.tabpServices.ResumeLayout(false);
            this.tabpClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            this.tabpSklad.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabpOrders;
        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.TabPage tabpBooks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripMenuItem miUsers;
        private System.Windows.Forms.TabPage tabpClients;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edFindBookByName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edFindBookByAuthor;
        private System.Windows.Forms.DataGridView dataGridBooks;
        private System.Windows.Forms.Button buDeleteOrder;
        private System.Windows.Forms.Button buEditOrder;
        private System.Windows.Forms.Button buAddOrder;
        private System.Windows.Forms.Button buDeleteBook;
        private System.Windows.Forms.Button buEditBook;
        private System.Windows.Forms.Button buAddBook;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miReports;
        private System.Windows.Forms.ToolStripMenuItem miUserRoles;
        private System.Windows.Forms.Button buFindBookReset;
        private System.Windows.Forms.Button buFindOrderReset;
        private System.Windows.Forms.DateTimePicker dtOrderTo;
        private System.Windows.Forms.DateTimePicker dtOrderFrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buDeleteClient;
        private System.Windows.Forms.Button buEditClient;
        private System.Windows.Forms.Button buAddClient;
        private System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.TabPage tabpServices;
        private System.Windows.Forms.Button buExportBooks;
        private System.Windows.Forms.Button buClientsExport;
        private System.Windows.Forms.Button buOrdersExport;
        private System.Windows.Forms.TabPage tabpSklad;
        private System.Windows.Forms.DataGridView dataGridServices;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miCompany;
        private System.Windows.Forms.Button buServiceDelete;
        private System.Windows.Forms.Button buServiceEdit;
        private System.Windows.Forms.Button buServiceExport;
        private System.Windows.Forms.Button buServiceAdd;
        private System.Windows.Forms.DataGridView dataGridWarehouse;
        private System.Windows.Forms.Button buWhDelete;
        private System.Windows.Forms.Button buWhEdit;
        private System.Windows.Forms.Button buWhAdd;
        private System.Windows.Forms.Button buWhExport;
    }
}