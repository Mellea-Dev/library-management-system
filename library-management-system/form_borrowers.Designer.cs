namespace library_management_system
{
    partial class form_borrowers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_borrowers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolbar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.frm_label = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewBorrowers = new System.Windows.Forms.DataGridView();
            this.emptyVisual = new System.Windows.Forms.PictureBox();
            this.input_search_borrowers = new library_management_system.CustomComponents.RoundedTextBox();
            this.cancelEdit = new library_management_system.CustomComponents.RoundButton();
            this.editBorrower = new library_management_system.CustomComponents.RoundButton();
            this.issueBookButton = new library_management_system.CustomComponents.RoundButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_borrower = new library_management_system.CustomComponents.RoundedTextBox();
            this.input_contact = new library_management_system.CustomComponents.RoundedTextBox();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBorrowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.toolbar.Controls.Add(this.button1);
            this.toolbar.Controls.Add(this.frm_label);
            this.toolbar.Controls.Add(this.close);
            this.toolbar.Controls.Add(this.logo);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(800, 25);
            this.toolbar.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(773, 0);
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
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.Location = new System.Drawing.Point(800, 0);
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
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Borrowers";
            // 
            // gridViewBorrowers
            // 
            this.gridViewBorrowers.AllowUserToAddRows = false;
            this.gridViewBorrowers.AllowUserToDeleteRows = false;
            this.gridViewBorrowers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewBorrowers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewBorrowers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridViewBorrowers.BackgroundColor = System.Drawing.Color.White;
            this.gridViewBorrowers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridViewBorrowers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(104)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewBorrowers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewBorrowers.GridColor = System.Drawing.Color.White;
            this.gridViewBorrowers.Location = new System.Drawing.Point(18, 79);
            this.gridViewBorrowers.Name = "gridViewBorrowers";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(104)))), ((int)(((byte)(134)))));
            this.gridViewBorrowers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewBorrowers.Size = new System.Drawing.Size(538, 331);
            this.gridViewBorrowers.TabIndex = 12;
            this.gridViewBorrowers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.borrowerSelect);
            // 
            // emptyVisual
            // 
            this.emptyVisual.Image = ((System.Drawing.Image)(resources.GetObject("emptyVisual.Image")));
            this.emptyVisual.InitialImage = null;
            this.emptyVisual.Location = new System.Drawing.Point(46, 112);
            this.emptyVisual.Name = "emptyVisual";
            this.emptyVisual.Size = new System.Drawing.Size(470, 272);
            this.emptyVisual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emptyVisual.TabIndex = 13;
            this.emptyVisual.TabStop = false;
            // 
            // input_search_borrowers
            // 
            this.input_search_borrowers.BackColor = System.Drawing.SystemColors.Window;
            this.input_search_borrowers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_search_borrowers.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(222)))));
            this.input_search_borrowers.BorderRadius = 5;
            this.input_search_borrowers.BorderSize = 2;
            this.input_search_borrowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_search_borrowers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_search_borrowers.Location = new System.Drawing.Point(153, 41);
            this.input_search_borrowers.Margin = new System.Windows.Forms.Padding(4);
            this.input_search_borrowers.Multiline = false;
            this.input_search_borrowers.Name = "input_search_borrowers";
            this.input_search_borrowers.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_search_borrowers.PasswordChar = false;
            this.input_search_borrowers.PlaceholderColor = System.Drawing.Color.Gray;
            this.input_search_borrowers.PlaceholderText = "Search Borrowers";
            this.input_search_borrowers.Size = new System.Drawing.Size(403, 31);
            this.input_search_borrowers.TabIndex = 11;
            this.input_search_borrowers.Texts = "Search Borrowers";
            this.input_search_borrowers.UnderlinedStyle = false;
            this.input_search_borrowers._TextChanged += new System.EventHandler(this.search);
            // 
            // cancelEdit
            // 
            this.cancelEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cancelEdit.FlatAppearance.BorderSize = 0;
            this.cancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelEdit.ForeColor = System.Drawing.Color.White;
            this.cancelEdit.Location = new System.Drawing.Point(578, 352);
            this.cancelEdit.Name = "cancelEdit";
            this.cancelEdit.Size = new System.Drawing.Size(192, 36);
            this.cancelEdit.TabIndex = 23;
            this.cancelEdit.Text = "Cancel";
            this.cancelEdit.UseVisualStyleBackColor = false;
            this.cancelEdit.Click += new System.EventHandler(this.cancelUpdate);
            // 
            // editBorrower
            // 
            this.editBorrower.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editBorrower.FlatAppearance.BorderSize = 0;
            this.editBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBorrower.ForeColor = System.Drawing.Color.White;
            this.editBorrower.Location = new System.Drawing.Point(578, 310);
            this.editBorrower.Name = "editBorrower";
            this.editBorrower.Size = new System.Drawing.Size(192, 36);
            this.editBorrower.TabIndex = 22;
            this.editBorrower.Text = "Edit";
            this.editBorrower.UseVisualStyleBackColor = false;
            this.editBorrower.Click += new System.EventHandler(this.updateBorrower);
            // 
            // issueBookButton
            // 
            this.issueBookButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.issueBookButton.FlatAppearance.BorderSize = 0;
            this.issueBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueBookButton.ForeColor = System.Drawing.Color.White;
            this.issueBookButton.Location = new System.Drawing.Point(578, 256);
            this.issueBookButton.Name = "issueBookButton";
            this.issueBookButton.Size = new System.Drawing.Size(192, 36);
            this.issueBookButton.TabIndex = 24;
            this.issueBookButton.Text = "Issue a Book to this Borrower";
            this.issueBookButton.UseVisualStyleBackColor = false;
            this.issueBookButton.Click += new System.EventHandler(this.issueBookButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.label3.Location = new System.Drawing.Point(579, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.label2.Location = new System.Drawing.Point(579, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fullname";
            // 
            // input_borrower
            // 
            this.input_borrower.BackColor = System.Drawing.SystemColors.Window;
            this.input_borrower.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_borrower.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(222)))));
            this.input_borrower.BorderRadius = 5;
            this.input_borrower.BorderSize = 2;
            this.input_borrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_borrower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_borrower.Location = new System.Drawing.Point(578, 112);
            this.input_borrower.Margin = new System.Windows.Forms.Padding(4);
            this.input_borrower.Multiline = false;
            this.input_borrower.Name = "input_borrower";
            this.input_borrower.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_borrower.PasswordChar = false;
            this.input_borrower.PlaceholderColor = System.Drawing.Color.Gray;
            this.input_borrower.PlaceholderText = "";
            this.input_borrower.Size = new System.Drawing.Size(192, 31);
            this.input_borrower.TabIndex = 18;
            this.input_borrower.Texts = "";
            this.input_borrower.UnderlinedStyle = false;
            // 
            // input_contact
            // 
            this.input_contact.BackColor = System.Drawing.SystemColors.Window;
            this.input_contact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_contact.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(222)))));
            this.input_contact.BorderRadius = 5;
            this.input_contact.BorderSize = 2;
            this.input_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_contact.Location = new System.Drawing.Point(578, 182);
            this.input_contact.Margin = new System.Windows.Forms.Padding(4);
            this.input_contact.Multiline = false;
            this.input_contact.Name = "input_contact";
            this.input_contact.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_contact.PasswordChar = false;
            this.input_contact.PlaceholderColor = System.Drawing.Color.Gray;
            this.input_contact.PlaceholderText = "";
            this.input_contact.Size = new System.Drawing.Size(192, 31);
            this.input_contact.TabIndex = 20;
            this.input_contact.Texts = "";
            this.input_contact.UnderlinedStyle = false;
            // 
            // form_borrowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.issueBookButton);
            this.Controls.Add(this.cancelEdit);
            this.Controls.Add(this.editBorrower);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_contact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_borrower);
            this.Controls.Add(this.emptyVisual);
            this.Controls.Add(this.gridViewBorrowers);
            this.Controls.Add(this.input_search_borrowers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_borrowers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_borrowers";
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBorrowers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyVisual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Label frm_label;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private CustomComponents.RoundedTextBox input_search_borrowers;
        private System.Windows.Forms.DataGridView gridViewBorrowers;
        private System.Windows.Forms.PictureBox emptyVisual;
        private CustomComponents.RoundButton cancelEdit;
        private CustomComponents.RoundButton editBorrower;
        private CustomComponents.RoundButton issueBookButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomComponents.RoundedTextBox input_borrower;
        private CustomComponents.RoundedTextBox input_contact;
    }
}