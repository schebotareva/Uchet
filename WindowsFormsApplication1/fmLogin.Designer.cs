namespace WindowsFormsApplication1
{
    partial class fmLogin
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
            this.edUserName = new System.Windows.Forms.TextBox();
            this.edPassword = new System.Windows.Forms.TextBox();
            this.buLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пользователь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // edUserName
            // 
            this.edUserName.Location = new System.Drawing.Point(123, 25);
            this.edUserName.Name = "edUserName";
            this.edUserName.Size = new System.Drawing.Size(186, 20);
            this.edUserName.TabIndex = 2;
            // 
            // edPassword
            // 
            this.edPassword.Location = new System.Drawing.Point(123, 51);
            this.edPassword.Name = "edPassword";
            this.edPassword.PasswordChar = '●';
            this.edPassword.Size = new System.Drawing.Size(186, 20);
            this.edPassword.TabIndex = 3;
            // 
            // buLogin
            // 
            this.buLogin.Location = new System.Drawing.Point(234, 82);
            this.buLogin.Name = "buLogin";
            this.buLogin.Size = new System.Drawing.Size(75, 23);
            this.buLogin.TabIndex = 4;
            this.buLogin.Text = "Войти";
            this.buLogin.UseVisualStyleBackColor = true;
            this.buLogin.Click += new System.EventHandler(this.buLogin_Click);
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 117);
            this.Controls.Add(this.buLogin);
            this.Controls.Add(this.edPassword);
            this.Controls.Add(this.edUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fmLogin";
            this.Text = "Вход пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edUserName;
        private System.Windows.Forms.TextBox edPassword;
        private System.Windows.Forms.Button buLogin;
    }
}