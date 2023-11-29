namespace WinFormsApp4
{
    partial class BreakoutGame
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
            components = new System.ComponentModel.Container();
            labelTxtScore = new Label();
            player = new PictureBox();
            ball = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // labelTxtScore
            // 
            labelTxtScore.AutoSize = true;
            labelTxtScore.BackColor = Color.Transparent;
            labelTxtScore.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTxtScore.ForeColor = SystemColors.ControlLightLight;
            labelTxtScore.Location = new Point(15, 16);
            labelTxtScore.Name = "labelTxtScore";
            labelTxtScore.Size = new Size(67, 25);
            labelTxtScore.TabIndex = 0;
            labelTxtScore.Text = "Score:";
            // 
            // player
            // 
            player.BackColor = Color.Yellow;
            player.Location = new Point(484, 623);
            player.Name = "player";
            player.Size = new Size(81, 25);
            player.TabIndex = 1;
            player.TabStop = false;
            // 
            // ball
            // 
            ball.BackColor = Color.Lime;
            ball.Location = new Point(533, 423);
            ball.Name = "ball";
            ball.Size = new Size(14, 15);
            ball.TabIndex = 2;
            ball.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += mainGameTimerEvent;
            // 
            // BreakoutGame
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Black;
            ClientSize = new Size(1584, 710);
            Controls.Add(ball);
            Controls.Add(player);
            Controls.Add(labelTxtScore);
            Name = "BreakoutGame";
            Text = "Break Out Game";
            KeyDown += keyIsDown;
            KeyUp += keyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTxtScore;
        private PictureBox player;
        private PictureBox ball;
        private System.Windows.Forms.Timer gameTimer;
    }
}