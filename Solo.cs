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
    public partial class Solo : Form
    {
        Graphics g;
        bool moveUp, moveDown, shootRigth;
        int x = 16, y = 10;
        public PictureBox character = new PictureBox();

        public Solo()
        {
            character.Location = new Point(x, y);
            InitializeComponent();
            character.Parent = pictureBox1;
            
            Image image = Properties.Resources.Character;
            character.Image = image;
            character.SizeMode = PictureBoxSizeMode.AutoSize;
            character.BackColor = Color.Transparent;
            character.BringToFront();
            
        }

        
        private void ShopButton_Click(object sender, EventArgs e)
        {

        }
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.DrawLine(new Pen(Brushes.RosyBrown, 10), new Point(80, 0), new Point(80, 660));
            for (int i = 1; i < 5; i++)
                g.DrawLine(new Pen(Brushes.RosyBrown, 5), new Point(80, 100 * i + i * 5), new Point(1458, 100 * i + i * 5));
        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
            if ((moveDown == true) && (character.Bottom <= 450))
                character.Top += 105;
            if ((moveUp == true) && (character.Top >= 100))
                character.Top -= 105;


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
