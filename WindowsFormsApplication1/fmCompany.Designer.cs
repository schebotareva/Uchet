namespace WindowsFormsApplication1
{
    partial class fmCompany
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
            this.tbKPP = new System.Windows.Forms.TextBox();
            this.tbINN = new System.Windows.Forms.TextBox();
            this.tbClearingAccount = new System.Windows.Forms.TextBox();
            this.tbCorrespondentAccount = new System.Windows.Forms.TextBox();
            this.tbLegalAddress = new System.Windows.Forms.TextBox();
            this.tbLegalName = new System.Windows.Forms.TextBox();
            this.buOK = new System.Windows.Forms.Button();
            this.buCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // tbKPP
            // 
            this.tbKPP.Location = new System.Drawing.Point(156, 168);
            this.tbKPP.Name = "tbKPP";
            this.tbKPP.Size = new System.Drawing.Size(204, 20);
            this.tbKPP.TabIndex = 1;
            // 
            // tbINN
            // 
            this.tbINN.Location = new System.Drawing.Point(156, 142);
            this.tbINN.Name = "tbINN";
            this.tbINN.Size = new System.Drawing.Size(204, 20);
            this.tbINN.TabIndex = 2;
            // 
            // tbClearingAccount
            // 
            this.tbClearingAccount.Location = new System.Drawing.Point(156, 116);
            this.tbClearingAccount.Name = "tbClearingAccount";
            this.tbClearingAccount.Size = new System.Drawing.Size(204, 20);
            this.tbClearingAccount.TabIndex = 3;
            // 
            // tbCorrespondentAccount
            // 
            this.tbCorrespondentAccount.Location = new System.Drawing.Point(156, 90);
            this.tbCorrespondentAccount.Name = "tbCorrespondentAccount";
            this.tbCorrespondentAccount.Size = new System.Drawing.Size(204, 20);
            this.tbCorrespondentAccount.TabIndex = 4;
            // 
            // tbLegalAddress
            // 
            this.tbLegalAddress.Location = new System.Drawing.Point(156, 38);
            this.tbLegalAddress.Name = "tbLegalAddress";
            this.tbLegalAddress.Size = new System.Drawing.Size(204, 20);
            this.tbLegalAddress.TabIndex = 6;
            // 
            // tbLegalName
            // 
            this.tbLegalName.Location = new System.Drawing.Point(156, 12);
            this.tbLegalName.Name = "tbLegalName";
            this.tbLegalName.Size = new System.Drawing.Size(204, 20);
            this.tbLegalName.TabIndex = 7;
            // 
            // buOK
            // 
            this.buOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buOK.Location = new System.Drawing.Point(204, 213);
            this.buOK.Name = "buOK";
            this.buOK.Size = new System.Drawing.Size(75, 23);
            this.buOK.TabIndex = 8;
            this.buOK.Text = "OK";
            this.buOK.UseVisualStyleBackColor = true;
            this.buOK.Click += new System.EventHandler(this.buOK_Click);
            // 
            // buCancel
            // 
            this.buCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buCancel.Location = new System.Drawing.Point(285, 213);
            this.buCancel.Name = "buCancel";
            this.buCancel.Size = new System.Drawing.Size(75, 23);
            this.buCancel.TabIndex = 9;
            this.buCancel.Text = "Отмена";
            this.buCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Название организации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Юридический адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Корреспондентский счет";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Расчетный счет";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ИНН";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "КПП";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(156, 64);
            this.tbPhone.Mask = "+9 (999) 000-0000";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(204, 20);
            this.tbPhone.TabIndex = 18;
            // 
            // fmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 248);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buCancel);
            this.Controls.Add(this.buOK);
            this.Controls.Add(this.tbLegalName);
            this.Controls.Add(this.tbLegalAddress);
            this.Controls.Add(this.tbCorrespondentAccount);
            this.Controls.Add(this.tbClearingAccount);
            this.Controls.Add(this.tbINN);
            this.Controls.Add(this.tbKPP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fmCompany";
            this.Text = "Реквизиты компании";
            this.Load += new System.EventHandler(this.fmCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbKPP;
        private System.Windows.Forms.TextBox tbINN;
        private System.Windows.Forms.TextBox tbClearingAccount;
        private System.Windows.Forms.TextBox tbCorrespondentAccount;
        private System.Windows.Forms.TextBox tbLegalAddress;
        private System.Windows.Forms.TextBox tbLegalName;
        private System.Windows.Forms.Button buOK;
        private System.Windows.Forms.Button buCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox tbPhone;
    }
}