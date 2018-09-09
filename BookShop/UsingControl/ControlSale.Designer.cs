namespace BookShop.Forms
{
    partial class ControlSale
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
            this.bttnSale = new System.Windows.Forms.Button();
            this.lblPrice3 = new System.Windows.Forms.Label();
            this.lblAge3 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.pctrBx = new System.Windows.Forms.PictureBox();
            this.lblTheme3 = new System.Windows.Forms.Label();
            this.lblAuthor3 = new System.Windows.Forms.Label();
            this.txtBxTitle = new System.Windows.Forms.TextBox();
            this.txtBxAuthor = new System.Windows.Forms.TextBox();
            this.txtBxTheme = new System.Windows.Forms.TextBox();
            this.txtBxAge = new System.Windows.Forms.TextBox();
            this.txtBxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnDispose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBx)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnSale
            // 
            this.bttnSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.bttnSale.FlatAppearance.BorderSize = 0;
            this.bttnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSale.Font = new System.Drawing.Font("Segoe Script", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bttnSale.Location = new System.Drawing.Point(32, 422);
            this.bttnSale.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSale.Name = "bttnSale";
            this.bttnSale.Size = new System.Drawing.Size(662, 57);
            this.bttnSale.TabIndex = 21;
            this.bttnSale.Text = "Купить";
            this.bttnSale.UseVisualStyleBackColor = false;
            this.bttnSale.Click += new System.EventHandler(this.bttnSale_Click);
            // 
            // lblPrice3
            // 
            this.lblPrice3.AutoEllipsis = true;
            this.lblPrice3.AutoSize = true;
            this.lblPrice3.Font = new System.Drawing.Font("Segoe Print", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.lblPrice3.Location = new System.Drawing.Point(121, 313);
            this.lblPrice3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice3.Name = "lblPrice3";
            this.lblPrice3.Size = new System.Drawing.Size(92, 44);
            this.lblPrice3.TabIndex = 17;
            this.lblPrice3.Text = "Цена:";
            // 
            // lblAge3
            // 
            this.lblAge3.AutoEllipsis = true;
            this.lblAge3.AutoSize = true;
            this.lblAge3.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAge3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.lblAge3.Location = new System.Drawing.Point(153, 263);
            this.lblAge3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge3.Name = "lblAge3";
            this.lblAge3.Size = new System.Drawing.Size(54, 30);
            this.lblAge3.TabIndex = 22;
            this.lblAge3.Text = "Год:";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoEllipsis = true;
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.lblTitle3.Location = new System.Drawing.Point(53, 93);
            this.lblTitle3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(159, 50);
            this.lblTitle3.TabIndex = 18;
            this.lblTitle3.Text = "Название:";
            this.lblTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctrBx
            // 
            this.pctrBx.Location = new System.Drawing.Point(720, 3);
            this.pctrBx.Name = "pctrBx";
            this.pctrBx.Size = new System.Drawing.Size(397, 494);
            this.pctrBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrBx.TabIndex = 16;
            this.pctrBx.TabStop = false;
            // 
            // lblTheme3
            // 
            this.lblTheme3.AutoEllipsis = true;
            this.lblTheme3.AutoSize = true;
            this.lblTheme3.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTheme3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.lblTheme3.Location = new System.Drawing.Point(134, 213);
            this.lblTheme3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheme3.Name = "lblTheme3";
            this.lblTheme3.Size = new System.Drawing.Size(78, 30);
            this.lblTheme3.TabIndex = 20;
            this.lblTheme3.Text = "Жанр:";
            // 
            // lblAuthor3
            // 
            this.lblAuthor3.AutoEllipsis = true;
            this.lblAuthor3.AutoSize = true;
            this.lblAuthor3.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthor3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.lblAuthor3.Location = new System.Drawing.Point(123, 163);
            this.lblAuthor3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor3.Name = "lblAuthor3";
            this.lblAuthor3.Size = new System.Drawing.Size(89, 30);
            this.lblAuthor3.TabIndex = 19;
            this.lblAuthor3.Text = "Автор:";
            // 
            // txtBxTitle
            // 
            this.txtBxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxTitle.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxTitle.Location = new System.Drawing.Point(227, 104);
            this.txtBxTitle.Name = "txtBxTitle";
            this.txtBxTitle.ReadOnly = true;
            this.txtBxTitle.Size = new System.Drawing.Size(361, 39);
            this.txtBxTitle.TabIndex = 23;
            // 
            // txtBxAuthor
            // 
            this.txtBxAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxAuthor.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxAuthor.Location = new System.Drawing.Point(227, 156);
            this.txtBxAuthor.Name = "txtBxAuthor";
            this.txtBxAuthor.ReadOnly = true;
            this.txtBxAuthor.Size = new System.Drawing.Size(361, 39);
            this.txtBxAuthor.TabIndex = 24;
            // 
            // txtBxTheme
            // 
            this.txtBxTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxTheme.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxTheme.Location = new System.Drawing.Point(227, 208);
            this.txtBxTheme.Name = "txtBxTheme";
            this.txtBxTheme.ReadOnly = true;
            this.txtBxTheme.Size = new System.Drawing.Size(361, 39);
            this.txtBxTheme.TabIndex = 25;
            // 
            // txtBxAge
            // 
            this.txtBxAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxAge.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxAge.Location = new System.Drawing.Point(227, 260);
            this.txtBxAge.Name = "txtBxAge";
            this.txtBxAge.ReadOnly = true;
            this.txtBxAge.Size = new System.Drawing.Size(361, 39);
            this.txtBxAge.TabIndex = 26;
            // 
            // txtBxPrice
            // 
            this.txtBxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxPrice.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxPrice.Location = new System.Drawing.Point(227, 312);
            this.txtBxPrice.Name = "txtBxPrice";
            this.txtBxPrice.ReadOnly = true;
            this.txtBxPrice.Size = new System.Drawing.Size(361, 39);
            this.txtBxPrice.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(258, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 54);
            this.label1.TabIndex = 28;
            this.label1.Text = "ПОКУПКА";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnDispose
            // 
            this.bttnDispose.BackColor = System.Drawing.Color.Transparent;
            this.bttnDispose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnDispose.FlatAppearance.BorderSize = 0;
            this.bttnDispose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDispose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDispose.ForeColor = System.Drawing.Color.White;
            this.bttnDispose.Image = global::BookShop.Properties.Resources.exitWithControl;
            this.bttnDispose.Location = new System.Drawing.Point(1134, 4);
            this.bttnDispose.Margin = new System.Windows.Forms.Padding(4);
            this.bttnDispose.Name = "bttnDispose";
            this.bttnDispose.Size = new System.Drawing.Size(59, 67);
            this.bttnDispose.TabIndex = 29;
            this.bttnDispose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnDispose.UseVisualStyleBackColor = false;
            this.bttnDispose.Click += new System.EventHandler(this.button13_Click);
            // 
            // ControlSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.bttnDispose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxPrice);
            this.Controls.Add(this.txtBxAge);
            this.Controls.Add(this.txtBxTheme);
            this.Controls.Add(this.txtBxAuthor);
            this.Controls.Add(this.txtBxTitle);
            this.Controls.Add(this.bttnSale);
            this.Controls.Add(this.lblPrice3);
            this.Controls.Add(this.lblAge3);
            this.Controls.Add(this.lblTitle3);
            this.Controls.Add(this.pctrBx);
            this.Controls.Add(this.lblTheme3);
            this.Controls.Add(this.lblAuthor3);
            this.Name = "ControlSale";
            this.Size = new System.Drawing.Size(1197, 500);
            this.Load += new System.EventHandler(this.ControlSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnSale;
        private System.Windows.Forms.Label lblPrice3;
        private System.Windows.Forms.Label lblAge3;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.PictureBox pctrBx;
        private System.Windows.Forms.Label lblTheme3;
        private System.Windows.Forms.Label lblAuthor3;
        private System.Windows.Forms.TextBox txtBxTitle;
        private System.Windows.Forms.TextBox txtBxAuthor;
        private System.Windows.Forms.TextBox txtBxTheme;
        private System.Windows.Forms.TextBox txtBxAge;
        private System.Windows.Forms.TextBox txtBxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnDispose;
    }
}
