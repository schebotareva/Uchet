namespace WindowsFormsApplication1
{
    partial class fmOrderCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.buCancel = new System.Windows.Forms.Button();
            this.dataGridBooks = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buDelete = new System.Windows.Forms.Button();
            this.buAdd = new System.Windows.Forms.Button();
            this.medOrderNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFIO = new System.Windows.Forms.Label();
            this.buSelectClient = new System.Windows.Forms.Button();
            this.butOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер заказа";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buCancel
            // 
            this.buCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buCancel.Location = new System.Drawing.Point(606, 481);
            this.buCancel.Name = "buCancel";
            this.buCancel.Size = new System.Drawing.Size(82, 23);
            this.buCancel.TabIndex = 7;
            this.buCancel.Text = "Отмена";
            this.buCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridBooks
            // 
            this.dataGridBooks.AllowUserToAddRows = false;
            this.dataGridBooks.AllowUserToDeleteRows = false;
            this.dataGridBooks.AllowUserToResizeRows = false;
            this.dataGridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBooks.Location = new System.Drawing.Point(16, 19);
            this.dataGridBooks.Name = "dataGridBooks";
            this.dataGridBooks.ReadOnly = true;
            this.dataGridBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBooks.Size = new System.Drawing.Size(552, 269);
            this.dataGridBooks.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buDelete);
            this.groupBox1.Controls.Add(this.buAdd);
            this.groupBox1.Controls.Add(this.dataGridBooks);
            this.groupBox1.Location = new System.Drawing.Point(11, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 307);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Товары";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buDelete
            // 
            this.buDelete.Location = new System.Drawing.Point(574, 48);
            this.buDelete.Name = "buDelete";
            this.buDelete.Size = new System.Drawing.Size(96, 23);
            this.buDelete.TabIndex = 11;
            this.buDelete.Text = "Удалить";
            this.buDelete.UseVisualStyleBackColor = true;
            this.buDelete.Click += new System.EventHandler(this.buDelete_Click);
            // 
            // buAdd
            // 
            this.buAdd.Location = new System.Drawing.Point(574, 19);
            this.buAdd.Name = "buAdd";
            this.buAdd.Size = new System.Drawing.Size(96, 23);
            this.buAdd.TabIndex = 9;
            this.buAdd.Text = "Добавить";
            this.buAdd.UseVisualStyleBackColor = true;
            this.buAdd.Click += new System.EventHandler(this.buAdd_Click);
            // 
            // medOrderNumber
            // 
            this.medOrderNumber.Location = new System.Drawing.Point(122, 14);
            this.medOrderNumber.Mask = "LL-000000000000000";
            this.medOrderNumber.Name = "medOrderNumber";
            this.medOrderNumber.Size = new System.Drawing.Size(250, 20);
            this.medOrderNumber.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Покупатель";
            // 
            // lblFIO
            // 
            this.lblFIO.AutoSize = true;
            this.lblFIO.Location = new System.Drawing.Point(119, 45);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(66, 13);
            this.lblFIO.TabIndex = 15;
            this.lblFIO.Text = "(не выбран)";
            // 
            // buSelectClient
            // 
            this.buSelectClient.Location = new System.Drawing.Point(297, 40);
            this.buSelectClient.Name = "buSelectClient";
            this.buSelectClient.Size = new System.Drawing.Size(75, 23);
            this.buSelectClient.TabIndex = 16;
            this.buSelectClient.Text = "Выбрать";
            this.buSelectClient.UseVisualStyleBackColor = true;
            this.buSelectClient.Click += new System.EventHandler(this.buSelectClient_Click);
            // 
            // butOK
            // 
            this.butOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butOK.Location = new System.Drawing.Point(525, 481);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 17;
            this.butOK.Text = "ОК";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Скидка, %:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Сумма заказа, руб.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Сумма со скидкой, руб:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "1300";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscount.ForeColor = System.Drawing.Color.Red;
            this.lblDiscount.Location = new System.Drawing.Point(137, 112);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(21, 13);
            this.lblDiscount.TabIndex = 20;
            this.lblDiscount.Text = "13";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(137, 89);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(31, 13);
            this.lblSum.TabIndex = 21;
            this.lblSum.Text = "1500";
            // 
            // fmOrderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buCancel;
            this.ClientSize = new System.Drawing.Size(699, 516);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.buSelectClient);
            this.Controls.Add(this.lblFIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.medOrderNumber);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buCancel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmOrderCard";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buCancel;
        private System.Windows.Forms.DataGridView dataGridBooks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox medOrderNumber;
        private System.Windows.Forms.Button buDelete;
        private System.Windows.Forms.Button buAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buSelectClient;
        private System.Windows.Forms.Button butOK;
        public System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSum;
    }
}