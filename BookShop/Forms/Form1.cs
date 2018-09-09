using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class Form1 : Form
    {
        login uc;
        public Form1()
        {
            InitializeComponent();
            uc = new login();
            Controls.Add(uc);
            
        }


    }
}
