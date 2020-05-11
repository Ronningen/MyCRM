namespace CRMCore.Moduls.Product_Managment
{
    partial class ProductEntityForm
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
            this.labelеTypes = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.checkBoxSold = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.FlatAppearance.BorderSize = 0;
            this.buttonConfirm.Location = new System.Drawing.Point(25, 156);
            this.buttonConfirm.Size = new System.Drawing.Size(147, 45);
            // 
            // pictureBoxEmblem
            // 
            this.pictureBoxEmblem.Location = new System.Drawing.Point(97, 25);
            // 
            // labelеTypes
            // 
            this.labelеTypes.AutoSize = true;
            this.labelеTypes.Location = new System.Drawing.Point(22, 56);
            this.labelеTypes.Name = "labelеTypes";
            this.labelеTypes.Size = new System.Drawing.Size(52, 18);
            this.labelеTypes.TabIndex = 8;
            this.labelеTypes.Text = "Type:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(25, 84);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(10);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(147, 26);
            this.comboBoxType.TabIndex = 9;
            // 
            // checkBoxSold
            // 
            this.checkBoxSold.AutoSize = true;
            this.checkBoxSold.Location = new System.Drawing.Point(25, 123);
            this.checkBoxSold.Name = "checkBoxSold";
            this.checkBoxSold.Size = new System.Drawing.Size(62, 22);
            this.checkBoxSold.TabIndex = 11;
            this.checkBoxSold.Text = "Sold";
            this.checkBoxSold.UseVisualStyleBackColor = true;
            // 
            // ProductEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 226);
            this.Controls.Add(this.checkBoxSold);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelеTypes);
            this.MinimumSize = new System.Drawing.Size(213, 265);
            this.Name = "ProductEntityForm";
            this.Text = "ProductEntityForm";
            this.Load += new System.EventHandler(this.ProductEntityForm_Load);
            this.Controls.SetChildIndex(this.pictureBoxEmblem, 0);
            this.Controls.SetChildIndex(this.buttonConfirm, 0);
            this.Controls.SetChildIndex(this.labelеTypes, 0);
            this.Controls.SetChildIndex(this.comboBoxType, 0);
            this.Controls.SetChildIndex(this.checkBoxSold, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelеTypes;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.CheckBox checkBoxSold;
    }
}