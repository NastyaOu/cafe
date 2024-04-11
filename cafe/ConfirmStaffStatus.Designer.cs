namespace cafe
{
    partial class ConfirmStaffStatus
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
            this.label_confirm = new System.Windows.Forms.Label();
            this.button_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_confirm
            // 
            this.label_confirm.AutoSize = true;
            this.label_confirm.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_confirm.Location = new System.Drawing.Point(16, 20);
            this.label_confirm.Name = "label_confirm";
            this.label_confirm.Size = new System.Drawing.Size(548, 37);
            this.label_confirm.TabIndex = 2;
            this.label_confirm.Text = "Подтвердить изменение статуса?";
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.button_confirm.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_confirm.Location = new System.Drawing.Point(188, 71);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(194, 41);
            this.button_confirm.TabIndex = 33;
            this.button_confirm.Text = "Подтвердить";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // ConfirmStaffStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 137);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.label_confirm);
            this.Name = "ConfirmStaffStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кафе \"Сезон\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_confirm;
        private System.Windows.Forms.Button button_confirm;
    }
}