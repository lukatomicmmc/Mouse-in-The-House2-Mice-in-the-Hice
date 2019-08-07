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
            this.lblDead = new System.Windows.Forms.Label();
            this.txtDead = new System.Windows.Forms.TextBox();
            this.pnlDog.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDog
            // 
            this.pnlDog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDog.BackgroundImage")));
            this.pnlDog.Controls.Add(this.txtDead);
            this.pnlDog.Controls.Add(this.lblDead);
            this.pnlDog.Location = new System.Drawing.Point(0, 0);
            this.pnlDog.Name = "pnlDog";
            this.pnlDog.Size = new System.Drawing.Size(1276, 692);
            this.pnlDog.TabIndex = 0;
            // 
            // lblDead
            // 
            this.lblDead.BackColor = System.Drawing.Color.Transparent;
            this.lblDead.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDead.Location = new System.Drawing.Point(586, 73);
            this.lblDead.Name = "lblDead";
            this.lblDead.Size = new System.Drawing.Size(473, 246);
            this.lblDead.TabIndex = 1;
            this.lblDead.Click += new System.EventHandler(this.lblDead_Click);
            // 
            // txtDead
            // 
            this.txtDead.Location = new System.Drawing.Point(594, 81);
            this.txtDead.Name = "txtDead";
            this.txtDead.ReadOnly = true;
            this.txtDead.Size = new System.Drawing.Size(100, 20);
            this.txtDead.TabIndex = 2;
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
            this.pnlDog.ResumeLayout(false);
            this.pnlDog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDog;
        private System.Windows.Forms.Label lblDead;
        private System.Windows.Forms.TextBox txtDead;
    }
}