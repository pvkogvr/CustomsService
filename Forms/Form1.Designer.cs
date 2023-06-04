namespace Coursework
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.декларацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ДобавитьДекларацию = new System.Windows.Forms.ToolStripMenuItem();
            this.EmplList = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSupplierMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПоставщиковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказчикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCustomerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗаказчиковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Postavka = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.AddSupl = new System.Windows.Forms.Button();
            this.DeleteCustDec = new System.Windows.Forms.Button();
            this.DelSupply = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.TopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.декларацииToolStripMenuItem,
            this.EmplList,
            this.поставщикиToolStripMenuItem,
            this.заказчикиToolStripMenuItem,
            this.Postavka});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(1061, 28);
            this.TopMenu.TabIndex = 0;
            this.TopMenu.Text = "menuStrip1";
            // 
            // декларацииToolStripMenuItem
            // 
            this.декларацииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ДобавитьДекларацию});
            this.декларацииToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("декларацииToolStripMenuItem.Image")));
            this.декларацииToolStripMenuItem.Name = "декларацииToolStripMenuItem";
            this.декларацииToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.декларацииToolStripMenuItem.Text = "Декларации";
            // 
            // ДобавитьДекларацию
            // 
            this.ДобавитьДекларацию.Image = ((System.Drawing.Image)(resources.GetObject("ДобавитьДекларацию.Image")));
            this.ДобавитьДекларацию.Name = "ДобавитьДекларацию";
            this.ДобавитьДекларацию.Size = new System.Drawing.Size(177, 26);
            this.ДобавитьДекларацию.Text = "Декларации";
            this.ДобавитьДекларацию.Click += new System.EventHandler(this.Declra);
            // 
            // EmplList
            // 
            this.EmplList.Image = ((System.Drawing.Image)(resources.GetObject("EmplList.Image")));
            this.EmplList.Name = "EmplList";
            this.EmplList.Size = new System.Drawing.Size(185, 24);
            this.EmplList.Text = "Список сотрудников";
            this.EmplList.Click += new System.EventHandler(this.EmplList_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSupplierMenu,
            this.списокПоставщиковToolStripMenuItem});
            this.поставщикиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("поставщикиToolStripMenuItem.Image")));
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            // 
            // AddSupplierMenu
            // 
            this.AddSupplierMenu.Name = "AddSupplierMenu";
            this.AddSupplierMenu.Size = new System.Drawing.Size(246, 26);
            this.AddSupplierMenu.Text = "Добавить поставщика";
            this.AddSupplierMenu.Click += new System.EventHandler(this.AddSupplier_Click);
            // 
            // списокПоставщиковToolStripMenuItem
            // 
            this.списокПоставщиковToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("списокПоставщиковToolStripMenuItem.Image")));
            this.списокПоставщиковToolStripMenuItem.Name = "списокПоставщиковToolStripMenuItem";
            this.списокПоставщиковToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.списокПоставщиковToolStripMenuItem.Text = "Список поставщиков";
            this.списокПоставщиковToolStripMenuItem.Click += new System.EventHandler(this.SuppliersList);
            // 
            // заказчикиToolStripMenuItem
            // 
            this.заказчикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCustomerMenu,
            this.списокЗаказчиковToolStripMenuItem});
            this.заказчикиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("заказчикиToolStripMenuItem.Image")));
            this.заказчикиToolStripMenuItem.Name = "заказчикиToolStripMenuItem";
            this.заказчикиToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.заказчикиToolStripMenuItem.Text = "Заказчики";
            // 
            // AddCustomerMenu
            // 
            this.AddCustomerMenu.Name = "AddCustomerMenu";
            this.AddCustomerMenu.Size = new System.Drawing.Size(232, 26);
            this.AddCustomerMenu.Text = "Добавить заказчика";
            this.AddCustomerMenu.Click += new System.EventHandler(this.AddCustomerMenu_Click);
            // 
            // списокЗаказчиковToolStripMenuItem
            // 
            this.списокЗаказчиковToolStripMenuItem.Name = "списокЗаказчиковToolStripMenuItem";
            this.списокЗаказчиковToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.списокЗаказчиковToolStripMenuItem.Text = "Список заказчиков";
            this.списокЗаказчиковToolStripMenuItem.Click += new System.EventHandler(this.CustomersList);
            // 
            // Postavka
            // 
            this.Postavka.Image = ((System.Drawing.Image)(resources.GetObject("Postavka.Image")));
            this.Postavka.Name = "Postavka";
            this.Postavka.Size = new System.Drawing.Size(108, 24);
            this.Postavka.Text = "Поставки";
            this.Postavka.Click += new System.EventHandler(this.PostavkaS);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGV.Location = new System.Drawing.Point(12, 41);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(1037, 452);
            this.DGV.TabIndex = 1;
            this.DGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseDoubleClick);
            // 
            // AddSupl
            // 
            this.AddSupl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSupl.Location = new System.Drawing.Point(160, 499);
            this.AddSupl.Name = "AddSupl";
            this.AddSupl.Size = new System.Drawing.Size(789, 32);
            this.AddSupl.TabIndex = 2;
            this.AddSupl.Text = "Добавить поставку";
            this.AddSupl.UseVisualStyleBackColor = true;
            this.AddSupl.Visible = false;
            this.AddSupl.Click += new System.EventHandler(this.AddSupl_Click);
            // 
            // DeleteCustDec
            // 
            this.DeleteCustDec.Location = new System.Drawing.Point(12, 500);
            this.DeleteCustDec.Name = "DeleteCustDec";
            this.DeleteCustDec.Size = new System.Drawing.Size(150, 31);
            this.DeleteCustDec.TabIndex = 3;
            this.DeleteCustDec.Text = "Удалить";
            this.DeleteCustDec.UseVisualStyleBackColor = true;
            this.DeleteCustDec.Visible = false;
            this.DeleteCustDec.Click += new System.EventHandler(this.DeleteCustDec_Click);
            // 
            // DelSupply
            // 
            this.DelSupply.Location = new System.Drawing.Point(947, 499);
            this.DelSupply.Name = "DelSupply";
            this.DelSupply.Size = new System.Drawing.Size(102, 32);
            this.DelSupply.TabIndex = 4;
            this.DelSupply.Text = "Удалить";
            this.DelSupply.UseVisualStyleBackColor = true;
            this.DelSupply.Click += new System.EventHandler(this.DelSupply_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(763, 500);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(186, 31);
            this.Update.TabIndex = 5;
            this.Update.Text = "Изменить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Visible = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(12, 499);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(150, 31);
            this.Search.TabIndex = 6;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 543);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.DelSupply);
            this.Controls.Add(this.DeleteCustDec);
            this.Controls.Add(this.AddSupl);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.TopMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.TopMenu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таможня";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem декларацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ДобавитьДекларацию;
        private System.Windows.Forms.ToolStripMenuItem EmplList;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказчикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Postavka;
        private System.Windows.Forms.ToolStripMenuItem AddSupplierMenu;
        private System.Windows.Forms.ToolStripMenuItem списокПоставщиковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCustomerMenu;
        private System.Windows.Forms.ToolStripMenuItem списокЗаказчиковToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button AddSupl;
        private System.Windows.Forms.Button DeleteCustDec;
        private System.Windows.Forms.Button DelSupply;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Search;
    }
}

