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
        public void Setup
        {

        }

        public Solo()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            Image image = Properties.Resources.Didzhey_eban;
            g.DrawImage(Properties.Resources.Didzhey_eban, new Point(100, 100));
        }

        
        private void ShopButton_Click(object sender, EventArgs e)
        {

        }
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
