using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace BookShop.Forms
{
    public partial class ControlSale : UserControl
    {
        Shop sh;
        public ControlSale(Shop sh){InitializeComponent();
            this.sh = sh;
        }

        //загрузка формы + загрузка данных о книге в контрол
        private void ControlSale_Load(object sender, EventArgs e)
        {
            txtBxPrice.Text = "₴ " + (Convert.ToInt32(sh.PriceSales));
            txtBxTitle.Text = sh.Books.Title;
            txtBxAuthor.Text = sh.Books.Authors.LastName;
            txtBxTheme.Text = sh.Books.Theme;
            txtBxAge.Text = sh.Books.AgeOfReceipt.ToString();
            pctrBx.Load(@".../ImajeBook/" + sh.Picture);
        }

        //Покупка передача данных в БД через транзакцию в EF
        private void bttnSale_Click(object sender, EventArgs e)
        {
            using (BookShopEntities db = new BookShopEntities())
            {
                using (DbContextTransaction dbTran = db.Database.BeginTransaction())
                {
                    try
                    {
                        Sales sl = new Sales { BooksID = sh.BooksID, DateOfSales = DateTime.Today, Quantity = 1, Price = (int)sh.PriceSales };
                        db.Sales.Add(sl);
                        Shop s = db.Shop.Where(sp => sp.BooksID == sh.BooksID).FirstOrDefault();
                        s.QuantityBooks = s.QuantityBooks - 1;
                        db.SaveChanges();
                        dbTran.Commit();
                    }
                    catch (Exception ex) { dbTran.Rollback(); }

                }
            }
            //освобождение ресурсов закрытие контроллера
            this.Dispose();
        }

        //освобождение ресурсов
        private void button13_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
