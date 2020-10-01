using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun
{
    public partial class Form1 : Form
    {
        public Player PlayerOne { get; set; }
        public Computer ComputerPlayer { get; set; }
        public Logic GameLogic { get; set; }

        public Form1()
        {
            InitializeComponent();
            PlayerOne = new Player();
            ComputerPlayer = new Computer();
            GameLogic = new Logic();
            lblPlayerShots.Text = PlayerOne.PlayerShots.ToString();
            lblOpponentShots.Text = ComputerPlayer.ComputerShots.ToString();
        }
        private void cmdBlock_Click(object sender, EventArgs e)
        {
            GameLogic.Block(PlayerOne, ComputerPlayer);
            GameLogic.Turn(PlayerOne, ComputerPlayer);
            CheckWinner();
            CheckAmmo();
        }
        private void cmdReload_Click(object sender, EventArgs e)
        {
            GameLogic.Load(PlayerOne, ComputerPlayer);
            GameLogic.Turn(PlayerOne, ComputerPlayer);
            CheckWinner();
            CheckAmmo();
        }
        private void cmdShoot_Click(object sender, EventArgs e)
        {
            GameLogic.Shoot(PlayerOne, ComputerPlayer);
            GameLogic.Turn(PlayerOne, ComputerPlayer);
            CheckWinner();
            CheckAmmo();
        }
        private void cmdShotgun_Click(object sender, EventArgs e)
        {
            GameLogic.Shotgun(PlayerOne, ComputerPlayer);
            GameLogic.Turn(PlayerOne, ComputerPlayer);
            CheckWinner();
            CheckAmmo();
        }
        private void CheckAmmo()
        {
            lblPlayerShots.Text = PlayerOne.PlayerShots.ToString();
            lblOpponentShots.Text = ComputerPlayer.ComputerShots.ToString();
            cmdShoot.Enabled = PlayerOne.HasAmmo();
            cmdShotgun.Enabled = PlayerOne.ShotgunAvailable();
        }
        private void CheckWinner()
        {
            if (ComputerPlayer.IsWinner)
            {
                MessageBox.Show("You have lost!");
                cmdBlock.Enabled = false;
                cmdReload.Enabled = false;
            }
            else if (PlayerOne.IsWinner)
            {
                MessageBox.Show("You have won!");
                cmdBlock.Enabled = false;
                cmdReload.Enabled = false;
            }
        }
        private void cmdPlayAgain_Click(object sender, EventArgs e)
        {

            cmdShoot.Enabled = false;
            cmdReload.Enabled = true;
            cmdBlock.Enabled = true;
            ComputerPlayer.PlayAgain();
            PlayerOne.PlayAgain();
            lblPlayerShots.Text = PlayerOne.PlayerShots.ToString();
            lblOpponentShots.Text = ComputerPlayer.ComputerShots.ToString();
            MessageBox.Show("New Round!");
        }
    }
}


