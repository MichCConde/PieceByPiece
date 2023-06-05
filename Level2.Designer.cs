namespace PiecebyPiece
{
    partial class Level2
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.lblGuide1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pnlComplete = new System.Windows.Forms.Panel();
            this.btnMap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Door = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Platform = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Platform1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pnlComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.Level2Timer);
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Orbitron", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.txtScore.Location = new System.Drawing.Point(20, 20);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(301, 64);
            this.txtScore.TabIndex = 22;
            this.txtScore.Text = "Pieces Collected: ";
            // 
            // lblGuide1
            // 
            this.lblGuide1.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide1.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Bold);
            this.lblGuide1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.lblGuide1.Location = new System.Drawing.Point(465, 318);
            this.lblGuide1.Name = "lblGuide1";
            this.lblGuide1.Size = new System.Drawing.Size(221, 28);
            this.lblGuide1.TabIndex = 23;
            this.lblGuide1.Text = "Watch out for mobs!";
            // 
            // pnlComplete
            // 
            this.pnlComplete.BackColor = System.Drawing.Color.Maroon;
            this.pnlComplete.Controls.Add(this.btnMap);
            this.pnlComplete.Controls.Add(this.label2);
            this.pnlComplete.Controls.Add(this.btnExit);
            this.pnlComplete.Controls.Add(this.btnAdvance);
            this.pnlComplete.Location = new System.Drawing.Point(250, 115);
            this.pnlComplete.Name = "pnlComplete";
            this.pnlComplete.Size = new System.Drawing.Size(453, 315);
            this.pnlComplete.TabIndex = 31;
            // 
            // btnMap
            // 
            this.btnMap.Font = new System.Drawing.Font("Orbitron", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.Location = new System.Drawing.Point(141, 171);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(170, 39);
            this.btnMap.TabIndex = 18;
            this.btnMap.Text = "MAP";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Orbitron", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 101);
            this.label2.TabIndex = 16;
            this.label2.Text = "LEVEL COMPLETE!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Orbitron", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(141, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 39);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "QUIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnAdvance
            // 
            this.btnAdvance.Font = new System.Drawing.Font("Orbitron", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvance.Location = new System.Drawing.Point(141, 119);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(170, 39);
            this.btnAdvance.TabIndex = 0;
            this.btnAdvance.Text = "NEXT LEVEL";
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = global::PiecebyPiece.Properties.Resources.L2_Platform__3_;
            this.pictureBox3.Location = new System.Drawing.Point(855, 300);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Platform";
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Transparent;
            this.Enemy.Image = global::PiecebyPiece.Properties.Resources.Ghost___Mobs;
            this.Enemy.Location = new System.Drawing.Point(536, 406);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(44, 44);
            this.Enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy.TabIndex = 28;
            this.Enemy.TabStop = false;
            this.Enemy.Tag = "Enemy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::PiecebyPiece.Properties.Resources.L2_Platform;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 450);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Platform";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::PiecebyPiece.Properties.Resources.Sprite_Idle;
            this.Player.Location = new System.Drawing.Point(22, 332);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(55, 55);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 17;
            this.Player.TabStop = false;
            this.Player.Tag = "Player";
            // 
            // Door
            // 
            this.Door.BackColor = System.Drawing.Color.Transparent;
            this.Door.Image = global::PiecebyPiece.Properties.Resources.Door;
            this.Door.Location = new System.Drawing.Point(354, 381);
            this.Door.Name = "Door";
            this.Door.Size = new System.Drawing.Size(50, 70);
            this.Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Door.TabIndex = 18;
            this.Door.TabStop = false;
            this.Door.Tag = "Door";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::PiecebyPiece.Properties.Resources.Puzzle_Piece;
            this.pictureBox6.Location = new System.Drawing.Point(241, 285);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 60);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "Piece";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = global::PiecebyPiece.Properties.Resources.L2_Platform__2_;
            this.pictureBox4.Location = new System.Drawing.Point(796, 351);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(247, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Platform";
            // 
            // Platform
            // 
            this.Platform.BackColor = System.Drawing.Color.Black;
            this.Platform.Image = global::PiecebyPiece.Properties.Resources.L2_Platform2;
            this.Platform.Location = new System.Drawing.Point(333, 450);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(453, 95);
            this.Platform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Platform.TabIndex = 26;
            this.Platform.TabStop = false;
            this.Platform.Tag = "Platform";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::PiecebyPiece.Properties.Resources.Puzzle_Piece;
            this.pictureBox5.Location = new System.Drawing.Point(885, 234);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Piece";
            // 
            // Platform1
            // 
            this.Platform1.BackColor = System.Drawing.Color.Transparent;
            this.Platform1.Image = global::PiecebyPiece.Properties.Resources.Floating_Platform;
            this.Platform1.Location = new System.Drawing.Point(209, 351);
            this.Platform1.Name = "Platform1";
            this.Platform1.Size = new System.Drawing.Size(120, 40);
            this.Platform1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Platform1.TabIndex = 27;
            this.Platform1.TabStop = false;
            this.Platform1.Tag = "Platform";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::PiecebyPiece.Properties.Resources.Puzzle_Piece;
            this.pictureBox7.Location = new System.Drawing.Point(718, 384);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "Piece";
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(957, 573);
            this.ControlBox = false;
            this.Controls.Add(this.pnlComplete);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGuide1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Door);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Platform);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Platform1);
            this.Controls.Add(this.pictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Level2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level2";
            this.Load += new System.EventHandler(this.Level2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.pnlComplete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Door;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Platform;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox Platform1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblGuide1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlComplete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.Button btnMap;
    }
}