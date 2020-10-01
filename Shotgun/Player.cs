using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun
{
    public class Player : Logic
    {
        public int PlayerShots { get; set; }
        public string CurrentAction { get; set; }
        public bool IsWinner { get; set; }


        public Player()
        {
            PlayerShots = 0;
            IsWinner = false;
            CurrentAction = "";
        }
        //Shotgun blir tillgänlig om spelaren har 3 skott eller fler
        public bool ShotgunAvailable()
        {
            if (PlayerShots >= 3)
            {
                return true;
            }
            else
                return false;
        }
        //Ser om spelarna har skott
        public bool HasAmmo()
        {
            if (PlayerShots > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Om man vill spela igen så nollställs värdena
        public void PlayAgain()
        {
            PlayerShots = 0;
            IsWinner = false;
            CurrentAction = " ";
        }
    }
}
