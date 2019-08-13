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
            this.t = new System.Windows.Forms.Panel();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAge = new System.Windows.Forms.NumericUpDown();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLore = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMenuLogo = new System.Windows.Forms.Panel();
            this.t.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAge)).BeginInit();
            this.SuspendLayout();
            // 
            // t
            // 
            this.t.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("t.BackgroundImage")));
            this.t.Controls.Add(this.lblAge);
            this.t.Controls.Add(this.lblName);
            this.t.Controls.Add(this.label1);
            this.t.Controls.Add(this.txtName);
            this.t.Controls.Add(this.btnAge);
            this.t.Controls.Add(this.btnPlay);
            this.t.Controls.Add(this.btnHelp);
            this.t.Controls.Add(this.btnLore);
            this.t.Controls.Add(this.btnExit);
            this.t.Controls.Add(this.pnlMenuLogo);
            this.t.Location = new System.Drawing.Point(0, -36);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(1276, 719);
            this.t.TabIndex = 0;
            this.t.Paint += new System.Windows.Forms.PaintEventHandler(this.t_Paint);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(946, 317);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(39, 23);
            this.lblAge.TabIndex = 11;
            this.lblAge.Text = "Age";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(691, 317);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 23);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.PeachPuff;
            this.txtName.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(695, 347);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 33);
            this.txtName.TabIndex = 8;
            this.txtName.Text = "Sparkles";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // btnAge
            // 
            this.btnAge.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAge.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAge.Location = new System.Drawing.Point(950, 347);
            this.btnAge.Maximum = new decimal(new int[] {
            123,
            0,
            0,
            0});
            this.btnAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.btnAge.Name = "btnAge";
            this.btnAge.Size = new System.Drawing.Size(91, 33);
            this.btnAge.TabIndex = 7;
            this.btnAge.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.btnAge.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.btnAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAge_KeyDown);
            this.btnAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAge_KeyPress);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(695, 397);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(346, 57);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.Location = new System.Drawing.Point(695, 471);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(346, 57);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "HELP";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnLore
            // 
            this.btnLore.BackColor = System.Drawing.Color.Transparent;
            this.btnLore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLore.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLore.Image = ((System.Drawing.Image)(resources.GetObject("btnLore.Image")));
            this.btnLore.Location = new System.Drawing.Point(695, 543);
            this.btnLore.Name = "btnLore";
            this.btnLore.Size = new System.Drawing.Size(346, 57);
            this.btnLore.TabIndex = 4;
            this.btnLore.Text = "LORE";
            this.btnLore.UseVisualStyleBackColor = false;
            this.btnLore.Click += new System.EventHandler(this.btnLore_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(695, 612);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(346, 57);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
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
            this.ControlBox = false;
            this.Controls.Add(this.t);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.t.ResumeLayout(false);
            this.t.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel t;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMenuLogo;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnLore;
        private System.Windows.Forms.NumericUpDown btnAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
    }
}