namespace library_management_system
{
    partial class form_books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_books));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolbar = new System.Windows.Forms.Panel();
            this.frm_label = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.gridViewBooks = new System.Windows.Forms.DataGridView();
            this.emptyVisual = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roundButton2 = new library_management_system.CustomComponents.RoundButton();
            this.roundButton1 = new library_management_system.CustomComponents.RoundButton();
            this.input_registered_date = new library_management_system.CustomComponents.RoundedDateTimePicker();
            this.input_category = new library_management_system.CustomComponents.RoundedTextBox();
            this.input_author = new library_management_system.CustomComponents.RoundedTextBox();
            this.input_title = new library_management_system.CustomComponents.RoundedTextBox();
            this.input_search_books = new library_management_system.CustomComponents.RoundedTextBox();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.toolbar.Controls.Add(this.frm_label);
            this.toolbar.Controls.Add(this.close);
            this.toolbar.Controls.Add(this.logo);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(827, 25);
            this.toolbar.TabIndex = 2;
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
            // gridViewBooks
            // 
            this.gridViewBooks.AllowUserToAddRows = false;
            this.gridViewBooks.AllowUserToDeleteRows = false;
            this.gridViewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridViewBooks.BackgroundColor = System.Drawing.Color.White;
            this.gridViewBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridViewBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(104)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewBooks.GridColor = System.Drawing.Color.White;
            this.gridViewBooks.Location = new System.Drawing.Point(12, 72);
            this.gridViewBooks.Name = "gridViewBooks";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(104)))), ((int)(((byte)(134)))));
            this.gridViewBooks.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewBooks.Size = new System.Drawing.Size(615, 347);
            this.gridViewBooks.TabIndex = 3;
            this.gridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick);
            // 
            // emptyVisual
            // 
            this.emptyVisual.Image = ((System.Drawing.Image)(resources.GetObject("emptyVisual.Image")));
            this.emptyVisual.InitialImage = null;
            this.emptyVisual.Location = new System.Drawing.Point(72, 87);
            this.emptyVisual.Name = "emptyVisual";
            this.emptyVisual.Size = new System.Drawing.Size(519, 306);
            this.emptyVisual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emptyVisual.TabIndex = 4;
            this.emptyVisual.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.label2.Location = new System.Drawing.Point(646, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Book Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.label3.Location = new System.Drawing.Point(646, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 18;
            this.label3.Text = "Book Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.label4.Location = new System.Drawing.Point(645, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 14);
            this.label4.TabIndex = 19;
            this.label4.Text = "Book Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.label5.Location = new System.Drawing.Point(645, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 14);
            this.label5.TabIndex = 20;
            this.label5.Text = "Registered Date";
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(730, 337);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(81, 36);
            this.roundButton2.TabIndex = 22;
            this.roundButton2.Text = "Cancel";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.cancelUpdateClick);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(644, 337);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(81, 36);
            this.roundButton1.TabIndex = 21;
            this.roundButton1.Text = "Edit";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.updateClick);
            // 
            // input_registered_date
            // 
            this.input_registered_date.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_registered_date.BorderSize = 2;
            this.input_registered_date.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_registered_date.Location = new System.Drawing.Point(645, 286);
            this.input_registered_date.MinimumSize = new System.Drawing.Size(4, 31);
            this.input_registered_date.Name = "input_registered_date";
            this.input_registered_date.Size = new System.Drawing.Size(166, 31);
            this.input_registered_date.SkinColor = System.Drawing.Color.White;
            this.input_registered_date.TabIndex = 16;
            this.input_registered_date.TextColor = System.Drawing.Color.Gray;
            // 
            // input_category
            // 
            this.input_category.BackColor = System.Drawing.SystemColors.Window;
            this.input_category.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_category.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(222)))));
            this.input_category.BorderRadius = 5;
            this.input_category.BorderSize = 2;
            this.input_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_category.Location = new System.Drawing.Point(644, 222);
            this.input_category.Margin = new System.Windows.Forms.Padding(4);
            this.input_category.Multiline = false;
            this.input_category.Name = "input_category";
            this.input_category.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_category.PasswordChar = false;
            this.input_category.PlaceholderColor = System.Drawing.Color.Gray;
            this.input_category.PlaceholderText = "";
            this.input_category.Size = new System.Drawing.Size(166, 31);
            this.input_category.TabIndex = 15;
            this.input_category.Texts = "";
            this.input_category.UnderlinedStyle = false;
            // 
            // input_author
            // 
            this.input_author.BackColor = System.Drawing.SystemColors.Window;
            this.input_author.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_author.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(222)))));
            this.input_author.BorderRadius = 5;
            this.input_author.BorderSize = 2;
            this.input_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_author.Location = new System.Drawing.Point(645, 156);
            this.input_author.Margin = new System.Windows.Forms.Padding(4);
            this.input_author.Multiline = false;
            this.input_author.Name = "input_author";
            this.input_author.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_author.PasswordChar = false;
            this.input_author.PlaceholderColor = System.Drawing.Color.Gray;
            this.input_author.PlaceholderText = "";
            this.input_author.Size = new System.Drawing.Size(166, 31);
            this.input_author.TabIndex = 14;
            this.input_author.Texts = "";
            this.input_author.UnderlinedStyle = false;
            // 
            // input_title
            // 
            this.input_title.BackColor = System.Drawing.SystemColors.Window;
            this.input_title.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_title.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(222)))));
            this.input_title.BorderRadius = 5;
            this.input_title.BorderSize = 2;
            this.input_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_title.Location = new System.Drawing.Point(645, 90);
            this.input_title.Margin = new System.Windows.Forms.Padding(4);
            this.input_title.Multiline = false;
            this.input_title.Name = "input_title";
            this.input_title.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_title.PasswordChar = false;
            this.input_title.PlaceholderColor = System.Drawing.Color.Gray;
            this.input_title.PlaceholderText = "";
            this.input_title.Size = new System.Drawing.Size(166, 31);
            this.input_title.TabIndex = 13;
            this.input_title.Texts = "";
            this.input_title.UnderlinedStyle = false;
            // 
            // input_search_books
            // 
            this.input_search_books.BackColor = System.Drawing.SystemColors.Window;
            this.input_search_books.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_search_books.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(222)))));
            this.input_search_books.BorderRadius = 5;
            this.input_search_books.BorderSize = 2;
            this.input_search_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_search_books.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_search_books.Location = new System.Drawing.Point(105, 34);
            this.input_search_books.Margin = new System.Windows.Forms.Padding(4);
            this.input_search_books.Multiline = false;
            this.input_search_books.Name = "input_search_books";
            this.input_search_books.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_search_books.PasswordChar = false;
            this.input_search_books.PlaceholderColor = System.Drawing.Color.Gray;
            this.input_search_books.PlaceholderText = "Search Books";
            this.input_search_books.Size = new System.Drawing.Size(522, 31);
            this.input_search_books.TabIndex = 10;
            this.input_search_books.Texts = "Search Books";
            this.input_search_books.UnderlinedStyle = false;
            this.input_search_books._TextChanged += new System.EventHandler(this.search);
            // 
            // form_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 431);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_registered_date);
            this.Controls.Add(this.input_category);
            this.Controls.Add(this.input_author);
            this.Controls.Add(this.input_title);
            this.Controls.Add(this.input_search_books);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emptyVisual);
            this.Controls.Add(this.gridViewBooks);
            this.Controls.Add(this.toolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_books";
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyVisual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Label frm_label;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.DataGridView gridViewBooks;
        private System.Windows.Forms.PictureBox emptyVisual;
        private System.Windows.Forms.Label label1;
        private CustomComponents.RoundedTextBox input_search_books;
        private CustomComponents.RoundedTextBox input_title;
        private CustomComponents.RoundedTextBox input_author;
        private CustomComponents.RoundedTextBox input_category;
        private CustomComponents.RoundedDateTimePicker input_registered_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomComponents.RoundButton roundButton1;
        private CustomComponents.RoundButton roundButton2;
    }
}