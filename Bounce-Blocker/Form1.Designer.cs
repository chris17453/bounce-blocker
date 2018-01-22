namespace Bounce_Blocker
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scnTimer = new System.Windows.Forms.Timer(this.components);
            this.bbGame1 = new Bounce_Blocker.bbGame();
            this.SuspendLayout();
            // 
            // bbGame1
            // 
            this.bbGame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bbGame1.Location = new System.Drawing.Point(0, 0);
            this.bbGame1.Name = "bbGame1";
            this.bbGame1.Size = new System.Drawing.Size(821, 458);
            this.bbGame1.TabIndex = 0;
            this.bbGame1.exitEvent += new System.EventHandler(this.bbGame1_exitEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(821, 458);
            this.Controls.Add(this.bbGame1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Bounce Blocker : By Matthew Watkins";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer scnTimer;
        private bbGame bbGame1;
    }
}

