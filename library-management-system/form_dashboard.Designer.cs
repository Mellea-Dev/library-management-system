namespace library_management_system
{
    partial class form_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_dashboard));
            this.toolbar = new System.Windows.Forms.Panel();
            this.frm_label = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.registerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.registerBook = new System.Windows.Forms.ToolStripMenuItem();
            this.registerBorrower = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBorrowers = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBorrowerLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientPanel1 = new library_management_system.CustomComponents.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.widgetReturns = new LibraryManagementSystem.CustomComponents.CardWidget();
            this.widgetIssueds = new LibraryManagementSystem.CustomComponents.CardWidget();
            this.widgetBooks = new LibraryManagementSystem.CustomComponents.CardWidget();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.menu.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.toolbar.Controls.Add(this.frm_label);
            this.toolbar.Controls.Add(this.minimize);
            this.toolbar.Controls.Add(this.close);
            this.toolbar.Controls.Add(this.logo);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(778, 25);
            this.toolbar.TabIndex = 1;
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
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
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
            this.close.Click += new System.EventHandler(this.close_Click);
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
            // menu
            // 
            this.menu.AllowDrop = true;
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerMenu,
            this.viewRecordsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 25);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(278, 24);
            this.menu.TabIndex = 5;
            this.menu.Text = "menuStrip1";
            // 
            // registerMenu
            // 
            this.registerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.registerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerBook,
            this.registerBorrower});
            this.registerMenu.Name = "registerMenu";
            this.registerMenu.Size = new System.Drawing.Size(61, 20);
            this.registerMenu.Text = "Register";
            // 
            // registerBook
            // 
            this.registerBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.registerBook.Name = "registerBook";
            this.registerBook.Size = new System.Drawing.Size(167, 22);
            this.registerBook.Text = "Register Book";
            this.registerBook.Click += new System.EventHandler(this.registerBook_Click);
            // 
            // registerBorrower
            // 
            this.registerBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.registerBorrower.Name = "registerBorrower";
            this.registerBorrower.Size = new System.Drawing.Size(167, 22);
            this.registerBorrower.Text = "Register Borrower";
            this.registerBorrower.Click += new System.EventHandler(this.registerBorrower_Click);
            // 
            // viewRecordsToolStripMenuItem
            // 
            this.viewRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBooks,
            this.viewBorrowers,
            this.viewBorrowerLogs});
            this.viewRecordsToolStripMenuItem.Name = "viewRecordsToolStripMenuItem";
            this.viewRecordsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.viewRecordsToolStripMenuItem.Text = "View Records";
            // 
            // viewBooks
            // 
            this.viewBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.viewBooks.Name = "viewBooks";
            this.viewBooks.Size = new System.Drawing.Size(180, 22);
            this.viewBooks.Text = "Books";
            this.viewBooks.Click += new System.EventHandler(this.viewBooks_Click);
            // 
            // viewBorrowers
            // 
            this.viewBorrowers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.viewBorrowers.Name = "viewBorrowers";
            this.viewBorrowers.Size = new System.Drawing.Size(180, 22);
            this.viewBorrowers.Text = "Borrowers";
            this.viewBorrowers.Click += new System.EventHandler(this.viewBorrowers_Click);
            // 
            // viewBorrowerLogs
            // 
            this.viewBorrowerLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.viewBorrowerLogs.Name = "viewBorrowerLogs";
            this.viewBorrowerLogs.Size = new System.Drawing.Size(180, 22);
            this.viewBorrowerLogs.Text = "Borrower Logs";
            this.viewBorrowerLogs.Click += new System.EventHandler(this.viewBorrowerLogs_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Color1 = System.Drawing.Color.Transparent;
            this.gradientPanel1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 167);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(778, 232);
            this.gradientPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(538, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // widgetReturns
            // 
            this.widgetReturns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(222)))));
            this.widgetReturns.CardIconImage = ((System.Drawing.Image)(resources.GetObject("widgetReturns.CardIconImage")));
            this.widgetReturns.CardTitleText = "Returned Books";
            this.widgetReturns.CountLabelText = "24";
            this.widgetReturns.Location = new System.Drawing.Point(428, 70);
            this.widgetReturns.Name = "widgetReturns";
            this.widgetReturns.Size = new System.Drawing.Size(215, 68);
            this.widgetReturns.TabIndex = 4;
            // 
            // widgetIssueds
            // 
            this.widgetIssueds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(222)))));
            this.widgetIssueds.CardIconImage = ((System.Drawing.Image)(resources.GetObject("widgetIssueds.CardIconImage")));
            this.widgetIssueds.CardTitleText = "Books Issued";
            this.widgetIssueds.CountLabelText = "24";
            this.widgetIssueds.Location = new System.Drawing.Point(218, 70);
            this.widgetIssueds.Name = "widgetIssueds";
            this.widgetIssueds.Size = new System.Drawing.Size(204, 68);
            this.widgetIssueds.TabIndex = 3;
            // 
            // widgetBooks
            // 
            this.widgetBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(222)))));
            this.widgetBooks.CardIconImage = ((System.Drawing.Image)(resources.GetObject("widgetBooks.CardIconImage")));
            this.widgetBooks.CardTitleText = "Total Books";
            this.widgetBooks.CountLabelText = "24";
            this.widgetBooks.Location = new System.Drawing.Point(12, 70);
            this.widgetBooks.Name = "widgetBooks";
            this.widgetBooks.Size = new System.Drawing.Size(200, 68);
            this.widgetBooks.TabIndex = 0;
            // 
            // form_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 399);
            this.Controls.Add(this.widgetReturns);
            this.Controls.Add(this.widgetBooks);
            this.Controls.Add(this.widgetIssueds);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menu;
            this.Name = "form_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Label frm_label;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox logo;
        private CustomComponents.GradientPanel gradientPanel1;
        private LibraryManagementSystem.CustomComponents.CardWidget widgetIssueds;
        private LibraryManagementSystem.CustomComponents.CardWidget widgetBooks;
        private LibraryManagementSystem.CustomComponents.CardWidget widgetReturns;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem registerMenu;
        private System.Windows.Forms.ToolStripMenuItem registerBook;
        private System.Windows.Forms.ToolStripMenuItem registerBorrower;
        private System.Windows.Forms.ToolStripMenuItem viewRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBooks;
        private System.Windows.Forms.ToolStripMenuItem viewBorrowers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem viewBorrowerLogs;
    }
}