namespace Coursework.Forms.SubForms
{
    partial class AddSupplier
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
            this.TelSupplier = new System.Windows.Forms.TextBox();
            this.AddressSupplier = new System.Windows.Forms.TextBox();
            this.EmailSupplier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FIOSupplier = new System.Windows.Forms.TextBox();
            this.ButAddSup = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TelSupplier
            // 
            this.TelSupplier.Location = new System.Drawing.Point(253, 96);
            this.TelSupplier.MaxLength = 7;
            this.TelSupplier.Name = "TelSupplier";
            this.TelSupplier.Size = new System.Drawing.Size(199, 22);
            this.TelSupplier.TabIndex = 1;
            // 
            // AddressSupplier
            // 
            this.AddressSupplier.Location = new System.Drawing.Point(253, 141);
            this.AddressSupplier.MaxLength = 80;
            this.AddressSupplier.Name = "AddressSupplier";
            this.AddressSupplier.Size = new System.Drawing.Size(199, 22);
            this.AddressSupplier.TabIndex = 2;
            // 
            // EmailSupplier
            // 
            this.EmailSupplier.Location = new System.Drawing.Point(253, 186);
            this.EmailSupplier.MaxLength = 30;
            this.EmailSupplier.Name = "EmailSupplier";
            this.EmailSupplier.Size = new System.Drawing.Size(199, 22);
            this.EmailSupplier.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "№ Телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Фамилия";
            // 
            // FIOSupplier
            // 
            this.FIOSupplier.Location = new System.Drawing.Point(253, 48);
            this.FIOSupplier.MaxLength = 40;
            this.FIOSupplier.Name = "FIOSupplier";
            this.FIOSupplier.Size = new System.Drawing.Size(199, 22);
            this.FIOSupplier.TabIndex = 0;
            // 
            // ButAddSup
            // 
            this.ButAddSup.Location = new System.Drawing.Point(142, 271);
            this.ButAddSup.Name = "ButAddSup";
            this.ButAddSup.Size = new System.Drawing.Size(120, 32);
            this.ButAddSup.TabIndex = 9;
            this.ButAddSup.Text = "Добавить";
            this.ButAddSup.UseVisualStyleBackColor = true;
            this.ButAddSup.Click += new System.EventHandler(this.ButAddSup_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(305, 271);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(127, 32);
            this.Close.TabIndex = 10;
            this.Close.Text = "Отмена";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 351);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.ButAddSup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailSupplier);
            this.Controls.Add(this.AddressSupplier);
            this.Controls.Add(this.TelSupplier);
            this.Controls.Add(this.FIOSupplier);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSupplier";
            this.Text = "AddSupplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TelSupplier;
        private System.Windows.Forms.TextBox AddressSupplier;
        private System.Windows.Forms.TextBox EmailSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FIOSupplier;
        private System.Windows.Forms.Button ButAddSup;
        private System.Windows.Forms.Button Close;
    }
}