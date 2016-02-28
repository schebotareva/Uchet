namespace WindowsFormsApplication1
{
    partial class fmBook
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
            this.cbPublisher = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridAuthors = new System.Windows.Forms.DataGridView();
            this.buAddAuthor = new System.Windows.Forms.Button();
            this.buDeleteAuthor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbOriginalName = new System.Windows.Forms.TextBox();
            this.tbDSC = new System.Windows.Forms.TextBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buOK = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbISBN = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblPriceNotif = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPublisher
            // 
            this.cbPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPublisher.FormattingEnabled = true;
            this.cbPublisher.Location = new System.Drawing.Point(128, 332);
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.Size = new System.Drawing.Size(187, 21);
            this.cbPublisher.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Издательство:";
            // 
            // dataGridAuthors
            // 
            this.dataGridAuthors.AllowUserToAddRows = false;
            this.dataGridAuthors.AllowUserToDeleteRows = false;
            this.dataGridAuthors.AllowUserToResizeRows = false;
            this.dataGridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAuthors.Location = new System.Drawing.Point(10, 19);
            this.dataGridAuthors.MultiSelect = false;
            this.dataGridAuthors.Name = "dataGridAuthors";
            this.dataGridAuthors.ReadOnly = true;
            this.dataGridAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAuthors.Size = new System.Drawing.Size(412, 131);
            this.dataGridAuthors.TabIndex = 10;
            // 
            // buAddAuthor
            // 
            this.buAddAuthor.Location = new System.Drawing.Point(270, 159);
            this.buAddAuthor.Name = "buAddAuthor";
            this.buAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.buAddAuthor.TabIndex = 12;
            this.buAddAuthor.Text = "Добавить";
            this.buAddAuthor.UseVisualStyleBackColor = true;
            this.buAddAuthor.Click += new System.EventHandler(this.buAddAuthor_Click);
            // 
            // buDeleteAuthor
            // 
            this.buDeleteAuthor.Location = new System.Drawing.Point(347, 159);
            this.buDeleteAuthor.Name = "buDeleteAuthor";
            this.buDeleteAuthor.Size = new System.Drawing.Size(75, 23);
            this.buDeleteAuthor.TabIndex = 14;
            this.buDeleteAuthor.Text = "Удалить";
            this.buDeleteAuthor.UseVisualStyleBackColor = true;
            this.buDeleteAuthor.Click += new System.EventHandler(this.buDeleteAuthor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Год:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Название:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ориг. название:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(128, 11);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(187, 20);
            this.tbName.TabIndex = 22;
            // 
            // tbOriginalName
            // 
            this.tbOriginalName.Location = new System.Drawing.Point(128, 37);
            this.tbOriginalName.Name = "tbOriginalName";
            this.tbOriginalName.Size = new System.Drawing.Size(187, 20);
            this.tbOriginalName.TabIndex = 23;
            // 
            // tbDSC
            // 
            this.tbDSC.Location = new System.Drawing.Point(12, 453);
            this.tbDSC.MaxLength = 4000;
            this.tbDSC.Multiline = true;
            this.tbDSC.Name = "tbDSC";
            this.tbDSC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDSC.Size = new System.Drawing.Size(437, 129);
            this.tbDSC.TabIndex = 25;
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(128, 305);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(187, 21);
            this.cbYear.TabIndex = 26;
            // 
            // cbGenre
            // 
            this.cbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(128, 278);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(187, 21);
            this.cbGenre.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Главный жанр:";
            // 
            // buOK
            // 
            this.buOK.Location = new System.Drawing.Point(291, 588);
            this.buOK.Name = "buOK";
            this.buOK.Size = new System.Drawing.Size(75, 23);
            this.buOK.TabIndex = 29;
            this.buOK.Text = "ОК";
            this.buOK.UseVisualStyleBackColor = true;
            this.buOK.Click += new System.EventHandler(this.buOK_Click);
            // 
            // button5
            // 
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Location = new System.Drawing.Point(372, 588);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "Отмена";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "ISBN:";
            // 
            // mtbISBN
            // 
            this.mtbISBN.Location = new System.Drawing.Point(128, 360);
            this.mtbISBN.Name = "mtbISBN";
            this.mtbISBN.Size = new System.Drawing.Size(187, 20);
            this.mtbISBN.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Описание:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(128, 386);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(187, 20);
            this.tbPrice.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Цена:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(321, 389);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(126, 13);
            this.lblPrice.TabIndex = 36;
            this.lblPrice.Text = "Необходимо заполнить";
            this.lblPrice.Visible = false;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.ForeColor = System.Drawing.Color.Red;
            this.lblISBN.Location = new System.Drawing.Point(321, 363);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(126, 13);
            this.lblISBN.TabIndex = 37;
            this.lblISBN.Text = "Необходимо заполнить";
            this.lblISBN.Visible = false;
            // 
            // lblPriceNotif
            // 
            this.lblPriceNotif.AutoSize = true;
            this.lblPriceNotif.Location = new System.Drawing.Point(331, 389);
            this.lblPriceNotif.Name = "lblPriceNotif";
            this.lblPriceNotif.Size = new System.Drawing.Size(0, 13);
            this.lblPriceNotif.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridAuthors);
            this.groupBox1.Controls.Add(this.buAddAuthor);
            this.groupBox1.Controls.Add(this.buDeleteAuthor);
            this.groupBox1.Location = new System.Drawing.Point(10, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 190);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторы";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(321, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 13);
            this.lblName.TabIndex = 40;
            this.lblName.Text = "Необходимо заполнить";
            this.lblName.Visible = false;
            // 
            // fmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 616);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPriceNotif);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbOriginalName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtbISBN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.tbDSC);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPublisher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmBook";
            this.Text = "Книга";
            this.Load += new System.EventHandler(this.fmBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPublisher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buDeleteAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbOriginalName;
        private System.Windows.Forms.TextBox tbDSC;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buOK;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbISBN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button buAddAuthor;
        public System.Windows.Forms.DataGridView dataGridAuthors;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblPriceNotif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
    }
}