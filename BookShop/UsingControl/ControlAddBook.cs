using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BookShop.Forms
{
    public partial class ControlAddBook : UserControl
    {
       
        private static ControlAddBook _inctance;
        public static ControlAddBook Instance
        {
            get
            {
                if (_inctance == null)
                    _inctance = new ControlAddBook();
                return _inctance;
            }
        }

        public ControlAddBook()
        { InitializeComponent(); }

        //добавление автора
        private void dttnAddAuthor_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBxAuthorFN.Text) && !String.IsNullOrWhiteSpace(txtBxAuthorLN.Text))
            {
                using (BookShopEntities db = new BookShopEntities())
                {
                    Authors au = new Authors { FirstName = txtBxAuthorFN.Text, LastName = txtBxAuthorLN.Text };
                    db.Authors.Add(au);
                    db.SaveChanges();
                }
            }
            else MessageBox.Show("Заполните все поля!");
        }

        //добав книг
        private void bttnAddBook_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBookAgeOfPublic.Text) && !String.IsNullOrWhiteSpace(txtBookPage.Text) && !String.IsNullOrWhiteSpace(txtBookPrice.Text) && !String.IsNullOrWhiteSpace(txtBookPublish.Text) &&
                !String.IsNullOrWhiteSpace(txtBookTheme.Text) && !String.IsNullOrWhiteSpace(txtBookTitle.Text) && !String.IsNullOrWhiteSpace(txtLNAuthor.Text))
            {
                using (BookShopEntities db = new BookShopEntities())
                {
                    int price = 0, age=0, page=0;
                    var au = db.Authors.Where(a => a.LastName == txtLNAuthor.Text).FirstOrDefault();
                    if (int.TryParse(txtBookPrice.Text, out price))
                    {
                        if (int.TryParse(txtBookAgeOfPublic.Text, out age))
                        {
                            if (int.TryParse(txtBookPage.Text, out page))
                            {
                                Books book = new Books
                                {
                                    Title = txtBookTitle.Text,
                                    Theme = txtBookTheme.Text,
                                    Publisher = txtBookPublish.Text,
                                    Price = price,
                                    AgeOfReceipt = age,
                                    Pages = page,
                                    AuthorsID = au.ID
                                };
                                db.Books.Add(book);
                                db.SaveChanges();
                            }
                            else MessageBox.Show("только числовые значения");
                        }
                        else MessageBox.Show("только числовые значения");
                    }
                    else MessageBox.Show("только числовые значения");
                }
            }
            else MessageBox.Show("Заполните все поля!");
        }

        //добав книги в магазин
        private void button1_Click(object sender, EventArgs e)
        {
            if ( !String.IsNullOrWhiteSpace(txtShopIdBook.Text) && !String.IsNullOrWhiteSpace(txtShopPicture.Text) && 
                !String.IsNullOrWhiteSpace(txtShopPriceSale.Text) && !String.IsNullOrWhiteSpace(txtShopQuantity.Text))
            {
                int qunt = 0, priceSale =0;      
                using (BookShopEntities db = new BookShopEntities())
                {
                    var book = db.Books.Where(b => b.Title == txtShopIdBook.Text).FirstOrDefault();
                    if (int.TryParse(txtShopQuantity.Text, out qunt))
                    {
                        if (int.TryParse(txtShopPriceSale.Text, out priceSale))
                        {
                            
                            Shop shop = new Shop {
                                Picture = txtShopPicture.Text,
                                QuantityBooks = qunt,
                                DateSales = DateTime.Today,
                                PriceSales = priceSale,
                                BooksID = book.ID};

                            db.Shop.Add(shop);
                            db.SaveChanges();
                        }
                        else MessageBox.Show("только числовые значения");
                    }
                    else MessageBox.Show("только числовые значения");
                }
            }
            else MessageBox.Show("Заполните все поля!");
        }
    }
}
