namespace WindowsFormsApplication1
{
    partial class fmAutorList
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
            this.buSelect = new System.Windows.Forms.Button();
            this.dataGridAuthors = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // buSelect
            // 
            this.buSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buSelect.Location = new System.Drawing.Point(12, 276);
            this.buSelect.Name = "buSelect";
            this.buSelect.Size = new System.Drawing.Size(75, 23);
            this.buSelect.TabIndex = 0;
            this.buSelect.Text = "Выбрать";
            this.buSelect.UseVisualStyleBackColor = true;
            this.buSelect.Click += new System.EventHandler(this.buSelect_Click);
            // 
            // dataGridAuthors
            // 
            this.dataGridAuthors.AllowUserToAddRows = false;
            this.dataGridAuthors.AllowUserToDeleteRows = false;
            this.dataGridAuthors.AllowUserToResizeRows = false;
            this.dataGridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAuthors.Location = new System.Drawing.Point(12, 12);
            this.dataGridAuthors.MultiSelect = false;
            this.dataGridAuthors.Name = "dataGridAuthors";
            this.dataGridAuthors.ReadOnly = true;
            this.dataGridAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAuthors.Size = new System.Drawing.Size(438, 258);
            this.dataGridAuthors.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(375, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fmAutorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridAuthors);
            this.Controls.Add(this.buSelect);
            this.Name = "fmAutorList";
            this.Text = "Список авторов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buSelect;
        private System.Windows.Forms.DataGridView dataGridAuthors;
        private System.Windows.Forms.Button button1;
    }
}