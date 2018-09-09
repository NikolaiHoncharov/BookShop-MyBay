using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.Forms
{
    public partial class ControlNewsBooks : UserControl
    {
        int indexbttn1 = -1, indexbttn2 = -1, indexbttn3 = -1, indexbttn4 = -1;
        List<Shop> books;
        private static ControlNewsBooks _inctance;
        public static ControlNewsBooks Instance
        {
            get
            {
                if (_inctance == null)
                    _inctance = new ControlNewsBooks();
                return _inctance;
            }
        }
        public ControlNewsBooks()
        {InitializeComponent();}

        //кнопки покупки книг
        private void bnntSale4_Click(object sender, EventArgs e)
        {SaleBook(indexbttn4);}

        private void bnntSale2_Click(object sender, EventArgs e)
        {SaleBook(indexbttn2);}

        private void bnntSale3_Click(object sender, EventArgs e)
        {SaleBook(indexbttn3);}

        private void bnntSale1_Click(object sender, EventArgs e)
        {SaleBook(indexbttn1);}

        //при загрузки формы заполняется 4 самых последних книги
        private void ControlNewsBooks_Load(object sender, EventArgs e)
        {
            using (BookShopEntities db = new BookShopEntities())
            {
                books = (from b in db.Books
                             from a in db.Authors
                             from sh in db.Shop
                             where a.ID == b.AuthorsID && sh.BooksID == b.ID
                             orderby sh.DateSales descending
                             select sh).ToList();
                if (books != null)
                {
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (i == 0) { panel1.Visible = true; Init(lblTitle1, lblAge1, lblTheme1, lblAuthor1, lblPrice1, lblDataBySale1, pchrBxBook1, books[i]); indexbttn1 = i; }
                        if (i == 1) { panel2.Visible = true; Init(lblTitle2, lblAge2, lblTheme2, lblAuthor2, lblPrice2, lblDataBySale2, pchrBxBook2, books[i]); indexbttn2 = i; }
                        if (i == 2) { panel3.Visible = true; Init(lblTitle3, lblAge3, lblTheme3, lblAuthor3, lblPrice3, lblDataBySale3, pchrBxBook3, books[i]); indexbttn3 = i; }
                        if (i == 3) { panel4.Visible = true; Init(lblTitle4, lblAge4, lblTheme4, lblAuthor4, lblPrice4, lblDataBySale4, pchrBxBook4, books[i]); indexbttn4 = i; }
                    }
                }
            }
        }

        //метод для заполения полей
        public void Init(Label lblTitle, Label lblAge, Label lblTheme, Label lblAuthor, Label lblPrice, Label lblDataBySale, PictureBox pctrBx, Shop sh)
        {
            lblPrice.Text = "₴ " + (Convert.ToInt32(sh.PriceSales));
            lblTitle.Text = sh.Books.Title;
            lblAuthor.Text = $"Автор: {sh.Books.Authors.LastName}";
            lblTheme.Text = $"Жанр: {sh.Books.Theme}";
            lblAge.Text = $"Год: {sh.Books.AgeOfReceipt.ToString()}";
            lblDataBySale.Text += $" {sh.DateSales.ToString("dd/MM/yy")}";
            pctrBx.Load(@".../ImajeBook/" + sh.Picture);
        }
        //метод для вызова пользовательского контролелра покупки
        private void SaleBook(int index)
        {
            if (index != -1)
            {
                ControlSale sl = new ControlSale(books[index]);

                if (!this.Controls.Contains(sl))
                {
                    this.Controls.Add(sl);
                    sl.Dock = DockStyle.Fill;
                    sl.BringToFront();
                }
                else sl.BringToFront();
            }
        }
    }
}
