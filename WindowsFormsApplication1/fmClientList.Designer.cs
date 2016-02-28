namespace WindowsFormsApplication1
{
    partial class fmClientList
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
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.buSelectClient = new System.Windows.Forms.Button();
            this.buCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClients
            // 
            this.dataGridClients.AllowUserToAddRows = false;
            this.dataGridClients.AllowUserToDeleteRows = false;
            this.dataGridClients.AllowUserToResizeRows = false;
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Location = new System.Drawing.Point(12, 12);
            this.dataGridClients.MultiSelect = false;
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.ReadOnly = true;
            this.dataGridClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClients.Size = new System.Drawing.Size(704, 359);
            this.dataGridClients.TabIndex = 0;
            this.dataGridClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClients_CellDoubleClick);
            // 
            // buSelectClient
            // 
            this.buSelectClient.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buSelectClient.Location = new System.Drawing.Point(12, 377);
            this.buSelectClient.Name = "buSelectClient";
            this.buSelectClient.Size = new System.Drawing.Size(75, 23);
            this.buSelectClient.TabIndex = 4;
            this.buSelectClient.Text = "Выбрать";
            this.buSelectClient.UseVisualStyleBackColor = true;
            this.buSelectClient.Click += new System.EventHandler(this.buSelectClient_Click);
            // 
            // buCancel
            // 
            this.buCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buCancel.Location = new System.Drawing.Point(641, 377);
            this.buCancel.Name = "buCancel";
            this.buCancel.Size = new System.Drawing.Size(75, 23);
            this.buCancel.TabIndex = 5;
            this.buCancel.Text = "Закрыть";
            this.buCancel.UseVisualStyleBackColor = true;
            // 
            // fmClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 412);
            this.Controls.Add(this.buCancel);
            this.Controls.Add(this.buSelectClient);
            this.Controls.Add(this.dataGridClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmClientList";
            this.Text = "Список клиентов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.Button buSelectClient;
        private System.Windows.Forms.Button buCancel;
    }
}