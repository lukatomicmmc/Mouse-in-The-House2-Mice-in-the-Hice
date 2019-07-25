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
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlGame.Location = new System.Drawing.Point(12, 112);
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
            // FormHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(984, 535);
            this.Controls.Add(this.pnlGame);
            this.DoubleBuffered = true;
            this.Name = "FormHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The House";
            this.Load += new System.EventHandler(this.FormHouse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Timer tmrBigMouse;
        private System.Windows.Forms.Timer tmrSmallMouse;
    }
}

