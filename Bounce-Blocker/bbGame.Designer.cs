namespace Bounce_Blocker
{
    partial class bbGame
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu1 = new Bounce_Blocker.menu();
            this.game1 = new Bounce_Blocker.game();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(783, 425);
            this.menu1.TabIndex = 1;
            this.menu1.startGameEvent += new System.EventHandler(this.menu1_startGameEvent);
            this.menu1.highScoresEvent += new System.EventHandler(this.menu1_highScoresEvent);
            this.menu1.instructionsEvent += new System.EventHandler(this.menu1_instructionsEvent);
            this.menu1.creditsEvent += new System.EventHandler(this.menu1_creditsEvent);
            this.menu1.exitEvent += new System.EventHandler(this.menu1_exitEvent);
            this.menu1.Load += new System.EventHandler(this.menu1_Load);
            // 
            // game1
            // 
            this.game1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.game1.Location = new System.Drawing.Point(0, 0);
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(783, 425);
            this.game1.TabIndex = 0;
            this.game1.Visible = false;
            this.game1.showMenu += new System.EventHandler(this.game1_showMenu);
            // 
            // bbGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.game1);
            this.Name = "bbGame";
            this.Size = new System.Drawing.Size(783, 425);
            this.ResumeLayout(false);

        }

        #endregion

        private game game1;
        private menu menu1;
    }
}
