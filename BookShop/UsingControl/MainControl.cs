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
    public partial class MainControl : UserControl
    {
        int index;
        List<Shop> books;
        private static MainControl _inctance;
        public static MainControl Instance
        {
            get {
                if (_inctance==null)
                    _inctance = new MainControl();
                return _inctance;
            }
        }

        public MainControl(){InitializeComponent();}

        private void MainControl_Load(object sender, EventArgs e)
        {
            using (BookShopEntities db = new BookShopEntities())
            {
                books = (from b in db.Books
                             from a in db.Authors
                             from sh in db.Shop
                             where a.ID == b.AuthorsID && sh.BooksID == b.ID
                             select sh).ToList();
                Random rand = new Random();
                index = rand.Next(0, books.Count-1);

                lblPrice.Text = "₴ " + (Convert.ToInt32(books[index].PriceSales - Convert.ToInt32(Convert.ToDouble(books[index].PriceSales) * 0.05)));
                lblTitle.Text = books[index].Books.Title;
                lblAuthor.Text = $"Автор: {books[index].Books.Authors.LastName} {books[index].Books.Authors.FirstName}";
                lblTheme.Text = $"Жанр: {books[index].Books.Theme}";
                lblAge.Text = $"Год: {books[index].Books.AgeOfReceipt.ToString()}";
                pchrBxBook.Load(@".../ImajeBook/"+ books[index].Picture);
            }
        }

        private void bnntSale_Click(object sender, EventArgs e)
        {
            //нужен другой вариант с покупкой возможно корзина или вообще убрать кнопку купить
            books[index].PriceSales = Convert.ToInt32(books[index].PriceSales - Convert.ToInt32(Convert.ToDouble(books[index].PriceSales) * 0.05));
            ControlSale sl = new ControlSale(books[index]);

            if (!MainControl.Instance.Controls.Contains(sl))
            {
                MainControl.Instance.Controls.Add(sl);
                sl.Dock = DockStyle.Fill;
                sl.BringToFront();
            }
            else sl.BringToFront();

           
            //if (!MainControl.Instance.Controls.Contains(ControlCatalog.Instance))
            //{
            //    MainControl.Instance.Controls.Add(ControlCatalog.Instance);
            //    ControlCatalog.Instance.Dock = DockStyle.Fill;
            //    ControlCatalog.Instance.BringToFront();
            //}
            //else ControlCatalog.Instance.BringToFront();
        }
    }
}
