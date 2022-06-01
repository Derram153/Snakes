﻿using System;
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
        bool moveUp, moveDown, shootRigth, gameOver = false;
        public static int idGuns = 1; //1 - пистолет, 2 - автомат, 3 - снайперка
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
            countbullet = 5;
            gropBoxAK47.Hide();
            groupBoxSniper.Hide();
            CharacterCreate();
            Enemies();
            
        }

        private async void Enemies()
        {
            for (int i = 0; i < 5; i++)
            {
                Enemy enemy = new Enemy();
                enemy.picture.Parent = Map;
                enemy.DoStaff();

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


        private void MoveTimerEvent(object sender, EventArgs e)
        {
            BulletCount.Text = countbullet.ToString();
            money.Text = balance.ToString();
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

        private void Restart()
        {
            for (int i = 0; i < enemyList.Count(); i++)
            {
                enemyList[i].Die();
            }

            //Enemies();

            health = 100;
            balance = 0;
        }
    }
}
