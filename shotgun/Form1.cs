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

        private string ComputerTurn()
        {
            string computerAction = "";

            //ska kolla vilka möjligheter datorn har, sedan randomisera en action att utföra

            return computerAction;
        }

        private string ResolveTurn(string playerAction, string computerAction)
        {
            string result = "";

            if (playerAction == "load")
            {
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


            return result;
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
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnFire.Enabled = true;
            playerAmmo++;

            if (playerAmmo == 0)
            {
                PlayerOutOfAmmo();
            }
            else if (playerAmmo == 3)
            {
                PlayerHasShotgun();
            }

            ResolveTurn("fire", ComputerTurn()); //returnerar just nu en string till inget
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            ResolveTurn("block", ComputerTurn());
        }

        private void btnFire_Click(object sender, EventArgs e)
        {

        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {

        }
    }
}
