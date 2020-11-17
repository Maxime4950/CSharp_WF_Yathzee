namespace MAES_MAXIME_YATHZEE
{
    partial class EcranInitialisationJeu
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
            this.btnCommencer = new System.Windows.Forms.Button();
            this.tbJ2 = new System.Windows.Forms.TextBox();
            this.tbJ1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnLancerJ2 = new System.Windows.Forms.Button();
            this.btnLancerJ1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pbLancementJ2 = new System.Windows.Forms.PictureBox();
            this.pbLancementJ1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChargeSauvegarde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLancementJ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLancementJ1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCommencer
            // 
            this.btnCommencer.BackColor = System.Drawing.Color.Brown;
            this.btnCommencer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCommencer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCommencer.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommencer.ForeColor = System.Drawing.Color.White;
            this.btnCommencer.Location = new System.Drawing.Point(-25, 896);
            this.btnCommencer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCommencer.Name = "btnCommencer";
            this.btnCommencer.Size = new System.Drawing.Size(768, 194);
            this.btnCommencer.TabIndex = 31;
            this.btnCommencer.Text = "C O M M E N C E R";
            this.btnCommencer.UseVisualStyleBackColor = false;
            this.btnCommencer.Click += new System.EventHandler(this.btnCommencer_Click);
            // 
            // tbJ2
            // 
            this.tbJ2.Location = new System.Drawing.Point(411, 118);
            this.tbJ2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbJ2.Multiline = true;
            this.tbJ2.Name = "tbJ2";
            this.tbJ2.Size = new System.Drawing.Size(262, 46);
            this.tbJ2.TabIndex = 28;
            this.tbJ2.TextChanged += new System.EventHandler(this.tbJ2_TextChanged);
            // 
            // tbJ1
            // 
            this.tbJ1.Location = new System.Drawing.Point(50, 120);
            this.tbJ1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbJ1.Multiline = true;
            this.tbJ1.Name = "tbJ1";
            this.tbJ1.Size = new System.Drawing.Size(262, 44);
            this.tbJ1.TabIndex = 27;
            this.tbJ1.TextChanged += new System.EventHandler(this.tbJ1_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Brown;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(411, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 50);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nom Joueur 2:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.Location = new System.Drawing.Point(50, 506);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(623, 82);
            this.btnRecommencer.TabIndex = 42;
            this.btnRecommencer.Text = "R E C O M M E N C E R  (S I  E G A L I T E)";
            this.btnRecommencer.UseVisualStyleBackColor = true;
            this.btnRecommencer.Click += new System.EventHandler(this.btnRecommencer_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(52, 724);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(621, 148);
            this.lblResultat.TabIndex = 41;
            this.lblResultat.Text = "Veuillez indiquer votre nom\r\net\r\nlancer les dés pour définir l\'ordre de jeu";
            this.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLancerJ2
            // 
            this.btnLancerJ2.Location = new System.Drawing.Point(492, 381);
            this.btnLancerJ2.Name = "btnLancerJ2";
            this.btnLancerJ2.Size = new System.Drawing.Size(131, 82);
            this.btnLancerJ2.TabIndex = 40;
            this.btnLancerJ2.Text = "L A N C E R";
            this.btnLancerJ2.UseVisualStyleBackColor = true;
            this.btnLancerJ2.Click += new System.EventHandler(this.btnLancerJ2_Click);
            // 
            // btnLancerJ1
            // 
            this.btnLancerJ1.Location = new System.Drawing.Point(106, 381);
            this.btnLancerJ1.Name = "btnLancerJ1";
            this.btnLancerJ1.Size = new System.Drawing.Size(131, 82);
            this.btnLancerJ1.TabIndex = 39;
            this.btnLancerJ1.Text = "L A N C E R";
            this.btnLancerJ1.UseVisualStyleBackColor = true;
            this.btnLancerJ1.Click += new System.EventHandler(this.btnLancerJ1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 38;
            // 
            // pbLancementJ2
            // 
            this.pbLancementJ2.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de6;
            this.pbLancementJ2.Location = new System.Drawing.Point(492, 225);
            this.pbLancementJ2.Name = "pbLancementJ2";
            this.pbLancementJ2.Size = new System.Drawing.Size(131, 117);
            this.pbLancementJ2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLancementJ2.TabIndex = 37;
            this.pbLancementJ2.TabStop = false;
            // 
            // pbLancementJ1
            // 
            this.pbLancementJ1.Image = global::MAES_MAXIME_YATHZEE.Properties.Resources.de6;
            this.pbLancementJ1.Location = new System.Drawing.Point(106, 225);
            this.pbLancementJ1.Name = "pbLancementJ1";
            this.pbLancementJ1.Size = new System.Drawing.Size(131, 117);
            this.pbLancementJ1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLancementJ1.TabIndex = 36;
            this.pbLancementJ1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Brown;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(50, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 50);
            this.label4.TabIndex = 44;
            this.label4.Text = "Nom Joueur 1:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChargeSauvegarde
            // 
            this.btnChargeSauvegarde.Location = new System.Drawing.Point(50, 609);
            this.btnChargeSauvegarde.Name = "btnChargeSauvegarde";
            this.btnChargeSauvegarde.Size = new System.Drawing.Size(623, 82);
            this.btnChargeSauvegarde.TabIndex = 45;
            this.btnChargeSauvegarde.Text = "C H A R G E R  S A U V E G A R D E";
            this.btnChargeSauvegarde.UseVisualStyleBackColor = true;
            this.btnChargeSauvegarde.Click += new System.EventHandler(this.btnChargeSauvegarde_Click);
            // 
            // EcranInitialisationJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(716, 1079);
            this.Controls.Add(this.btnChargeSauvegarde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnLancerJ2);
            this.Controls.Add(this.btnLancerJ1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbLancementJ2);
            this.Controls.Add(this.pbLancementJ1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCommencer);
            this.Controls.Add(this.tbJ2);
            this.Controls.Add(this.tbJ1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranInitialisationJeu";
            this.Text = "ficInitialisationJeu";
            this.Load += new System.EventHandler(this.EcranInitialisationJeu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLancementJ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLancementJ1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCommencer;
        public System.Windows.Forms.TextBox tbJ2;
        public System.Windows.Forms.TextBox tbJ1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.Button btnLancerJ2;
        private System.Windows.Forms.Button btnLancerJ1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbLancementJ2;
        private System.Windows.Forms.PictureBox pbLancementJ1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnChargeSauvegarde;
    }
}