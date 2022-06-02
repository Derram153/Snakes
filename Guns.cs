using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    class Guns
    {
        //1 - пистолет, 2 - автомат, 3 - снайперка, 4 - пулемет
        public static int id = 1;
        public static int Damage()
        {
            switch (id)
            {
                case 1:
                    return 1;
                case 2:
                    return 1;
                case 3:
                    return 6;
                case 4:
                    return 1;
            }
            return 0;
        }
        public static int TimeBetweenShots()
        {
            switch (id)
            {
                case 1:
                    return 1000;
                case 2:
                    return 200;
                case 3:
                    return 2000;
                case 4:
                    return 1;
            }
            return 0;
        }
        public static void Bullets()
        {
            switch (id)
            {
                case 1:
                    Solo.countbullet = 5;
                    break;
                case 2:
                    Solo.countbullet = 10;
                    break;
                case 3:
                    Solo.countbullet = 3;
                    break;
                case 4:
                    Solo.countbullet = 100;
                    break;
            }
        } 
        public static int ReloadingTime()
        {
            switch (id)
            {
                case 1:
                    return 1500;
                case 2:
                    return 2000;
                case 3:
                    return 1500;
            }
            return 0;
        }
        public static void Buying()
        {
            switch (id)
            {
                case 1:
                   // Program.solo.groupBoxBullet.Show();
                   // Solo.countbullet = 0;
                    Program.solo.groupBoxMachinegun.Hide();
                    Program.solo.gropBoxAK47.Hide();
                    Program.solo.groupBoxSniper.Hide();
                   // Program.solo.groupBoxPistol.Show();
                    break;
                case 2:
                    Program.solo.groupBoxBullet.Hide();
                    Program.solo.reload.Enabled = true;
                    Solo.countbullet = 0;
                    Program.solo.groupBoxMachinegun.Hide();
                    Program.solo.groupBoxPistol.Hide();
                    Program.solo.groupBoxSniper.Hide();
                    Program.solo.gropBoxAK47.Show();
                    break;
                case 3:
                    Program.solo.groupBoxBullet.Hide();
                    Program.solo.reload.Enabled = true;
                    Solo.countbullet = 0;
                    Program.solo.groupBoxMachinegun.Hide();
                    Program.solo.gropBoxAK47.Hide();
                    Program.solo.groupBoxPistol.Hide();
                    Program.solo.groupBoxSniper.Show();
                    break;
                case 4:
                    //Program.solo.groupBoxBullet.Hide();
                    Solo.countbullet = 100;
                    Program.solo.reload.Enabled = false;
                    Program.solo.gropBoxAK47.Hide();
                    Program.solo.groupBoxPistol.Hide();
                    Program.solo.groupBoxMachinegun.Show();
                    break;
            }
        }
    }
}
