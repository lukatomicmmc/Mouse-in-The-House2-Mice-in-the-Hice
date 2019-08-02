namespace Mice_in_the_Hice
{
    partial class FormHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHouse));
            this.pnlGame = new System.Windows.Forms.Panel();
            this.tmrBigMouse = new System.Windows.Forms.Timer(this.components);
            this.tmrSmallMouse = new System.Windows.Forms.Timer(this.components);
            this.tmrSparkles = new System.Windows.Forms.Timer(this.components);
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreLvl = new System.Windows.Forms.Label();
            this.lblScoreName = new System.Windows.Forms.Label();
            this.lblScoreLvlName = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblLivesName = new System.Windows.Forms.Label();
            this.tmrMice = new System.Windows.Forms.Timer(this.components);
            this.tmrAnim = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlGame.Location = new System.Drawing.Point(12, 116);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(960, 553);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            // 
            // tmrBigMouse
            // 
            this.tmrBigMouse.Enabled = true;
            this.tmrBigMouse.Tick += new System.EventHandler(this.tmrBigMouse_Tick);
            // 
            // tmrSmallMouse
            // 
            this.tmrSmallMouse.Enabled = true;
            this.tmrSmallMouse.Tick += new System.EventHandler(this.tmrSmallMouse_Tick);
            // 
            // tmrSparkles
            // 
            this.tmrSparkles.Enabled = true;
            this.tmrSparkles.Tick += new System.EventHandler(this.tmrSparkles_Tick);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.Location = new System.Drawing.Point(12, 7);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(1166, 103);
            this.pnlLogo.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(1000, 143);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 20);
            this.txtName.TabIndex = 10;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScore.Location = new System.Drawing.Point(1134, 432);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(79, 46);
            this.lblScore.TabIndex = 30;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreLvl
            // 
            this.lblScoreLvl.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblScoreLvl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreLvl.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreLvl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScoreLvl.Location = new System.Drawing.Point(1134, 356);
            this.lblScoreLvl.Name = "lblScoreLvl";
            this.lblScoreLvl.Size = new System.Drawing.Size(79, 46);
            this.lblScoreLvl.TabIndex = 20;
            this.lblScoreLvl.Text = "0";
            this.lblScoreLvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreName
            // 
            this.lblScoreName.BackColor = System.Drawing.Color.White;
            this.lblScoreName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreName.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScoreName.Location = new System.Drawing.Point(1000, 432);
            this.lblScoreName.Name = "lblScoreName";
            this.lblScoreName.Size = new System.Drawing.Size(94, 46);
            this.lblScoreName.TabIndex = 6;
            this.lblScoreName.Text = "Score";
            this.lblScoreName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreLvlName
            // 
            this.lblScoreLvlName.BackColor = System.Drawing.Color.White;
            this.lblScoreLvlName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreLvlName.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreLvlName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScoreLvlName.Location = new System.Drawing.Point(1000, 356);
            this.lblScoreLvlName.Name = "lblScoreLvlName";
            this.lblScoreLvlName.Size = new System.Drawing.Size(94, 46);
            this.lblScoreLvlName.TabIndex = 5;
            this.lblScoreLvlName.Text = "Level";
            this.lblScoreLvlName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLives
            // 
            this.lblLives.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblLives.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLives.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLives.Location = new System.Drawing.Point(1134, 245);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(79, 46);
            this.lblLives.TabIndex = 10;
            this.lblLives.Text = "5";
            this.lblLives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLivesName
            // 
            this.lblLivesName.BackColor = System.Drawing.Color.White;
            this.lblLivesName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLivesName.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivesName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLivesName.Location = new System.Drawing.Point(1000, 245);
            this.lblLivesName.Name = "lblLivesName";
            this.lblLivesName.Size = new System.Drawing.Size(94, 46);
            this.lblLivesName.TabIndex = 1;
            this.lblLivesName.Text = "Lives";
            this.lblLivesName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrMice
            // 
            this.tmrMice.Enabled = true;
            this.tmrMice.Tick += new System.EventHandler(this.tmrMice_Tick);
            // 
            // tmrAnim
            // 
            this.tmrAnim.Enabled = true;
            this.tmrAnim.Interval = 10;
            this.tmrAnim.Tick += new System.EventHandler(this.tmrAnim_Tick);
            // 
            // FormHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblScoreName);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblScoreLvl);
            this.Controls.Add(this.lblScoreLvlName);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblLivesName);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "FormHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormHouse_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormHouse_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormHouse_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Timer tmrBigMouse;
        private System.Windows.Forms.Timer tmrSmallMouse;
        private System.Windows.Forms.Timer tmrSparkles;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLivesName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreLvl;
        private System.Windows.Forms.Label lblScoreName;
        private System.Windows.Forms.Label lblScoreLvlName;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Timer tmrMice;
        private System.Windows.Forms.Timer tmrAnim;
    }
}

