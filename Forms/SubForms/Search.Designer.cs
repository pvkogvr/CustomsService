namespace Coursework.Forms.SubForms
{
    partial class Search
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
            this.SearchSup = new System.Windows.Forms.RadioButton();
            this.SearchCus = new System.Windows.Forms.RadioButton();
            this.Searrch = new System.Windows.Forms.Button();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchSup
            // 
            this.SearchSup.AutoSize = true;
            this.SearchSup.Checked = true;
            this.SearchSup.Location = new System.Drawing.Point(23, 63);
            this.SearchSup.Name = "SearchSup";
            this.SearchSup.Size = new System.Drawing.Size(102, 21);
            this.SearchSup.TabIndex = 0;
            this.SearchSup.TabStop = true;
            this.SearchSup.Text = "Поставщик";
            this.SearchSup.UseVisualStyleBackColor = true;
            // 
            // SearchCus
            // 
            this.SearchCus.AutoSize = true;
            this.SearchCus.Location = new System.Drawing.Point(140, 63);
            this.SearchCus.Name = "SearchCus";
            this.SearchCus.Size = new System.Drawing.Size(91, 21);
            this.SearchCus.TabIndex = 1;
            this.SearchCus.Text = "Заказчик";
            this.SearchCus.UseVisualStyleBackColor = true;
            // 
            // Searrch
            // 
            this.Searrch.Location = new System.Drawing.Point(80, 153);
            this.Searrch.Name = "Searrch";
            this.Searrch.Size = new System.Drawing.Size(94, 34);
            this.Searrch.TabIndex = 2;
            this.Searrch.Text = "Выбрать";
            this.Searrch.UseVisualStyleBackColor = true;
            this.Searrch.Click += new System.EventHandler(this.Searrch_Click);
            // 
            // SearchTB
            // 
            this.SearchTB.Location = new System.Drawing.Point(55, 106);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(132, 22);
            this.SearchTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите Id";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 199);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.Searrch);
            this.Controls.Add(this.SearchCus);
            this.Controls.Add(this.SearchSup);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton SearchSup;
        private System.Windows.Forms.RadioButton SearchCus;
        private System.Windows.Forms.Button Searrch;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Label label1;
    }
}