namespace CRMCore.Patterns
{
    partial class PatternForm
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
            this.pictureBoxEmblem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEmblem
            // 
            this.pictureBoxEmblem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxEmblem.Image = global::CRMCore.Properties.Resources.Emblem;
            this.pictureBoxEmblem.Location = new System.Drawing.Point(111, 25);
            this.pictureBoxEmblem.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBoxEmblem.Name = "pictureBoxEmblem";
            this.pictureBoxEmblem.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBoxEmblem.Size = new System.Drawing.Size(75, 33);
            this.pictureBoxEmblem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmblem.TabIndex = 0;
            this.pictureBoxEmblem.TabStop = false;
            // 
            // PatternForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(211, 422);
            this.Controls.Add(this.pictureBoxEmblem);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PatternForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatternForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatternForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PatternForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxEmblem;
    }
}