using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bounce_Blocker
{
    public partial class bbGame : UserControl
    {
        public bbGame()
        {
            InitializeComponent();
        }

        private void menu1_Load(object sender, EventArgs e)
        {

        }

        private void menu1_instructionsEvent(object sender, EventArgs e)
        {

        }

        private void menu1_highScoresEvent(object sender, EventArgs e)
        {

        }

        bool inGame=false;
        private void menu1_startGameEvent(object sender, EventArgs e)
        {
           
            menu1.Visible=false;
            game1.Visible=true;
            updateGameMenu();
            if( inGame) game1.unPause();
            if(!inGame) inGame=true;
        }

        void updateGameMenu()
        {
            if( inGame) menu1.inGame();
            if(!inGame) menu1.notInGame();
        }

        private void menu1_creditsEvent(object sender, EventArgs e)
        {

        }

        
        public event EventHandler exitEvent;
        private void menu1_exitEvent(object sender, EventArgs e)
        {
            if (this.exitEvent != null) { 
                this.exitEvent(this,e);
            }
            
        }


        private void game1_showMenu(object sender, EventArgs e)
        {
            updateGameMenu();
            game1.Visible=false;
            menu1.Visible=true;

        }
    }
}
