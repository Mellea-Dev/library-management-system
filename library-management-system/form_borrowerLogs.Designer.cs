namespace library_management_system
{
    partial class form_borrowerLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_borrowerLogs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolbar = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.frm_label = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Button();
            this.gridViewBorrowerLogs = new System.Windows.Forms.DataGridView();
            this.input_search_logs = new library_management_system.CustomComponents.RoundedTextBox();
            this.formLabel = new System.Windows.Forms.Label();
            this.emptyVisual = new System.Windows.Forms.PictureBox();
            this.returnBookButton = new library_management_system.CustomComponents.RoundButton();
            this.clearFields = new library_management_system.CustomComponents.RoundButton();
            this.label3 = new System.Windows.Forms.Label();
            this.input_book = new library_management_system.CustomComponents.RoundedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input_borrower = new library_management_system.CustomComponents.RoundedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logIDValue = new System.Windows.Forms.Label();
            this.generateReport = new library_management_system.CustomComponents.RoundButton();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBorrowerLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.toolbar.Controls.Add(this.CloseButton);
            this.toolbar.Controls.Add(this.frm_label);
            this.toolbar.Controls.Add(this.logo);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(800, 25);
            this.toolbar.TabIndex = 6;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.Location = new System.Drawing.Point(773, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 25);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.Close);
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
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.Location = new System.Drawing.Point(773, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(27, 25);
            this.close.TabIndex = 2;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.Close);
            // 
            // gridViewBorrowerLogs
            // 
            this.gridViewBorrowerLogs.AllowUserToAddRows = false;
            this.gridViewBorrowerLogs.AllowUserToDeleteRows = false;
            this.gridViewBorrowerLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewBorrowerLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewBorrowerLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridViewBorrowerLogs.BackgroundColor = System.Drawing.Color.White;
            this.gridViewBorrowerLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridViewBorrowerLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(104)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewBorrowerLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.gridViewBorrowerLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewBorrowerLogs.GridColor = System.Drawing.Color.White;
            this.gridViewBorrowerLogs.Location = new System.Drawing.Point(18, 78);
            this.gridViewBorrowerLogs.Name = "gridViewBorrowerLogs";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(104)))), ((int)(((byte)(134)))));
            this.gridViewBorrowerLogs.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.gridViewBorrowerLogs.Size = new System.Drawing.Size(538, 330);
            this.gridViewBorrowerLogs.TabIndex = 15;
            this.gridViewBorrowerLogs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LogSelect);
            // 
            // input_search_logs
            // 
            this.input_search_logs.BackColor = System.Drawing.SystemColors.Window;
            this.input_search_logs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_search_logs.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(222)))));
            this.input_search_logs.BorderRadius = 5;
            this.input_search_logs.BorderSize = 2;
            this.input_search_logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_search_logs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_search_logs.Location = new System.Drawing.Point(216, 37);
            this.input_search_logs.Margin = new System.Windows.Forms.Padding(4);
            this.input_search_logs.Multiline = false;
            this.input_search_logs.Name = "input_search_logs";
            this.input_search_logs.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_search_logs.PasswordChar = false;
            this.input_search_logs.PlaceholderColor = System.Drawing.Color.Gray;
            this.input_search_logs.PlaceholderText = "Search Logs";
            this.input_search_logs.Size = new System.Drawing.Size(340, 31);
            this.input_search_logs.TabIndex = 14;
            this.input_search_logs.Texts = "Search Logs";
            this.input_search_logs.UnderlinedStyle = false;
            this.input_search_logs._TextChanged += new System.EventHandler(this.search);
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.formLabel.Location = new System.Drawing.Point(12, 37);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(197, 34);
            this.formLabel.TabIndex = 13;
            this.formLabel.Text = "Borrowers Logs";
            // 
            // emptyVisual
            // 
            this.emptyVisual.Image = ((System.Drawing.Image)(resources.GetObject("emptyVisual.Image")));
            this.emptyVisual.InitialImage = null;
            this.emptyVisual.Location = new System.Drawing.Point(47, 106);
            this.emptyVisual.Name = "emptyVisual";
            this.emptyVisual.Size = new System.Drawing.Size(478, 272);
            this.emptyVisual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emptyVisual.TabIndex = 16;
            this.emptyVisual.TabStop = false;
            // 
            // returnBookButton
            // 
            this.returnBookButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.returnBookButton.FlatAppearance.BorderSize = 0;
            this.returnBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBookButton.ForeColor = System.Drawing.Color.White;
            this.returnBookButton.Location = new System.Drawing.Point(579, 288);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(192, 36);
            this.returnBookButton.TabIndex = 31;
            this.returnBookButton.Text = "Return this Book";
            this.returnBookButton.UseVisualStyleBackColor = false;
            this.returnBookButton.Click += new System.EventHandler(this.returnBook);
            // 
            // clearFields
            // 
            this.clearFields.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clearFields.FlatAppearance.BorderSize = 0;
            this.clearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFields.ForeColor = System.Drawing.Color.White;
            this.clearFields.Location = new System.Drawing.Point(579, 346);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(192, 36);
            this.clearFields.TabIndex = 30;
            this.clearFields.Text = "Cancel";
            this.clearFields.UseVisualStyleBackColor = false;
            this.clearFields.Click += new System.EventHandler(this.clearFields_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.label3.Location = new System.Drawing.Point(576, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 14);
            this.label3.TabIndex = 28;
            this.label3.Text = "Book Borrowed";
            // 
            // input_book
            // 
            this.input_book.BackColor = System.Drawing.SystemColors.Window;
            this.input_book.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_book.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(222)))));
            this.input_book.BorderRadius = 5;
            this.input_book.BorderSize = 2;
            this.input_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_book.Location = new System.Drawing.Point(575, 213);
            this.input_book.Margin = new System.Windows.Forms.Padding(4);
            this.input_book.Multiline = false;
            this.input_book.Name = "input_book";
            this.input_book.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_book.PasswordChar = false;
            this.input_book.PlaceholderColor = System.Drawing.Color.Gray;
            this.input_book.PlaceholderText = "";
            this.input_book.Size = new System.Drawing.Size(196, 31);
            this.input_book.TabIndex = 27;
            this.input_book.Texts = "";
            this.input_book.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.label2.Location = new System.Drawing.Point(576, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 26;
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
            this.input_borrower.Location = new System.Drawing.Point(575, 143);
            this.input_borrower.Margin = new System.Windows.Forms.Padding(4);
            this.input_borrower.Multiline = false;
            this.input_borrower.Name = "input_borrower";
            this.input_borrower.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_borrower.PasswordChar = false;
            this.input_borrower.PlaceholderColor = System.Drawing.Color.Gray;
            this.input_borrower.PlaceholderText = "";
            this.input_borrower.Size = new System.Drawing.Size(196, 31);
            this.input_borrower.TabIndex = 25;
            this.input_borrower.Texts = "";
            this.input_borrower.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.label1.Location = new System.Drawing.Point(576, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 32;
            this.label1.Text = "Log ID :";
            // 
            // logIDValue
            // 
            this.logIDValue.AutoSize = true;
            this.logIDValue.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIDValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.logIDValue.Location = new System.Drawing.Point(629, 78);
            this.logIDValue.Name = "logIDValue";
            this.logIDValue.Size = new System.Drawing.Size(0, 14);
            this.logIDValue.TabIndex = 33;
            // 
            // generateReport
            // 
            this.generateReport.BackColor = System.Drawing.Color.CornflowerBlue;
            this.generateReport.FlatAppearance.BorderSize = 0;
            this.generateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateReport.ForeColor = System.Drawing.Color.White;
            this.generateReport.Location = new System.Drawing.Point(575, 35);
            this.generateReport.Name = "generateReport";
            this.generateReport.Size = new System.Drawing.Size(196, 33);
            this.generateReport.TabIndex = 34;
            this.generateReport.Text = "Print Logs";
            this.generateReport.UseVisualStyleBackColor = false;
            this.generateReport.Click += new System.EventHandler(this.generateReport_Click);
            // 
            // form_borrowerLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.logIDValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnBookButton);
            this.Controls.Add(this.clearFields);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_book);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_borrower);
            this.Controls.Add(this.emptyVisual);
            this.Controls.Add(this.input_search_logs);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.gridViewBorrowerLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_borrowerLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_borrowerLogs";
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBorrowerLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyVisual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Label frm_label;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.DataGridView gridViewBorrowerLogs;
        private CustomComponents.RoundedTextBox input_search_logs;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.PictureBox emptyVisual;
        private CustomComponents.RoundButton returnBookButton;
        private CustomComponents.RoundButton clearFields;
        private System.Windows.Forms.Label label3;
        private CustomComponents.RoundedTextBox input_book;
        private System.Windows.Forms.Label label2;
        private CustomComponents.RoundedTextBox input_borrower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label logIDValue;
        private System.Windows.Forms.Button CloseButton;
        private CustomComponents.RoundButton generateReport;
    }
}