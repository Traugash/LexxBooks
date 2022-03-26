namespace LexBooksProject
{
    partial class Form1
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
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox2_pass = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_reg = new System.Windows.Forms.Button();
            this.buttom_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(148, 85);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(168, 20);
            this.textBox_login.TabIndex = 2;
            // 
            // textBox2_pass
            // 
            this.textBox2_pass.Location = new System.Drawing.Point(148, 117);
            this.textBox2_pass.Name = "textBox2_pass";
            this.textBox2_pass.Size = new System.Drawing.Size(168, 20);
            this.textBox2_pass.TabIndex = 3;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(100, 158);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(102, 30);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "Войти";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_reg
            // 
            this.button_reg.Location = new System.Drawing.Point(214, 158);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(102, 30);
            this.button_reg.TabIndex = 5;
            this.button_reg.Text = "Регистрация";
            this.button_reg.UseVisualStyleBackColor = true;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // buttom_quit
            // 
            this.buttom_quit.Location = new System.Drawing.Point(100, 194);
            this.buttom_quit.Name = "buttom_quit";
            this.buttom_quit.Size = new System.Drawing.Size(216, 30);
            this.buttom_quit.TabIndex = 6;
            this.buttom_quit.Text = "Выход";
            this.buttom_quit.UseVisualStyleBackColor = true;
            this.buttom_quit.Click += new System.EventHandler(this.buttom_quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 302);
            this.Controls.Add(this.buttom_quit);
            this.Controls.Add(this.button_reg);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox2_pass);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox2_pass;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.Button buttom_quit;
    }
}

