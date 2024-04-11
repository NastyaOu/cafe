namespace cafe
{
    partial class Authorization
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
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_entrance = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(353, 140);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(250, 35);
            this.textBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(353, 189);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(250, 35);
            this.textBox_password.TabIndex = 1;
            // 
            // button_entrance
            // 
            this.button_entrance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.button_entrance.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_entrance.Location = new System.Drawing.Point(257, 249);
            this.button_entrance.Name = "button_entrance";
            this.button_entrance.Size = new System.Drawing.Size(346, 43);
            this.button_entrance.TabIndex = 2;
            this.button_entrance.Text = "Войти";
            this.button_entrance.UseVisualStyleBackColor = false;
            this.button_entrance.Click += new System.EventHandler(this.button_entrance_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(252, 145);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(76, 27);
            this.label_login.TabIndex = 3;
            this.label_login.Text = "Логин";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.Location = new System.Drawing.Point(252, 193);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(95, 27);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Пароль";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::cafe.Properties.Resources.Logotip1;
            this.pictureBox_logo.Location = new System.Drawing.Point(706, 12);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(82, 116);
            this.pictureBox_logo.TabIndex = 5;
            this.pictureBox_logo.TabStop = false;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.button_entrance);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кафе \"Сезон\"";
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_entrance;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.PictureBox pictureBox_logo;
    }
}

