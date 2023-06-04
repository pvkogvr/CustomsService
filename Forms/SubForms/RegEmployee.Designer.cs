namespace Coursework.Forms.SubForms
{
    partial class RegEmployee
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
            this.AddEmpl = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.CodeCus = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Patrynomic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameEmp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddEmpl
            // 
            this.AddEmpl.Location = new System.Drawing.Point(73, 186);
            this.AddEmpl.Name = "AddEmpl";
            this.AddEmpl.Size = new System.Drawing.Size(98, 39);
            this.AddEmpl.TabIndex = 0;
            this.AddEmpl.Text = "Добавить";
            this.AddEmpl.UseVisualStyleBackColor = true;
            this.AddEmpl.Click += new System.EventHandler(this.AddEmpl_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(294, 186);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(98, 39);
            this.Close.TabIndex = 1;
            this.Close.Text = "Отмена";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // CodeCus
            // 
            this.CodeCus.Location = new System.Drawing.Point(217, 37);
            this.CodeCus.Name = "CodeCus";
            this.CodeCus.Size = new System.Drawing.Size(175, 22);
            this.CodeCus.TabIndex = 2;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(217, 93);
            this.Surname.MaxLength = 20;
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(175, 22);
            this.Surname.TabIndex = 5;
            // 
            // Patrynomic
            // 
            this.Patrynomic.Location = new System.Drawing.Point(217, 121);
            this.Patrynomic.MaxLength = 30;
            this.Patrynomic.Name = "Patrynomic";
            this.Patrynomic.Size = new System.Drawing.Size(175, 22);
            this.Patrynomic.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Код таможни";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Отчество";
            // 
            // NameEmp
            // 
            this.NameEmp.Location = new System.Drawing.Point(217, 65);
            this.NameEmp.Name = "NameEmp";
            this.NameEmp.Size = new System.Drawing.Size(175, 22);
            this.NameEmp.TabIndex = 12;
            // 
            // RegEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 267);
            this.Controls.Add(this.NameEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Patrynomic);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.CodeCus);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.AddEmpl);
            this.MaximizeBox = false;
            this.Name = "RegEmployee";
            this.Text = "RegEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEmpl;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox CodeCus;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Patrynomic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameEmp;
    }
}