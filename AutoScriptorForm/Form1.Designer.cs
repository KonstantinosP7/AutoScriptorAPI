namespace AutoScriptorForm
{
    partial class Form1
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
            panel1 = new Panel();
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
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(calendarBtn);
            panel1.Controls.Add(settingsBtn);
            panel1.Controls.Add(resourceBtn);
            panel1.Controls.Add(executeBtn);
            panel1.Controls.Add(homepageBtn);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 510);
            panel1.TabIndex = 0;
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
            calendarBtn.ImageAlign = ContentAlignment.MiddleRight;
            calendarBtn.Location = new Point(0, 310);
            calendarBtn.Name = "calendarBtn";
            calendarBtn.Size = new Size(186, 50);
            calendarBtn.TabIndex = 5;
            calendarBtn.Text = "ΗΜΕΡΟΛΟΓΙΟ";
            calendarBtn.UseVisualStyleBackColor = true;
            calendarBtn.Click += calendarBtn_Click;
            calendarBtn.Leave += calendarBtn_Leave;
            // 
            // settingsBtn
            // 
            settingsBtn.Dock = DockStyle.Top;
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            settingsBtn.ForeColor = SystemColors.ControlLightLight;
            settingsBtn.ImageAlign = ContentAlignment.MiddleRight;
            settingsBtn.Location = new Point(0, 260);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(186, 50);
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
            resourceBtn.ImageAlign = ContentAlignment.MiddleRight;
            resourceBtn.Location = new Point(0, 210);
            resourceBtn.Name = "resourceBtn";
            resourceBtn.Size = new Size(186, 50);
            resourceBtn.TabIndex = 3;
            resourceBtn.Text = "ΑΠΟΘΗΚΗ";
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
            executeBtn.ImageAlign = ContentAlignment.MiddleRight;
            executeBtn.Location = new Point(0, 160);
            executeBtn.Name = "executeBtn";
            executeBtn.Size = new Size(186, 50);
            executeBtn.TabIndex = 2;
            executeBtn.Text = "ΚΑΤΑΧΩΡΗΣΗ";
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
            homepageBtn.ImageAlign = ContentAlignment.MiddleRight;
            homepageBtn.Location = new Point(0, 110);
            homepageBtn.Name = "homepageBtn";
            homepageBtn.Size = new Size(186, 50);
            homepageBtn.TabIndex = 1;
            homepageBtn.Text = "ΑΡΧΙΚΗ";
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
            panel2.Size = new Size(186, 110);
            panel2.TabIndex = 0;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(60, 80);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(73, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Χρήστης1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(60, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Fill;
            pnlFormLoader.Location = new Point(189, 64);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(759, 510);
            pnlFormLoader.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(pnlFormLoader);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
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
    }
}
