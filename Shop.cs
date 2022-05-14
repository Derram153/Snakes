using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakes
{
    public partial class Shop : Form
    {
        //private static int balance = 0;
        public Shop()
        {
            InitializeComponent();
            moneyshop.Text = Solo.balance.ToString();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void automat_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(price1.Text);
            int money = Convert.ToInt32(moneyshop.Text);
            if (money >= price)
            {
                Solo.balance -= Convert.ToInt32(price1.Text);
                moneyshop.Text = Solo.balance.ToString();
            }
            //сделать чтобы изменения сразу отображались в "Деньги" в форме Solo
            //или чтобы каждый раз при получении очков оно отображалось
        }
    }
}
