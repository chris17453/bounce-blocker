
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
    public partial class game : UserControl
    {
            dm.dosScreen.sObj paddle1=new dm.dosScreen.sObj();
            dm.dosScreen.sObj paddle2=new dm.dosScreen.sObj();
            dm.dosScreen.sObj ball   =new dm.dosScreen.sObj();
            float ballDir=0;
            float ballSpeed=1;
            float ballX=5,ballY=5;
            Random R=new Random();
            bool startGame=false;
            
            public event EventHandler showMenu;
            public event EventHandler gameOver;

            public game()
            {
            InitializeComponent();
            }
         
            public void initBouncBlocker(){
            paddle1.x1=1;
            paddle1.y1=1;
            paddle1.x2=paddle1.x1;
            paddle1.y2=paddle1.y1+4;
            paddle1.background=dm.dosScreen.Colors.BLACK;
            paddle1.foreground=dm.dosScreen.Colors.BLUE;

            paddle2.x1=scn.width-2;
            paddle2.y1=1;
            paddle2.x2=paddle2.x1;
            paddle2.y2=paddle2.y1+4;
            
            paddle2.background=dm.dosScreen.Colors.BLACK;
            paddle2.foreground=dm.dosScreen.Colors.RED;

            ball.x1=scn.width/8;
            ball.y1=scn.height/4;
            ball.x2=ball.x1;
            ball.y2=ball.y1;

            ball.background=dm.dosScreen.Colors.BLACK;
            ball.foreground=dm.dosScreen.Colors.YELLOW;

            }

            private void drawGame(){
            scn.cls();
            scn.box(0,0,79,24,dm.dosScreen.Colors.DARKGREEN,dm.dosScreen.Colors.GREEN);
            scn.box(paddle1);
            scn.box(paddle2);
            //scn.box(ball);
            scn.setCharacter(ball.x1,ball.y1,'O');
            }

            double[] spinZ(float dir, float x, float y)
            {
            double angle=dir;
            double x1 = x*Math.Cos(angle) - y*Math.Sin(angle);
            double y1 = y*Math.Cos(angle) + x*Math.Sin(angle);
            return new double[] {x1,y1};
            }

            private void moveBall()
            {
            
            double[] coords=spinZ((float)(ballDir*.017453),ballSpeed,0);
            float cX=(float)coords[0];
            float cY=(float)coords[1];
            float tx,ty;

            tx=ballX+cX;
            ty=ballY+cY;

            
            bool newCoords=false;

            if (tx <= 2 || tx >= 77) {
                    if (ty>=paddle1.y1 && ty<=paddle1.y2) {//HIT BY PADDLE
                            ballDir= 179 - ballDir;   
                    //          newCoords=true;
                        if(tx<=3) tx=3;
                        if(tx>=77) tx=77;
                    }else{
                        newBall();
                    }
            
            } else 
            if (ty <=1 ||ty >=23) {
                if(ty<=1) ty=1;
                if(ty>=23) ty=23;
             
                
                
                ballDir=359 - ballDir; 
                //newCoords=true;
            }

            if (newCoords){
                coords=spinZ((float)(ballDir*.017453),ballSpeed,0);
                cX=(float)coords[0];
                cY=(float)coords[1];
                tx=ballX+cX;
                ty=ballY+cY;
            }
            


            ballX=tx;
            ballY=ty;
            
            ball.x1=(int)ballX;
            ball.y1=(int)ballY;
            ball.x2=ball.x1+1;
            ball.y2=ball.y1+1;
            
            int distance=paddle2.y2-paddle2.y1;
            paddle2.y1=ball.y1-distance/2;
            if(paddle2.y1<0) paddle2.y1=0;
            paddle2.y2=paddle2.y1+distance;

            ball.foreground++;

            }
   

            public void newBall(){
            ball.x1=scn.width/2;
            ball.y1=scn.height/2;
            ball.x2=ball.x1+1;
            ball.y2=ball.y1+1;
            ballDir=R.Next(0,360);
            ballX=ball.x1;
            ballY=ball.y1;
            
            ballSpeed=(float)(R.Next(0,3000))/1000+1;

            }
  
            protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
                if(keyData == Keys.Escape){
                    if (this.showMenu != null){
                        pause();
                        this.showMenu(this,null);
                    }
                }
                
                
                if(keyData == Keys.Up){
                    paddle1.up();
                    paddle1.up();
                }
                if(keyData == Keys.Down){
                    paddle1.down();
                    paddle1.down();
                }
                
                if(keyData == Keys.Space)
                    newBall();
            return base.ProcessCmdKey(ref msg, keyData);
            }

            private void scn_MouseMove(object sender, MouseEventArgs e)
            {
                int distance=paddle1.y2-paddle1.y1;
                byte[] coord=scn.getMouseCooridinates();
                paddle1.y1=coord[1]-distance/2;
                if(paddle1.y1<0) paddle1.y1=0;
                paddle1.y2=paddle1.y1+distance;
            }

            private void scn_Load(object sender, EventArgs e)
            {
                initBouncBlocker();
                startScreen();
            }

            public void startScreen()
            {
                scn.drawString(20,10,"Click to START!");
            }
           
            private void scn_MouseClick(object sender, MouseEventArgs e)
            {
                if (startGame == false)
                {
                    startGame=true;
                    gameLoopTimer.Start();
                }
            }

            private void gameLoopTimer_Tick(object sender, EventArgs e)
            {
                moveBall();
                drawGame();
            }

            public void pause()
            {
                gameLoopTimer.Stop();
            }

            public void unPause()
            {
                gameLoopTimer.Start();
            }


      
        


    }
}
