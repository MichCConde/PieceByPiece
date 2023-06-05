namespace PiecebyPiece
{
    partial class SecretLevel
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
            this.pnlComplete = new System.Windows.Forms.Panel();
            this.btnMap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Door = new System.Windows.Forms.PictureBox();
            this.Piece2 = new System.Windows.Forms.PictureBox();
            this.verticalPlatform = new System.Windows.Forms.PictureBox();
            this.Platform = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Platform2 = new System.Windows.Forms.PictureBox();
            this.Platform1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.pnlComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piece2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.SecretLevelTimer);
            // 
            // pnlComplete
            // 
            this.pnlComplete.BackColor = System.Drawing.Color.Maroon;
            this.pnlComplete.Controls.Add(this.btnMap);
            this.pnlComplete.Controls.Add(this.label2);
            this.pnlComplete.Controls.Add(this.btnExit);
            this.pnlComplete.Location = new System.Drawing.Point(250, 115);
            this.pnlComplete.Name = "pnlComplete";
            this.pnlComplete.Size = new System.Drawing.Size(453, 303);
            this.pnlComplete.TabIndex = 55;
            // 
            // btnMap
            // 
            this.btnMap.Font = new System.Drawing.Font("Orbitron", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.Location = new System.Drawing.Point(104, 214);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(244, 39);
            this.btnMap.TabIndex = 19;
            this.btnMap.Text = "MAP";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Orbitron", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 101);
            this.label2.TabIndex = 16;
            this.label2.Text = "LEVEL COMPLETE!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Orbitron", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(104, 154);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(244, 39);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "MAIN MENU";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Orbitron", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.txtScore.Location = new System.Drawing.Point(4, 24);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(301, 64);
            this.txtScore.TabIndex = 51;
            this.txtScore.Text = "Pieces Collected: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::PiecebyPiece.Properties.Resources.L3_Platform;
            this.pictureBox1.Location = new System.Drawing.Point(-222, 454);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Platform";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::PiecebyPiece.Properties.Resources.Sprite_Idle;
            this.Player.Location = new System.Drawing.Point(18, 327);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(55, 55);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 46;
            this.Player.TabStop = false;
            this.Player.Tag = "Player";
            // 
            // Door
            // 
            this.Door.BackColor = System.Drawing.Color.Transparent;
            this.Door.Image = global::PiecebyPiece.Properties.Resources.Door;
            this.Door.Location = new System.Drawing.Point(18, 388);
            this.Door.Name = "Door";
            this.Door.Size = new System.Drawing.Size(50, 70);
            this.Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Door.TabIndex = 47;
            this.Door.TabStop = false;
            this.Door.Tag = "Door";
            // 
            // Piece2
            // 
            this.Piece2.BackColor = System.Drawing.Color.Transparent;
            this.Piece2.Image = global::PiecebyPiece.Properties.Resources.Puzzle_Piece;
            this.Piece2.Location = new System.Drawing.Point(807, 388);
            this.Piece2.Name = "Piece2";
            this.Piece2.Size = new System.Drawing.Size(60, 60);
            this.Piece2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Piece2.TabIndex = 49;
            this.Piece2.TabStop = false;
            this.Piece2.Tag = "Piece";
            // 
            // verticalPlatform
            // 
            this.verticalPlatform.BackColor = System.Drawing.Color.Transparent;
            this.verticalPlatform.Image = global::PiecebyPiece.Properties.Resources.l3_Floating_Platform;
            this.verticalPlatform.Location = new System.Drawing.Point(638, 365);
            this.verticalPlatform.Name = "verticalPlatform";
            this.verticalPlatform.Size = new System.Drawing.Size(120, 40);
            this.verticalPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.verticalPlatform.TabIndex = 45;
            this.verticalPlatform.TabStop = false;
            this.verticalPlatform.Tag = "Platform";
            // 
            // Platform
            // 
            this.Platform.BackColor = System.Drawing.Color.Black;
            this.Platform.Image = global::PiecebyPiece.Properties.Resources.L2_Platform2;
            this.Platform.Location = new System.Drawing.Point(709, 454);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(341, 95);
            this.Platform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Platform.TabIndex = 52;
            this.Platform.TabStop = false;
            this.Platform.Tag = "Platform";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::PiecebyPiece.Properties.Resources.Puzzle_Piece;
            this.pictureBox5.Location = new System.Drawing.Point(428, 68);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 48;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Piece";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::PiecebyPiece.Properties.Resources.Puzzle_Piece;
            this.pictureBox7.Location = new System.Drawing.Point(428, 298);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 50;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "Piece";
            // 
            // Platform2
            // 
            this.Platform2.BackColor = System.Drawing.Color.Black;
            this.Platform2.Image = global::PiecebyPiece.Properties.Resources.L3_Platform__2_;
            this.Platform2.Location = new System.Drawing.Point(176, 139);
            this.Platform2.Name = "Platform2";
            this.Platform2.Size = new System.Drawing.Size(393, 40);
            this.Platform2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Platform2.TabIndex = 54;
            this.Platform2.TabStop = false;
            this.Platform2.Tag = "Platform";
            // 
            // Platform1
            // 
            this.Platform1.BackColor = System.Drawing.Color.Transparent;
            this.Platform1.Image = global::PiecebyPiece.Properties.Resources.Floating_Platform;
            this.Platform1.Location = new System.Drawing.Point(396, 365);
            this.Platform1.Name = "Platform1";
            this.Platform1.Size = new System.Drawing.Size(120, 40);
            this.Platform1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Platform1.TabIndex = 56;
            this.Platform1.TabStop = false;
            this.Platform1.Tag = "Platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PiecebyPiece.Properties.Resources.Floating_Platform;
            this.pictureBox2.Location = new System.Drawing.Point(161, 365);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Platform";
            // 
            // Enemy2
            // 
            this.Enemy2.BackColor = System.Drawing.Color.Transparent;
            this.Enemy2.Image = global::PiecebyPiece.Properties.Resources.Ghost___Mobs;
            this.Enemy2.Location = new System.Drawing.Point(350, 90);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(44, 44);
            this.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy2.TabIndex = 58;
            this.Enemy2.TabStop = false;
            this.Enemy2.Tag = "Enemy";
            // 
            // Enemy1
            // 
            this.Enemy1.BackColor = System.Drawing.Color.Transparent;
            this.Enemy1.Image = global::PiecebyPiece.Properties.Resources.Ghost___Mobs;
            this.Enemy1.Location = new System.Drawing.Point(716, 404);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(44, 44);
            this.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy1.TabIndex = 59;
            this.Enemy1.TabStop = false;
            this.Enemy1.Tag = "Enemy";
            // 
            // SecretLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(957, 573);
            this.ControlBox = false;
            this.Controls.Add(this.pnlComplete);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.Enemy2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Platform1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Door);
            this.Controls.Add(this.Piece2);
            this.Controls.Add(this.verticalPlatform);
            this.Controls.Add(this.Platform);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.Platform2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SecretLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecretLevel";
            this.Load += new System.EventHandler(this.SecretLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.pnlComplete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piece2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Panel pnlComplete;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Door;
        private System.Windows.Forms.PictureBox Piece2;
        private System.Windows.Forms.PictureBox verticalPlatform;
        private System.Windows.Forms.PictureBox Platform;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox Platform2;
        private System.Windows.Forms.PictureBox Platform1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Enemy2;
        private System.Windows.Forms.PictureBox Enemy1;
    }
}