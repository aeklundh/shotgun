using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shotgun
{
    public partial class frmShotgun : Form
    {

        int playerAmmo = 0, computerAmmo = 0;

        private void UpdatePlayerAmmoLabel()
        {
            lblPlayerAmmoCount.Text = playerAmmo.ToString() + "/3";
        }

        private void UpdateComputerAmmoLabel()
        {
            lblComputerAmmoCount.Text = computerAmmo.ToString() + "/3";
        }

        private void UpdateEventLog(string playerAction, string computerAction)
        {
            lblEventLog.Text = "The player used: " + playerAction + "\nThe computer used: " + computerAction;
        }

        private string ComputerTurn()
        {
            string computerAction = "";

            if (computerAmmo == 0 && playerAmmo == 0)
            {
                computerAction = "load";
            }
            else if (computerAmmo == 0)
            {
                computerAction = ComputerRandomisation("load", "block");
            }
            else if (playerAmmo == 0 && computerAmmo == 2)
            {
                computerAction = "load";
            }
            else if (playerAmmo == 0 && computerAmmo != 3)
            {
                computerAction = ComputerRandomisation("load", "fire");
            }
            else if (computerAmmo == 3)
            {
                computerAction = "shotgun";
            }
            else
            {
                computerAction = ComputerRandomisation("load", "block", "fire");
            }

            switch (computerAction)
            {
                case "load": computerAmmo++; UpdateComputerAmmoLabel(); break;
                case "fire": computerAmmo--; UpdateComputerAmmoLabel(); break;
                case "shotgun": computerAmmo = 0; UpdateComputerAmmoLabel(); break;
            }

            return computerAction;
        }

        private string ComputerRandomisation(string possibility1, string possibility2, string possibility3 = "")
        {
            string action = "";
            int i = 0;
            Random rng = new Random();

            if (possibility3 != "")
            {
                i = rng.Next(1, 4);
            }
            else if (possibility2 == "block")
            {
                i = rng.Next(1, 3);
            }
            else if (possibility2 == "fire")
            {
                i = rng.Next(2, 4);
            }

            switch (i)
            {
                case 1: action = "block"; break;
                case 2: action = "load"; break;
                case 3: action = "fire"; break;
            }

            return action;
        }

        private void SimulateResult(string playerAction, string computerAction)
        {
            string result = "";
            UpdateEventLog(playerAction, computerAction);

            if (playerAction == "load")
            {
                playerAmmo++;
                UpdatePlayerAmmoLabel();
                switch (computerAction)
                {
                    case "fire": result = "computer win"; break;
                    case "shotgun": result = "computer win"; break;
                    default: result = "draw"; break;
                }
            }
            else if (playerAction == "block")
            {
                switch (computerAction)
                {
                    case "shotgun": result = "computer win"; break;
                    default: result = "draw"; break;
                }
            }
            else if (playerAction == "fire")
            {
                playerAmmo--;
                UpdatePlayerAmmoLabel();
                if (playerAmmo == 0)
                {
                    PlayerOutOfAmmo();
                }
                switch (computerAction)
                {
                    case "load": result = "player win"; break;
                    case "shotgun": result = "computer win"; break;
                    default: result = "draw"; break;
                }
            }
            else if (playerAction == "shotgun")
            {
                switch (computerAction)
                {
                    case "shotgun": result = "both lose"; break;
                    default: result = "player win"; break;
                }
            }
            ResolveTurn(result);
        }

        private void ResolveTurn(string result)
        {
            switch (result)
            {
                case "draw": break;
                case "player win": MessageBox.Show("The player wins!"); System.Windows.Forms.Application.Exit(); break;
                case "computer win": MessageBox.Show("The computer wins!"); System.Windows.Forms.Application.Exit(); break;
                case "both lose": MessageBox.Show("It's a draw!"); System.Windows.Forms.Application.Exit(); break;
                default: MessageBox.Show("Whoops, something went wrong..."); break;
            }
        }

        private void PlayerHasShotgun()
        {
            btnLoad.Enabled = false;
            btnBlock.Enabled = false;
            btnFire.Enabled = false;
            btnShotgun.Enabled = true;
        }
        
        private void PlayerOutOfAmmo()
        {
            btnFire.Enabled = false;
        }

        public frmShotgun()
        {
            InitializeComponent();
            lblEventLog.Text = "[Event log]\nThe duelists ready themselves...";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnFire.Enabled = true;

            if (playerAmmo == 3)
            {
                PlayerHasShotgun();
            }

            SimulateResult("load", ComputerTurn());
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            SimulateResult("block", ComputerTurn());
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            SimulateResult("fire", ComputerTurn());
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            playerAmmo = 0;
            UpdatePlayerAmmoLabel();
            SimulateResult("shotgun", ComputerTurn());
        }
    }
}
