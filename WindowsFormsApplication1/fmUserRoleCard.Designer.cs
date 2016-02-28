namespace WindowsFormsApplication1
{
    partial class fmUserRoleCard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.Заказы = new System.Windows.Forms.GroupBox();
            this.cxOrderDelete = new System.Windows.Forms.CheckBox();
            this.cxOrderEdit = new System.Windows.Forms.CheckBox();
            this.cxOrderView = new System.Windows.Forms.CheckBox();
            this.cxOrderCreate = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cxClientDelete = new System.Windows.Forms.CheckBox();
            this.cxClientEdit = new System.Windows.Forms.CheckBox();
            this.cxClientCreate = new System.Windows.Forms.CheckBox();
            this.cxClientView = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cxBookDelete = new System.Windows.Forms.CheckBox();
            this.cxBookEdit = new System.Windows.Forms.CheckBox();
            this.cxBookCreate = new System.Windows.Forms.CheckBox();
            this.cxBookView = new System.Windows.Forms.CheckBox();
            this.buOK = new System.Windows.Forms.Button();
            this.buCancel = new System.Windows.Forms.Button();
            this.edUserRoleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Заказы.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox15);
            this.groupBox1.Controls.Add(this.checkBox16);
            this.groupBox1.Location = new System.Drawing.Point(12, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(15, 19);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(157, 17);
            this.checkBox15.TabIndex = 12;
            this.checkBox15.Text = "Право администрировать";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(15, 42);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(154, 17);
            this.checkBox16.TabIndex = 13;
            this.checkBox16.Text = "Право выгружать отчеты";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // Заказы
            // 
            this.Заказы.Controls.Add(this.cxOrderDelete);
            this.Заказы.Controls.Add(this.cxOrderEdit);
            this.Заказы.Controls.Add(this.cxOrderView);
            this.Заказы.Controls.Add(this.cxOrderCreate);
            this.Заказы.Location = new System.Drawing.Point(12, 46);
            this.Заказы.Name = "Заказы";
            this.Заказы.Size = new System.Drawing.Size(314, 117);
            this.Заказы.TabIndex = 1;
            this.Заказы.TabStop = false;
            this.Заказы.Text = "Заказы";
            // 
            // cxOrderDelete
            // 
            this.cxOrderDelete.AutoSize = true;
            this.cxOrderDelete.Location = new System.Drawing.Point(15, 88);
            this.cxOrderDelete.Name = "cxOrderDelete";
            this.cxOrderDelete.Size = new System.Drawing.Size(76, 17);
            this.cxOrderDelete.TabIndex = 8;
            this.cxOrderDelete.Text = "Удаление";
            this.cxOrderDelete.UseVisualStyleBackColor = true;
            // 
            // cxOrderEdit
            // 
            this.cxOrderEdit.AutoSize = true;
            this.cxOrderEdit.Location = new System.Drawing.Point(15, 65);
            this.cxOrderEdit.Name = "cxOrderEdit";
            this.cxOrderEdit.Size = new System.Drawing.Size(110, 17);
            this.cxOrderEdit.TabIndex = 5;
            this.cxOrderEdit.Text = "Редактирование";
            this.cxOrderEdit.UseVisualStyleBackColor = true;
            // 
            // cxOrderView
            // 
            this.cxOrderView.AutoSize = true;
            this.cxOrderView.Location = new System.Drawing.Point(15, 19);
            this.cxOrderView.Name = "cxOrderView";
            this.cxOrderView.Size = new System.Drawing.Size(166, 17);
            this.cxOrderView.TabIndex = 6;
            this.cxOrderView.Text = "Просмотр реестра заказов";
            this.cxOrderView.UseVisualStyleBackColor = true;
            // 
            // cxOrderCreate
            // 
            this.cxOrderCreate.AutoSize = true;
            this.cxOrderCreate.Location = new System.Drawing.Point(15, 42);
            this.cxOrderCreate.Name = "cxOrderCreate";
            this.cxOrderCreate.Size = new System.Drawing.Size(75, 17);
            this.cxOrderCreate.TabIndex = 7;
            this.cxOrderCreate.Text = "Создание";
            this.cxOrderCreate.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cxClientDelete);
            this.groupBox4.Controls.Add(this.cxClientEdit);
            this.groupBox4.Controls.Add(this.cxClientCreate);
            this.groupBox4.Controls.Add(this.cxClientView);
            this.groupBox4.Location = new System.Drawing.Point(12, 169);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 112);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Клиенты";
            // 
            // cxClientDelete
            // 
            this.cxClientDelete.AutoSize = true;
            this.cxClientDelete.Location = new System.Drawing.Point(15, 89);
            this.cxClientDelete.Name = "cxClientDelete";
            this.cxClientDelete.Size = new System.Drawing.Size(76, 17);
            this.cxClientDelete.TabIndex = 4;
            this.cxClientDelete.Text = "Удаление";
            this.cxClientDelete.UseVisualStyleBackColor = true;
            // 
            // cxClientEdit
            // 
            this.cxClientEdit.AutoSize = true;
            this.cxClientEdit.Location = new System.Drawing.Point(15, 64);
            this.cxClientEdit.Name = "cxClientEdit";
            this.cxClientEdit.Size = new System.Drawing.Size(239, 17);
            this.cxClientEdit.TabIndex = 3;
            this.cxClientEdit.Text = "Редактирование существующих клиентов";
            this.cxClientEdit.UseVisualStyleBackColor = true;
            // 
            // cxClientCreate
            // 
            this.cxClientCreate.AutoSize = true;
            this.cxClientCreate.Location = new System.Drawing.Point(15, 42);
            this.cxClientCreate.Name = "cxClientCreate";
            this.cxClientCreate.Size = new System.Drawing.Size(173, 17);
            this.cxClientCreate.TabIndex = 2;
            this.cxClientCreate.Text = "Добавление новых клиентов";
            this.cxClientCreate.UseVisualStyleBackColor = true;
            // 
            // cxClientView
            // 
            this.cxClientView.AutoSize = true;
            this.cxClientView.Location = new System.Drawing.Point(15, 19);
            this.cxClientView.Name = "cxClientView";
            this.cxClientView.Size = new System.Drawing.Size(171, 17);
            this.cxClientView.TabIndex = 0;
            this.cxClientView.Text = "Просмотр реестра клиентов";
            this.cxClientView.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cxBookDelete);
            this.groupBox5.Controls.Add(this.cxBookEdit);
            this.groupBox5.Controls.Add(this.cxBookCreate);
            this.groupBox5.Controls.Add(this.cxBookView);
            this.groupBox5.Location = new System.Drawing.Point(12, 287);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(314, 111);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Книги";
            // 
            // cxBookDelete
            // 
            this.cxBookDelete.AutoSize = true;
            this.cxBookDelete.Location = new System.Drawing.Point(15, 88);
            this.cxBookDelete.Name = "cxBookDelete";
            this.cxBookDelete.Size = new System.Drawing.Size(76, 17);
            this.cxBookDelete.TabIndex = 1;
            this.cxBookDelete.Text = "Удаление";
            this.cxBookDelete.UseVisualStyleBackColor = true;
            // 
            // cxBookEdit
            // 
            this.cxBookEdit.AutoSize = true;
            this.cxBookEdit.Location = new System.Drawing.Point(15, 65);
            this.cxBookEdit.Name = "cxBookEdit";
            this.cxBookEdit.Size = new System.Drawing.Size(215, 17);
            this.cxBookEdit.TabIndex = 2;
            this.cxBookEdit.Text = "Редактирование существующих книг";
            this.cxBookEdit.UseVisualStyleBackColor = true;
            // 
            // cxBookCreate
            // 
            this.cxBookCreate.AutoSize = true;
            this.cxBookCreate.Location = new System.Drawing.Point(15, 42);
            this.cxBookCreate.Name = "cxBookCreate";
            this.cxBookCreate.Size = new System.Drawing.Size(149, 17);
            this.cxBookCreate.TabIndex = 3;
            this.cxBookCreate.Text = "Добавление новых книг";
            this.cxBookCreate.UseVisualStyleBackColor = true;
            // 
            // cxBookView
            // 
            this.cxBookView.AutoSize = true;
            this.cxBookView.Location = new System.Drawing.Point(15, 19);
            this.cxBookView.Name = "cxBookView";
            this.cxBookView.Size = new System.Drawing.Size(147, 17);
            this.cxBookView.TabIndex = 4;
            this.cxBookView.Text = "Просмотр реестра книг";
            this.cxBookView.UseVisualStyleBackColor = true;
            // 
            // buOK
            // 
            this.buOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buOK.Location = new System.Drawing.Point(170, 560);
            this.buOK.Name = "buOK";
            this.buOK.Size = new System.Drawing.Size(75, 23);
            this.buOK.TabIndex = 8;
            this.buOK.Text = "ОК";
            this.buOK.UseVisualStyleBackColor = true;
            this.buOK.Click += new System.EventHandler(this.buOK_Click);
            // 
            // buCancel
            // 
            this.buCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buCancel.Location = new System.Drawing.Point(251, 560);
            this.buCancel.Name = "buCancel";
            this.buCancel.Size = new System.Drawing.Size(75, 23);
            this.buCancel.TabIndex = 9;
            this.buCancel.Text = "Отмена";
            this.buCancel.UseVisualStyleBackColor = true;
            // 
            // edUserRoleName
            // 
            this.edUserRoleName.Location = new System.Drawing.Point(73, 12);
            this.edUserRoleName.Name = "edUserRoleName";
            this.edUserRoleName.Size = new System.Drawing.Size(253, 20);
            this.edUserRoleName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Имя роли:";
            // 
            // fmUserRoleCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edUserRoleName);
            this.Controls.Add(this.buOK);
            this.Controls.Add(this.buCancel);
            this.Controls.Add(this.Заказы);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "fmUserRoleCard";
            this.Text = "Настройка роли пользователя";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Заказы.ResumeLayout(false);
            this.Заказы.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Заказы;
        private System.Windows.Forms.CheckBox cxOrderDelete;
        private System.Windows.Forms.CheckBox cxOrderEdit;
        private System.Windows.Forms.CheckBox cxOrderView;
        private System.Windows.Forms.CheckBox cxOrderCreate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cxClientDelete;
        private System.Windows.Forms.CheckBox cxClientEdit;
        private System.Windows.Forms.CheckBox cxClientCreate;
        private System.Windows.Forms.CheckBox cxClientView;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cxBookDelete;
        private System.Windows.Forms.CheckBox cxBookEdit;
        private System.Windows.Forms.CheckBox cxBookCreate;
        private System.Windows.Forms.CheckBox cxBookView;
        private System.Windows.Forms.Button buOK;
        private System.Windows.Forms.Button buCancel;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.TextBox edUserRoleName;
        private System.Windows.Forms.Label label1;
    }
}