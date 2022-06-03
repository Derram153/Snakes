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
                    return 4;
                case 4:
                    return 2;
            }
            return 0;
        }
        public static void Bonus()
        {
            if (Solo.bonusActive == true)
            {
                switch (id)
                {
                    case 1:
                        if (Solo.score % 2 == 0)
                            Solo.countbullet = 5;
                        break;
                    case 2:
                        if (Solo.score % 10 == 0)
                            Solo.countbullet = 10;
                        break;
                    case 3:
                        if (Solo.score % 2 == 0)
                            Solo.countbullet++;
                        break;
                        //case 4:
                        //   break;
                }
            }
        }
        public static int TimeBetweenShots()
        {
            switch (id)
            {
                case 1:
                    return 600;
                case 2:
                    return 200;
                case 3:
                    return 1000;
                case 4:
                    return 200;
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
                    return 2500;
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
                    Program.solo.groupBoxBullet.Show();
                   // Solo.countbullet = 0;
                    Program.solo.groupBoxMachinegun.Hide();
                    Program.solo.gropBoxAK47.Hide();
                    Program.solo.groupBoxSniper.Hide();
                    Program.solo.groupBoxPistol.Show();
                    Program.solo.character.Image = Properties.Resources.Character_with_gun;
                    break;
                case 2:
                    Program.solo.groupBoxBullet.Hide();
                    Program.solo.reload.Enabled = true;
                    Solo.countbullet = 0;
                    Program.solo.groupBoxMachinegun.Hide();
                    Program.solo.groupBoxPistol.Hide();
                    Program.solo.groupBoxSniper.Hide();
                    Program.solo.gropBoxAK47.Show();
                    Program.solo.character.Image = Properties.Resources.Character1;
                    break;
                case 3:
                    Program.solo.groupBoxBullet.Hide();
                    Program.solo.reload.Enabled = true;
                    Solo.countbullet = 0;
                    Program.solo.groupBoxMachinegun.Hide();
                    Program.solo.gropBoxAK47.Hide();
                    Program.solo.groupBoxPistol.Hide();
                    Program.solo.groupBoxSniper.Show();
                    Program.solo.character.Image = Properties.Resources.Character2;
                    break;
                case 4:
                    //Program.solo.groupBoxBullet.Hide();
                    Solo.countbullet = 100;
                    Program.solo.reload.Enabled = false;
                    Program.solo.gropBoxAK47.Hide();
                    Program.solo.groupBoxPistol.Hide();
                    Program.solo.groupBoxMachinegun.Show();
                    Program.solo.character.Image = Properties.Resources.Character3;
                    break;
            }
        }
    }
}
