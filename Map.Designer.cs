namespace PiecebyPiece
{
    partial class Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnLevel3 = new System.Windows.Forms.Button();
            this.btnSecret = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLevel1
            // 
            this.btnLevel1.BackColor = System.Drawing.Color.Transparent;
            this.btnLevel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevel1.BackgroundImage")));
            this.btnLevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLevel1.Font = new System.Drawing.Font("Orbitron", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel1.ForeColor = System.Drawing.Color.Snow;
            this.btnLevel1.Location = new System.Drawing.Point(168, 120);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(100, 100);
            this.btnLevel1.TabIndex = 0;
            this.btnLevel1.Text = "1";
            this.btnLevel1.UseVisualStyleBackColor = false;
            this.btnLevel1.Click += new System.EventHandler(this.btnLevel1_Click);
            this.btnLevel1.MouseLeave += new System.EventHandler(this.btnLevel1_MouseLeave);
            this.btnLevel1.MouseHover += new System.EventHandler(this.btnLevel1_MouseHover);
            // 
            // btnLevel2
            // 
            this.btnLevel2.BackColor = System.Drawing.Color.Transparent;
            this.btnLevel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevel2.BackgroundImage")));
            this.btnLevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLevel2.Font = new System.Drawing.Font("Orbitron", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel2.ForeColor = System.Drawing.Color.Snow;
            this.btnLevel2.Location = new System.Drawing.Point(329, 293);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(100, 100);
            this.btnLevel2.TabIndex = 1;
            this.btnLevel2.Text = "2";
            this.btnLevel2.UseVisualStyleBackColor = false;
            this.btnLevel2.Click += new System.EventHandler(this.btnLevel2_Click);
            this.btnLevel2.MouseLeave += new System.EventHandler(this.btnLevel2_MouseLeave);
            this.btnLevel2.MouseHover += new System.EventHandler(this.btnLevel2_MouseHover);
            // 
            // btnLevel3
            // 
            this.btnLevel3.BackColor = System.Drawing.Color.Transparent;
            this.btnLevel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevel3.BackgroundImage")));
            this.btnLevel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLevel3.Font = new System.Drawing.Font("Orbitron", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel3.ForeColor = System.Drawing.Color.Snow;
            this.btnLevel3.Location = new System.Drawing.Point(641, 221);
            this.btnLevel3.Name = "btnLevel3";
            this.btnLevel3.Size = new System.Drawing.Size(100, 100);
            this.btnLevel3.TabIndex = 2;
            this.btnLevel3.Text = "3";
            this.btnLevel3.UseVisualStyleBackColor = false;
            this.btnLevel3.Click += new System.EventHandler(this.btnLevel3_Click);
            this.btnLevel3.MouseLeave += new System.EventHandler(this.btnLevel3_MouseLeave);
            this.btnLevel3.MouseHover += new System.EventHandler(this.btnLevel3_MouseHover);
            // 
            // btnSecret
            // 
            this.btnSecret.BackColor = System.Drawing.Color.Transparent;
            this.btnSecret.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSecret.BackgroundImage")));
            this.btnSecret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSecret.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSecret.Font = new System.Drawing.Font("Orbitron", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecret.ForeColor = System.Drawing.Color.Snow;
            this.btnSecret.Location = new System.Drawing.Point(532, 120);
            this.btnSecret.Name = "btnSecret";
            this.btnSecret.Size = new System.Drawing.Size(100, 100);
            this.btnSecret.TabIndex = 3;
            this.btnSecret.Text = "?";
            this.btnSecret.UseVisualStyleBackColor = false;
            this.btnSecret.Click += new System.EventHandler(this.btnSecret_Click);
            this.btnSecret.MouseLeave += new System.EventHandler(this.btnL_MouseLeave);
            this.btnSecret.MouseHover += new System.EventHandler(this.btnL_MouseHover);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Orbitron", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(218)))), ((int)(((byte)(178)))));
            this.BackgroundImage = global::PiecebyPiece.Properties.Resources.Map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 539);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSecret);
            this.Controls.Add(this.btnLevel3);
            this.Controls.Add(this.btnLevel2);
            this.Controls.Add(this.btnLevel1);
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.Button btnLevel3;
        private System.Windows.Forms.Button btnSecret;
        private System.Windows.Forms.Button btnBack;
    }
}