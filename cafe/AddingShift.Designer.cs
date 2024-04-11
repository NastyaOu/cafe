namespace cafe
{
    partial class AddingShift
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
            this.textBox_end = new System.Windows.Forms.TextBox();
            this.label_end = new System.Windows.Forms.Label();
            this.textBox_begin = new System.Windows.Forms.TextBox();
            this.label_begin = new System.Windows.Forms.Label();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_shifts = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_end
            // 
            this.textBox_end.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_end.Location = new System.Drawing.Point(253, 154);
            this.textBox_end.Name = "textBox_end";
            this.textBox_end.Size = new System.Drawing.Size(541, 35);
            this.textBox_end.TabIndex = 29;
            // 
            // label_end
            // 
            this.label_end.AutoSize = true;
            this.label_end.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_end.Location = new System.Drawing.Point(70, 162);
            this.label_end.Name = "label_end";
            this.label_end.Size = new System.Drawing.Size(79, 27);
            this.label_end.TabIndex = 28;
            this.label_end.Text = "Конец";
            // 
            // textBox_begin
            // 
            this.textBox_begin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_begin.Location = new System.Drawing.Point(253, 110);
            this.textBox_begin.Name = "textBox_begin";
            this.textBox_begin.Size = new System.Drawing.Size(541, 35);
            this.textBox_begin.TabIndex = 27;
            // 
            // label_begin
            // 
            this.label_begin.AutoSize = true;
            this.label_begin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_begin.Location = new System.Drawing.Point(70, 118);
            this.label_begin.Name = "label_begin";
            this.label_begin.Size = new System.Drawing.Size(94, 27);
            this.label_begin.TabIndex = 26;
            this.label_begin.Text = "Начало";
            // 
            // textBox_date
            // 
            this.textBox_date.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_date.Location = new System.Drawing.Point(253, 66);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(541, 35);
            this.textBox_date.TabIndex = 25;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date.Location = new System.Drawing.Point(70, 74);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(64, 27);
            this.label_date.TabIndex = 24;
            this.label_date.Text = "Дата";
            // 
            // label_shifts
            // 
            this.label_shifts.AutoSize = true;
            this.label_shifts.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_shifts.Location = new System.Drawing.Point(282, 9);
            this.label_shifts.Name = "label_shifts";
            this.label_shifts.Size = new System.Drawing.Size(325, 37);
            this.label_shifts.TabIndex = 23;
            this.label_shifts.Text = "Добавление смены";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.button_add.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(337, 212);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(194, 41);
            this.button_add.TabIndex = 31;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // AddingShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 274);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_end);
            this.Controls.Add(this.label_end);
            this.Controls.Add(this.textBox_begin);
            this.Controls.Add(this.label_begin);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_shifts);
            this.Name = "AddingShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_end;
        private System.Windows.Forms.Label label_end;
        private System.Windows.Forms.TextBox textBox_begin;
        private System.Windows.Forms.Label label_begin;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_shifts;
        private System.Windows.Forms.Button button_add;
    }
}