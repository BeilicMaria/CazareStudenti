namespace EvidentaCamin_Form1
{
    partial class Modificare
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.BtnCautare = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.lblAn = new System.Windows.Forms.Label();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.lblModifica = new System.Windows.Forms.Label();
            this.lblCamera = new System.Windows.Forms.Label();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.SalvareFisierCazati = new System.Windows.Forms.MenuStrip();
            this.salvareCazati = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridStudent = new System.Windows.Forms.DataGridView();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnSterge = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalvareFisierCazati.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 374);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(195, 38);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Înapoi";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.BackColor = System.Drawing.Color.Transparent;
            this.lblNume.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNume.Location = new System.Drawing.Point(6, 23);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(57, 20);
            this.lblNume.TabIndex = 2;
            this.lblNume.Text = "Nume:";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenume.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenume.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPrenume.Location = new System.Drawing.Point(0, 73);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(79, 20);
            this.lblPrenume.TabIndex = 3;
            this.lblPrenume.Text = "Prenume:";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(92, 23);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(95, 22);
            this.txtNume.TabIndex = 4;
            this.txtNume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNume_KeyPress);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(92, 73);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(95, 22);
            this.txtPrenume.TabIndex = 5;
            this.txtPrenume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNume_KeyPress);
            // 
            // BtnCautare
            // 
            this.BtnCautare.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnCautare.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCautare.Location = new System.Drawing.Point(0, 115);
            this.BtnCautare.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCautare.Name = "BtnCautare";
            this.BtnCautare.Size = new System.Drawing.Size(195, 43);
            this.BtnCautare.TabIndex = 12;
            this.BtnCautare.Text = "Căutare";
            this.BtnCautare.UseVisualStyleBackColor = false;
            this.BtnCautare.Click += new System.EventHandler(this.BtnCautare_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnModifica.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(0, 281);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(195, 40);
            this.btnModifica.TabIndex = 14;
            this.btnModifica.Text = "Modifică";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.BackColor = System.Drawing.Color.Transparent;
            this.lblAn.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAn.Location = new System.Drawing.Point(14, 195);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(35, 20);
            this.lblAn.TabIndex = 15;
            this.lblAn.Text = "An:";
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(92, 193);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(95, 22);
            this.txtAn.TabIndex = 16;
            this.txtAn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAn_KeyPress);
            // 
            // lblModifica
            // 
            this.lblModifica.AutoSize = true;
            this.lblModifica.Location = new System.Drawing.Point(198, 9);
            this.lblModifica.Name = "lblModifica";
            this.lblModifica.Size = new System.Drawing.Size(0, 17);
            this.lblModifica.TabIndex = 17;
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.BackColor = System.Drawing.Color.Transparent;
            this.lblCamera.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamera.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCamera.Location = new System.Drawing.Point(6, 244);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(83, 23);
            this.lblCamera.TabIndex = 28;
            this.lblCamera.Text = "Camera:";
            // 
            // cmbCamera
            // 
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Items.AddRange(new object[] {
            "1 ",
            "2 ",
            "3 ",
            "4 "});
            this.cmbCamera.Location = new System.Drawing.Point(92, 243);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(95, 24);
            this.cmbCamera.TabIndex = 27;
            // 
            // SalvareFisierCazati
            // 
            this.SalvareFisierCazati.BackColor = System.Drawing.Color.LightSlateGray;
            this.SalvareFisierCazati.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SalvareFisierCazati.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareCazati});
            this.SalvareFisierCazati.Location = new System.Drawing.Point(0, 0);
            this.SalvareFisierCazati.Name = "SalvareFisierCazati";
            this.SalvareFisierCazati.Size = new System.Drawing.Size(813, 28);
            this.SalvareFisierCazati.TabIndex = 29;
            this.SalvareFisierCazati.Text = "menuStrip1";
            // 
            // salvareCazati
            // 
            this.salvareCazati.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvareCazati.Name = "salvareCazati";
            this.salvareCazati.Size = new System.Drawing.Size(127, 26);
            this.salvareCazati.Text = "Salvare Cazați";
            this.salvareCazati.Click += new System.EventHandler(this.salvareCazati_Click);
            // 
            // dataGridStudent
            // 
            this.dataGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudent.Location = new System.Drawing.Point(201, 36);
            this.dataGridStudent.Name = "dataGridStudent";
            this.dataGridStudent.RowHeadersWidth = 51;
            this.dataGridStudent.RowTemplate.Height = 24;
            this.dataGridStudent.Size = new System.Drawing.Size(605, 406);
            this.dataGridStudent.TabIndex = 32;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(234, 9);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 17);
            this.lblMesaj.TabIndex = 33;
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSterge.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.Location = new System.Drawing.Point(0, 327);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(195, 41);
            this.btnSterge.TabIndex = 34;
            this.btnSterge.Text = "Șterge";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = global::EvidentaCamin_Form1.Properties.Resources._0F1F38;
            this.panel1.Controls.Add(this.txtPrenume);
            this.panel1.Controls.Add(this.btnSterge);
            this.panel1.Controls.Add(this.lblNume);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnModifica);
            this.panel1.Controls.Add(this.lblPrenume);
            this.panel1.Controls.Add(this.lblCamera);
            this.panel1.Controls.Add(this.txtNume);
            this.panel1.Controls.Add(this.cmbCamera);
            this.panel1.Controls.Add(this.BtnCautare);
            this.panel1.Controls.Add(this.txtAn);
            this.panel1.Controls.Add(this.lblAn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 422);
            this.panel1.TabIndex = 35;
            // 
            // Modificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvidentaCamin_Form1.Properties.Resources.s5681;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.dataGridStudent);
            this.Controls.Add(this.SalvareFisierCazati);
            this.Controls.Add(this.lblModifica);
            this.MainMenuStrip = this.SalvareFisierCazati;
            this.Name = "Modificare";
            this.ShowIcon = false;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNume_KeyPress);
            this.SalvareFisierCazati.ResumeLayout(false);
            this.SalvareFisierCazati.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Button BtnCautare;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.Label lblModifica;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.MenuStrip SalvareFisierCazati;
        private System.Windows.Forms.ToolStripMenuItem salvareCazati;
        private System.Windows.Forms.DataGridView dataGridStudent;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Panel panel1;
    }
}