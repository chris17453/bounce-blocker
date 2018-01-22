using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bounce_Blocker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void start_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void scores_Click(object sender, EventArgs e)
        {

        }

        private void instructions_Click(object sender, EventArgs e)
        {

        }

        private void credits_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {

        }

        private void bbGame1_exitEvent(object sender, EventArgs e)
        {
            this.Close();
        } 

         /*
        void face(byte px,byte py){
            byte w=80;
            byte h=25;
            
            byte e1x1,e1x2,e1y1,e1y2;
            byte e2x1,e2x2,e2y1,e2y2;
            
            byte tx1,tx2,ty1,ty2;
            byte nx1,nx2,ny1,ny2;
            byte mx1,mx2,my1,my2;
            
          
            e1x1=(byte)(h/7-2-5+px);
            e1x2=(byte)(e1x1+5);

            e1y1=(byte)(2+py);

            e1y2=(byte)(e1y1+4);


            e2x1=(byte)(e1x1+10);
            e2x2=(byte)(e2x1+5);

            e2y1=(byte)(e1y1);
            e2y2=(byte)(e1y2);

            nx1=(byte)(e1x2);
            nx2=(byte)(nx1+4);

            ny1=(byte)(e1y2+2);
            ny2=(byte)(ny1+5);

            mx1=(byte)(e1x1);
            mx2=(byte)(e2x2);

            my1=(byte)(ny2+2);
            my2=(byte)(my1+3);

            tx1=(byte)(mx1+6);
            tx2=(byte)(tx1+5);

            ty1=(byte)(my1+2);
            ty2=(byte)(ty1+1);
            
            scn.box((byte)(px-10),py,(byte)(px+20),(byte)(py+20),dm.dosScreen.Colors.DARKGREEN,dm.dosScreen.Colors.YELLOW);
            
            //eyes
            scn.box(e1x1,e1y1,e1x2,(byte)e1y2,dm.dosScreen.Colors.BLUE,dm.dosScreen.Colors.BLACK);
            scn.box(e2x1,e2y1,e2x2,e2y2,dm.dosScreen.Colors.BLUE,dm.dosScreen.Colors.BLACK);
            //nose
            scn.box(nx1,ny1,nx2,ny2,dm.dosScreen.Colors.DARKBLUE,dm.dosScreen.Colors.DARKBLUE);

            //mouth
            scn.box(mx1,my1,mx2,my2,dm.dosScreen.Colors.BLACK,dm.dosScreen.Colors.GRAY);

            //tounge
            scn.box(tx1,ty1,tx2,ty2,dm.dosScreen.Colors.RED,dm.dosScreen.Colors.RED);
            scn.drawString(e1x1,e1y1,@"Try again because you S-U-C-K! You suc.",dm.dosScreen.Colors.GRAY,dm.dosScreen.Colors.GREEN);
        }

    */
  


    }//end class
}//end namespace
           
 