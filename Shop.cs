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
        public Shop()
        {
            InitializeComponent();
            moneyshop.Text = Solo.balance.ToString();
        }

        private void Automat_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(price1.Text);
            int money = Convert.ToInt32(moneyshop.Text);

            if (money >= price)
            {
                Guns.id = 2;
                Guns.Buying();
                Solo.balance -= price;
                moneyshop.Text = Solo.balance.ToString();
                Close();
            }
        }

        private void Rifle_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(price2.Text);
            int money = Convert.ToInt32(moneyshop.Text);
            if (money >= price)
            {
                Guns.id = 3;
                Guns.Buying();
                Solo.balance -= price;
                moneyshop.Text = Solo.balance.ToString();
                Close();
            }
        }

        private void machinegun_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(price3.Text);
            int money = Convert.ToInt32(moneyshop.Text);
            if (money >= price)
            {
                Guns.id = 4;
                Guns.Buying();
                Solo.balance -= price;
                moneyshop.Text = Solo.balance.ToString();
                Close();
            }
        }

        private void Repair_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(price4.Text);
            int money = Convert.ToInt32(moneyshop.Text);
            if (money >= price)
            {
                Solo.balance -= price;
                Solo.health += 10;
                moneyshop.Text = Solo.balance.ToString();
                Close();
            }
        }
    }
}
