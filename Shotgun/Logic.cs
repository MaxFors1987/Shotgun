using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun
{

    public class Logic
    {
        public Player PlayerOne { get; set; }
        public Computer ComputerPlayer { get; set; }

        public void Load(Player player, Computer computer)
        {
            player.CurrentAction = "Load";
            computer.ComputerChoice();
        }
        public void Block(Player player, Computer computer)
        {
            player.CurrentAction = "Block";
            computer.ComputerChoice();
        }
        public void Shoot(Player player, Computer computer)
        {
            player.CurrentAction = "Shoot";
            computer.ComputerChoice();
        }
        public void Shotgun(Player player, Computer computer)
        {
            player.CurrentAction = "Shotgun";
            computer.ComputerChoice();
        }
        public void Turn(Player player, Computer computer)
        {

            RunActions(player, computer);
        }

        private void RunActions(Player player, Computer computer)
        {
            //Om spelarn väljer 
            bool isPlayerLoading = player.CurrentAction.ToLower() == "load";
            bool isPlayerBlocking = player.CurrentAction.ToLower() == "block";
            bool isPlayerShoot = player.CurrentAction.ToLower() == "shoot";
            bool isPlayerShotgun = player.CurrentAction.ToLower() == "shotgun";

            bool isComputerLoading = computer.CurrentAction.ToLower() == "load";
            bool isComputerBlocking = computer.CurrentAction.ToLower() == "block";
            bool isComputerShoot = computer.CurrentAction.ToLower() == "shoot";
            bool isComputerShotgun = computer.CurrentAction.ToLower() == "shotgun";


            //Logiken för om spelaren väljer och motspelarens random drag
            if (isPlayerLoading && isComputerShoot)
            {
                computer.ComputerShots--;
                player.PlayerShots--;
                computer.IsWinner = true;
                player.CurrentAction = "";
                computer.CurrentAction = "";
            }
            else if (isPlayerLoading && isComputerLoading)
            {
                computer.ComputerShots++;
                player.PlayerShots++;
                player.CurrentAction = "";
                computer.CurrentAction = "";
            }
            else if (isPlayerLoading && isComputerBlocking)
            {
                player.PlayerShots++;
                player.CurrentAction = "";
                computer.CurrentAction = "";
            }
            else if (isPlayerLoading && isComputerShotgun)
            {
                computer.ComputerShots -= 3;
                computer.IsWinner = true;
                player.CurrentAction = "";
                computer.CurrentAction = "";
            }
            else if (isPlayerBlocking && isComputerBlocking)
            {
                player.CurrentAction = "";
                computer.CurrentAction = "";
            }
            else if (isPlayerBlocking && isComputerLoading)
            {
                computer.ComputerShots++;
                player.CurrentAction = "";
                computer.CurrentAction = "";
            }
            else if (isPlayerBlocking && isComputerShoot)
            {
                computer.ComputerShots--;
                player.CurrentAction = "";
                computer.CurrentAction = "";
            }
            else if (isPlayerBlocking && isComputerShotgun)
            {
                computer.ComputerShots -= 3;
                computer.IsWinner = true;
                player.CurrentAction = "";
                computer.CurrentAction = "";
            }
            else if (isPlayerShoot && isComputerLoading)
            {
                player.IsWinner = true;
                player.CurrentAction = "";
                computer.CurrentAction = "";
            }
            else if (isPlayerShoot && isComputerBlocking)
            {
                player.PlayerShots--;
                player.CurrentAction = "";
                computer.CurrentAction = "";
            }
            else if (isPlayerShoot && isComputerShoot)
            {
                player.PlayerShots--;
                computer.ComputerShots--;
                player.CurrentAction = "";
                computer.CurrentAction = "";
            }
            else if (isPlayerShotgun)
            {
                player.PlayerShots = 0;
                player.IsWinner = true;
                player.CurrentAction = "";
                computer.CurrentAction = "";
            }
            else if (isComputerShotgun)
            {
                computer.ComputerShots = 0;
                computer.IsWinner = true;
                player.CurrentAction = "";
                computer.CurrentAction = "";
            }
            else
            {
                player.CurrentAction = "";
                computer.CurrentAction = "";
            }

        }
    }
}



