using System.Drawing;

namespace library_management_system
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.toolbar = new System.Windows.Forms.Panel();
            this.frm_label = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.brand_logo = new System.Windows.Forms.PictureBox();
            this.gradient_display = new library_management_system.CustomComponents.GradientPanel();
            this.login_btn = new library_management_system.CustomComponents.RoundButton();
            this.input_password = new library_management_system.CustomComponents.RoundedTextBox();
            this.input_username = new library_management_system.CustomComponents.RoundedTextBox();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand_logo)).BeginInit();
            this.gradient_display.SuspendLayout();
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
            this.toolbar.Size = new System.Drawing.Size(514, 25);
            this.toolbar.TabIndex = 0;
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
            this.minimize.Location = new System.Drawing.Point(468, 0);
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
            this.close.Location = new System.Drawing.Point(487, 0);
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
            // brand_logo
            // 
            this.brand_logo.Image = ((System.Drawing.Image)(resources.GetObject("brand_logo.Image")));
            this.brand_logo.Location = new System.Drawing.Point(135, 60);
            this.brand_logo.Name = "brand_logo";
            this.brand_logo.Size = new System.Drawing.Size(250, 116);
            this.brand_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.brand_logo.TabIndex = 2;
            this.brand_logo.TabStop = false;
            // 
            // gradient_display
            // 
            this.gradient_display.Color1 = System.Drawing.Color.White;
            this.gradient_display.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.gradient_display.Controls.Add(this.login_btn);
            this.gradient_display.Location = new System.Drawing.Point(0, 276);
            this.gradient_display.Name = "gradient_display";
            this.gradient_display.Size = new System.Drawing.Size(514, 158);
            this.gradient_display.TabIndex = 1;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(104)))), ((int)(((byte)(134)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(135, 40);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(250, 36);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // input_password
            // 
            this.input_password.BackColor = System.Drawing.SystemColors.Window;
            this.input_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_password.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_password.BorderRadius = 5;
            this.input_password.BorderSize = 2;
            this.input_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_password.Location = new System.Drawing.Point(135, 256);
            this.input_password.Margin = new System.Windows.Forms.Padding(4);
            this.input_password.Multiline = false;
            this.input_password.Name = "input_password";
            this.input_password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_password.PasswordChar = true;
            this.input_password.PlaceholderColor = System.Drawing.Color.Gray;
            this.input_password.PlaceholderText = "Password";
            this.input_password.Size = new System.Drawing.Size(250, 31);
            this.input_password.TabIndex = 4;
            this.input_password.Texts = "";
            this.input_password.UnderlinedStyle = false;
            // 
            // input_username
            // 
            this.input_username.BackColor = System.Drawing.SystemColors.Window;
            this.input_username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_username.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(9)))));
            this.input_username.BorderRadius = 5;
            this.input_username.BorderSize = 2;
            this.input_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.input_username.Location = new System.Drawing.Point(135, 200);
            this.input_username.Margin = new System.Windows.Forms.Padding(4);
            this.input_username.Multiline = false;
            this.input_username.Name = "input_username";
            this.input_username.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.input_username.PasswordChar = false;
            this.input_username.PlaceholderColor = System.Drawing.SystemColors.GrayText;
            this.input_username.PlaceholderText = "Username";
            this.input_username.Size = new System.Drawing.Size(250, 31);
            this.input_username.TabIndex = 3;
            this.input_username.Texts = "";
            this.input_username.UnderlinedStyle = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 432);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.input_username);
            this.Controls.Add(this.brand_logo);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.gradient_display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Location = new System.Drawing.Point(50, 50);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand_logo)).EndInit();
            this.gradient_display.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Label frm_label;
        private CustomComponents.GradientPanel gradient_display;
        private System.Windows.Forms.PictureBox brand_logo;
        private library_management_system.CustomComponents.RoundedTextBox input_username;
        private library_management_system.CustomComponents.RoundedTextBox input_password;
        private CustomComponents.RoundButton login_btn;
    }
}

