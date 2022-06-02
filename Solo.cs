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
        bool moveUp, moveDown, gameOver = false, shootRight;
        public static int score = 0;//количество килов зомби
        int x = 16, y = 10;
        public PictureBox character = new PictureBox();
        List<Enemy> enemyList = new List<Enemy>();
        public static int countbullet;

        //передача данных
        public static int balance = 0;
        public static int health = 100;

        public Solo()
        {
            Program.solo = this;
            InitializeComponent();
            //1 - пистолет, 2 - автомат, 3 - снайперка
            Guns.Bullets();
            Guns.Buying();
            // BulletCount.Text = countbullet.ToString();
            CharacterCreate();
            CreateEnemies();
        }

        private async void CreateEnemies()
        {
            for (int i = 0; i < 5; i++)
            {
                Enemy enemy = new Enemy();
                enemy.Create(this);
                enemy.picture.Parent = Map;
                enemy.StartMoving();
                enemyList.Add(enemy);
                await Task.Delay(600);
            }
        }

        private void CharacterCreate()
        {
            character.Location = new Point(x, y);
            character.Parent = Map;
            Image image = Properties.Resources.Character_with_gun;
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
            Shop shop = new Shop();
            if (Application.OpenForms.OfType<Shop>().Count() == 1) //проверка открыта ли форма
                Application.OpenForms.OfType<Shop>().First().Close();
            labelFocusRemover.Focus();
            shop.Show();

        }

        private async void Reload_Click(object sender, EventArgs e)
        {
            countbullet = 0;
            groupBoxBullet.Hide();
            reload.Enabled = false;
            shopButton.Enabled = false;
            if (Application.OpenForms.OfType<Shop>().Count() == 1)
                Application.OpenForms.OfType<Shop>().First().Close();
            await Task.Delay(Guns.ReloadingTime());
            reload.Enabled = true;
            shopButton.Enabled = true;
            groupBoxBullet.Show();
            labelFocusRemover.Focus();
            Guns.Bullets();
        }

        private void MoveTimerEvent(object sender, EventArgs e)
        {
            scorelable.Text = score.ToString();
            BulletCount.Text = countbullet.ToString();
            money.Text = balance.ToString();
            if (Guns.id == 4) reload.Enabled = false;
            if (!gameOver)
            {
                if ((moveDown == true) && (character.Bottom <= 450))
                    character.Top += 105;
                if ((moveUp == true) && (character.Top >= 100))
                    character.Top -= 105;
                if (health >= 0)
                {
                    life.Text = health.ToString();
                }
                else
                {
                    gameOver = true;
                    pictureGameOver.Visible = true;
                    foreach (var zombi in enemyList)
                        zombi.Stop();
                    moveTimer.Stop();
                }
            }
        }

        private async void ShootTimerEvent(object sender, EventArgs e)
        {
            if ((shootRight == true) && (countbullet > 0) && (!gameOver))
            {
                countbullet--;
                ShootBullet();
                await Task.Delay(Guns.TimeBetweenShots());
            }
            foreach (PictureBox j in Map.Controls)
            {
                if ((string)j.Tag == "bullet")
                {
                    foreach (Enemy zombie in enemyList)
                    {
                        if (zombie.picture.Bounds.IntersectsWith(j.Bounds))
                        {
                            Map.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            zombie.health -= Guns.Damage();
                            if (zombie.health <= 0)
                            {
                                balance += 100;
                                score++;
                                zombie.Die();
                            }
                        }
                    }
                }
            }
        }

        private void AddMoney_Click(object sender, EventArgs e)
        {
            balance += 1000;
            money.Text = balance.ToString();
            labelFocusRemover.Focus();

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Restart();
            labelFocusRemover.Focus();
        }

        //событие для закрытия формы
        private void Solo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (!gameOver)
            {
                if (e.KeyCode == Keys.Down)
                    moveDown = true;
                if (e.KeyCode == Keys.Up)
                    moveUp = true;
                if (e.KeyCode == Keys.Right)
                    shootRight = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (!gameOver)
            {
                if (e.KeyCode == Keys.Down)
                    moveDown = false;
                if (e.KeyCode == Keys.Up)
                    moveUp = false;
                if (e.KeyCode == Keys.Right)
                    shootRight = false;
                
            }
        }

        private void Restart()
        {
            foreach (Enemy zombi in enemyList)
            {
                Map.Controls.Remove(zombi.picture);
                zombi.Stop();
            }
            enemyList.Clear();
            CreateEnemies();
            Guns.id = 1;
            Guns.Bullets();
            Guns.Buying();
            health = 100;
            balance = 0;
            score = 0;
            pictureGameOver.Visible = false;
            gameOver = false;
            moveTimer.Start();
        }

        private void ShootBullet()
        {
            Bullet shootBullet = new Bullet();

            shootBullet.bulletLeft = character.Left + (character.Width / 2);
            shootBullet.bulletTop = character.Top + (character.Height / 2);
            shootBullet.MakeBullet(this);
            shootBullet.bullet.Parent = Map;
        }
    }
}

