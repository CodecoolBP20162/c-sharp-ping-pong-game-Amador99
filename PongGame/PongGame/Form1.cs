using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame
{

    public partial class Form1 : Form
    {
        Timer timer;
        
        const int AREA_WIDTH = 500;
        const int AREA_HEIGHT = 400;

        int SpeedX = 4;
        int SpeedY = 4;
        int aiSpeed = 3;
        int aiScore = 0;
        int playerScore = 0;
        int TimerInterval = 1;

        void timer_Tick(object sender, EventArgs e)
        {
            picBoxBall.Location = new Point(picBoxBall.Location.X + SpeedX, picBoxBall.Location.Y + SpeedY);
            AreaCollision();
            padlleCollision();
            playerMovement();
            aiMovement();

        }

        private void playerMovement()
        {
            if (this.PointToClient(MousePosition).X >= paddle1.Width / 2 && this.PointToClient(MousePosition).X <= ClientSize.Width - paddle1.Height / 2)
            {
                int playerX = this.PointToClient(MousePosition).X - paddle1.Width / 2;
                int playerY = ClientSize.Height - paddle1.Height;

                paddle1.Location = new Point(playerX, playerY);
            }
        }

        private void AreaCollision()
        {
            if (picBoxBall.Location.Y > ClientSize.Height)
            {
                resetBall();
                aiScore++;
                ai_score.Text = Convert.ToString(aiScore);
            }
            else if (picBoxBall.Location.Y < 0)
            {
                resetBall();
                playerScore++;
                player_score.Text = Convert.ToString(playerScore);
            }
            else if (picBoxBall.Location.X > ClientSize.Width)
            {
                SpeedX = -SpeedX;
            }
            else if (picBoxBall.Location.X < 0)
            {
                SpeedX = -SpeedX;
            }
        }

        private void resetBall()
        {
            picBoxBall.Location = new Point(ClientSize.Width / 2 - picBoxBall.Width / 2, ClientSize.Height / 2 - picBoxBall.Height / 2);
        }

        private void padlleCollision()
        {
            if (picBoxBall.Bounds.IntersectsWith(paddle1.Bounds))
            {
                SpeedY = -SpeedY;
            }

            if (picBoxBall.Bounds.IntersectsWith(paddleAI.Bounds))
            {
                SpeedY *= -1;
            }
        }

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            Cursor.Hide();

            timer.Enabled = true;
            timer.Interval = TimerInterval;

            timer.Tick += new EventHandler(timer_Tick);
            pause_label.Hide();
            
            this.Width = AREA_WIDTH;
            this.Height = AREA_HEIGHT;

            paddle1.Location = new Point(ClientSize.Width / 2, ClientSize.Height - paddle1.Height);
            this.Controls.Add(paddle1);
            
            paddleAI.Location = new Point(ClientSize.Width / 2, 0 + paddle1.Height);
            this.Controls.Add(paddleAI);

            picBoxBall.Location = new Point(ClientSize.Width / 2 - picBoxBall.Width, ClientSize.Height / 2 - picBoxBall.Height / 2);
            this.Controls.Add(picBoxBall);
        }

        private void aiMovement()
        {
            if (SpeedX < 0 && SpeedY < 0 && picBoxBall.Location.X < paddleAI.Location.X) 
            {
                paddleAI.Location = new Point(paddleAI.Location.X - aiSpeed, 0);
            }
            else if (SpeedX < 0 && SpeedY > 0 && picBoxBall.Location.X > ClientSize.Width / 2)
            {
                paddleAI.Location = new Point(paddleAI.Location.X - aiSpeed, 0);
            }
            else if (SpeedX > 0 && SpeedY < 0 && picBoxBall.Location.X > paddleAI.Location.X)
            {
                paddleAI.Location = new Point(paddleAI.Location.X + aiSpeed, 0);
            }
            else if (SpeedX > 0 && SpeedY > 0 && paddleAI.Location.X < ClientSize.Width / 2)
            {
                paddleAI.Location = new Point(paddleAI.Location.X + aiSpeed, 0);
            }
        }

        private void space_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (timer.Enabled == true)
                {
                    timer.Enabled = false;
                    pause_label.Show();
                }
                else
                {
                    timer.Enabled = true;
                    pause_label.Hide();
                }
            }
        }
    }
}
