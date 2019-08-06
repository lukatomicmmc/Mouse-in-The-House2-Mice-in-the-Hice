namespace Mice_in_the_Hice
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.pnlMenuImage = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLore = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMenuLogo = new System.Windows.Forms.Panel();
            this.pnlMenuImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuImage
            // 
            this.pnlMenuImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenuImage.BackgroundImage")));
            this.pnlMenuImage.Controls.Add(this.btnPlay);
            this.pnlMenuImage.Controls.Add(this.btnHelp);
            this.pnlMenuImage.Controls.Add(this.btnLore);
            this.pnlMenuImage.Controls.Add(this.btnExit);
            this.pnlMenuImage.Controls.Add(this.pnlMenuLogo);
            this.pnlMenuImage.Location = new System.Drawing.Point(0, -36);
            this.pnlMenuImage.Name = "pnlMenuImage";
            this.pnlMenuImage.Size = new System.Drawing.Size(1276, 719);
            this.pnlMenuImage.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(695, 328);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(346, 57);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.Location = new System.Drawing.Point(695, 409);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(346, 57);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnLore
            // 
            this.btnLore.BackColor = System.Drawing.Color.Transparent;
            this.btnLore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLore.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLore.Image = ((System.Drawing.Image)(resources.GetObject("btnLore.Image")));
            this.btnLore.Location = new System.Drawing.Point(695, 494);
            this.btnLore.Name = "btnLore";
            this.btnLore.Size = new System.Drawing.Size(346, 57);
            this.btnLore.TabIndex = 4;
            this.btnLore.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(695, 575);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(346, 57);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlMenuLogo
            // 
            this.pnlMenuLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenuLogo.BackgroundImage")));
            this.pnlMenuLogo.Location = new System.Drawing.Point(695, 48);
            this.pnlMenuLogo.Name = "pnlMenuLogo";
            this.pnlMenuLogo.Size = new System.Drawing.Size(346, 243);
            this.pnlMenuLogo.TabIndex = 0;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlMenuImage);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.pnlMenuImage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuImage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMenuLogo;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnLore;
    }
}