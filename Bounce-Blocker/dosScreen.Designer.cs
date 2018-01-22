namespace dmRDClient_PC
{
    partial class dosScreen
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
            this.components = new System.ComponentModel.Container();
            this.blinker = new System.Windows.Forms.Timer(this.components);
            this.screenRedraw = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // blinker
            // 
            this.blinker.Enabled = true;
            this.blinker.Interval = 800;
            this.blinker.Tick += new System.EventHandler(this.blinker_Tick);
            // 
            // screenRedraw
            // 
            this.screenRedraw.Enabled = true;
            this.screenRedraw.Interval = 1000;
            this.screenRedraw.Tick += new System.EventHandler(this.screenRedraw_Tick);
            // 
            // dosScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoubleBuffered = true;
            this.Name = "dosScreen";
            this.Size = new System.Drawing.Size(642, 331);
            this.Load += new System.EventHandler(this.dosScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.dosScreen_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dosScreen_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dosScreen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dosScreen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dosScreen_MouseUp);
            this.Resize += new System.EventHandler(this.dosScreen_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer blinker;
        private System.Windows.Forms.Timer screenRedraw;
    }
}
