namespace WindowsFormsApplication1
{
    partial class fmUserRoleList
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
            this.buAdd = new System.Windows.Forms.Button();
            this.buEdit = new System.Windows.Forms.Button();
            this.buRemove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buAdd
            // 
            this.buAdd.Location = new System.Drawing.Point(569, 426);
            this.buAdd.Name = "buAdd";
            this.buAdd.Size = new System.Drawing.Size(75, 23);
            this.buAdd.TabIndex = 0;
            this.buAdd.Text = "Добавить";
            this.buAdd.UseVisualStyleBackColor = true;
            this.buAdd.Click += new System.EventHandler(this.buAdd_Click);
            // 
            // buEdit
            // 
            this.buEdit.Location = new System.Drawing.Point(650, 426);
            this.buEdit.Name = "buEdit";
            this.buEdit.Size = new System.Drawing.Size(96, 23);
            this.buEdit.TabIndex = 1;
            this.buEdit.Text = "Редактировать";
            this.buEdit.UseVisualStyleBackColor = true;
            this.buEdit.Click += new System.EventHandler(this.buEdit_Click);
            // 
            // buRemove
            // 
            this.buRemove.Location = new System.Drawing.Point(752, 426);
            this.buRemove.Name = "buRemove";
            this.buRemove.Size = new System.Drawing.Size(75, 23);
            this.buRemove.TabIndex = 2;
            this.buRemove.Text = "Удалить";
            this.buRemove.UseVisualStyleBackColor = true;
            this.buRemove.Click += new System.EventHandler(this.buRemove_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(815, 408);
            this.dataGridView1.TabIndex = 3;
            // 
            // fmUserRoleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buRemove);
            this.Controls.Add(this.buEdit);
            this.Controls.Add(this.buAdd);
            this.Name = "fmUserRoleList";
            this.Text = "Список ролей пользователей";
            this.Load += new System.EventHandler(this.fmUserRoleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buAdd;
        private System.Windows.Forms.Button buEdit;
        private System.Windows.Forms.Button buRemove;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}