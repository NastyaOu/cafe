namespace cafe
{
    partial class AddingOrder
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
            this.textBox_character = new System.Windows.Forms.TextBox();
            this.label_character = new System.Windows.Forms.Label();
            this.textBox_clients = new System.Windows.Forms.TextBox();
            this.label_clients = new System.Windows.Forms.Label();
            this.textBox_table = new System.Windows.Forms.TextBox();
            this.label_table = new System.Windows.Forms.Label();
            this.label_logo = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_character
            // 
            this.textBox_character.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_character.Location = new System.Drawing.Point(325, 163);
            this.textBox_character.Name = "textBox_character";
            this.textBox_character.Size = new System.Drawing.Size(409, 35);
            this.textBox_character.TabIndex = 22;
            // 
            // label_character
            // 
            this.label_character.AutoSize = true;
            this.label_character.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_character.Location = new System.Drawing.Point(76, 171);
            this.label_character.Name = "label_character";
            this.label_character.Size = new System.Drawing.Size(91, 27);
            this.label_character.TabIndex = 21;
            this.label_character.Text = "Состав";
            // 
            // textBox_clients
            // 
            this.textBox_clients.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_clients.Location = new System.Drawing.Point(325, 119);
            this.textBox_clients.Name = "textBox_clients";
            this.textBox_clients.Size = new System.Drawing.Size(409, 35);
            this.textBox_clients.TabIndex = 20;
            // 
            // label_clients
            // 
            this.label_clients.AutoSize = true;
            this.label_clients.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_clients.Location = new System.Drawing.Point(76, 127);
            this.label_clients.Name = "label_clients";
            this.label_clients.Size = new System.Drawing.Size(248, 27);
            this.label_clients.TabIndex = 19;
            this.label_clients.Text = "Количество клиентов";
            // 
            // textBox_table
            // 
            this.textBox_table.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_table.Location = new System.Drawing.Point(325, 75);
            this.textBox_table.Name = "textBox_table";
            this.textBox_table.Size = new System.Drawing.Size(409, 35);
            this.textBox_table.TabIndex = 18;
            // 
            // label_table
            // 
            this.label_table.AutoSize = true;
            this.label_table.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_table.Location = new System.Drawing.Point(76, 83);
            this.label_table.Name = "label_table";
            this.label_table.Size = new System.Drawing.Size(90, 27);
            this.label_table.TabIndex = 17;
            this.label_table.Text = "Столик";
            // 
            // label_logo
            // 
            this.label_logo.AutoSize = true;
            this.label_logo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_logo.Location = new System.Drawing.Point(237, 18);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(322, 37);
            this.label_logo.TabIndex = 16;
            this.label_logo.Text = "Добавление заказа";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.button_add.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(304, 223);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(194, 41);
            this.button_add.TabIndex = 32;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // AddingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 283);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_character);
            this.Controls.Add(this.label_character);
            this.Controls.Add(this.textBox_clients);
            this.Controls.Add(this.label_clients);
            this.Controls.Add(this.textBox_table);
            this.Controls.Add(this.label_table);
            this.Controls.Add(this.label_logo);
            this.Name = "AddingOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кафе \"Сезон\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_character;
        private System.Windows.Forms.Label label_character;
        private System.Windows.Forms.TextBox textBox_clients;
        private System.Windows.Forms.Label label_clients;
        private System.Windows.Forms.TextBox textBox_table;
        private System.Windows.Forms.Label label_table;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.Button button_add;
    }
}