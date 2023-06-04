namespace Coursework.Forms.SubForms
{
    partial class Employee
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
            this.ToComIn = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.IdEmpl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToComIn
            // 
            this.ToComIn.Location = new System.Drawing.Point(220, 44);
            this.ToComIn.Name = "ToComIn";
            this.ToComIn.Size = new System.Drawing.Size(75, 62);
            this.ToComIn.TabIndex = 0;
            this.ToComIn.Text = "Войти";
            this.ToComIn.UseVisualStyleBackColor = true;
            this.ToComIn.Click += new System.EventHandler(this.ToComIn_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(220, 139);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 58);
            this.Close.TabIndex = 1;
            this.Close.Text = "Отмена";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // IdEmpl
            // 
            this.IdEmpl.Location = new System.Drawing.Point(25, 79);
            this.IdEmpl.Name = "IdEmpl";
            this.IdEmpl.Size = new System.Drawing.Size(171, 22);
            this.IdEmpl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите Id№ Сотрудника";
            // 
            // Reg
            // 
            this.Reg.Location = new System.Drawing.Point(25, 139);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(171, 58);
            this.Reg.TabIndex = 4;
            this.Reg.Text = "Зарегистрировать нового сотрудника";
            this.Reg.UseVisualStyleBackColor = true;
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 222);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdEmpl);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.ToComIn);
            this.MaximizeBox = false;
            this.Name = "Employee";
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToComIn;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox IdEmpl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reg;
    }
}