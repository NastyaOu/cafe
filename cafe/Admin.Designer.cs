namespace cafe
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_staff = new System.Windows.Forms.Label();
            this.dataGridView_staff = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name_staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymic_staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position_staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login_staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password_staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_staff = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button_staff = new System.Windows.Forms.Button();
            this.label_orders = new System.Windows.Forms.Label();
            this.dataGridView_shifts = new System.Windows.Forms.DataGridView();
            this.label_shifts = new System.Windows.Forms.Label();
            this.button_shifts = new System.Windows.Forms.Button();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_assign = new System.Windows.Forms.Button();
            this.dataGridView_orders = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.begin_shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_clients_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_shifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // label_staff
            // 
            this.label_staff.AutoSize = true;
            this.label_staff.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_staff.Location = new System.Drawing.Point(300, 88);
            this.label_staff.Name = "label_staff";
            this.label_staff.Size = new System.Drawing.Size(202, 37);
            this.label_staff.TabIndex = 0;
            this.label_staff.Text = "Сотрудники";
            // 
            // dataGridView_staff
            // 
            this.dataGridView_staff.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.last_name_staff,
            this.name_staff,
            this.patronymic_staff,
            this.position_staff,
            this.login_staff,
            this.password_staff,
            this.status_staff});
            this.dataGridView_staff.Location = new System.Drawing.Point(29, 148);
            this.dataGridView_staff.Name = "dataGridView_staff";
            this.dataGridView_staff.Size = new System.Drawing.Size(743, 87);
            this.dataGridView_staff.TabIndex = 1;
            // 
            // Column4
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "id";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // last_name_staff
            // 
            this.last_name_staff.HeaderText = "Фамилия";
            this.last_name_staff.Name = "last_name_staff";
            this.last_name_staff.ReadOnly = true;
            // 
            // name_staff
            // 
            this.name_staff.HeaderText = "Имя";
            this.name_staff.Name = "name_staff";
            this.name_staff.ReadOnly = true;
            // 
            // patronymic_staff
            // 
            this.patronymic_staff.HeaderText = "Отчество";
            this.patronymic_staff.Name = "patronymic_staff";
            this.patronymic_staff.ReadOnly = true;
            // 
            // position_staff
            // 
            this.position_staff.HeaderText = "Должность";
            this.position_staff.Name = "position_staff";
            this.position_staff.ReadOnly = true;
            // 
            // login_staff
            // 
            this.login_staff.HeaderText = "Логин";
            this.login_staff.Name = "login_staff";
            this.login_staff.ReadOnly = true;
            // 
            // password_staff
            // 
            this.password_staff.HeaderText = "Пароль";
            this.password_staff.Name = "password_staff";
            this.password_staff.ReadOnly = true;
            // 
            // status_staff
            // 
            this.status_staff.HeaderText = "Статус";
            this.status_staff.Items.AddRange(new object[] {
            "Работает",
            "Уволен"});
            this.status_staff.Name = "status_staff";
            this.status_staff.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status_staff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button_staff
            // 
            this.button_staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.button_staff.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_staff.Location = new System.Drawing.Point(208, 274);
            this.button_staff.Name = "button_staff";
            this.button_staff.Size = new System.Drawing.Size(194, 41);
            this.button_staff.TabIndex = 2;
            this.button_staff.Text = "Добавить";
            this.button_staff.UseVisualStyleBackColor = false;
            this.button_staff.Click += new System.EventHandler(this.button_staff_Click);
            // 
            // label_orders
            // 
            this.label_orders.AutoSize = true;
            this.label_orders.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_orders.Location = new System.Drawing.Point(335, 373);
            this.label_orders.Name = "label_orders";
            this.label_orders.Size = new System.Drawing.Size(132, 37);
            this.label_orders.TabIndex = 3;
            this.label_orders.Text = "Заказы";
            // 
            // dataGridView_shifts
            // 
            this.dataGridView_shifts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_shifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_shifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.date_shift,
            this.begin_shift,
            this.end_shift,
            this.staff_shift});
            this.dataGridView_shifts.Location = new System.Drawing.Point(78, 676);
            this.dataGridView_shifts.Name = "dataGridView_shifts";
            this.dataGridView_shifts.Size = new System.Drawing.Size(642, 115);
            this.dataGridView_shifts.TabIndex = 6;
            // 
            // label_shifts
            // 
            this.label_shifts.AutoSize = true;
            this.label_shifts.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_shifts.Location = new System.Drawing.Point(335, 621);
            this.label_shifts.Name = "label_shifts";
            this.label_shifts.Size = new System.Drawing.Size(127, 37);
            this.label_shifts.TabIndex = 5;
            this.label_shifts.Text = "Смены";
            // 
            // button_shifts
            // 
            this.button_shifts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.button_shifts.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_shifts.Location = new System.Drawing.Point(215, 814);
            this.button_shifts.Name = "button_shifts";
            this.button_shifts.Size = new System.Drawing.Size(194, 41);
            this.button_shifts.TabIndex = 7;
            this.button_shifts.Text = "Добавить";
            this.button_shifts.UseVisualStyleBackColor = false;
            this.button_shifts.Click += new System.EventHandler(this.button_shifts_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::cafe.Properties.Resources.Logotip2;
            this.pictureBox_logo.Location = new System.Drawing.Point(706, 12);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(82, 116);
            this.pictureBox_logo.TabIndex = 8;
            this.pictureBox_logo.TabStop = false;
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.button_confirm.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_confirm.Location = new System.Drawing.Point(408, 274);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(194, 41);
            this.button_confirm.TabIndex = 36;
            this.button_confirm.Text = "Подтвердить";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_assign
            // 
            this.button_assign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.button_assign.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_assign.Location = new System.Drawing.Point(415, 814);
            this.button_assign.Name = "button_assign";
            this.button_assign.Size = new System.Drawing.Size(194, 41);
            this.button_assign.TabIndex = 37;
            this.button_assign.Text = "Назначить";
            this.button_assign.UseVisualStyleBackColor = false;
            this.button_assign.Click += new System.EventHandler(this.button_assign_Click);
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
            this.dataGridView_orders.Location = new System.Drawing.Point(29, 429);
            this.dataGridView_orders.Name = "dataGridView_orders";
            this.dataGridView_orders.ReadOnly = true;
            this.dataGridView_orders.Size = new System.Drawing.Size(744, 115);
            this.dataGridView_orders.TabIndex = 4;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "id";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // date_shift
            // 
            this.date_shift.HeaderText = "Дата";
            this.date_shift.Name = "date_shift";
            // 
            // begin_shift
            // 
            this.begin_shift.HeaderText = "Начало";
            this.begin_shift.Name = "begin_shift";
            // 
            // end_shift
            // 
            this.end_shift.HeaderText = "Конец";
            this.end_shift.Name = "end_shift";
            // 
            // staff_shift
            // 
            this.staff_shift.HeaderText = "Работники";
            this.staff_shift.Name = "staff_shift";
            this.staff_shift.Width = 300;
            // 
            // Column1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            this.status_order.Name = "status_order";
            this.status_order.ReadOnly = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 876);
            this.Controls.Add(this.button_assign);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.button_shifts);
            this.Controls.Add(this.dataGridView_shifts);
            this.Controls.Add(this.label_shifts);
            this.Controls.Add(this.dataGridView_orders);
            this.Controls.Add(this.label_orders);
            this.Controls.Add(this.button_staff);
            this.Controls.Add(this.dataGridView_staff);
            this.Controls.Add(this.label_staff);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кафе \"Сезон\"";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_shifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_staff;
        private System.Windows.Forms.DataGridView dataGridView_staff;
        private System.Windows.Forms.Button button_staff;
        private System.Windows.Forms.Label label_orders;
        private System.Windows.Forms.DataGridView dataGridView_shifts;
        private System.Windows.Forms.Label label_shifts;
        private System.Windows.Forms.Button button_shifts;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_assign;
        private System.Windows.Forms.DataGridView dataGridView_orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymic_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn position_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn login_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn password_staff;
        private System.Windows.Forms.DataGridViewComboBoxColumn status_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn begin_shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_clients_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_order;
    }
}