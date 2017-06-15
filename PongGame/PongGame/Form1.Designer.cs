namespace PongGame
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
            this.pause_label = new System.Windows.Forms.Label();
            this.ai_score = new System.Windows.Forms.Label();
            this.paddleAI = new System.Windows.Forms.PictureBox();
            this.paddle1 = new System.Windows.Forms.PictureBox();
            this.picBoxBall = new System.Windows.Forms.PictureBox();
            this.player_score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paddleAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBall)).BeginInit();
            this.SuspendLayout();
            // 
            // pause_label
            // 
            this.pause_label.AutoSize = true;
            this.pause_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pause_label.Location = new System.Drawing.Point(183, 63);
            this.pause_label.Name = "pause_label";
            this.pause_label.Size = new System.Drawing.Size(85, 25);
            this.pause_label.TabIndex = 2;
            this.pause_label.Text = "Paused";
            // 
            // ai_score
            // 
            this.ai_score.AutoSize = true;
            this.ai_score.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ai_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ai_score.Location = new System.Drawing.Point(12, 9);
            this.ai_score.Name = "ai_score";
            this.ai_score.Size = new System.Drawing.Size(24, 25);
            this.ai_score.TabIndex = 3;
            this.ai_score.Text = "0";
            // 
            // paddleAI
            // 
            this.paddleAI.Image = global::PongGame.Properties.Resources.Paddle2;
            this.paddleAI.Location = new System.Drawing.Point(185, 0);
            this.paddleAI.Name = "paddleAI";
            this.paddleAI.Size = new System.Drawing.Size(83, 10);
            this.paddleAI.TabIndex = 4;
            this.paddleAI.TabStop = false;
            // 
            // paddle1
            // 
            this.paddle1.Image = global::PongGame.Properties.Resources.Paddle1;
            this.paddle1.Location = new System.Drawing.Point(185, 310);
            this.paddle1.Name = "paddle1";
            this.paddle1.Size = new System.Drawing.Size(65, 10);
            this.paddle1.TabIndex = 1;
            this.paddle1.TabStop = false;
            // 
            // picBoxBall
            // 
            this.picBoxBall.Image = global::PongGame.Properties.Resources.Ball;
            this.picBoxBall.Location = new System.Drawing.Point(215, 138);
            this.picBoxBall.Name = "picBoxBall";
            this.picBoxBall.Size = new System.Drawing.Size(20, 23);
            this.picBoxBall.TabIndex = 0;
            this.picBoxBall.TabStop = false;
            // 
            // player_score
            // 
            this.player_score.AutoSize = true;
            this.player_score.BackColor = System.Drawing.Color.LightSalmon;
            this.player_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player_score.Location = new System.Drawing.Point(423, 9);
            this.player_score.Name = "player_score";
            this.player_score.Size = new System.Drawing.Size(24, 25);
            this.player_score.TabIndex = 5;
            this.player_score.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 332);
            this.Controls.Add(this.player_score);
            this.Controls.Add(this.paddleAI);
            this.Controls.Add(this.ai_score);
            this.Controls.Add(this.pause_label);
            this.Controls.Add(this.paddle1);
            this.Controls.Add(this.picBoxBall);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.space_Down);
            ((System.ComponentModel.ISupportInitialize)(this.paddleAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBall;
        private System.Windows.Forms.PictureBox paddle1;
        private System.Windows.Forms.Label pause_label;
        private System.Windows.Forms.Label ai_score;
        private System.Windows.Forms.PictureBox paddleAI;
        private System.Windows.Forms.Label player_score;
    }
}

