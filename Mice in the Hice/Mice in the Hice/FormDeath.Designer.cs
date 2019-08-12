namespace Mice_in_the_Hice
{
    partial class FormDeath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeath));
            this.pnlDog = new System.Windows.Forms.Panel();
            this.lblScoreLvlName = new System.Windows.Forms.Label();
            this.lblScoreName = new System.Windows.Forms.Label();
            this.lblScoreLvl = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblDead = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAgeName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.pnlDog.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDog
            // 
            this.pnlDog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDog.BackgroundImage")));
            this.pnlDog.Controls.Add(this.lblAge);
            this.pnlDog.Controls.Add(this.lblAgeName);
            this.pnlDog.Controls.Add(this.lblName);
            this.pnlDog.Controls.Add(this.lblScoreLvlName);
            this.pnlDog.Controls.Add(this.lblScoreName);
            this.pnlDog.Controls.Add(this.lblScoreLvl);
            this.pnlDog.Controls.Add(this.lblScore);
            this.pnlDog.Controls.Add(this.btnRetry);
            this.pnlDog.Controls.Add(this.btnMenu);
            this.pnlDog.Controls.Add(this.lblDead);
            this.pnlDog.Location = new System.Drawing.Point(0, 0);
            this.pnlDog.Name = "pnlDog";
            this.pnlDog.Size = new System.Drawing.Size(1276, 692);
            this.pnlDog.TabIndex = 0;
            // 
            // lblScoreLvlName
            // 
            this.lblScoreLvlName.BackColor = System.Drawing.Color.White;
            this.lblScoreLvlName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreLvlName.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreLvlName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScoreLvlName.Location = new System.Drawing.Point(818, 368);
            this.lblScoreLvlName.Name = "lblScoreLvlName";
            this.lblScoreLvlName.Size = new System.Drawing.Size(125, 38);
            this.lblScoreLvlName.TabIndex = 24;
            this.lblScoreLvlName.Text = "Level";
            this.lblScoreLvlName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreName
            // 
            this.lblScoreName.BackColor = System.Drawing.Color.White;
            this.lblScoreName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreName.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScoreName.Location = new System.Drawing.Point(818, 320);
            this.lblScoreName.Name = "lblScoreName";
            this.lblScoreName.Size = new System.Drawing.Size(125, 38);
            this.lblScoreName.TabIndex = 23;
            this.lblScoreName.Text = "Score";
            this.lblScoreName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreLvl
            // 
            this.lblScoreLvl.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblScoreLvl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreLvl.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreLvl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScoreLvl.Location = new System.Drawing.Point(949, 368);
            this.lblScoreLvl.Name = "lblScoreLvl";
            this.lblScoreLvl.Size = new System.Drawing.Size(100, 38);
            this.lblScoreLvl.TabIndex = 22;
            this.lblScoreLvl.Text = "0";
            this.lblScoreLvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScore.Location = new System.Drawing.Point(949, 320);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 38);
            this.lblScore.TabIndex = 21;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.Transparent;
            this.btnRetry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetry.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetry.Image = ((System.Drawing.Image)(resources.GetObject("btnRetry.Image")));
            this.btnRetry.Location = new System.Drawing.Point(628, 487);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(346, 57);
            this.btnRetry.TabIndex = 9;
            this.btnRetry.Text = "TRY AGAIN";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(628, 579);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(346, 57);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "BACK TO MAIN MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblDead
            // 
            this.lblDead.BackColor = System.Drawing.Color.Transparent;
            this.lblDead.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDead.Location = new System.Drawing.Point(566, 38);
            this.lblDead.Name = "lblDead";
            this.lblDead.Size = new System.Drawing.Size(483, 248);
            this.lblDead.TabIndex = 1;
            this.lblDead.Click += new System.EventHandler(this.lblDead_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(573, 320);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(226, 38);
            this.lblName.TabIndex = 26;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgeName
            // 
            this.lblAgeName.BackColor = System.Drawing.Color.White;
            this.lblAgeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAgeName.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAgeName.Location = new System.Drawing.Point(573, 368);
            this.lblAgeName.Name = "lblAgeName";
            this.lblAgeName.Size = new System.Drawing.Size(129, 38);
            this.lblAgeName.TabIndex = 28;
            this.lblAgeName.Text = "Age";
            this.lblAgeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAge
            // 
            this.lblAge.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAge.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAge.Location = new System.Drawing.Point(720, 368);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(79, 38);
            this.lblAge.TabIndex = 29;
            this.lblAge.Text = "0";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDeath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDog);
            this.Name = "FormDeath";
            this.Text = "FormDeath";
            this.Load += new System.EventHandler(this.FormDeath_Load);
            this.pnlDog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDog;
        private System.Windows.Forms.Label lblDead;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Label lblScoreLvl;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreLvlName;
        private System.Windows.Forms.Label lblScoreName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAgeName;
        private System.Windows.Forms.Label lblName;
    }
}