namespace Bounce_Blocker
{
    partial class menu
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
            this.credits = new System.Windows.Forms.Button();
            this.instructions = new System.Windows.Forms.Button();
            this.scores = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // credits
            // 
            this.credits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.credits.AutoSize = true;
            this.credits.Location = new System.Drawing.Point(308, 277);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(195, 60);
            this.credits.TabIndex = 9;
            this.credits.Text = "Credits";
            this.credits.UseVisualStyleBackColor = true;
            this.credits.Click += new System.EventHandler(this.credits_Click);
            // 
            // instructions
            // 
            this.instructions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instructions.AutoSize = true;
            this.instructions.Location = new System.Drawing.Point(308, 193);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(195, 60);
            this.instructions.TabIndex = 8;
            this.instructions.Text = "Instructions";
            this.instructions.UseVisualStyleBackColor = true;
            this.instructions.Click += new System.EventHandler(this.instructions_Click);
            // 
            // scores
            // 
            this.scores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scores.AutoSize = true;
            this.scores.Location = new System.Drawing.Point(308, 106);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(195, 60);
            this.scores.TabIndex = 7;
            this.scores.Text = "High Scores";
            this.scores.UseVisualStyleBackColor = true;
            this.scores.Click += new System.EventHandler(this.scores_Click);
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit.AutoSize = true;
            this.exit.Location = new System.Drawing.Point(308, 366);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(195, 55);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(308, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(195, 60);
            this.start.TabIndex = 5;
            this.start.Text = "Start Game";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.credits);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.start);
            this.Name = "menu";
            this.Size = new System.Drawing.Size(810, 433);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button credits;
        private System.Windows.Forms.Button instructions;
        private System.Windows.Forms.Button scores;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button start;
    }
}
