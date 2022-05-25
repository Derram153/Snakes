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
        //BulletCount.Text = countbullet.ToString();
        Graphics g;
        bool moveUp, moveDown, shootRigth;
        public static int idGuns = 1; //1 - пистолет, 2 - автомат, 3 - снайперка
        int x = 16, y = 10;
        public PictureBox character = new PictureBox();
        public static int countbullet;
        //передача данных
        public static int balance = 0; 
        public Solo()
        {
            Program.solo = this;
            character.Location = new Point(x, y);
            //
            InitializeComponent();
            //
            countbullet = 5;
           // BulletCount.Text = countbullet.ToString();
            gropBoxAK47.Hide();
            groupBoxSniper.Hide();
            character.Parent = Map;
            Image image = Properties.Resources.Character;
            character.Image = image;
            character.SizeMode = PictureBoxSizeMode.AutoSize;
            character.BackColor = Color.Transparent;
            character.BringToFront();
            
        }
        
        private void Map_Paint(object sender, PaintEventArgs e)
        {
            g = Map.CreateGraphics();
            g.DrawLine(new Pen(Brushes.RosyBrown, 10), new Point(80, 0), new Point(80, 660));
            for (int i = 1; i < 5; i++)
                g.DrawLine(new Pen(Brushes.RosyBrown, 5), new Point(80, 100 * i + i * 5), new Point(1458, 100 * i + i * 5));
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            //проверка открыта ли форма
            Shop shop = new Shop();
            if (Application.OpenForms.OfType<Shop>().Count() == 1)
                Application.OpenForms.OfType<Shop>().First().Close();
           labelFocusRemover.Focus(); 
            shop.Show();
        }

        private async void reload_Click(object sender, EventArgs e)
        {
            countbullet = 0;
            //BulletCount.Text = countbullet.ToString();
            groupBoxBullet.Hide();
            reload.Enabled = false;
            await Task.Delay(5000);
            reload.Enabled = true;
            groupBoxBullet.Show();
            labelFocusRemover.Focus();
            //BulletCount.Text = countbullet.ToString();
            switch (idGuns)
            {
                case 1:
                    countbullet = 5;
                    break;
                case 2:
                    countbullet = 10;
                    break;
                case 3:
                    countbullet = 3;
                    break;
            }
            
        }


        private void moveTimerEvent(object sender, EventArgs e)
        {
            BulletCount.Text = countbullet.ToString();
            money.Text = balance.ToString();
            if ((moveDown == true) && (character.Bottom <= 450))
                character.Top += 105;
            if ((moveUp == true) && (character.Top >= 100))
                character.Top -= 105;
        }

            private void AddMoney_Click(object sender, EventArgs e)
        {
            balance += 1000;
            money.Text = balance.ToString();
            labelFocusRemover.Focus();

        }

        //событие для закрытия формы
        private void Solo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                moveDown = true;
            if (e.KeyCode == Keys.Up)
                moveUp = true;
            if (e.KeyCode == Keys.Right)
                shootRigth = true;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                moveDown = false;
            if (e.KeyCode == Keys.Up)
                moveUp = false;
            if (e.KeyCode == Keys.Right)
                shootRigth = false;
        }
    }
}
