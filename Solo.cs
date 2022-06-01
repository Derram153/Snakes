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
        Graphics g;
        public static int score = 0;//количество килов зомби
        bool moveUp, moveDown, shootRigth;
        int x = 16, y = 10;
        public PictureBox character = new PictureBox();
        Enemy[] enemy = new Enemy[5];
        public static int countbullet;
        
        //передача данных
        public static int balance = 0;
        public static int health = 100;
        
        public Solo()
        {
            //Random random = new Random();
            //LehmerRng rng = new LehmerRng(random.Next(1, 50));
            //int[] vs = new int[100];
            //for (int i = 0; i < 100; i++)
            //vs[i]=Convert.ToInt32((rng.Next()*50%4));
            Program.solo = this;
            InitializeComponent();
            //1 - пистолет, 2 - автомат, 3 - снайперка
            Guns.Bullets();
            gropBoxAK47.Hide();
            groupBoxSniper.Hide();
            // BulletCount.Text = countbullet.ToString();
            CharacterCreate();
            Enemies();
            
        }

        private async void RespawnMonsters()
        {
            for (int i = 0; i < 5; i++)
            {
                enemy[i].Die();
                await Task.Delay(100);
            }
        }

        private async void Enemies()
        {
            for (int i = 0; i < 5; i++)
            {
                enemy[i] = new Enemy();
                enemy[i].picture.Parent = Map;
                enemy[i].DoStaff();
                await Task.Delay(600);
            }
            //while (true)
            //{
            //    Enemy en = new Enemy();
            //    en.picture.Parent = Map;
            //    en.DoStaff();
            //    await Task.Delay(7000);
            //}
        }

        private void CharacterCreate()
        {
            character.Location = new Point(x, y);
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

        private void ShopButton_Click(object sender, EventArgs e)
        {
            //проверка открыта ли форма
            Shop shop = new Shop();
            if (Application.OpenForms.OfType<Shop>().Count() == 1)
                Application.OpenForms.OfType<Shop>().First().Close();
            labelFocusRemover.Focus();
            shop.Show();
            
        }

        private async void Reload_Click(object sender, EventArgs e)
        {
            countbullet = 0;
            groupBoxBullet.Hide();
            reload.Enabled = false;
            await Task.Delay(Guns.ReloadingTime());
            reload.Enabled = true;
            groupBoxBullet.Show();
            labelFocusRemover.Focus();
            Guns.Bullets();
        }


        private void MoveTimerEvent(object sender, EventArgs e)
        {
            BulletCount.Text = countbullet.ToString();
            money.Text = balance.ToString();
            if (Guns.id == 4) reload.Enabled = false;
            if ((moveDown == true) && (character.Bottom <= 450))
                character.Top += 105;
            if ((moveUp == true) && (character.Top >= 100))
                character.Top -= 105;
            life.Text = health.ToString();
        }

            private void AddMoney_Click(object sender, EventArgs e)
        {
            balance += 1000;
            money.Text = balance.ToString();
            labelFocusRemover.Focus();

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            RespawnMonsters();
            //Enemies();
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
