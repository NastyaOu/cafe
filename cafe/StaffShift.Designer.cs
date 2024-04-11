namespace cafe
{
    partial class StaffShift
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
            this.dataGridView_staff = new System.Windows.Forms.DataGridView();
            this.lastname_staff_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_staff_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymic_staff_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position_staff_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assign_staff_order = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label_staff = new System.Windows.Forms.Label();
            this.button_confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_staff
            // 
            this.dataGridView_staff.AllowUserToAddRows = false;
            this.dataGridView_staff.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastname_staff_order,
            this.name_staff_order,
            this.patronymic_staff_order,
            this.position_staff_order,
            this.assign_staff_order});
            this.dataGridView_staff.Location = new System.Drawing.Point(57, 71);
            this.dataGridView_staff.Name = "dataGridView_staff";
            this.dataGridView_staff.Size = new System.Drawing.Size(541, 103);
            this.dataGridView_staff.TabIndex = 3;
            // 
            // lastname_staff_order
            // 
            this.lastname_staff_order.HeaderText = "Фамилия";
            this.lastname_staff_order.Name = "lastname_staff_order";
            // 
            // name_staff_order
            // 
            this.name_staff_order.HeaderText = "Имя";
            this.name_staff_order.Name = "name_staff_order";
            // 
            // patronymic_staff_order
            // 
            this.patronymic_staff_order.HeaderText = "Отчество";
            this.patronymic_staff_order.Name = "patronymic_staff_order";
            // 
            // position_staff_order
            // 
            this.position_staff_order.HeaderText = "Должность";
            this.position_staff_order.Name = "position_staff_order";
            // 
            // assign_staff_order
            // 
            this.assign_staff_order.FalseValue = "false";
            this.assign_staff_order.HeaderText = "Назначен";
            this.assign_staff_order.Name = "assign_staff_order";
            this.assign_staff_order.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.assign_staff_order.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.assign_staff_order.TrueValue = "true";
            // 
            // label_staff
            // 
            this.label_staff.AutoSize = true;
            this.label_staff.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_staff.Location = new System.Drawing.Point(217, 17);
            this.label_staff.Name = "label_staff";
            this.label_staff.Size = new System.Drawing.Size(202, 37);
            this.label_staff.TabIndex = 2;
            this.label_staff.Text = "Сотрудники";
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.button_confirm.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_confirm.Location = new System.Drawing.Point(221, 196);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(194, 41);
            this.button_confirm.TabIndex = 35;
            this.button_confirm.Text = "Подтвердить";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // StaffShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 256);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.dataGridView_staff);
            this.Controls.Add(this.label_staff);
            this.Name = "StaffShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кафе \"Сезон\"";
            this.Load += new System.EventHandler(this.StaffShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_staff;
        private System.Windows.Forms.Label label_staff;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname_staff_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_staff_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymic_staff_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn position_staff_order;
        private System.Windows.Forms.DataGridViewCheckBoxColumn assign_staff_order;
    }
}