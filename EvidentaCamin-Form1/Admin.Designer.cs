namespace EvidentaCamin_Form1
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnInregistreaza = new System.Windows.Forms.Button();
            this.BtnCautare = new System.Windows.Forms.Button();
            this.btnDeconectare = new System.Windows.Forms.Button();
            this.pbUSV = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbUSV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInregistreaza
            // 
            this.btnInregistreaza.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnInregistreaza.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInregistreaza.Location = new System.Drawing.Point(-1, 190);
            this.btnInregistreaza.Name = "btnInregistreaza";
            this.btnInregistreaza.Size = new System.Drawing.Size(165, 58);
            this.btnInregistreaza.TabIndex = 0;
            this.btnInregistreaza.Text = "Înregistrează student";
            this.btnInregistreaza.UseVisualStyleBackColor = false;
            this.btnInregistreaza.Click += new System.EventHandler(this.btnInregistreaza_Click);
            // 
            // BtnCautare
            // 
            this.BtnCautare.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnCautare.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCautare.Location = new System.Drawing.Point(-1, 295);
            this.BtnCautare.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCautare.Name = "BtnCautare";
            this.BtnCautare.Size = new System.Drawing.Size(166, 71);
            this.BtnCautare.TabIndex = 12;
            this.BtnCautare.Text = "Căutare student";
            this.BtnCautare.UseVisualStyleBackColor = false;
            this.BtnCautare.Click += new System.EventHandler(this.BtnCautare_Click);
            // 
            // btnDeconectare
            // 
            this.btnDeconectare.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeconectare.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconectare.Location = new System.Drawing.Point(-1, 418);
            this.btnDeconectare.Name = "btnDeconectare";
            this.btnDeconectare.Size = new System.Drawing.Size(165, 48);
            this.btnDeconectare.TabIndex = 13;
            this.btnDeconectare.Text = "Deconectare";
            this.btnDeconectare.UseVisualStyleBackColor = false;
            this.btnDeconectare.Click += new System.EventHandler(this.btnDeconectare_Click);
            // 
            // pbUSV
            // 
            this.pbUSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbUSV.Image = global::EvidentaCamin_Form1.Properties.Resources.giphy;
            this.pbUSV.Location = new System.Drawing.Point(303, 133);
            this.pbUSV.Name = "pbUSV";
            this.pbUSV.Size = new System.Drawing.Size(410, 321);
            this.pbUSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUSV.TabIndex = 14;
            this.pbUSV.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EvidentaCamin_Form1.Properties.Resources.Navy_Brick;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbAdmin);
            this.panel1.Controls.Add(this.btnInregistreaza);
            this.panel1.Controls.Add(this.btnDeconectare);
            this.panel1.Controls.Add(this.BtnCautare);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 537);
            this.panel1.TabIndex = 15;
            // 
            // pbAdmin
            // 
            this.pbAdmin.BackgroundImage = global::EvidentaCamin_Form1.Properties.Resources.Navy_Brick1;
            this.pbAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAdmin.Location = new System.Drawing.Point(0, -1);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(165, 159);
            this.pbAdmin.TabIndex = 0;
            this.pbAdmin.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(165, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 37);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(165, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(684, 19);
            this.panel3.TabIndex = 17;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 537);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbUSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.pbUSV)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInregistreaza;
        private System.Windows.Forms.Button BtnCautare;
        private System.Windows.Forms.Button btnDeconectare;
        private System.Windows.Forms.PictureBox pbUSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}