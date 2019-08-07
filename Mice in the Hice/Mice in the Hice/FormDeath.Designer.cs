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
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblDead = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            this.pnlDog.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDog
            // 
            this.pnlDog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDog.BackgroundImage")));
            this.pnlDog.Controls.Add(this.btnRetry);
            this.pnlDog.Controls.Add(this.btnMenu);
            this.pnlDog.Controls.Add(this.lblDead);
            this.pnlDog.Location = new System.Drawing.Point(0, 0);
            this.pnlDog.Name = "pnlDog";
            this.pnlDog.Size = new System.Drawing.Size(1276, 692);
            this.pnlDog.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(628, 529);
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
            this.lblDead.Location = new System.Drawing.Point(586, 73);
            this.lblDead.Name = "lblDead";
            this.lblDead.Size = new System.Drawing.Size(470, 248);
            this.lblDead.TabIndex = 1;
            this.lblDead.Text = "gggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggguub" +
    "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb";
            this.lblDead.Click += new System.EventHandler(this.lblDead_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.Transparent;
            this.btnRetry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetry.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetry.Image = ((System.Drawing.Image)(resources.GetObject("btnRetry.Image")));
            this.btnRetry.Location = new System.Drawing.Point(628, 434);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(346, 57);
            this.btnRetry.TabIndex = 9;
            this.btnRetry.Text = "TRY AGAIN";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDog;
        private System.Windows.Forms.Label lblDead;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnRetry;
    }
}