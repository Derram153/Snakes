using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakes
{
    public class Enemy
    {
        public int health, speed, damage;
        public PictureBox picture = new PictureBox();

        //public int version { get; set; } //0 - normal, 1 - fast, 2 - big

        public void DoStaff()
        {
            //Create();
            StartMoving();
        }
        public void Create(Form form)
        {
            Random rnd = new Random();
            int version = rnd.Next(0, 100)%3;
            switch (version)
            {
                case 0:
                    health = 5;
                    speed = 7;
                    damage = 5;
                    picture.Location = GetLocation();
                    picture.Image = Properties.Resources.normal;
                    picture.SizeMode = PictureBoxSizeMode.AutoSize;
                    picture.BackColor = Color.Transparent;
                    picture.BringToFront();
                    form.Controls.Add(picture);
                    break;
                case 1:
                    health = 2;
                    speed = 10;
                    damage = 3;
                    picture.Location = GetLocation();
                    picture.Image = Properties.Resources.fast;
                    picture.SizeMode = PictureBoxSizeMode.AutoSize;
                    picture.BackColor = Color.Transparent;
                    picture.BringToFront();
                    form.Controls.Add(picture);
                    break;
                case 2:
                    health = 7;
                    speed = 5;
                    damage = 10;
                    picture.Location = GetLocation();
                    picture.Image = Properties.Resources.big;
                    picture.SizeMode = PictureBoxSizeMode.AutoSize;
                    picture.BackColor = Color.Transparent;
                    picture.BringToFront();
                    form.Controls.Add(picture);
                    break;
                default:
                    break;
            }
        }
        public void Create()
        {
            Random rnd = new Random();
            int version = rnd.Next(0, 100) % 3;
            switch (version)
            {
                case 0:
                    health = 5;
                    speed = 10;
                    damage = 5;
                    picture.Location = GetLocation();
                    picture.Image = Properties.Resources.normal;
                    picture.SizeMode = PictureBoxSizeMode.AutoSize;
                    picture.BackColor = Color.Transparent;
                    picture.Tag = "zombie";
                    picture.BringToFront();
                    break;
                case 1:
                    health = 2;
                    speed = 15;
                    damage = 3;
                    picture.Location = GetLocation();
                    picture.Image = Properties.Resources.fast;
                    picture.SizeMode = PictureBoxSizeMode.AutoSize;
                    picture.BackColor = Color.Transparent;
                    picture.Tag = "zombie";
                    picture.BringToFront();
                    break;
                case 2:
                    health = 7;
                    speed = 7;
                    damage = 10;
                    picture.Location = GetLocation();
                    picture.Image = Properties.Resources.big;
                    picture.SizeMode = PictureBoxSizeMode.AutoSize;
                    picture.BackColor = Color.Transparent;
                    picture.Tag = "zombie";
                    picture.BringToFront();
                    break;
                default:
                    break;
            }
        }

        public Point GetLocation()
        {
            Random rnd = new Random();
            int line = rnd.Next(0, 100)%5;
            return new Point(1050, 10 + (105 * line));
        }
        public async void StartMoving()
        {
            if (health > 0)
            {
                while (picture.Left >= 100)
                {
                    await Task.Delay(100);
                    picture.Left -= speed;
                }
                Smash(damage);
            }
            else
                Die();
        }
        public void Smash(int damage)
        {
            Solo.health -= damage;
            Create();
            StartMoving();
        }
        public void Die()
        {
            Create();
        }

        public void Stop()
        {
            speed = 0;
        }
    }
}
