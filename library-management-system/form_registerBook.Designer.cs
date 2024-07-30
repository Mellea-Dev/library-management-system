namespace library_management_system
{
    partial class form_registerBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_registerBook));
            this.toolbar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.frm_label = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputReminder = new System.Windows.Forms.Label();
            this.input_book_number = new library_management_system.CustomComponents.RoundedTextBox();
            this.addBookButton = new library_management_system.CustomComponents.RoundButton();
            this.input_book_category = new library_management_system.CustomComponents.RoundedTextBox();
            this.input_book_author = new library_management_system.CustomComponents.RoundedTextBox();
            this.input_book_title = new library_management_system.CustomComponents.RoundedTextBox();
            this.gradientPanel1 = new library_management_system.CustomComponents.GradientPanel();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.toolbar.Controls.Add(this.button1);
            this.toolbar.Controls.Add(this.frm_label);
            this.toolbar.Controls.Add(this.minimize);
            this.toolbar.Controls.Add(this.close);
            this.toolbar.Controls.Add(this.logo);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(479, 25);
            this.toolbar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(452, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 25);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.close_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.label1.Location = new System.Drawing.Point(144, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Register Book";
            // 
            // inputReminder
            // 
            this.inputReminder.AutoSize = true;
            this.inputReminder.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputReminder.ForeColor = System.Drawing.Color.Red;
            this.inputReminder.Location = new System.Drawing.Point(100, 107);
            this.inputReminder.Name = "inputReminder";
            this.inputReminder.Size = new System.Drawing.Size(163, 14);
            this.inputReminder.TabIndex = 12;
            this.inputReminder.Text = "Book Number must be Unique";
            this.inputReminder.Visible = false;
            // 
            // input_book_number
            // 
            this.input_book_number.BackColor = System.Drawing.SystemColors.Window;
            this.input_book_number.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_book_number.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_book_number.BorderRadius = 5;
            this.input_book_number.BorderSize = 2;
            this.input_book_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_book_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_book_number.Location = new System.Drawing.Point(103, 125);
            this.input_book_number.Margin = new System.Windows.Forms.Padding(4);
            this.input_book_number.Multiline = false;
            this.input_book_number.Name = "input_book_number";
            this.input_book_number.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_book_number.PasswordChar = false;
            this.input_book_number.PlaceholderColor = System.Drawing.SystemColors.GrayText;
            this.input_book_number.PlaceholderText = "Book Number";
            this.input_book_number.Size = new System.Drawing.Size(267, 31);
            this.input_book_number.TabIndex = 11;
            this.input_book_number.Texts = "";
            this.input_book_number.UnderlinedStyle = false;
            this.input_book_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputBookNumber_KeyPress);
            // 
            // addBookButton
            // 
            this.addBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(104)))), ((int)(((byte)(134)))));
            this.addBookButton.FlatAppearance.BorderSize = 0;
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookButton.ForeColor = System.Drawing.Color.White;
            this.addBookButton.Location = new System.Drawing.Point(103, 303);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(267, 42);
            this.addBookButton.TabIndex = 9;
            this.addBookButton.Text = "Add book to the Shelf";
            this.addBookButton.UseVisualStyleBackColor = false;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // input_book_category
            // 
            this.input_book_category.BackColor = System.Drawing.SystemColors.Window;
            this.input_book_category.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_book_category.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_book_category.BorderRadius = 5;
            this.input_book_category.BorderSize = 2;
            this.input_book_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_book_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_book_category.Location = new System.Drawing.Point(103, 254);
            this.input_book_category.Margin = new System.Windows.Forms.Padding(4);
            this.input_book_category.Multiline = false;
            this.input_book_category.Name = "input_book_category";
            this.input_book_category.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_book_category.PasswordChar = false;
            this.input_book_category.PlaceholderColor = System.Drawing.SystemColors.GrayText;
            this.input_book_category.PlaceholderText = "Book Category";
            this.input_book_category.Size = new System.Drawing.Size(267, 31);
            this.input_book_category.TabIndex = 6;
            this.input_book_category.Texts = "";
            this.input_book_category.UnderlinedStyle = false;
            // 
            // input_book_author
            // 
            this.input_book_author.BackColor = System.Drawing.SystemColors.Window;
            this.input_book_author.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_book_author.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_book_author.BorderRadius = 5;
            this.input_book_author.BorderSize = 2;
            this.input_book_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_book_author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_book_author.Location = new System.Drawing.Point(103, 215);
            this.input_book_author.Margin = new System.Windows.Forms.Padding(4);
            this.input_book_author.Multiline = false;
            this.input_book_author.Name = "input_book_author";
            this.input_book_author.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_book_author.PasswordChar = false;
            this.input_book_author.PlaceholderColor = System.Drawing.SystemColors.GrayText;
            this.input_book_author.PlaceholderText = "Book Author";
            this.input_book_author.Size = new System.Drawing.Size(267, 31);
            this.input_book_author.TabIndex = 5;
            this.input_book_author.Texts = "";
            this.input_book_author.UnderlinedStyle = false;
            // 
            // input_book_title
            // 
            this.input_book_title.BackColor = System.Drawing.SystemColors.Window;
            this.input_book_title.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_book_title.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_book_title.BorderRadius = 5;
            this.input_book_title.BorderSize = 2;
            this.input_book_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_book_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_book_title.Location = new System.Drawing.Point(103, 164);
            this.input_book_title.Margin = new System.Windows.Forms.Padding(4);
            this.input_book_title.Multiline = false;
            this.input_book_title.Name = "input_book_title";
            this.input_book_title.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_book_title.PasswordChar = false;
            this.input_book_title.PlaceholderColor = System.Drawing.SystemColors.GrayText;
            this.input_book_title.PlaceholderText = "Book Title";
            this.input_book_title.Size = new System.Drawing.Size(267, 31);
            this.input_book_title.TabIndex = 4;
            this.input_book_title.Texts = "";
            this.input_book_title.UnderlinedStyle = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Color1 = System.Drawing.Color.Transparent;
            this.gradientPanel1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.gradientPanel1.Location = new System.Drawing.Point(0, 292);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(479, 120);
            this.gradientPanel1.TabIndex = 10;
            // 
            // form_registerBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 411);
            this.Controls.Add(this.inputReminder);
            this.Controls.Add(this.input_book_number);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_book_category);
            this.Controls.Add(this.input_book_author);
            this.Controls.Add(this.input_book_title);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_registerBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_registerBook";
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Label frm_label;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button button1;
        private CustomComponents.RoundedTextBox input_book_title;
        private CustomComponents.RoundedTextBox input_book_author;
        private CustomComponents.RoundedTextBox input_book_category;
        private System.Windows.Forms.Label label1;
        private CustomComponents.RoundButton addBookButton;
        private CustomComponents.GradientPanel gradientPanel1;
        private CustomComponents.RoundedTextBox input_book_number;
        private System.Windows.Forms.Label inputReminder;
    }
}