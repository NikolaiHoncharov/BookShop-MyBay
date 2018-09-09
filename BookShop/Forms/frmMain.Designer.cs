using BookShop.Forms;

namespace BookShop
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.bttnCatalog = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bttnAddBook = new System.Windows.Forms.Button();
            this.bttnChange = new System.Windows.Forms.Button();
            this.bttnMain = new System.Windows.Forms.Button();
            this.btnnNew = new System.Windows.Forms.Button();
            this.bttnHelp = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.PnlControl = new System.Windows.Forms.Panel();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnPropertes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblInfor = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.bttnCatalog);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.bttnAddBook);
            this.panel1.Controls.Add(this.bttnChange);
            this.panel1.Controls.Add(this.bttnMain);
            this.panel1.Controls.Add(this.btnnNew);
            this.panel1.Controls.Add(this.bttnHelp);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 633);
            this.panel1.TabIndex = 1;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 185);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 50);
            this.SidePanel.TabIndex = 15;
            // 
            // bttnCatalog
            // 
            this.bttnCatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bttnCatalog.FlatAppearance.BorderSize = 0;
            this.bttnCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCatalog.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnCatalog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnCatalog.Location = new System.Drawing.Point(0, 243);
            this.bttnCatalog.Name = "bttnCatalog";
            this.bttnCatalog.Size = new System.Drawing.Size(273, 50);
            this.bttnCatalog.TabIndex = 12;
            this.bttnCatalog.Text = "   Каталог ";
            this.bttnCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnCatalog.UseVisualStyleBackColor = false;
            this.bttnCatalog.Click += new System.EventHandler(this.bttnCatalog_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BookShop.Properties.Resources.logo1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // bttnAddBook
            // 
            this.bttnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bttnAddBook.FlatAppearance.BorderSize = 0;
            this.bttnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAddBook.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnAddBook.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnAddBook.Location = new System.Drawing.Point(-1, 426);
            this.bttnAddBook.Name = "bttnAddBook";
            this.bttnAddBook.Size = new System.Drawing.Size(273, 50);
            this.bttnAddBook.TabIndex = 10;
            this.bttnAddBook.Text = "   Добавление книг";
            this.bttnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnAddBook.UseVisualStyleBackColor = false;
            this.bttnAddBook.Click += new System.EventHandler(this.bttnAddBook_Click);
            // 
            // bttnChange
            // 
            this.bttnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bttnChange.FlatAppearance.BorderSize = 0;
            this.bttnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnChange.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnChange.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnChange.Location = new System.Drawing.Point(-1, 365);
            this.bttnChange.Name = "bttnChange";
            this.bttnChange.Size = new System.Drawing.Size(273, 50);
            this.bttnChange.TabIndex = 9;
            this.bttnChange.Text = "   Редактирование";
            this.bttnChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnChange.UseVisualStyleBackColor = false;
            this.bttnChange.Click += new System.EventHandler(this.bttnChange_Click);
            // 
            // bttnMain
            // 
            this.bttnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bttnMain.FlatAppearance.BorderSize = 0;
            this.bttnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMain.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnMain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnMain.Location = new System.Drawing.Point(0, 182);
            this.bttnMain.Name = "bttnMain";
            this.bttnMain.Size = new System.Drawing.Size(273, 50);
            this.bttnMain.TabIndex = 8;
            this.bttnMain.Text = "   Главная ";
            this.bttnMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnMain.UseVisualStyleBackColor = false;
            this.bttnMain.Click += new System.EventHandler(this.bttnMain_Click);
            // 
            // btnnNew
            // 
            this.btnnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnnNew.FlatAppearance.BorderSize = 0;
            this.btnnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnNew.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnnNew.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnnNew.Location = new System.Drawing.Point(0, 304);
            this.btnnNew.Name = "btnnNew";
            this.btnnNew.Size = new System.Drawing.Size(279, 50);
            this.btnnNew.TabIndex = 7;
            this.btnnNew.Text = "   Новинки";
            this.btnnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnNew.UseVisualStyleBackColor = false;
            this.btnnNew.Click += new System.EventHandler(this.btnnNew_Click);
            // 
            // bttnHelp
            // 
            this.bttnHelp.FlatAppearance.BorderSize = 0;
            this.bttnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHelp.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnHelp.ForeColor = System.Drawing.Color.White;
            this.bttnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnHelp.Location = new System.Drawing.Point(4, 587);
            this.bttnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.bttnHelp.Name = "bttnHelp";
            this.bttnHelp.Size = new System.Drawing.Size(48, 42);
            this.bttnHelp.TabIndex = 5;
            this.bttnHelp.Text = "?";
            this.bttnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnHelp.UseVisualStyleBackColor = true;
            this.bttnHelp.Click += new System.EventHandler(this.bttnHelp_Click);
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(4, 672);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(48, 42);
            this.button14.TabIndex = 4;
            this.button14.Text = "?";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // PnlControl
            // 
            this.PnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.PnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlControl.Location = new System.Drawing.Point(279, 0);
            this.PnlControl.Margin = new System.Windows.Forms.Padding(4);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(1002, 20);
            this.PnlControl.TabIndex = 2;
            // 
            // bttnExit
            // 
            this.bttnExit.FlatAppearance.BorderSize = 0;
            this.bttnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.ForeColor = System.Drawing.Color.White;
            this.bttnExit.Image = ((System.Drawing.Image)(resources.GetObject("bttnExit.Image")));
            this.bttnExit.Location = new System.Drawing.Point(1232, 20);
            this.bttnExit.Margin = new System.Windows.Forms.Padding(4);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(43, 43);
            this.bttnExit.TabIndex = 5;
            this.bttnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.button13_Click);
            // 
            // bttnPropertes
            // 
            this.bttnPropertes.FlatAppearance.BorderSize = 0;
            this.bttnPropertes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPropertes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPropertes.ForeColor = System.Drawing.Color.White;
            this.bttnPropertes.Image = ((System.Drawing.Image)(resources.GetObject("bttnPropertes.Image")));
            this.bttnPropertes.Location = new System.Drawing.Point(1166, 20);
            this.bttnPropertes.Margin = new System.Windows.Forms.Padding(4);
            this.bttnPropertes.Name = "bttnPropertes";
            this.bttnPropertes.Size = new System.Drawing.Size(43, 43);
            this.bttnPropertes.TabIndex = 6;
            this.bttnPropertes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnPropertes.UseVisualStyleBackColor = true;
            this.bttnPropertes.Click += new System.EventHandler(this.bttnChange_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(337, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 164);
            this.panel3.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookShop.Properties.Resources.logobook2;
            this.pictureBox1.Location = new System.Drawing.Point(25, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "книжный мир";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "MyBay";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMain.Location = new System.Drawing.Point(279, 175);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1002, 458);
            this.pnlMain.TabIndex = 12;
            // 
            // lblInfor
            // 
            this.lblInfor.AutoSize = true;
            this.lblInfor.BackColor = System.Drawing.Color.Transparent;
            this.lblInfor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfor.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfor.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblInfor.Location = new System.Drawing.Point(584, 60);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(417, 57);
            this.lblInfor.TabIndex = 44;
            this.lblInfor.Text = "РЕДАКТИРОВАНИЕ";
            this.lblInfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PnlControl;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(1281, 633);
            this.Controls.Add(this.lblInfor);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnPropertes);
            this.Controls.Add(this.PnlControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttnChange;
        private System.Windows.Forms.Button bttnMain;
        private System.Windows.Forms.Button btnnNew;
        private System.Windows.Forms.Button bttnHelp;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Panel PnlControl;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnPropertes;
        private System.Windows.Forms.Button bttnAddBook;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnCatalog;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label lblInfor;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}