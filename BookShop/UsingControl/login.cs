using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BookShop
{
    public partial class login : UserControl
    {
        string name;
        public login()
        {
            InitializeComponent();
            txtPassword.KeyPress += TxtPassword_KeyPress;    
            txtLogin.KeyPress += TxtPassword_KeyPress;
        }


        int panel1_y = 500, waiter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            waiter++;
            if (waiter > 150)
            {
                panel1_y -= 6;
                panel1.Size = new Size(panel1.Size.Width, panel1_y);
                if (panel1_y < 1)
                {
                    panel1.Hide();
                    timer1.Enabled = false;
                }
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!String.IsNullOrWhiteSpace(txtLogin.Text) && !String.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    using (BookShopEntities db = new BookShopEntities())
                    {
                        var query = (from sl in db.Seller
                                     where sl.Login == txtLogin.Text
                                     where sl.Password == txtPassword.Text
                                     select sl).FirstOrDefault();
                        if (query != null)
                        {

                            if ((query.Login==txtLogin.Text) && (query.Password==txtPassword.Text))
                            {
                                timer1.Enabled = false;
                                timer2.Enabled = true;
                                name = query.FirstName;
                            }
                            else
                            {
                                txtLogin.Clear();
                                txtPassword.Clear();
                            }
                        }
                    }
                }
                else
                {
                    txtLogin.Clear();
                    txtPassword.Clear();
                }
            }
        }

        int panel2_y = 500;
        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2_y -= 6;
            panel2.Size = new Size(panel2.Size.Width, panel2_y);
            if (panel2_y < 1)
            {
                panel2.Hide();
                timer2.Enabled = false;
                label6.Text += name+ "!";
                timer3.Enabled = true;
            }
        }
        int panel3_y = 500;



        private void timer3_Tick(object sender, EventArgs e)
        {
            
            panel3_y -= 6;
           
            if (panel3_y < 1)
            {
                
                timer3.Enabled = false;
                //label6.Text = "Удачи";
                frmMain frm = new frmMain();
                frm.ShowDialog();

            }
           
        }

    }
}
