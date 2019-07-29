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
            this.lblLivesName = new System.Windows.Forms.Label();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlGame.Location = new System.Drawing.Point(0, 110);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(731, 426);
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
            this.pnlLogo.Controls.Add(this.lblLivesName);
            this.pnlLogo.Controls.Add(this.pnlGame);
            this.pnlLogo.Location = new System.Drawing.Point(12, 2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(960, 547);
            this.pnlLogo.TabIndex = 1;
            // 
            // lblLivesName
            // 
            this.lblLivesName.AutoSize = true;
            this.lblLivesName.BackColor = System.Drawing.Color.Yellow;
            this.lblLivesName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLivesName.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivesName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLivesName.Location = new System.Drawing.Point(760, 136);
            this.lblLivesName.Name = "lblLivesName";
            this.lblLivesName.Size = new System.Drawing.Size(79, 36);
            this.lblLivesName.TabIndex = 1;
            this.lblLivesName.Text = "Lives";
            this.lblLivesName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(984, 535);
            this.Controls.Add(this.pnlLogo);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "FormHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The House";
            this.Load += new System.EventHandler(this.FormHouse_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormHouse_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormHouse_KeyUp);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Timer tmrBigMouse;
        private System.Windows.Forms.Timer tmrSmallMouse;
        private System.Windows.Forms.Timer tmrSparkles;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLivesName;
    }
}

