
namespace РГР_УД
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.adminPassword = new System.Windows.Forms.TextBox();
            this.adminLogin = new System.Windows.Forms.TextBox();
            this.userLoginButton = new System.Windows.Forms.Button();
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Войти как пользователь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Войти как администратор";
            // 
            // userLogin
            // 
            this.userLogin.Location = new System.Drawing.Point(104, 117);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(166, 22);
            this.userLogin.TabIndex = 2;
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(104, 164);
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '*';
            this.userPassword.Size = new System.Drawing.Size(166, 22);
            this.userPassword.TabIndex = 2;
            // 
            // adminPassword
            // 
            this.adminPassword.Location = new System.Drawing.Point(532, 164);
            this.adminPassword.Name = "adminPassword";
            this.adminPassword.PasswordChar = '*';
            this.adminPassword.Size = new System.Drawing.Size(166, 22);
            this.adminPassword.TabIndex = 2;
            // 
            // adminLogin
            // 
            this.adminLogin.Location = new System.Drawing.Point(532, 117);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(166, 22);
            this.adminLogin.TabIndex = 2;
            // 
            // userLoginButton
            // 
            this.userLoginButton.Location = new System.Drawing.Point(104, 224);
            this.userLoginButton.Name = "userLoginButton";
            this.userLoginButton.Size = new System.Drawing.Size(166, 23);
            this.userLoginButton.TabIndex = 3;
            this.userLoginButton.Text = "Войти";
            this.userLoginButton.UseVisualStyleBackColor = true;
            this.userLoginButton.Click += new System.EventHandler(this.userLoginButton_Click);
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.Location = new System.Drawing.Point(532, 224);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(166, 23);
            this.adminLoginButton.TabIndex = 3;
            this.adminLoginButton.Text = "Войти";
            this.adminLoginButton.UseVisualStyleBackColor = true;
            this.adminLoginButton.Click += new System.EventHandler(this.adminLoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminLoginButton);
            this.Controls.Add(this.userLoginButton);
            this.Controls.Add(this.adminPassword);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.adminLogin);
            this.Controls.Add(this.userLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.TextBox adminPassword;
        private System.Windows.Forms.TextBox adminLogin;
        private System.Windows.Forms.Button userLoginButton;
        private System.Windows.Forms.Button adminLoginButton;
    }
}

