namespace EvidentaCamin_Form1
{
    partial class Info
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
            this.cmbCamin = new System.Windows.Forms.ComboBox();
            this.lblCamin = new System.Windows.Forms.Label();
            this.pcBCamin = new System.Windows.Forms.PictureBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblZona = new System.Windows.Forms.Label();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.txtAdministrator = new System.Windows.Forms.TextBox();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblDotari = new System.Windows.Forms.Label();
            this.rtbDotari = new System.Windows.Forms.RichTextBox();
            this.lblCapacitate = new System.Windows.Forms.Label();
            this.txtCapacitate = new System.Windows.Forms.TextBox();
            this.lblTarif = new System.Windows.Forms.Label();
            this.txtTarif = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcBCamin)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCamin
            // 
            this.cmbCamin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCamin.FormattingEnabled = true;
            this.cmbCamin.Items.AddRange(new object[] {
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "C8"});
            this.cmbCamin.Location = new System.Drawing.Point(91, 24);
            this.cmbCamin.Name = "cmbCamin";
            this.cmbCamin.Size = new System.Drawing.Size(278, 27);
            this.cmbCamin.TabIndex = 0;
            this.cmbCamin.SelectedIndexChanged += new System.EventHandler(this.cmbCamin_SelectedIndexChanged);
            // 
            // lblCamin
            // 
            this.lblCamin.AutoSize = true;
            this.lblCamin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCamin.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamin.Location = new System.Drawing.Point(12, 25);
            this.lblCamin.Name = "lblCamin";
            this.lblCamin.Size = new System.Drawing.Size(64, 20);
            this.lblCamin.TabIndex = 1;
            this.lblCamin.Text = "Cămine";
            // 
            // pcBCamin
            // 
            this.pcBCamin.Location = new System.Drawing.Point(12, 66);
            this.pcBCamin.Name = "pcBCamin";
            this.pcBCamin.Size = new System.Drawing.Size(356, 337);
            this.pcBCamin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBCamin.TabIndex = 2;
            this.pcBCamin.TabStop = false;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.Location = new System.Drawing.Point(374, 28);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(66, 20);
            this.lblAdresa.TabIndex = 3;
            this.lblAdresa.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAdresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdresa.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtAdresa.Location = new System.Drawing.Point(447, 30);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.ReadOnly = true;
            this.txtAdresa.Size = new System.Drawing.Size(304, 18);
            this.txtAdresa.TabIndex = 4;
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZona.Location = new System.Drawing.Point(376, 48);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(51, 20);
            this.lblZona.TabIndex = 5;
            this.lblZona.Text = "Zona:";
            // 
            // txtZona
            // 
            this.txtZona.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtZona.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZona.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtZona.Location = new System.Drawing.Point(432, 50);
            this.txtZona.Name = "txtZona";
            this.txtZona.ReadOnly = true;
            this.txtZona.Size = new System.Drawing.Size(319, 18);
            this.txtZona.TabIndex = 6;
            // 
            // txtAdministrator
            // 
            this.txtAdministrator.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAdministrator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdministrator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtAdministrator.Location = new System.Drawing.Point(495, 74);
            this.txtAdministrator.Name = "txtAdministrator";
            this.txtAdministrator.ReadOnly = true;
            this.txtAdministrator.Size = new System.Drawing.Size(256, 18);
            this.txtAdministrator.TabIndex = 8;
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrator.Location = new System.Drawing.Point(374, 71);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(115, 20);
            this.lblAdministrator.TabIndex = 7;
            this.lblAdministrator.Text = "Administrator:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefon.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtTelefon.Location = new System.Drawing.Point(448, 98);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.ReadOnly = true;
            this.txtTelefon.Size = new System.Drawing.Size(303, 18);
            this.txtTelefon.TabIndex = 10;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(376, 96);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(67, 20);
            this.lblTelefon.TabIndex = 9;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtTip
            // 
            this.txtTip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtTip.Location = new System.Drawing.Point(481, 122);
            this.txtTip.Name = "txtTip";
            this.txtTip.ReadOnly = true;
            this.txtTip.Size = new System.Drawing.Size(270, 18);
            this.txtTip.TabIndex = 12;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(376, 122);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(90, 20);
            this.lblTip.TabIndex = 11;
            this.lblTip.Text = "Tip (m,f,b):";
            // 
            // lblDotari
            // 
            this.lblDotari.AutoSize = true;
            this.lblDotari.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDotari.Location = new System.Drawing.Point(376, 151);
            this.lblDotari.Name = "lblDotari";
            this.lblDotari.Size = new System.Drawing.Size(61, 20);
            this.lblDotari.TabIndex = 13;
            this.lblDotari.Text = "Dotari:";
            // 
            // rtbDotari
            // 
            this.rtbDotari.BackColor = System.Drawing.SystemColors.Control;
            this.rtbDotari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDotari.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDotari.Location = new System.Drawing.Point(378, 174);
            this.rtbDotari.Name = "rtbDotari";
            this.rtbDotari.ReadOnly = true;
            this.rtbDotari.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbDotari.Size = new System.Drawing.Size(334, 149);
            this.rtbDotari.TabIndex = 14;
            this.rtbDotari.Text = "";
            // 
            // lblCapacitate
            // 
            this.lblCapacitate.AutoSize = true;
            this.lblCapacitate.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacitate.Location = new System.Drawing.Point(376, 340);
            this.lblCapacitate.Name = "lblCapacitate";
            this.lblCapacitate.Size = new System.Drawing.Size(93, 20);
            this.lblCapacitate.TabIndex = 15;
            this.lblCapacitate.Text = "Capacitate:";
            // 
            // txtCapacitate
            // 
            this.txtCapacitate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCapacitate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCapacitate.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtCapacitate.Location = new System.Drawing.Point(483, 342);
            this.txtCapacitate.Name = "txtCapacitate";
            this.txtCapacitate.ReadOnly = true;
            this.txtCapacitate.Size = new System.Drawing.Size(268, 18);
            this.txtCapacitate.TabIndex = 16;
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarif.Location = new System.Drawing.Point(374, 372);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(158, 20);
            this.lblTarif.TabIndex = 17;
            this.lblTarif.Text = "Tarif/lună/persoană:";
            // 
            // txtTarif
            // 
            this.txtTarif.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTarif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTarif.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtTarif.Location = new System.Drawing.Point(538, 374);
            this.txtTarif.Name = "txtTarif";
            this.txtTarif.ReadOnly = true;
            this.txtTarif.Size = new System.Drawing.Size(213, 18);
            this.txtTarif.TabIndex = 18;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.BackgroundImage = global::EvidentaCamin_Form1.Properties.Resources.exit_button_png_button_cancel_close_delete_exit_remove_stop_x_icon_5121;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(757, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 38);
            this.btnExit.TabIndex = 19;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 434);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTarif);
            this.Controls.Add(this.lblTarif);
            this.Controls.Add(this.txtCapacitate);
            this.Controls.Add(this.lblCapacitate);
            this.Controls.Add(this.rtbDotari);
            this.Controls.Add(this.lblDotari);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtAdministrator);
            this.Controls.Add(this.lblAdministrator);
            this.Controls.Add(this.txtZona);
            this.Controls.Add(this.lblZona);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.pcBCamin);
            this.Controls.Add(this.lblCamin);
            this.Controls.Add(this.cmbCamin);
            this.Name = "Info";
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.pcBCamin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCamin;
        private System.Windows.Forms.Label lblCamin;
        private System.Windows.Forms.PictureBox pcBCamin;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.TextBox txtAdministrator;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblDotari;
        private System.Windows.Forms.RichTextBox rtbDotari;
        private System.Windows.Forms.Label lblCapacitate;
        private System.Windows.Forms.TextBox txtCapacitate;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.TextBox txtTarif;
        private System.Windows.Forms.Button btnExit;
    }
}