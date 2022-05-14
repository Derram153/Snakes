using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Snakes
{
    public partial class Solo : Form
    {
        //передача данных
        public static int balance = 0; 
        public Solo()
        {
            //balance = Convert.ToInt32(money.Text);
            InitializeComponent();
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            
            Form shop = new Shop();
            if (Application.OpenForms.OfType<Shop>().Count() == 1)
                Application.OpenForms.OfType<Shop>().First().Close();
            shop.Show();
        }

        private async void reload_Click(object sender, EventArgs e)
        {
            bullet1.Hide();
            bullet2.Hide();
            bullet3.Hide();
            bullet4.Hide();
            bullet5.Hide();
            reload.Hide();
            await Task.Delay(5000);
            reload.Show();
            bullet1.Show();
            bullet2.Show();
            bullet3.Show();
            bullet4.Show();
            bullet5.Show();
        }

        private void AddMoney_Click(object sender, EventArgs e)
        {
            balance += 1000;
            money.Text = balance.ToString();
        }


        //событие для закрытия формы
        private void Solo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
