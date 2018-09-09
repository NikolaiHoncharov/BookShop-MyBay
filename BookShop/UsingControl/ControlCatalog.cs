using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BookShop.Forms
{
    public partial class ControlCatalog : UserControl
    {
        static int i = 0, y=0;
        int indexbttn1 =-1, indexbttn2 = -1, indexbttn3 = -1,indexbttn4 =-1;
        List<Shop> books;
        private static ControlCatalog _inctance;
        public static ControlCatalog Instance
        {
            get
            {
                if (_inctance == null)
                    _inctance = new ControlCatalog();
                return _inctance;
            }
        }
        public ControlCatalog()
        {
            InitializeComponent();
        }

        //загрузка формы и 4 панелей инфой если она есть
        private void ControlCatalog_Load(object sender, EventArgs e)
        {
            using (BookShopEntities db = new BookShopEntities())
            {
                books = (from b in db.Books
                             from a in db.Authors
                             from sh in db.Shop
                             where a.ID == b.AuthorsID && sh.BooksID == b.ID
                             select sh).ToList();
                if (books != null)
                {
                    
                    for (; i < 4; i++)
                    {
                        if (i == 0) { panel2.Visible = true; Init(lblTitle1, lblAge1, lblTheme1, lblAuthor1, lblPrice1, pchrBxBook1, books[i]); indexbttn1 = i; }
                        if (i == 1) { panel3.Visible = true; Init(lblTitle2, lblAge2, lblTheme2, lblAuthor2, lblPrice2, pchrBxBook2, books[i]); indexbttn2 = i; }
                        if (i == 2) { panel4.Visible = true; Init(lblTitle3, lblAge3, lblTheme3, lblAuthor3, lblPrice3, pchrBxBook3, books[i]); indexbttn3 = i; }
                        if (i == 3) { panel1.Visible = true; Init(lblTitle4, lblAge4, lblTheme4, lblAuthor4, lblPrice4, pchrBxBook4, books[i]); indexbttn4 = i; }
                        
                    }    
                }                
             }
          }

        private void bnntSale4_Click(object sender, EventArgs e)
        {SaleBook(indexbttn4);}

        private void bnntSale2_Click(object sender, EventArgs e)
        {SaleBook(indexbttn2);}

        private void bnntSale3_Click(object sender, EventArgs e)
        {SaleBook(indexbttn3);}

       

        private void bnntSale1_Click(object sender, EventArgs e)
        {SaleBook(indexbttn1);}

        //метод вызова контролелра ПРОДАЖИ
        private void SaleBook(int index) {
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

        //Загрузка данных в панели
        public void Init(Label lblTitle, Label lblAge, Label lblTheme, Label lblAuthor, Label lblPrice, PictureBox pctrBx, Shop sh)
        {
            lblPrice.Text = "₴ " + (Convert.ToInt32(sh.PriceSales));
            lblTitle.Text = sh.Books.Title;
            lblAuthor.Text = $"Автор: {sh.Books.Authors.LastName}";
            lblTheme.Text = $"Жанр: {sh.Books.Theme}";
            lblAge.Text = $"Год: {sh.Books.AgeOfReceipt.ToString()}";
            pctrBx.Load(@".../ImajeBook/" + sh.Picture);
        }


        private void bttnLft_Click(object sender, EventArgs e)
        {
            if (books.Count>i)
            {
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel1.Visible = false;
                y = 0;
                int count = i + 4;
                using (BookShopEntities db = new BookShopEntities())
                {
                  var  books1 = (from b in db.Books
                             from a in db.Authors
                             from sh in db.Shop
                             where a.ID == b.AuthorsID && sh.BooksID == b.ID
                             select sh).ToList();

                    if (books1 != null)
                    {
                        for (; i < count; i++)
                        {
                            if (books1.Count > i)
                            {
                                if (y == 0) { panel1.Visible = true; Init(lblTitle1, lblAge1, lblTheme1, lblAuthor1, lblPrice1, pchrBxBook1, books1[i]); indexbttn1 = i; }
                                if (y == 1) { panel2.Visible = true; Init(lblTitle2, lblAge2, lblTheme2, lblAuthor2, lblPrice2, pchrBxBook2, books1[i]); indexbttn2 = i; }
                                if (y == 2) { panel3.Visible = true; Init(lblTitle3, lblAge3, lblTheme3, lblAuthor3, lblPrice3, pchrBxBook3, books1[i]); indexbttn3 = i; }
                                if (y == 3) { panel4.Visible = true; Init(lblTitle4, lblAge4, lblTheme4, lblAuthor4, lblPrice4, pchrBxBook4, books1[i]); indexbttn4 = i; }
                                y++;
                            }
                        }
                    }
                }
            }
        }

        private void bttnRt_Click(object sender, EventArgs e)
        {
            if (i != 0 && i != 4)
            {
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel1.Visible = false;
                y = 3;
                i -= 4;
                int count = i - 4;
                using (BookShopEntities db = new BookShopEntities())
                {
                    var books1 = (from b in db.Books
                                  from a in db.Authors
                                  from sh in db.Shop
                                  where a.ID == b.AuthorsID && sh.BooksID == b.ID
                                  select sh).ToList();

                    if (books1 != null)
                    {
                        for (; i > count; i--)
                        {
                            if (books1.Count >= i)
                            {
                                if (y == 0) { panel1.Visible = true; Init(lblTitle1, lblAge1, lblTheme1, lblAuthor1, lblPrice1, pchrBxBook1, books1[i]); indexbttn1 = i; }
                                if (y == 1) { panel2.Visible = true; Init(lblTitle2, lblAge2, lblTheme2, lblAuthor2, lblPrice2, pchrBxBook2, books1[i]); indexbttn2 = i; }
                                if (y == 2) { panel3.Visible = true; Init(lblTitle3, lblAge3, lblTheme3, lblAuthor3, lblPrice3, pchrBxBook3, books1[i]); indexbttn3 = i; }
                                if (y == 3) { panel4.Visible = true; Init(lblTitle4, lblAge4, lblTheme4, lblAuthor4, lblPrice4, pchrBxBook4, books1[i]); indexbttn4 = i; }
                                y--;
                            }
                        }
                    }
                }
            }
        }


    }
}
