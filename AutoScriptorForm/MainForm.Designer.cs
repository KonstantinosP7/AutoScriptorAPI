﻿namespace AutoScriptorForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            btnRetrieve = new Button();
            pnlNav = new Panel();
            calendarBtn = new Button();
            settingsBtn = new Button();
            resourceBtn = new Button();
            executeBtn = new Button();
            homepageBtn = new Button();
            panel2 = new Panel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox1 = new PictureBox();
            pnlFormLoader = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRetrieve);
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(calendarBtn);
            panel1.Controls.Add(settingsBtn);
            panel1.Controls.Add(resourceBtn);
            panel1.Controls.Add(executeBtn);
            panel1.Controls.Add(homepageBtn);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 918);
            panel1.TabIndex = 0;
            // 
            // btnRetrieve
            // 
            btnRetrieve.Dock = DockStyle.Top;
            btnRetrieve.FlatAppearance.BorderSize = 0;
            btnRetrieve.FlatStyle = FlatStyle.Flat;
            btnRetrieve.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnRetrieve.ForeColor = SystemColors.ControlLightLight;
            btnRetrieve.Image = Properties.Resources.icons8_search_24;
            btnRetrieve.Location = new Point(0, 361);
            btnRetrieve.Name = "btnRetrieve";
            btnRetrieve.Size = new Size(246, 61);
            btnRetrieve.TabIndex = 6;
            btnRetrieve.Text = "ΑΝΑΚΤΗΣΗ";
            btnRetrieve.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRetrieve.UseVisualStyleBackColor = true;
            btnRetrieve.Click += btnRetrieve_Click;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(3, 110);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(16, 50);
            pnlNav.TabIndex = 2;
            // 
            // calendarBtn
            // 
            calendarBtn.Dock = DockStyle.Top;
            calendarBtn.FlatAppearance.BorderSize = 0;
            calendarBtn.FlatStyle = FlatStyle.Flat;
            calendarBtn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            calendarBtn.ForeColor = SystemColors.ControlLightLight;
            calendarBtn.Image = Properties.Resources.icons8_calendar_24;
            calendarBtn.Location = new Point(0, 298);
            calendarBtn.Name = "calendarBtn";
            calendarBtn.Size = new Size(246, 63);
            calendarBtn.TabIndex = 5;
            calendarBtn.Text = "ΗΜΕΡΟΛΟΓΙΟ";
            calendarBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            calendarBtn.UseVisualStyleBackColor = true;
            calendarBtn.Click += calendarBtn_Click;
            calendarBtn.Leave += calendarBtn_Leave;
            // 
            // settingsBtn
            // 
            settingsBtn.Dock = DockStyle.Bottom;
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            settingsBtn.ForeColor = SystemColors.ControlLightLight;
            settingsBtn.ImageAlign = ContentAlignment.MiddleRight;
            settingsBtn.Location = new Point(0, 868);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(246, 50);
            settingsBtn.TabIndex = 4;
            settingsBtn.Text = "ΡΥΘΜΙΣΕΙΣ";
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
            settingsBtn.Leave += settingsBtn_Leave;
            // 
            // resourceBtn
            // 
            resourceBtn.Dock = DockStyle.Top;
            resourceBtn.FlatAppearance.BorderSize = 0;
            resourceBtn.FlatStyle = FlatStyle.Flat;
            resourceBtn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            resourceBtn.ForeColor = SystemColors.ControlLightLight;
            resourceBtn.Image = Properties.Resources.icons8_warehouse_24;
            resourceBtn.Location = new Point(0, 239);
            resourceBtn.Name = "resourceBtn";
            resourceBtn.Size = new Size(246, 59);
            resourceBtn.TabIndex = 3;
            resourceBtn.Text = "ΑΠΟΘΗΚΗ";
            resourceBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            resourceBtn.UseVisualStyleBackColor = true;
            resourceBtn.Click += resourceBtn_Click;
            resourceBtn.Leave += resourceBtn_Leave;
            // 
            // executeBtn
            // 
            executeBtn.Dock = DockStyle.Top;
            executeBtn.FlatAppearance.BorderSize = 0;
            executeBtn.FlatStyle = FlatStyle.Flat;
            executeBtn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            executeBtn.ForeColor = SystemColors.ControlLightLight;
            executeBtn.Image = Properties.Resources.icons8_download_24;
            executeBtn.Location = new Point(0, 169);
            executeBtn.Name = "executeBtn";
            executeBtn.Size = new Size(246, 70);
            executeBtn.TabIndex = 2;
            executeBtn.Text = "ΚΑΤΑΧΩΡΗΣΗ";
            executeBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            executeBtn.UseVisualStyleBackColor = true;
            executeBtn.Click += executeBtn_Click;
            executeBtn.Leave += executeBtn_Leave;
            // 
            // homepageBtn
            // 
            homepageBtn.Dock = DockStyle.Top;
            homepageBtn.FlatAppearance.BorderSize = 0;
            homepageBtn.FlatStyle = FlatStyle.Flat;
            homepageBtn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            homepageBtn.ForeColor = SystemColors.ControlLightLight;
            homepageBtn.Image = (Image)resources.GetObject("homepageBtn.Image");
            homepageBtn.Location = new Point(0, 110);
            homepageBtn.Name = "homepageBtn";
            homepageBtn.Size = new Size(246, 59);
            homepageBtn.TabIndex = 1;
            homepageBtn.Text = "ΑΡΧΙΚΗ";
            homepageBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            homepageBtn.UseVisualStyleBackColor = true;
            homepageBtn.Click += homepageBtn_Click;
            homepageBtn.Leave += homepageBtn_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(materialLabel1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 110);
            panel2.TabIndex = 0;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(92, 79);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(73, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Χρήστης1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(102, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Fill;
            pnlFormLoader.Location = new Point(249, 24);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(1589, 918);
            pnlFormLoader.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1841, 945);
            Controls.Add(pnlFormLoader);
            Controls.Add(panel1);
            DrawerShowIconsWhenHidden = true;
            DrawerWidth = 350;
            FormStyle = FormStyles.ActionBar_None;
            Name = "MainForm";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutoScirptor";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Button homepageBtn;
        private Button calendarBtn;
        private Button settingsBtn;
        private Button resourceBtn;
        private Button executeBtn;
        private Panel pnlNav;
        private Panel pnlFormLoader;
        private Button btnRetrieve;
    }
}
