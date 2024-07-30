namespace library_management_system
{
    partial class form_registerBorrowers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_registerBorrowers));
            this.frm_label = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.toolbar = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addBorrower = new library_management_system.CustomComponents.RoundButton();
            this.input_contact = new library_management_system.CustomComponents.RoundedTextBox();
            this.input_fullname = new library_management_system.CustomComponents.RoundedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.toolbar.SuspendLayout();
            this.SuspendLayout();
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
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.toolbar.Controls.Add(this.buttonClose);
            this.toolbar.Controls.Add(this.frm_label);
            this.toolbar.Controls.Add(this.minimize);
            this.toolbar.Controls.Add(this.close);
            this.toolbar.Controls.Add(this.logo);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(377, 25);
            this.toolbar.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Location = new System.Drawing.Point(350, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(27, 25);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.close_Click);
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
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.Location = new System.Drawing.Point(751, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(27, 25);
            this.close.TabIndex = 2;
            this.close.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.label1.Location = new System.Drawing.Point(74, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Register Borrower";
            // 
            // addBorrower
            // 
            this.addBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(104)))), ((int)(((byte)(134)))));
            this.addBorrower.FlatAppearance.BorderSize = 0;
            this.addBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBorrower.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBorrower.ForeColor = System.Drawing.Color.White;
            this.addBorrower.Location = new System.Drawing.Point(53, 215);
            this.addBorrower.Name = "addBorrower";
            this.addBorrower.Size = new System.Drawing.Size(267, 42);
            this.addBorrower.TabIndex = 14;
            this.addBorrower.Text = "Register Borrower";
            this.addBorrower.UseVisualStyleBackColor = false;
            this.addBorrower.Click += new System.EventHandler(this.addBorrower_Click);
            // 
            // input_contact
            // 
            this.input_contact.BackColor = System.Drawing.SystemColors.Window;
            this.input_contact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_contact.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_contact.BorderRadius = 5;
            this.input_contact.BorderSize = 2;
            this.input_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_contact.Location = new System.Drawing.Point(53, 166);
            this.input_contact.Margin = new System.Windows.Forms.Padding(4);
            this.input_contact.Multiline = false;
            this.input_contact.Name = "input_contact";
            this.input_contact.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_contact.PasswordChar = false;
            this.input_contact.PlaceholderColor = System.Drawing.SystemColors.GrayText;
            this.input_contact.PlaceholderText = "Contact";
            this.input_contact.Size = new System.Drawing.Size(267, 31);
            this.input_contact.TabIndex = 13;
            this.input_contact.Texts = "Contact";
            this.input_contact.UnderlinedStyle = false;
            // 
            // input_fullname
            // 
            this.input_fullname.BackColor = System.Drawing.SystemColors.Window;
            this.input_fullname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_fullname.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_fullname.BorderRadius = 5;
            this.input_fullname.BorderSize = 2;
            this.input_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_fullname.Location = new System.Drawing.Point(53, 116);
            this.input_fullname.Margin = new System.Windows.Forms.Padding(4);
            this.input_fullname.Multiline = false;
            this.input_fullname.Name = "input_fullname";
            this.input_fullname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_fullname.PasswordChar = false;
            this.input_fullname.PlaceholderColor = System.Drawing.SystemColors.GrayText;
            this.input_fullname.PlaceholderText = "Fullname";
            this.input_fullname.Size = new System.Drawing.Size(267, 31);
            this.input_fullname.TabIndex = 12;
            this.input_fullname.Texts = "Fullname";
            this.input_fullname.UnderlinedStyle = false;
            // 
            // form_registerBorrowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 304);
            this.Controls.Add(this.addBorrower);
            this.Controls.Add(this.input_contact);
            this.Controls.Add(this.input_fullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_registerBorrowers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_registerBorrowers";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frm_label;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private CustomComponents.RoundedTextBox input_fullname;
        private CustomComponents.RoundedTextBox input_contact;
        private CustomComponents.RoundButton addBorrower;
    }
}