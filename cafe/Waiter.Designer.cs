namespace cafe
{
    partial class Waiter
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
            this.label_orders = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.dataGridView_orders = new System.Windows.Forms.DataGridView();
            this.button_confirm = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_clients_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_order = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // label_orders
            // 
            this.label_orders.AutoSize = true;
            this.label_orders.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_orders.Location = new System.Drawing.Point(319, 93);
            this.label_orders.Name = "label_orders";
            this.label_orders.Size = new System.Drawing.Size(132, 37);
            this.label_orders.TabIndex = 6;
            this.label_orders.Text = "Заказы";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.button_add.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(189, 297);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(194, 41);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::cafe.Properties.Resources.Logotip1;
            this.pictureBox_logo.Location = new System.Drawing.Point(706, 12);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(82, 116);
            this.pictureBox_logo.TabIndex = 8;
            this.pictureBox_logo.TabStop = false;
            // 
            // dataGridView_orders
            // 
            this.dataGridView_orders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.table_order,
            this.num_clients_order,
            this.structure_order,
            this.status_order});
            this.dataGridView_orders.Location = new System.Drawing.Point(31, 153);
            this.dataGridView_orders.Name = "dataGridView_orders";
            this.dataGridView_orders.Size = new System.Drawing.Size(743, 115);
            this.dataGridView_orders.TabIndex = 12;
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.button_confirm.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_confirm.Location = new System.Drawing.Point(389, 297);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(194, 41);
            this.button_confirm.TabIndex = 35;
            this.button_confirm.Text = "Подтвердить";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Время";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // table_order
            // 
            this.table_order.HeaderText = "Столик";
            this.table_order.Name = "table_order";
            this.table_order.ReadOnly = true;
            // 
            // num_clients_order
            // 
            this.num_clients_order.HeaderText = "Количество клиентов";
            this.num_clients_order.Name = "num_clients_order";
            this.num_clients_order.ReadOnly = true;
            // 
            // structure_order
            // 
            this.structure_order.HeaderText = "Состав";
            this.structure_order.Name = "structure_order";
            this.structure_order.ReadOnly = true;
            this.structure_order.Width = 200;
            // 
            // status_order
            // 
            this.status_order.HeaderText = "Статус";
            this.status_order.Items.AddRange(new object[] {
            "Принят",
            "Готовится",
            "Готов",
            "Оплачен"});
            this.status_order.Name = "status_order";
            this.status_order.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status_order.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.dataGridView_orders);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.label_orders);
            this.Controls.Add(this.button_add);
            this.Name = "Waiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кафе \"Сезон\"";
            this.Load += new System.EventHandler(this.Waiter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_orders;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.DataGridView dataGridView_orders;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_clients_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_order;
        private System.Windows.Forms.DataGridViewComboBoxColumn status_order;
    }
}