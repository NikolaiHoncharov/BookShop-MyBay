using BookShop.Forms;
using System;
using System.Windows.Forms;

namespace BookShop
{
    public partial class frmMain : Form
    {
        //инициалиация формы
        public frmMain() {
            InitializeComponent();}

        //Выход
        private void button13_Click(object sender, EventArgs e) { this.Close(); }

        //При загрузке формы устнанов красную черту(SidePanel) к bttnMain
        private void frmMain_Load(object sender, EventArgs e)
        {
            SidePanel.Height = bttnMain.Height;
            SidePanel.Top = bttnMain.Top;
            lblInfor.Text = "Предложение дня!";
            pnlMain.Controls.Add(new MainControl());
            if (!pnlMain.Controls.Contains(MainControl.Instance))
            {
                pnlMain.Controls.Add(MainControl.Instance);
                MainControl.Instance.Dock = DockStyle.Fill;
                MainControl.Instance.BringToFront();
            }
            else MainControl.Instance.BringToFront();
        }

        //Главная
        private void bttnMain_Click(object sender, EventArgs e)
        {
            SidePanel.Height = bttnMain.Height;
            SidePanel.Top = bttnMain.Top;
            lblInfor.Text = "Предложение дня!";
           // pnlMain.Controls.Clear();
            if (!pnlMain.Controls.Contains(MainControl.Instance))
            {
                pnlMain.Controls.Add(MainControl.Instance);
                MainControl.Instance.Dock = DockStyle.Fill;
                MainControl.Instance.BringToFront();
            }
            else MainControl.Instance.BringToFront();
        }

        //каталог
        private void bttnCatalog_Click(object sender, EventArgs e)
        {
            SidePanel.Height = bttnCatalog.Height;
            SidePanel.Top = bttnCatalog.Top;
            lblInfor.Text = "Каталог книг";
            if (!pnlMain.Controls.Contains(ControlCatalog.Instance))
            {
                pnlMain.Controls.Add(ControlCatalog.Instance);
                ControlCatalog.Instance.Dock = DockStyle.Fill;
                ControlCatalog.Instance.BringToFront();
            }
            else ControlCatalog.Instance.BringToFront();
        }

        //Новинки
        private void btnnNew_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnnNew.Height;
            SidePanel.Top = btnnNew.Top;
            lblInfor.Text = "Топ 4 Новых";
            if (!pnlMain.Controls.Contains(ControlNewsBooks.Instance))
            {
                pnlMain.Controls.Add(ControlNewsBooks.Instance);
                ControlNewsBooks.Instance.Dock = DockStyle.Fill;
                ControlNewsBooks.Instance.BringToFront();
            }
            else ControlNewsBooks.Instance.BringToFront();
        }

        //Редоктирование книги
        private void bttnChange_Click(object sender, EventArgs e)
        {
            SidePanel.Height = bttnChange.Height;
            SidePanel.Top = bttnChange.Top;
            lblInfor.Text = "РЕДАКТИРОВАНИЕ";
            if (!pnlMain.Controls.Contains(ControlChangeBook.Instance))
            {
                pnlMain.Controls.Add(ControlChangeBook.Instance);
                ControlChangeBook.Instance.Dock = DockStyle.Fill;
                ControlChangeBook.Instance.BringToFront();
            }
            else ControlChangeBook.Instance.BringToFront();
        }
        
        
        //добавление книги
        private void bttnAddBook_Click(object sender, EventArgs e)
        {
            SidePanel.Height = bttnAddBook.Height;
            SidePanel.Top = bttnAddBook.Top;
            if (!pnlMain.Controls.Contains(ControlAddBook.Instance))
            {
                pnlMain.Controls.Add(ControlAddBook.Instance);
                ControlAddBook.Instance.Dock = DockStyle.Fill;
                ControlAddBook.Instance.BringToFront();
            }
            else ControlAddBook.Instance.BringToFront();
        }

        private void bttnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("за более детальной информацией обращайтесь на email: Goncharovnik@ukr.net");
        }

    }
}
