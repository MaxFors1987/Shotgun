using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun
{
    public class Computer : Logic
    {
        public int ComputerShots { get; set; }
        public string CurrentAction { get; set; }
        public bool IsWinner { get; set; }
        public bool FirstMove { get; set; }


        public Computer()
        {
            ComputerShots = 0;
            IsWinner = false;
            CurrentAction = "";
            FirstMove = true;
        }
        //Om spelaren har 3 skott eller fler så blir shotgun tillgänglig
        public bool ComputerShotgun()
        {
            if (ComputerShots >= 3)
            {
                return true;
            }
            else
                return false;
        }
        //Random logic för datorns val
        public void ComputerChoice()
        {
            if (FirstMove)
            {
                CurrentAction = "load";
                FirstMove = false;
                return;
            }
            if (ComputerShots >= 3)
            {
                string[] choices = { "block", "load", "shoot", "shotgun" };
                Random rnd = new Random();
                int num = rnd.Next(0, 4);
                CurrentAction = choices[num];
            }
            else if (ComputerShots > 0)
            {
                string[] choices = { "block", "load", "shoot" };
                Random rnd = new Random();
                int num = rnd.Next(0, 3);
                CurrentAction = choices[num];
            }
            else
            {
                string[] choices = { "block", "load" };
                Random rnd = new Random();
                int num = rnd.Next(0, 2);
                CurrentAction = choices[num];
            }
        }
        public void PlayAgain()
        {
            ComputerShots = 0;
            FirstMove = true;
            IsWinner = false;
            CurrentAction = "";
        }
    }
}

