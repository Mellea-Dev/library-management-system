﻿namespace library_management_system
{
    partial class form_returnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_returnBook));
            this.form_label = new System.Windows.Forms.Label();
            this.toolbar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.frm_label = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.borrowerNameValue = new System.Windows.Forms.Label();
            this.borrowerIDValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new library_management_system.CustomComponents.GradientPanel();
            this.selectBook = new library_management_system.CustomComponents.RoundedComboBox();
            this.returnBookButton = new library_management_system.CustomComponents.RoundButton();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // form_label
            // 
            this.form_label.AutoSize = true;
            this.form_label.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.form_label.Location = new System.Drawing.Point(80, 54);
            this.form_label.Name = "form_label";
            this.form_label.Size = new System.Drawing.Size(181, 34);
            this.form_label.TabIndex = 11;
            this.form_label.Text = "Return a Book";
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.toolbar.Controls.Add(this.button1);
            this.toolbar.Controls.Add(this.frm_label);
            this.toolbar.Controls.Add(this.minimize);
            this.toolbar.Controls.Add(this.logo);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(357, 25);
            this.toolbar.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(332, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 25);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frm_label
            // 
            this.frm_label.AutoSize = true;
            this.frm_label.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.frm_label.Location = new System.Drawing.Point(33, 3);
            this.frm_label.Name = "frm_label";
            this.frm_label.Size = new System.Drawing.Size(74, 19);
            this.frm_label.TabIndex = 4;
            this.frm_label.Text = "ShelfWise";
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize.Location = new System.Drawing.Point(735, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(20, 25);
            this.minimize.TabIndex = 3;
            this.minimize.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(24, 19);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // borrowerNameValue
            // 
            this.borrowerNameValue.AutoSize = true;
            this.borrowerNameValue.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.borrowerNameValue.Location = new System.Drawing.Point(111, 150);
            this.borrowerNameValue.Name = "borrowerNameValue";
            this.borrowerNameValue.Size = new System.Drawing.Size(0, 16);
            this.borrowerNameValue.TabIndex = 23;
            // 
            // borrowerIDValue
            // 
            this.borrowerIDValue.AutoSize = true;
            this.borrowerIDValue.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerIDValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.borrowerIDValue.Location = new System.Drawing.Point(129, 116);
            this.borrowerIDValue.Name = "borrowerIDValue";
            this.borrowerIDValue.Size = new System.Drawing.Size(0, 16);
            this.borrowerIDValue.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.label4.Location = new System.Drawing.Point(33, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Borrower: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.label3.Location = new System.Drawing.Point(33, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Select A Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.label2.Location = new System.Drawing.Point(33, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Borrower ID: ";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Color1 = System.Drawing.Color.Transparent;
            this.gradientPanel1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.gradientPanel1.Controls.Add(this.selectBook);
            this.gradientPanel1.Controls.Add(this.returnBookButton);
            this.gradientPanel1.Location = new System.Drawing.Point(-1, 169);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(359, 172);
            this.gradientPanel1.TabIndex = 17;
            // 
            // selectBook
            // 
            this.selectBook.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.selectBook.BorderSize = 2;
            this.selectBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.selectBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectBook.ForeColor = System.Drawing.Color.DimGray;
            this.selectBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.selectBook.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.selectBook.ListTextColor = System.Drawing.Color.DimGray;
            this.selectBook.Location = new System.Drawing.Point(37, 35);
            this.selectBook.MinimumSize = new System.Drawing.Size(200, 30);
            this.selectBook.Name = "selectBook";
            this.selectBook.Padding = new System.Windows.Forms.Padding(2);
            this.selectBook.Size = new System.Drawing.Size(286, 30);
            this.selectBook.TabIndex = 1;
            this.selectBook.Texts = "";
            // 
            // returnBookButton
            // 
            this.returnBookButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.returnBookButton.FlatAppearance.BorderSize = 0;
            this.returnBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBookButton.ForeColor = System.Drawing.Color.White;
            this.returnBookButton.Location = new System.Drawing.Point(37, 85);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(286, 37);
            this.returnBookButton.TabIndex = 0;
            this.returnBookButton.Text = "Return This Book";
            this.returnBookButton.UseVisualStyleBackColor = false;
            // 
            // form_returnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 341);
            this.Controls.Add(this.borrowerNameValue);
            this.Controls.Add(this.borrowerIDValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.form_label);
            this.Controls.Add(this.toolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_returnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_returnBook";
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form_label;
        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label frm_label;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label borrowerNameValue;
        private System.Windows.Forms.Label borrowerIDValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomComponents.GradientPanel gradientPanel1;
        private CustomComponents.RoundedComboBox selectBook;
        private CustomComponents.RoundButton returnBookButton;
    }
}