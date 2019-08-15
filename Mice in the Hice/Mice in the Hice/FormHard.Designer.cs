namespace Mice_in_the_Hice
{
    partial class FormHard
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
            this.pnlGamed = new System.Windows.Forms.Panel();
            this.lblPaused = new System.Windows.Forms.Label();
            this.lblRetried = new System.Windows.Forms.Label();
            this.lblMenud = new System.Windows.Forms.Label();
            this.txtNamed = new System.Windows.Forms.TextBox();
            this.txtAgeReal = new System.Windows.Forms.TextBox();
            this.txtAged = new System.Windows.Forms.TextBox();
            this.lblScoreReal = new System.Windows.Forms.Label();
            this.lblScored = new System.Windows.Forms.Label();
            this.tmrMiced = new System.Windows.Forms.Timer(this.components);
            this.tmrSparkled = new System.Windows.Forms.Timer(this.components);
            this.tmrAnimed = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlGamed
            // 
            this.pnlGamed.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlGamed.Location = new System.Drawing.Point(12, 116);
            this.pnlGamed.Name = "pnlGamed";
            this.pnlGamed.Size = new System.Drawing.Size(960, 553);
            this.pnlGamed.TabIndex = 0;
            this.pnlGamed.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGamed_Paint_1);
            // 
            // lblPaused
            // 
            this.lblPaused.Font = new System.Drawing.Font("Wide Latin", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaused.ForeColor = System.Drawing.Color.DimGray;
            this.lblPaused.Location = new System.Drawing.Point(12, -5);
            this.lblPaused.Name = "lblPaused";
            this.lblPaused.Size = new System.Drawing.Size(856, 105);
            this.lblPaused.TabIndex = 1;
            // 
            // lblRetried
            // 
            this.lblRetried.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetried.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRetried.Location = new System.Drawing.Point(888, 9);
            this.lblRetried.Name = "lblRetried";
            this.lblRetried.Size = new System.Drawing.Size(166, 36);
            this.lblRetried.TabIndex = 2;
            this.lblRetried.Click += new System.EventHandler(this.lblRetried_Click_1);
            // 
            // lblMenud
            // 
            this.lblMenud.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenud.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMenud.Location = new System.Drawing.Point(888, 65);
            this.lblMenud.Name = "lblMenud";
            this.lblMenud.Size = new System.Drawing.Size(166, 36);
            this.lblMenud.TabIndex = 3;
            this.lblMenud.Click += new System.EventHandler(this.lblMenud_Click_1);
            // 
            // txtNamed
            // 
            this.txtNamed.BackColor = System.Drawing.Color.DimGray;
            this.txtNamed.Enabled = false;
            this.txtNamed.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamed.Location = new System.Drawing.Point(989, 116);
            this.txtNamed.Name = "txtNamed";
            this.txtNamed.ReadOnly = true;
            this.txtNamed.Size = new System.Drawing.Size(263, 37);
            this.txtNamed.TabIndex = 6;
            // 
            // txtAgeReal
            // 
            this.txtAgeReal.BackColor = System.Drawing.Color.DarkGray;
            this.txtAgeReal.Enabled = false;
            this.txtAgeReal.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeReal.Location = new System.Drawing.Point(989, 159);
            this.txtAgeReal.Name = "txtAgeReal";
            this.txtAgeReal.ReadOnly = true;
            this.txtAgeReal.Size = new System.Drawing.Size(126, 37);
            this.txtAgeReal.TabIndex = 7;
            this.txtAgeReal.Text = "Age";
            // 
            // txtAged
            // 
            this.txtAged.BackColor = System.Drawing.Color.DimGray;
            this.txtAged.Enabled = false;
            this.txtAged.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAged.Location = new System.Drawing.Point(1121, 159);
            this.txtAged.Name = "txtAged";
            this.txtAged.ReadOnly = true;
            this.txtAged.Size = new System.Drawing.Size(131, 37);
            this.txtAged.TabIndex = 8;
            // 
            // lblScoreReal
            // 
            this.lblScoreReal.BackColor = System.Drawing.Color.DarkGray;
            this.lblScoreReal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreReal.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreReal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScoreReal.Location = new System.Drawing.Point(984, 338);
            this.lblScoreReal.Name = "lblScoreReal";
            this.lblScoreReal.Size = new System.Drawing.Size(268, 36);
            this.lblScoreReal.TabIndex = 9;
            this.lblScoreReal.Text = "Score";
            this.lblScoreReal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScored
            // 
            this.lblScored.BackColor = System.Drawing.Color.DimGray;
            this.lblScored.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScored.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScored.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScored.Location = new System.Drawing.Point(984, 398);
            this.lblScored.Name = "lblScored";
            this.lblScored.Size = new System.Drawing.Size(268, 36);
            this.lblScored.TabIndex = 10;
            this.lblScored.Text = "0";
            this.lblScored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrMiced
            // 
            this.tmrMiced.Enabled = true;
            this.tmrMiced.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrSparkled
            // 
            this.tmrSparkled.Enabled = true;
            this.tmrSparkled.Tick += new System.EventHandler(this.tmrSparkled_Tick_1);
            // 
            // tmrAnimed
            // 
            this.tmrAnimed.Enabled = true;
            this.tmrAnimed.Tick += new System.EventHandler(this.tmrAnimed_Tick);
            // 
            // FormHard
            // 
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblScored);
            this.Controls.Add(this.lblScoreReal);
            this.Controls.Add(this.txtAged);
            this.Controls.Add(this.txtAgeReal);
            this.Controls.Add(this.txtNamed);
            this.Controls.Add(this.lblMenud);
            this.Controls.Add(this.lblRetried);
            this.Controls.Add(this.lblPaused);
            this.Controls.Add(this.pnlGamed);
            this.Name = "FormHard";
            this.Text = "Welcome to cat hell!";
            this.Load += new System.EventHandler(this.FormHard_Load_2);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormHard_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormHard_KeyUp_1);
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
        private System.Windows.Forms.Panel pnlGamed;
        private System.Windows.Forms.Label lblPaused;
        private System.Windows.Forms.Label lblRetried;
        private System.Windows.Forms.Label lblMenud;
        private System.Windows.Forms.TextBox txtNamed;
        private System.Windows.Forms.TextBox txtAgeReal;
        private System.Windows.Forms.TextBox txtAged;
        private System.Windows.Forms.Label lblScoreReal;
        private System.Windows.Forms.Label lblScored;
        private System.Windows.Forms.Timer tmrMiced;
        private System.Windows.Forms.Timer tmrSparkled;
        private System.Windows.Forms.Timer tmrAnimed;
    }
}

