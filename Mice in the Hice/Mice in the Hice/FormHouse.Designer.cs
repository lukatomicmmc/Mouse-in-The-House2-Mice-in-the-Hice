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
            this.pnlGame = new System.Windows.Forms.Panel();
            this.tmrBigMouse = new System.Windows.Forms.Timer(this.components);
            this.tmrSmallMouse = new System.Windows.Forms.Timer(this.components);
            this.tmrSparkles = new System.Windows.Forms.Timer(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreLvl = new System.Windows.Forms.Label();
            this.lblScoreName = new System.Windows.Forms.Label();
            this.lblScoreLvlName = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblLivesName = new System.Windows.Forms.Label();
            this.tmrMice = new System.Windows.Forms.Timer(this.components);
            this.tmrAnim = new System.Windows.Forms.Timer(this.components);
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAgeName = new System.Windows.Forms.TextBox();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblRetry = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlGame.Location = new System.Drawing.Point(12, 116);
            this.pnlGame.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(1000, 148);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 33);
            this.txtName.TabIndex = 10;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScore.Location = new System.Drawing.Point(1134, 471);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lblScoreLvl.Location = new System.Drawing.Point(1134, 404);
            this.lblScoreLvl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lblScoreName.Location = new System.Drawing.Point(1000, 471);
            this.lblScoreName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lblScoreLvlName.Location = new System.Drawing.Point(1000, 404);
            this.lblScoreLvlName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lblLives.Location = new System.Drawing.Point(1134, 324);
            this.lblLives.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lblLivesName.Location = new System.Drawing.Point(1000, 324);
            this.lblLivesName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.Enabled = false;
            this.txtAge.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(1112, 199);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 33);
            this.txtAge.TabIndex = 33;
            // 
            // txtAgeName
            // 
            this.txtAgeName.BackColor = System.Drawing.Color.White;
            this.txtAgeName.Enabled = false;
            this.txtAgeName.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeName.Location = new System.Drawing.Point(1000, 199);
            this.txtAgeName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAgeName.Name = "txtAgeName";
            this.txtAgeName.Size = new System.Drawing.Size(100, 33);
            this.txtAgeName.TabIndex = 34;
            this.txtAgeName.Text = "Age";
            // 
            // lblPause
            // 
            this.lblPause.BackColor = System.Drawing.Color.Transparent;
            this.lblPause.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPause.Location = new System.Drawing.Point(12, -8);
            this.lblPause.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(359, 105);
            this.lblPause.TabIndex = 35;
            this.lblPause.Click += new System.EventHandler(this.lblPause_Click);
            // 
            // lblRetry
            // 
            this.lblRetry.BackColor = System.Drawing.Color.Transparent;
            this.lblRetry.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRetry.Location = new System.Drawing.Point(422, 9);
            this.lblRetry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRetry.Name = "lblRetry";
            this.lblRetry.Size = new System.Drawing.Size(166, 36);
            this.lblRetry.TabIndex = 36;
            this.lblRetry.Click += new System.EventHandler(this.lblRetry_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMenu.Location = new System.Drawing.Point(422, 65);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(166, 36);
            this.lblMenu.TabIndex = 37;
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // FormHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblRetry);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.txtAgeName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblScoreName);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblScoreLvl);
            this.Controls.Add(this.lblScoreLvlName);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblLivesName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Fast, the mice are coming!";
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
        private System.Windows.Forms.Label lblLivesName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreLvl;
        private System.Windows.Forms.Label lblScoreName;
        private System.Windows.Forms.Label lblScoreLvlName;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Timer tmrMice;
        private System.Windows.Forms.Timer tmrAnim;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAgeName;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label lblRetry;
        private System.Windows.Forms.Label lblMenu;
    }
}

