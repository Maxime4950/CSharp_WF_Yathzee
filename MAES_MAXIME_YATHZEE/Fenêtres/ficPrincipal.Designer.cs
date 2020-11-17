namespace MAES_MAXIME_YATHZEE
{
    partial class EcranPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranPrincipal));
            this.pbBanniere = new System.Windows.Forms.PictureBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnJouer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanniere)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBanniere
            // 
            this.pbBanniere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbBanniere.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbBanniere.Image = ((System.Drawing.Image)(resources.GetObject("pbBanniere.Image")));
            this.pbBanniere.Location = new System.Drawing.Point(0, 0);
            this.pbBanniere.Name = "pbBanniere";
            this.pbBanniere.Size = new System.Drawing.Size(897, 380);
            this.pbBanniere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBanniere.TabIndex = 13;
            this.pbBanniere.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Brown;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitter.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(488, 409);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(397, 185);
            this.btnQuitter.TabIndex = 10;
            this.btnQuitter.Text = "Q U I T T E R";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnJouer
            // 
            this.btnJouer.BackColor = System.Drawing.Color.Brown;
            this.btnJouer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnJouer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJouer.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJouer.ForeColor = System.Drawing.Color.White;
            this.btnJouer.Location = new System.Drawing.Point(12, 409);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(397, 185);
            this.btnJouer.TabIndex = 9;
            this.btnJouer.Text = "J O U E R";
            this.btnJouer.UseVisualStyleBackColor = false;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(897, 606);
            this.Controls.Add(this.pbBanniere);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnJouer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranPrincipal";
            this.Text = "Yathzee MAES MAXIME";
            ((System.ComponentModel.ISupportInitialize)(this.pbBanniere)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBanniere;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnJouer;
    }
}

