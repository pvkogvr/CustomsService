namespace Coursework.Forms.SubForms
{
    partial class CusDeclar
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
            this.NumbSupply = new System.Windows.Forms.TextBox();
            this.QuanProd = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.CusPay = new System.Windows.Forms.TextBox();
            this.VolQuot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CreateCustDec = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.RadioButton();
            this.Export = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShipOut = new System.Windows.Forms.RadioButton();
            this.PlaneOut = new System.Windows.Forms.RadioButton();
            this.AutoOut = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ShipIn = new System.Windows.Forms.RadioButton();
            this.PlaneIn = new System.Windows.Forms.RadioButton();
            this.AutoIn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumbSupply
            // 
            this.NumbSupply.Location = new System.Drawing.Point(185, 61);
            this.NumbSupply.Name = "NumbSupply";
            this.NumbSupply.ReadOnly = true;
            this.NumbSupply.Size = new System.Drawing.Size(298, 22);
            this.NumbSupply.TabIndex = 1;
            // 
            // QuanProd
            // 
            this.QuanProd.Location = new System.Drawing.Point(185, 98);
            this.QuanProd.MaxLength = 7;
            this.QuanProd.Name = "QuanProd";
            this.QuanProd.Size = new System.Drawing.Size(298, 22);
            this.QuanProd.TabIndex = 2;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(185, 180);
            this.Price.MaxLength = 7;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(298, 22);
            this.Price.TabIndex = 4;
            // 
            // CusPay
            // 
            this.CusPay.Location = new System.Drawing.Point(185, 261);
            this.CusPay.MaxLength = 7;
            this.CusPay.Name = "CusPay";
            this.CusPay.Size = new System.Drawing.Size(298, 22);
            this.CusPay.TabIndex = 7;
            // 
            // VolQuot
            // 
            this.VolQuot.Location = new System.Drawing.Point(185, 300);
            this.VolQuot.MaxLength = 7;
            this.VolQuot.Name = "VolQuot";
            this.VolQuot.Size = new System.Drawing.Size(298, 22);
            this.VolQuot.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Тип декларации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Номер поставки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Транспорт вне страны";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Транспорт в стране";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Таможенный платеж";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Квота по объему";
            // 
            // CreateCustDec
            // 
            this.CreateCustDec.Location = new System.Drawing.Point(12, 339);
            this.CreateCustDec.Name = "CreateCustDec";
            this.CreateCustDec.Size = new System.Drawing.Size(226, 152);
            this.CreateCustDec.TabIndex = 20;
            this.CreateCustDec.Text = "Создать";
            this.CreateCustDec.UseVisualStyleBackColor = true;
            this.CreateCustDec.Click += new System.EventHandler(this.CreateCustDec_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(244, 339);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(239, 152);
            this.Close.TabIndex = 21;
            this.Close.Text = "Отмена";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Import
            // 
            this.Import.AutoSize = true;
            this.Import.Checked = true;
            this.Import.Location = new System.Drawing.Point(185, 22);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(79, 21);
            this.Import.TabIndex = 22;
            this.Import.TabStop = true;
            this.Import.Text = "Импорт";
            this.Import.UseVisualStyleBackColor = true;
            // 
            // Export
            // 
            this.Export.AutoSize = true;
            this.Export.Location = new System.Drawing.Point(300, 20);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(83, 21);
            this.Export.TabIndex = 23;
            this.Export.Text = "Экспорт";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShipOut);
            this.groupBox1.Controls.Add(this.PlaneOut);
            this.groupBox1.Controls.Add(this.AutoOut);
            this.groupBox1.Location = new System.Drawing.Point(185, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 41);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // ShipOut
            // 
            this.ShipOut.AutoSize = true;
            this.ShipOut.Location = new System.Drawing.Point(192, 10);
            this.ShipOut.Name = "ShipOut";
            this.ShipOut.Size = new System.Drawing.Size(85, 21);
            this.ShipOut.TabIndex = 2;
            this.ShipOut.Text = "Корабль";
            this.ShipOut.UseVisualStyleBackColor = true;
            // 
            // PlaneOut
            // 
            this.PlaneOut.AutoSize = true;
            this.PlaneOut.Location = new System.Drawing.Point(87, 10);
            this.PlaneOut.Name = "PlaneOut";
            this.PlaneOut.Size = new System.Drawing.Size(86, 21);
            this.PlaneOut.TabIndex = 1;
            this.PlaneOut.Text = "Самолет";
            this.PlaneOut.UseVisualStyleBackColor = true;
            // 
            // AutoOut
            // 
            this.AutoOut.AutoSize = true;
            this.AutoOut.Checked = true;
            this.AutoOut.Location = new System.Drawing.Point(7, 10);
            this.AutoOut.Name = "AutoOut";
            this.AutoOut.Size = new System.Drawing.Size(60, 21);
            this.AutoOut.TabIndex = 0;
            this.AutoOut.TabStop = true;
            this.AutoOut.Text = "Авто";
            this.AutoOut.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ShipIn);
            this.groupBox2.Controls.Add(this.PlaneIn);
            this.groupBox2.Controls.Add(this.AutoIn);
            this.groupBox2.Location = new System.Drawing.Point(185, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 43);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // ShipIn
            // 
            this.ShipIn.AutoSize = true;
            this.ShipIn.Location = new System.Drawing.Point(192, 11);
            this.ShipIn.Name = "ShipIn";
            this.ShipIn.Size = new System.Drawing.Size(85, 21);
            this.ShipIn.TabIndex = 2;
            this.ShipIn.Text = "Корабль";
            this.ShipIn.UseVisualStyleBackColor = true;
            // 
            // PlaneIn
            // 
            this.PlaneIn.AutoSize = true;
            this.PlaneIn.Location = new System.Drawing.Point(87, 11);
            this.PlaneIn.Name = "PlaneIn";
            this.PlaneIn.Size = new System.Drawing.Size(86, 21);
            this.PlaneIn.TabIndex = 1;
            this.PlaneIn.Text = "Самолет";
            this.PlaneIn.UseVisualStyleBackColor = true;
            // 
            // AutoIn
            // 
            this.AutoIn.AutoSize = true;
            this.AutoIn.Checked = true;
            this.AutoIn.Location = new System.Drawing.Point(7, 11);
            this.AutoIn.Name = "AutoIn";
            this.AutoIn.Size = new System.Drawing.Size(60, 21);
            this.AutoIn.TabIndex = 0;
            this.AutoIn.TabStop = true;
            this.AutoIn.Text = "Авто";
            this.AutoIn.UseVisualStyleBackColor = true;
            // 
            // CusDeclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.CreateCustDec);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VolQuot);
            this.Controls.Add(this.CusPay);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.QuanProd);
            this.Controls.Add(this.NumbSupply);
            this.Name = "CusDeclar";
            this.Text = "CusDeclar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NumbSupply;
        private System.Windows.Forms.TextBox QuanProd;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox CusPay;
        private System.Windows.Forms.TextBox VolQuot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CreateCustDec;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.RadioButton Import;
        private System.Windows.Forms.RadioButton Export;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ShipOut;
        private System.Windows.Forms.RadioButton PlaneOut;
        private System.Windows.Forms.RadioButton AutoOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ShipIn;
        private System.Windows.Forms.RadioButton PlaneIn;
        private System.Windows.Forms.RadioButton AutoIn;
    }
}