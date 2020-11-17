namespace MAES_MAXIME_YATHZEE
{
    partial class EcranZeroPoint
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
            this.btnNonZero = new System.Windows.Forms.Button();
            this.btnOuiZero = new System.Windows.Forms.Button();
            this.lblZero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNonZero
            // 
            this.btnNonZero.Location = new System.Drawing.Point(227, 319);
            this.btnNonZero.Name = "btnNonZero";
            this.btnNonZero.Size = new System.Drawing.Size(93, 75);
            this.btnNonZero.TabIndex = 5;
            this.btnNonZero.Text = "Non";
            this.btnNonZero.UseVisualStyleBackColor = true;
            this.btnNonZero.Click += new System.EventHandler(this.btnNonZero_Click);
            // 
            // btnOuiZero
            // 
            this.btnOuiZero.Location = new System.Drawing.Point(35, 319);
            this.btnOuiZero.Name = "btnOuiZero";
            this.btnOuiZero.Size = new System.Drawing.Size(93, 75);
            this.btnOuiZero.TabIndex = 4;
            this.btnOuiZero.Text = "Oui";
            this.btnOuiZero.UseVisualStyleBackColor = true;
            this.btnOuiZero.Click += new System.EventHandler(this.btnOuiZero_Click);
            // 
            // lblZero
            // 
            this.lblZero.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZero.Location = new System.Drawing.Point(29, 25);
            this.lblZero.Name = "lblZero";
            this.lblZero.Size = new System.Drawing.Size(291, 265);
            this.lblZero.TabIndex = 3;
            this.lblZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EcranZeroPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 418);
            this.Controls.Add(this.btnNonZero);
            this.Controls.Add(this.btnOuiZero);
            this.Controls.Add(this.lblZero);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranZeroPoint";
            this.Text = "ficZeroPoint";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnNonZero;
        public System.Windows.Forms.Button btnOuiZero;
        public System.Windows.Forms.Label lblZero;
    }
}