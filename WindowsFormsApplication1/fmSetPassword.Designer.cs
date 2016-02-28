namespace WindowsFormsApplication1
{
    partial class fmSetPassword
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
            this.edNewPassword = new System.Windows.Forms.TextBox();
            this.edRepeatPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buOK = new System.Windows.Forms.Button();
            this.buCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edNewPassword
            // 
            this.edNewPassword.Location = new System.Drawing.Point(118, 12);
            this.edNewPassword.Name = "edNewPassword";
            this.edNewPassword.PasswordChar = '●';
            this.edNewPassword.Size = new System.Drawing.Size(176, 20);
            this.edNewPassword.TabIndex = 0;
            // 
            // edRepeatPassword
            // 
            this.edRepeatPassword.Location = new System.Drawing.Point(118, 38);
            this.edRepeatPassword.Name = "edRepeatPassword";
            this.edRepeatPassword.PasswordChar = '●';
            this.edRepeatPassword.Size = new System.Drawing.Size(176, 20);
            this.edRepeatPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Новый пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Повторите пароль";
            // 
            // buOK
            // 
            this.buOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buOK.Location = new System.Drawing.Point(138, 74);
            this.buOK.Name = "buOK";
            this.buOK.Size = new System.Drawing.Size(75, 23);
            this.buOK.TabIndex = 4;
            this.buOK.Text = "ОК";
            this.buOK.UseVisualStyleBackColor = true;
            this.buOK.Click += new System.EventHandler(this.buOK_Click);
            // 
            // buCancel
            // 
            this.buCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buCancel.Location = new System.Drawing.Point(219, 74);
            this.buCancel.Name = "buCancel";
            this.buCancel.Size = new System.Drawing.Size(75, 23);
            this.buCancel.TabIndex = 5;
            this.buCancel.Text = "Отмена";
            this.buCancel.UseVisualStyleBackColor = true;
            // 
            // fmSetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 112);
            this.Controls.Add(this.buCancel);
            this.Controls.Add(this.buOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edRepeatPassword);
            this.Controls.Add(this.edNewPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmSetPassword";
            this.Text = "Новый пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edNewPassword;
        private System.Windows.Forms.TextBox edRepeatPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buOK;
        private System.Windows.Forms.Button buCancel;
    }
}