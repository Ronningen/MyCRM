﻿namespace CRMCore.Patterns
{
    partial class PatternDataForm<TEntity, TEntityForm> 
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
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonObserve = new System.Windows.Forms.Button();
            this.buttonNavigator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEmblem
            // 
            this.pictureBoxEmblem.Location = new System.Drawing.Point(614, 25);
            this.pictureBoxEmblem.Size = new System.Drawing.Size(138, 42);
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToDeleteRows = false;
            this.mainDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDataGridView.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id});
            this.mainDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainDataGridView.Location = new System.Drawing.Point(18, 25);
            this.mainDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.ReadOnly = true;
            this.mainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDataGridView.Size = new System.Drawing.Size(576, 370);
            this.mainDataGridView.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(614, 87);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(10);
            this.buttonAdd.Size = new System.Drawing.Size(138, 45);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(614, 217);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(10);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Padding = new System.Windows.Forms.Padding(10);
            this.buttonEdit.Size = new System.Drawing.Size(138, 45);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.Color.Purple;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(614, 282);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(10);
            this.buttonDelete.Size = new System.Drawing.Size(138, 45);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonObserve
            // 
            this.buttonObserve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonObserve.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonObserve.FlatAppearance.BorderSize = 0;
            this.buttonObserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonObserve.ForeColor = System.Drawing.Color.White;
            this.buttonObserve.Location = new System.Drawing.Point(614, 152);
            this.buttonObserve.Margin = new System.Windows.Forms.Padding(10);
            this.buttonObserve.Name = "buttonObserve";
            this.buttonObserve.Padding = new System.Windows.Forms.Padding(10);
            this.buttonObserve.Size = new System.Drawing.Size(138, 45);
            this.buttonObserve.TabIndex = 9;
            this.buttonObserve.Text = "Observe";
            this.buttonObserve.UseVisualStyleBackColor = false;
            this.buttonObserve.Click += new System.EventHandler(this.buttonObserve_Click);
            // 
            // buttonNavigator
            // 
            this.buttonNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNavigator.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonNavigator.FlatAppearance.BorderSize = 0;
            this.buttonNavigator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavigator.ForeColor = System.Drawing.Color.White;
            this.buttonNavigator.Location = new System.Drawing.Point(614, 347);
            this.buttonNavigator.Margin = new System.Windows.Forms.Padding(10);
            this.buttonNavigator.Name = "buttonNavigator";
            this.buttonNavigator.Padding = new System.Windows.Forms.Padding(10);
            this.buttonNavigator.Size = new System.Drawing.Size(138, 45);
            this.buttonNavigator.TabIndex = 10;
            this.buttonNavigator.UseVisualStyleBackColor = false;
            this.buttonNavigator.Visible = false;
            // 
            // PatternDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 413);
            this.Controls.Add(this.buttonNavigator);
            this.Controls.Add(this.buttonObserve);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.mainDataGridView);
            this.Name = "PatternDataForm";
            this.Text = "";
            this.Load += new System.EventHandler(this.PatternDataForm_Load);
            this.Controls.SetChildIndex(this.pictureBoxEmblem, 0);
            this.Controls.SetChildIndex(this.mainDataGridView, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.buttonEdit, 0);
            this.Controls.SetChildIndex(this.buttonDelete, 0);
            this.Controls.SetChildIndex(this.buttonObserve, 0);
            this.Controls.SetChildIndex(this.buttonNavigator, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView mainDataGridView;
        protected System.Windows.Forms.Button buttonAdd;
        protected System.Windows.Forms.Button buttonEdit;
        protected System.Windows.Forms.Button buttonDelete;
        protected System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        protected System.Windows.Forms.Button buttonObserve;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Id;
        protected System.Windows.Forms.Button buttonNavigator;
    }
}