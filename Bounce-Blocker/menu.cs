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
    public partial class menu : UserControl
    {
        public menu()
        {
            InitializeComponent();
        }

        public event EventHandler startGameEvent;
        public event EventHandler highScoresEvent;
        public event EventHandler instructionsEvent;
        public event EventHandler creditsEvent;
        public event EventHandler exitEvent;

        public void inGame()
        {
            start.Text="Continue Game";
        }

        public void notInGame()
        {
            start.Text="Start Game";
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (this.startGameEvent!= null)
                this.startGameEvent(this, e);               
        }

        private void scores_Click(object sender, EventArgs e)
        {
            if (this.highScoresEvent!= null)
                this.highScoresEvent(this, e);               
        }

        private void instructions_Click(object sender, EventArgs e)
        {
            if (this.instructionsEvent!= null)
                this.instructionsEvent(this, e);               
        }

        private void credits_Click(object sender, EventArgs e)
        {
            if (this.creditsEvent!= null)
                this.creditsEvent(this, e);               
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (this.exitEvent!= null)
                this.exitEvent(this, e);               
        }
    }
}
