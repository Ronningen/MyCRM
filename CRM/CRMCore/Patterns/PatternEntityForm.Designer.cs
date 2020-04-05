namespace CRMCore.Patterns
{
    partial class PatternEntityForm<TEntity>
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
            this.buttonAE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEmblem
            // 
            this.pictureBoxEmblem.Location = new System.Drawing.Point(236, 25);
            // 
            // buttonAE
            // 
            this.buttonAE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAE.BackColor = System.Drawing.Color.Purple;
            this.buttonAE.FlatAppearance.BorderSize = 0;
            this.buttonAE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAE.ForeColor = System.Drawing.Color.White;
            this.buttonAE.Location = new System.Drawing.Point(25, 380);
            this.buttonAE.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAE.Name = "buttonAE";
            this.buttonAE.Padding = new System.Windows.Forms.Padding(10);
            this.buttonAE.Size = new System.Drawing.Size(286, 45);
            this.buttonAE.TabIndex = 7;
            this.buttonAE.Text = "Add" + typeof(TEntity).Name.ToLower();
            this.buttonAE.UseVisualStyleBackColor = false;
            this.buttonAE.Click += new System.EventHandler(this.buttonAE_Click);
            // 
            // PatternEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this.buttonAE);
            this.Name = "PatternEntityForm";
            this.Controls.SetChildIndex(this.pictureBoxEmblem, 0);
            this.Controls.SetChildIndex(this.buttonAE, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAE;
    }
}