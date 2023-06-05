namespace PiecebyPiece
{
    partial class Level1
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
            this.lblGuide3 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.lblGuide2 = new System.Windows.Forms.Label();
            this.lblGuide1 = new System.Windows.Forms.Label();
            this.pnlComplete = new System.Windows.Forms.Panel();
            this.btnMap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Door = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pnlComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // lblGuide3
            // 
            this.lblGuide3.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide3.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Bold);
            this.lblGuide3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.lblGuide3.Location = new System.Drawing.Point(658, 103);
            this.lblGuide3.Name = "lblGuide3";
            this.lblGuide3.Size = new System.Drawing.Size(266, 49);
            this.lblGuide3.TabIndex = 11;
            this.lblGuide3.Text = "Great! Enter the door to advance!";
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Orbitron", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.txtScore.Location = new System.Drawing.Point(20, 20);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(301, 64);
            this.txtScore.TabIndex = 8;
            this.txtScore.Text = "Pieces Collected: ";
            // 
            // lblGuide2
            // 
            this.lblGuide2.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide2.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Bold);
            this.lblGuide2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.lblGuide2.Location = new System.Drawing.Point(300, 246);
            this.lblGuide2.Name = "lblGuide2";
            this.lblGuide2.Size = new System.Drawing.Size(266, 49);
            this.lblGuide2.TabIndex = 10;
            this.lblGuide2.Text = "Collect all the Pieces to unlock the next level!";
            // 
            // lblGuide1
            // 
            this.lblGuide1.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide1.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Bold);
            this.lblGuide1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.lblGuide1.Location = new System.Drawing.Point(20, 296);
            this.lblGuide1.Name = "lblGuide1";
            this.lblGuide1.Size = new System.Drawing.Size(263, 49);
            this.lblGuide1.TabIndex = 9;
            this.lblGuide1.Text = "Arrow keys to move and Spacebar to Jump!";
            // 
            // pnlComplete
            // 
            this.pnlComplete.BackColor = System.Drawing.Color.Maroon;
            this.pnlComplete.Controls.Add(this.btnMap);
            this.pnlComplete.Controls.Add(this.label1);
            this.pnlComplete.Controls.Add(this.btnExit);
            this.pnlComplete.Controls.Add(this.btnAdvance);
            this.pnlComplete.Location = new System.Drawing.Point(250, 115);
            this.pnlComplete.Name = "pnlComplete";
            this.pnlComplete.Size = new System.Drawing.Size(453, 300);
            this.pnlComplete.TabIndex = 15;
            // 
            // btnMap
            // 
            this.btnMap.Font = new System.Drawing.Font("Orbitron", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.Location = new System.Drawing.Point(141, 171);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(170, 39);
            this.btnMap.TabIndex = 17;
            this.btnMap.Text = "MAP";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Orbitron", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 101);
            this.label1.TabIndex = 16;
            this.label1.Text = "LEVEL COMPLETE!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::PiecebyPiece.Properties.Resources.L1_Platform;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 466);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(962, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Platform";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::PiecebyPiece.Properties.Resources.Sprite_Idle;
            this.Player.Location = new System.Drawing.Point(24, 348);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(55, 55);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 3;
            this.Player.TabStop = false;
            this.Player.Tag = "Player";
            // 
            // Door
            // 
            this.Door.BackColor = System.Drawing.Color.Transparent;
            this.Door.Image = global::PiecebyPiece.Properties.Resources.Door;
            this.Door.Location = new System.Drawing.Point(850, 219);
            this.Door.Name = "Door";
            this.Door.Size = new System.Drawing.Size(50, 70);
            this.Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Door.TabIndex = 4;
            this.Door.TabStop = false;
            this.Door.Tag = "Door";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::PiecebyPiece.Properties.Resources.Puzzle_Piece;
            this.pictureBox6.Location = new System.Drawing.Point(850, 400);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 60);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "Piece";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Image = global::PiecebyPiece.Properties.Resources.L1_Platform__3_;
            this.pictureBox4.Location = new System.Drawing.Point(682, 289);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(292, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::PiecebyPiece.Properties.Resources.L1_Platform__1_;
            this.pictureBox2.Location = new System.Drawing.Point(208, 416);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(453, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Platform";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::PiecebyPiece.Properties.Resources.Puzzle_Piece;
            this.pictureBox5.Location = new System.Drawing.Point(243, 350);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Piece";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::PiecebyPiece.Properties.Resources.L1_Platform__2_;
            this.pictureBox3.Location = new System.Drawing.Point(360, 366);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Platform";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::PiecebyPiece.Properties.Resources.Puzzle_Piece;
            this.pictureBox7.Location = new System.Drawing.Point(730, 223);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "Piece";
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(957, 573);
            this.ControlBox = false;
            this.Controls.Add(this.pnlComplete);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblGuide3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGuide1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Door);
            this.Controls.Add(this.lblGuide2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Platform";
            this.Text = "Piece by Piece: Level 1";
            this.Load += new System.EventHandler(this.Levels_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.pnlComplete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Door;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label lblGuide1;
        private System.Windows.Forms.Label lblGuide2;
        private System.Windows.Forms.Label lblGuide3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlComplete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMap;
    }
}