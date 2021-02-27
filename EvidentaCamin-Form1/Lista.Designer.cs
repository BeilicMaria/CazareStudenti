namespace EvidentaCamin_Form1
{
    partial class Lista
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
            this.lstAfisareStud = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAfisareStud
            // 
            this.lstAfisareStud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAfisareStud.FormattingEnabled = true;
            this.lstAfisareStud.ItemHeight = 16;
            this.lstAfisareStud.Location = new System.Drawing.Point(12, 59);
            this.lstAfisareStud.Name = "lstAfisareStud";
            this.lstAfisareStud.Size = new System.Drawing.Size(790, 340);
            this.lstAfisareStud.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.BackgroundImage = global::EvidentaCamin_Form1.Properties.Resources.exit_button_png_button_cancel_close_delete_exit_remove_stop_x_icon_5121;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(761, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 37);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAfisare.BackgroundImage = global::EvidentaCamin_Form1.Properties.Resources.imgbin_check_mark_symbol_symbol_tJpVM5PCaMNtggHAbMVstYUnw;
            this.btnAfisare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAfisare.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfisare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAfisare.Location = new System.Drawing.Point(13, 12);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(45, 37);
            this.btnAfisare.TabIndex = 2;
            this.btnAfisare.UseVisualStyleBackColor = false;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvidentaCamin_Form1.Properties.Resources.s5682;
            this.ClientSize = new System.Drawing.Size(814, 434);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstAfisareStud);
            this.Name = "Lista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAfisareStud;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAfisare;
    }
}