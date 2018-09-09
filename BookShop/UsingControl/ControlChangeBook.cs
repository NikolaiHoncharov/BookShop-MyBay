using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace BookShop.Forms
{
    public partial class ControlChangeBook : UserControl
    {
        private static ControlChangeBook _inctance;
        public static ControlChangeBook Instance
        {
            get{
                if (_inctance == null)
                    _inctance = new ControlChangeBook();
                return _inctance;}
        }
        public ControlChangeBook(){InitializeComponent();}

        //кнопка закрытия
        private void bttnDispose_Click(object sender, EventArgs e){this.Dispose();}

        private void ControlChangeBook_Load(object sender, EventArgs e)
        {
            //using (BookShopEntities db = new BookShopEntities())
            //{
            //    books = (from b in db.Books
            //             from a in db.Authors
            //             from sh in db.Shop
            //             where a.ID == b.AuthorsID && sh.BooksID == b.ID
            //             select sh).ToList();
            //}
        }

        //chkdBx clik
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtIdSearch.Visible = true;
                bttnSearch.Visible = true;
            }
            if (checkBox1.Checked==false)
            {
                bttnSearch.Visible = false;
                txtIdSearch.Visible = false;
                txtIdSearch.Clear();
            }
        }

        //bnntSearch Click
        private void bttnSearch_Click(object sender, EventArgs e)
        {
           //проверка на не пустое поле поиска
            if (!String.IsNullOrWhiteSpace(txtIdSearch.Text))
            {
                if (!int.TryParse(txtIdSearch.Text, out temp))MessageBox.Show("Вы ввели не числовое значение!");
                else
                {
                    //подключение к БД и считывание таблиц
                    try
                    {
                        BookShopEntities db = new BookShopEntities();
                        books = (from b in db.Books
                                 from a in db.Authors
                                 from shp in db.Shop
                                 where a.ID == b.AuthorsID && shp.BooksID == b.ID
                                 select shp).ToList();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }

                    //загрукзка информвции в форму
                    if (books.Count >= temp && books.Count >0 && temp>0)
                    {
                        sh = (from bk in books where bk.BooksID == temp  select bk).First();
                        txtBxPrice.Text = Convert.ToInt32(sh.PriceSales).ToString();
                        txtBxTitle.Text = sh.Books.Title;
                        txtBxAuthor.Text = sh.Books.Authors.LastName;
                        txtBxAuthorName.Text = sh.Books.Authors.FirstName;
                        txtBxTheme.Text = sh.Books.Theme;
                        txtBxAge.Text = sh.Books.AgeOfReceipt.ToString();
                        pctrBx.Load(@".../ImajeBook/" + sh.Picture);
                        bttnSale.Visible = true;
                    }
                }
            }
        }

        //изменение
        private void bttnSale_Click(object sender, EventArgs e)
        {
            using (BookShopEntities db = new BookShopEntities())
            {
                using (DbContextTransaction dbTran = db.Database.BeginTransaction())
                {
                    try
                    {
                        
                        //МАГАЗИН
                        Shop s = db.Shop.Where(sp => sp.BooksID == temp).FirstOrDefault();
                        int price = 0, age =0;
                        if (int.TryParse(txtBxPrice.Text, out price))s.PriceSales = price;
                        else MessageBox.Show("только числовые значения");
                        
                        //КНИГИ
                        Books b = db.Books.Where(book => book.ID == temp).FirstOrDefault();
                        b.Title = txtBxTitle.Text;
                        b.Theme = txtBxTheme.Text;
                        if (int.TryParse(txtBxAge.Text, out age)) b.AgeOfReceipt = age;
                        else MessageBox.Show("только числовые значения");
                        
                        //Автор
                        Authors a = (from bk1 in db.Books
                                     from author in db.Authors
                                     where author.ID == bk1.AuthorsID && bk1.ID == temp
                                     select author).FirstOrDefault();
                        a.LastName = txtBxAuthor.Text;
                        a.FirstName = txtBxAuthorName.Text;
                        db.SaveChanges();
                            dbTran.Commit();
                        
                    }
                    catch (Exception ex) { dbTran.Rollback(); }

                }
            }
        }
    }
}
