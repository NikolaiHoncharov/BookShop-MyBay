using System.Collections.Generic;

namespace BookShop.Forms
{
    partial class ControlChangeBook
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBxPrice = new System.Windows.Forms.TextBox();
            this.txtBxAge = new System.Windows.Forms.TextBox();
            this.txtBxTheme = new System.Windows.Forms.TextBox();
            this.txtBxAuthor = new System.Windows.Forms.TextBox();
            this.txtBxTitle = new System.Windows.Forms.TextBox();
            this.bttnSale = new System.Windows.Forms.Button();
            this.lblPrice3 = new System.Windows.Forms.Label();
            this.lblAge3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pctrBx = new System.Windows.Forms.PictureBox();
            this.lblTheme3 = new System.Windows.Forms.Label();
            this.lblAuthor3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtIdSearch = new System.Windows.Forms.TextBox();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxAuthorName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBx)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxPrice
            // 
            this.txtBxPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtBxPrice.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxPrice.Location = new System.Drawing.Point(360, 372);
            this.txtBxPrice.Name = "txtBxPrice";
            this.txtBxPrice.Size = new System.Drawing.Size(361, 39);
            this.txtBxPrice.TabIndex = 41;
            this.txtBxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxAge
            // 
            this.txtBxAge.BackColor = System.Drawing.SystemColors.Control;
            this.txtBxAge.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxAge.Location = new System.Drawing.Point(360, 312);
            this.txtBxAge.Name = "txtBxAge";
            this.txtBxAge.Size = new System.Drawing.Size(361, 39);
            this.txtBxAge.TabIndex = 40;
            this.txtBxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxTheme
            // 
            this.txtBxTheme.BackColor = System.Drawing.SystemColors.Control;
            this.txtBxTheme.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxTheme.Location = new System.Drawing.Point(360, 252);
            this.txtBxTheme.Name = "txtBxTheme";
            this.txtBxTheme.Size = new System.Drawing.Size(361, 39);
            this.txtBxTheme.TabIndex = 39;
            this.txtBxTheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxAuthor
            // 
            this.txtBxAuthor.BackColor = System.Drawing.SystemColors.Control;
            this.txtBxAuthor.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxAuthor.Location = new System.Drawing.Point(360, 143);
            this.txtBxAuthor.Name = "txtBxAuthor";
            this.txtBxAuthor.Size = new System.Drawing.Size(361, 39);
            this.txtBxAuthor.TabIndex = 38;
            this.txtBxAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxTitle
            // 
            this.txtBxTitle.BackColor = System.Drawing.SystemColors.Control;
            this.txtBxTitle.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxTitle.Location = new System.Drawing.Point(360, 88);
            this.txtBxTitle.Name = "txtBxTitle";
            this.txtBxTitle.Size = new System.Drawing.Size(361, 39);
            this.txtBxTitle.TabIndex = 37;
            this.txtBxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttnSale
            // 
            this.bttnSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.bttnSale.FlatAppearance.BorderSize = 0;
            this.bttnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSale.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bttnSale.Location = new System.Drawing.Point(39, 454);
            this.bttnSale.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSale.Name = "bttnSale";
            this.bttnSale.Size = new System.Drawing.Size(691, 67);
            this.bttnSale.TabIndex = 35;
            this.bttnSale.Text = "Изменить";
            this.bttnSale.UseVisualStyleBackColor = false;
            this.bttnSale.Visible = false;
            this.bttnSale.Click += new System.EventHandler(this.bttnSale_Click);
            // 
            // lblPrice3
            // 
            this.lblPrice3.AutoEllipsis = true;
            this.lblPrice3.AutoSize = true;
            this.lblPrice3.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPrice3.ForeColor = System.Drawing.Color.Green;
            this.lblPrice3.Location = new System.Drawing.Point(100, 382);
            this.lblPrice3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice3.Name = "lblPrice3";
            this.lblPrice3.Size = new System.Drawing.Size(178, 29);
            this.lblPrice3.TabIndex = 31;
            this.lblPrice3.Text = "Цена продажи:";
            // 
            // lblAge3
            // 
            this.lblAge3.AutoEllipsis = true;
            this.lblAge3.AutoSize = true;
            this.lblAge3.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAge3.ForeColor = System.Drawing.Color.Green;
            this.lblAge3.Location = new System.Drawing.Point(100, 322);
            this.lblAge3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge3.Name = "lblAge3";
            this.lblAge3.Size = new System.Drawing.Size(225, 29);
            this.lblAge3.TabIndex = 36;
            this.lblAge3.Text = "Год издательства:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitle.ForeColor = System.Drawing.Color.Green;
            this.lblTitle.Location = new System.Drawing.Point(100, 98);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 29);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Название:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctrBx
            // 
            this.pctrBx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctrBx.Location = new System.Drawing.Point(767, 27);
            this.pctrBx.Name = "pctrBx";
            this.pctrBx.Size = new System.Drawing.Size(397, 494);
            this.pctrBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrBx.TabIndex = 30;
            this.pctrBx.TabStop = false;
            // 
            // lblTheme3
            // 
            this.lblTheme3.AutoEllipsis = true;
            this.lblTheme3.AutoSize = true;
            this.lblTheme3.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTheme3.ForeColor = System.Drawing.Color.Green;
            this.lblTheme3.Location = new System.Drawing.Point(100, 262);
            this.lblTheme3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheme3.Name = "lblTheme3";
            this.lblTheme3.Size = new System.Drawing.Size(156, 29);
            this.lblTheme3.TabIndex = 34;
            this.lblTheme3.Text = "Жанр книги:";
            // 
            // lblAuthor3
            // 
            this.lblAuthor3.AutoEllipsis = true;
            this.lblAuthor3.AutoSize = true;
            this.lblAuthor3.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAuthor3.ForeColor = System.Drawing.Color.Green;
            this.lblAuthor3.Location = new System.Drawing.Point(100, 153);
            this.lblAuthor3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor3.Name = "lblAuthor3";
            this.lblAuthor3.Size = new System.Drawing.Size(213, 29);
            this.lblAuthor3.TabIndex = 33;
            this.lblAuthor3.Text = "Фамилия автора:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(105, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(238, 29);
            this.checkBox1.TabIndex = 44;
            this.checkBox1.Text = "Изменить по ID книги";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtIdSearch
            // 
            this.txtIdSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdSearch.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIdSearch.Location = new System.Drawing.Point(360, 27);
            this.txtIdSearch.Name = "txtIdSearch";
            this.txtIdSearch.Size = new System.Drawing.Size(251, 39);
            this.txtIdSearch.TabIndex = 46;
            this.txtIdSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdSearch.Visible = false;
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.Color.Transparent;
            this.bttnSearch.BackgroundImage = global::BookShop.Properties.Resources._2164;
            this.bttnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnSearch.FlatAppearance.BorderSize = 0;
            this.bttnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSearch.ForeColor = System.Drawing.Color.White;
            this.bttnSearch.Location = new System.Drawing.Point(618, 26);
            this.bttnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(49, 39);
            this.bttnSearch.TabIndex = 47;
            this.bttnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Visible = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(100, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Имя автора:";
            // 
            // txtBxAuthorName
            // 
            this.txtBxAuthorName.BackColor = System.Drawing.SystemColors.Control;
            this.txtBxAuthorName.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxAuthorName.Location = new System.Drawing.Point(360, 197);
            this.txtBxAuthorName.Name = "txtBxAuthorName";
            this.txtBxAuthorName.Size = new System.Drawing.Size(361, 39);
            this.txtBxAuthorName.TabIndex = 49;
            this.txtBxAuthorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ControlChangeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.txtBxAuthorName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.txtIdSearch);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtBxPrice);
            this.Controls.Add(this.txtBxAge);
            this.Controls.Add(this.txtBxTheme);
            this.Controls.Add(this.txtBxAuthor);
            this.Controls.Add(this.txtBxTitle);
            this.Controls.Add(this.bttnSale);
            this.Controls.Add(this.lblPrice3);
            this.Controls.Add(this.lblAge3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pctrBx);
            this.Controls.Add(this.lblTheme3);
            this.Controls.Add(this.lblAuthor3);
            this.Name = "ControlChangeBook";
            this.Size = new System.Drawing.Size(1185, 585);
            this.Load += new System.EventHandler(this.ControlChangeBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxPrice;
        private System.Windows.Forms.TextBox txtBxAge;
        private System.Windows.Forms.TextBox txtBxTheme;
        private System.Windows.Forms.TextBox txtBxAuthor;
        private System.Windows.Forms.TextBox txtBxTitle;
        private System.Windows.Forms.Button bttnSale;
        private System.Windows.Forms.Label lblPrice3;
        private System.Windows.Forms.Label lblAge3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pctrBx;
        private System.Windows.Forms.Label lblTheme3;
        private System.Windows.Forms.Label lblAuthor3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtIdSearch;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxAuthorName;
        int temp = -1;
        Shop sh;
        List<Shop> books;
    }
}
