namespace WindowsFormsApplication1
{
    partial class fmUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edLastName = new System.Windows.Forms.TextBox();
            this.edFirstName = new System.Windows.Forms.TextBox();
            this.edMiddleName = new System.Windows.Forms.TextBox();
            this.buOK = new System.Windows.Forms.Button();
            this.cbUserRole = new System.Windows.Forms.ComboBox();
            this.edPosition = new System.Windows.Forms.TextBox();
            this.buCancel = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPasswordStatus = new System.Windows.Forms.Label();
            this.buSetPassword = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edPhone = new System.Windows.Forms.MaskedTextBox();
            this.cxBlocked = new System.Windows.Forms.CheckBox();
            this.edUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Должность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Роль";
            // 
            // edLastName
            // 
            this.edLastName.Location = new System.Drawing.Point(84, 23);
            this.edLastName.Name = "edLastName";
            this.edLastName.Size = new System.Drawing.Size(259, 20);
            this.edLastName.TabIndex = 7;
            // 
            // edFirstName
            // 
            this.edFirstName.Location = new System.Drawing.Point(84, 49);
            this.edFirstName.Name = "edFirstName";
            this.edFirstName.Size = new System.Drawing.Size(259, 20);
            this.edFirstName.TabIndex = 8;
            // 
            // edMiddleName
            // 
            this.edMiddleName.Location = new System.Drawing.Point(84, 74);
            this.edMiddleName.Name = "edMiddleName";
            this.edMiddleName.Size = new System.Drawing.Size(259, 20);
            this.edMiddleName.TabIndex = 9;
            // 
            // buOK
            // 
            this.buOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buOK.Location = new System.Drawing.Point(187, 351);
            this.buOK.Name = "buOK";
            this.buOK.Size = new System.Drawing.Size(75, 23);
            this.buOK.TabIndex = 14;
            this.buOK.Text = "ОК";
            this.buOK.UseVisualStyleBackColor = true;
            this.buOK.Click += new System.EventHandler(this.buOK_Click);
            // 
            // cbUserRole
            // 
            this.cbUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserRole.FormattingEnabled = true;
            this.cbUserRole.Location = new System.Drawing.Point(84, 249);
            this.cbUserRole.Name = "cbUserRole";
            this.cbUserRole.Size = new System.Drawing.Size(259, 21);
            this.cbUserRole.TabIndex = 15;
            // 
            // edPosition
            // 
            this.edPosition.Location = new System.Drawing.Point(84, 128);
            this.edPosition.Name = "edPosition";
            this.edPosition.Size = new System.Drawing.Size(259, 20);
            this.edPosition.TabIndex = 16;
            // 
            // buCancel
            // 
            this.buCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buCancel.Location = new System.Drawing.Point(268, 351);
            this.buCancel.Name = "buCancel";
            this.buCancel.Size = new System.Drawing.Size(75, 23);
            this.buCancel.TabIndex = 17;
            this.buCancel.Text = "Отмена";
            this.buCancel.UseVisualStyleBackColor = true;
            this.buCancel.Click += new System.EventHandler(this.buCancel_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(84, 276);
            this.textBox7.Name = "textBox7";
            this.textBox7.PasswordChar = '●';
            this.textBox7.Size = new System.Drawing.Size(259, 20);
            this.textBox7.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Пароль";
            // 
            // lblPasswordStatus
            // 
            this.lblPasswordStatus.AutoSize = true;
            this.lblPasswordStatus.Location = new System.Drawing.Point(84, 314);
            this.lblPasswordStatus.Name = "lblPasswordStatus";
            this.lblPasswordStatus.Size = new System.Drawing.Size(35, 13);
            this.lblPasswordStatus.TabIndex = 20;
            this.lblPasswordStatus.Text = "label9";
            // 
            // buSetPassword
            // 
            this.buSetPassword.Location = new System.Drawing.Point(214, 309);
            this.buSetPassword.Name = "buSetPassword";
            this.buSetPassword.Size = new System.Drawing.Size(129, 23);
            this.buSetPassword.TabIndex = 21;
            this.buSetPassword.Text = "Установить пароль...";
            this.buSetPassword.UseVisualStyleBackColor = true;
            this.buSetPassword.Click += new System.EventHandler(this.buSetPassword_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Пароль";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edPhone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.edLastName);
            this.groupBox1.Controls.Add(this.edPosition);
            this.groupBox1.Controls.Add(this.edFirstName);
            this.groupBox1.Controls.Add(this.edMiddleName);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 163);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Контактные данные";
            // 
            // edPhone
            // 
            this.edPhone.Location = new System.Drawing.Point(84, 100);
            this.edPhone.Mask = "(999) 000-0000";
            this.edPhone.Name = "edPhone";
            this.edPhone.Size = new System.Drawing.Size(259, 20);
            this.edPhone.TabIndex = 24;
            // 
            // cxBlocked
            // 
            this.cxBlocked.AutoSize = true;
            this.cxBlocked.Location = new System.Drawing.Point(16, 192);
            this.cxBlocked.Name = "cxBlocked";
            this.cxBlocked.Size = new System.Drawing.Size(64, 17);
            this.cxBlocked.TabIndex = 25;
            this.cxBlocked.Text = "Уволен";
            this.cxBlocked.UseVisualStyleBackColor = true;
            // 
            // edUserName
            // 
            this.edUserName.Location = new System.Drawing.Point(84, 223);
            this.edUserName.Name = "edUserName";
            this.edUserName.Size = new System.Drawing.Size(259, 20);
            this.edUserName.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Логин:";
            // 
            // fmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 386);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edUserName);
            this.Controls.Add(this.cxBlocked);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buSetPassword);
            this.Controls.Add(this.lblPasswordStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.buCancel);
            this.Controls.Add(this.cbUserRole);
            this.Controls.Add(this.buOK);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmUser";
            this.Text = "Пользователь";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edLastName;
        private System.Windows.Forms.TextBox edFirstName;
        private System.Windows.Forms.TextBox edMiddleName;
        private System.Windows.Forms.Button buOK;
        private System.Windows.Forms.ComboBox cbUserRole;
        private System.Windows.Forms.TextBox edPosition;
        private System.Windows.Forms.Button buCancel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPasswordStatus;
        private System.Windows.Forms.Button buSetPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox edPhone;
        private System.Windows.Forms.CheckBox cxBlocked;
        private System.Windows.Forms.TextBox edUserName;
        private System.Windows.Forms.Label label4;
    }
}