namespace Coursework.Forms.SubForms
{
    partial class Supply
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
            this.WeightSup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddSupply = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.CustomersList = new System.Windows.Forms.DataGridView();
            this.SuppliersList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBCNFEA = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersList)).BeginInit();
            this.SuspendLayout();
            // 
            // WeightSup
            // 
            this.WeightSup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WeightSup.Location = new System.Drawing.Point(518, 120);
            this.WeightSup.Name = "WeightSup";
            this.WeightSup.Size = new System.Drawing.Size(237, 22);
            this.WeightSup.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Код ТНВЭД";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Общая масса";
            // 
            // AddSupply
            // 
            this.AddSupply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSupply.Location = new System.Drawing.Point(374, 174);
            this.AddSupply.Name = "AddSupply";
            this.AddSupply.Size = new System.Drawing.Size(381, 173);
            this.AddSupply.TabIndex = 9;
            this.AddSupply.Text = "Добавить";
            this.AddSupply.UseVisualStyleBackColor = true;
            this.AddSupply.Click += new System.EventHandler(this.AddSupply_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Location = new System.Drawing.Point(374, 353);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(381, 173);
            this.Close.TabIndex = 10;
            this.Close.Text = "Отмена";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // CustomersList
            // 
            this.CustomersList.AllowUserToAddRows = false;
            this.CustomersList.AllowUserToDeleteRows = false;
            this.CustomersList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersList.Location = new System.Drawing.Point(12, 61);
            this.CustomersList.MultiSelect = false;
            this.CustomersList.Name = "CustomersList";
            this.CustomersList.ReadOnly = true;
            this.CustomersList.RowHeadersVisible = false;
            this.CustomersList.RowHeadersWidth = 51;
            this.CustomersList.RowTemplate.Height = 24;
            this.CustomersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersList.Size = new System.Drawing.Size(334, 465);
            this.CustomersList.TabIndex = 11;
            // 
            // SuppliersList
            // 
            this.SuppliersList.AllowUserToAddRows = false;
            this.SuppliersList.AllowUserToDeleteRows = false;
            this.SuppliersList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SuppliersList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SuppliersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuppliersList.Location = new System.Drawing.Point(797, 61);
            this.SuppliersList.MultiSelect = false;
            this.SuppliersList.Name = "SuppliersList";
            this.SuppliersList.ReadOnly = true;
            this.SuppliersList.RowHeadersVisible = false;
            this.SuppliersList.RowHeadersWidth = 51;
            this.SuppliersList.RowTemplate.Height = 24;
            this.SuppliersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SuppliersList.Size = new System.Drawing.Size(334, 474);
            this.SuppliersList.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Заказчики";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(917, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Поставщики";
            // 
            // CBCNFEA
            // 
            this.CBCNFEA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CBCNFEA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCNFEA.FormattingEnabled = true;
            this.CBCNFEA.Items.AddRange(new object[] {
            "10101: Лошади",
            "10102: Ослы",
            "10103: Мулы",
            "10201: Коровы",
            "10202: Буйволы",
            "10301: Свиньи",
            "10401: Овцы",
            "10402: Козы",
            "10501: Куры",
            "10502: Индейки",
            "10503: Утки",
            "10504: Гуси",
            "10505: Цесарки",
            "20101: Соль",
            "20102: Сера",
            "20103: Графит",
            "20104: Глины",
            "20201: Руды",
            "20202: Шлак",
            "20301: Торф",
            "20302: Газ",
            "20303: Нефть",
            "20304: Битум",
            "30101: Древисина топливная",
            "30102: Уголь древесный",
            "30102: Лесоматериалы необработанные",
            "30103: Шпалы деревянные",
            "30201: Пробка натуральная",
            "30301: Изделия из материалов для плетения"});
            this.CBCNFEA.Location = new System.Drawing.Point(518, 61);
            this.CBCNFEA.Name = "CBCNFEA";
            this.CBCNFEA.Size = new System.Drawing.Size(237, 24);
            this.CBCNFEA.TabIndex = 16;
            // 
            // Supply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 547);
            this.Controls.Add(this.CBCNFEA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SuppliersList);
            this.Controls.Add(this.CustomersList);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.AddSupply);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WeightSup);
            this.Name = "Supply";
            this.Text = "Supply";
            ((System.ComponentModel.ISupportInitialize)(this.CustomersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdNumSup;
        private System.Windows.Forms.TextBox IdNumCus;
        private System.Windows.Forms.TextBox CodeCNFEA;
        private System.Windows.Forms.TextBox WeightSup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddSupply;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.DataGridView CustomersList;
        private System.Windows.Forms.DataGridView SuppliersList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBCNFEA;
    }
}