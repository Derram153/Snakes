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
        public Solo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form shop = new Shop();
            shop.Show();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            bullet1.Hide();
            bullet2.Hide();
            bullet3.Hide();
            bullet4.Hide();
            bullet5.Hide();
            reload.Hide();
            Thread.Sleep(4000);
            reload.Show();
            bullet1.Show();
            bullet2.Show();
            bullet3.Show();
            bullet4.Show();
            bullet5.Show();
        }
    }
}
