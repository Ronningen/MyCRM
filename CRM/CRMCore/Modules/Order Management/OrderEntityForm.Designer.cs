namespace CRMCore.Moduls.Order_Managment
{
    partial class OrderEntityForm
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
            this.labelCustomer = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelDateOpen = new System.Windows.Forms.Label();
            this.dateTimePickerOpen = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerClose = new System.Windows.Forms.DateTimePicker();
            this.labelDateClose = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.labelProducts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.FlatAppearance.BorderSize = 0;
            this.buttonConfirm.Location = new System.Drawing.Point(25, 554);
            this.buttonConfirm.Size = new System.Drawing.Size(242, 45);
            // 
            // pictureBoxEmblem
            // 
            this.pictureBoxEmblem.Location = new System.Drawing.Point(192, 25);
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(22, 61);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(93, 18);
            this.labelCustomer.TabIndex = 8;
            this.labelCustomer.Text = "Customer:";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(25, 89);
            this.comboBoxCustomer.Margin = new System.Windows.Forms.Padding(10);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(242, 26);
            this.comboBoxCustomer.TabIndex = 9;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(22, 133);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(107, 18);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDescription.Location = new System.Drawing.Point(25, 161);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(10);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(242, 58);
            this.richTextBoxDescription.TabIndex = 11;
            this.richTextBoxDescription.Text = "";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(22, 239);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(68, 18);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Status:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Location = new System.Drawing.Point(25, 267);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(242, 27);
            this.textBoxStatus.TabIndex = 13;
            // 
            // labelDateOpen
            // 
            this.labelDateOpen.AutoSize = true;
            this.labelDateOpen.Location = new System.Drawing.Point(22, 316);
            this.labelDateOpen.Name = "labelDateOpen";
            this.labelDateOpen.Size = new System.Drawing.Size(136, 18);
            this.labelDateOpen.TabIndex = 14;
            this.labelDateOpen.Text = "Openning date:";
            // 
            // dateTimePickerOpen
            // 
            this.dateTimePickerOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerOpen.Location = new System.Drawing.Point(25, 344);
            this.dateTimePickerOpen.Margin = new System.Windows.Forms.Padding(10);
            this.dateTimePickerOpen.Name = "dateTimePickerOpen";
            this.dateTimePickerOpen.Size = new System.Drawing.Size(242, 27);
            this.dateTimePickerOpen.TabIndex = 15;
            // 
            // dateTimePickerClose
            // 
            this.dateTimePickerClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerClose.Location = new System.Drawing.Point(25, 419);
            this.dateTimePickerClose.Margin = new System.Windows.Forms.Padding(10);
            this.dateTimePickerClose.Name = "dateTimePickerClose";
            this.dateTimePickerClose.Size = new System.Drawing.Size(242, 27);
            this.dateTimePickerClose.TabIndex = 17;
            // 
            // labelDateClose
            // 
            this.labelDateClose.AutoSize = true;
            this.labelDateClose.Location = new System.Drawing.Point(22, 391);
            this.labelDateClose.Name = "labelDateClose";
            this.labelDateClose.Size = new System.Drawing.Size(118, 18);
            this.labelDateClose.TabIndex = 16;
            this.labelDateClose.Text = "Closing date:";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Location = new System.Drawing.Point(181, 488);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(40, 40);
            this.buttonRemove.TabIndex = 24;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(227, 488);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(40, 40);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 18;
            this.listBoxProducts.Location = new System.Drawing.Point(25, 488);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(10);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(143, 40);
            this.listBoxProducts.TabIndex = 22;
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Location = new System.Drawing.Point(22, 460);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(85, 18);
            this.labelProducts.TabIndex = 25;
            this.labelProducts.Text = "Products:";
            // 
            // OrderEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 624);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.dateTimePickerClose);
            this.Controls.Add(this.labelDateClose);
            this.Controls.Add(this.dateTimePickerOpen);
            this.Controls.Add(this.labelDateOpen);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.labelCustomer);
            this.MinimumSize = new System.Drawing.Size(308, 663);
            this.Name = "OrderEntityForm";
            this.Text = "OrderEntityForm";
            this.Load += new System.EventHandler(this.OrderEntityForm_Load);
            this.Controls.SetChildIndex(this.pictureBoxEmblem, 0);
            this.Controls.SetChildIndex(this.buttonConfirm, 0);
            this.Controls.SetChildIndex(this.labelCustomer, 0);
            this.Controls.SetChildIndex(this.comboBoxCustomer, 0);
            this.Controls.SetChildIndex(this.labelDescription, 0);
            this.Controls.SetChildIndex(this.richTextBoxDescription, 0);
            this.Controls.SetChildIndex(this.labelStatus, 0);
            this.Controls.SetChildIndex(this.textBoxStatus, 0);
            this.Controls.SetChildIndex(this.labelDateOpen, 0);
            this.Controls.SetChildIndex(this.dateTimePickerOpen, 0);
            this.Controls.SetChildIndex(this.labelDateClose, 0);
            this.Controls.SetChildIndex(this.dateTimePickerClose, 0);
            this.Controls.SetChildIndex(this.listBoxProducts, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.buttonRemove, 0);
            this.Controls.SetChildIndex(this.labelProducts, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelDateOpen;
        private System.Windows.Forms.DateTimePicker dateTimePickerOpen;
        private System.Windows.Forms.DateTimePicker dateTimePickerClose;
        private System.Windows.Forms.Label labelDateClose;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Label labelProducts;
    }
}