namespace AutoScriptorForm
{
    partial class addPrescription
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addPrescription));
            txtAG = new MaterialSkin.Controls.MaterialTextBox2();
            txtAMKA = new MaterialSkin.Controls.MaterialTextBox2();
            txtAMKADoc = new MaterialSkin.Controls.MaterialTextBox2();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            pdfVr = new Patagames.Pdf.Net.Controls.WinForms.PdfViewer();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            cmboxDevice = new MaterialSkin.Controls.MaterialComboBox();
            clndr = new Krypton.Toolkit.KryptonMonthCalendar();
            txtExecutionDate = new MaterialSkin.Controls.MaterialTextBox2();
            materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            txtSurname = new MaterialSkin.Controls.MaterialTextBox2();
            txtName = new MaterialSkin.Controls.MaterialTextBox2();
            txtIssueDate = new MaterialSkin.Controls.MaterialTextBox2();
            txtNameDoc = new MaterialSkin.Controls.MaterialTextBox2();
            txtSurnameDoc = new MaterialSkin.Controls.MaterialTextBox2();
            txtEndDate = new MaterialSkin.Controls.MaterialTextBox2();
            SuspendLayout();
            // 
            // txtAG
            // 
            txtAG.AnimateReadOnly = false;
            txtAG.BackgroundImageLayout = ImageLayout.None;
            txtAG.CharacterCasing = CharacterCasing.Normal;
            txtAG.Depth = 0;
            txtAG.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAG.HideSelection = true;
            txtAG.Hint = "Αριθμός Γνωμάτευσης";
            txtAG.LeadingIcon = Properties.Resources.icons8_paper_48;
            txtAG.Location = new Point(32, 69);
            txtAG.MaxLength = 32767;
            txtAG.MouseState = MaterialSkin.MouseState.OUT;
            txtAG.Name = "txtAG";
            txtAG.PasswordChar = '\0';
            txtAG.PrefixSuffixText = null;
            txtAG.ReadOnly = false;
            txtAG.RightToLeft = RightToLeft.No;
            txtAG.SelectedText = "";
            txtAG.SelectionLength = 0;
            txtAG.SelectionStart = 0;
            txtAG.ShortcutsEnabled = true;
            txtAG.Size = new Size(584, 48);
            txtAG.TabIndex = 0;
            txtAG.TabStop = false;
            txtAG.TextAlign = HorizontalAlignment.Left;
            txtAG.TrailingIcon = null;
            txtAG.UseSystemPasswordChar = false;
            // 
            // txtAMKA
            // 
            txtAMKA.AnimateReadOnly = true;
            txtAMKA.BackgroundImageLayout = ImageLayout.None;
            txtAMKA.CharacterCasing = CharacterCasing.Normal;
            txtAMKA.Depth = 0;
            txtAMKA.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAMKA.HideSelection = true;
            txtAMKA.Hint = "AMKA Εξεταζόμενου";
            txtAMKA.LeadingIcon = Properties.Resources.icons8_name_50;
            txtAMKA.Location = new Point(32, 186);
            txtAMKA.MaxLength = 32767;
            txtAMKA.MouseState = MaterialSkin.MouseState.OUT;
            txtAMKA.Name = "txtAMKA";
            txtAMKA.PasswordChar = '\0';
            txtAMKA.PrefixSuffixText = null;
            txtAMKA.ReadOnly = true;
            txtAMKA.RightToLeft = RightToLeft.No;
            txtAMKA.SelectedText = "";
            txtAMKA.SelectionLength = 0;
            txtAMKA.SelectionStart = 0;
            txtAMKA.ShortcutsEnabled = true;
            txtAMKA.Size = new Size(250, 48);
            txtAMKA.TabIndex = 2;
            txtAMKA.TabStop = false;
            txtAMKA.TextAlign = HorizontalAlignment.Left;
            txtAMKA.TrailingIcon = null;
            txtAMKA.UseSystemPasswordChar = false;
            // 
            // txtAMKADoc
            // 
            txtAMKADoc.AnimateReadOnly = true;
            txtAMKADoc.BackgroundImageLayout = ImageLayout.None;
            txtAMKADoc.CharacterCasing = CharacterCasing.Normal;
            txtAMKADoc.Depth = 0;
            txtAMKADoc.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAMKADoc.HideSelection = true;
            txtAMKADoc.Hint = "ΑΜΚΑ Ιατρού";
            txtAMKADoc.LeadingIcon = Properties.Resources.icons8_doctor_50;
            txtAMKADoc.Location = new Point(366, 186);
            txtAMKADoc.MaxLength = 32767;
            txtAMKADoc.MouseState = MaterialSkin.MouseState.OUT;
            txtAMKADoc.Name = "txtAMKADoc";
            txtAMKADoc.PasswordChar = '\0';
            txtAMKADoc.PrefixSuffixText = null;
            txtAMKADoc.ReadOnly = true;
            txtAMKADoc.RightToLeft = RightToLeft.No;
            txtAMKADoc.SelectedText = "";
            txtAMKADoc.SelectionLength = 0;
            txtAMKADoc.SelectionStart = 0;
            txtAMKADoc.ShortcutsEnabled = true;
            txtAMKADoc.Size = new Size(250, 48);
            txtAMKADoc.TabIndex = 3;
            txtAMKADoc.TabStop = false;
            txtAMKADoc.TextAlign = HorizontalAlignment.Left;
            txtAMKADoc.TrailingIcon = null;
            txtAMKADoc.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = Properties.Resources.icons8_search_50;
            materialButton1.Location = new Point(411, 686);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(205, 36);
            materialButton1.TabIndex = 4;
            materialButton1.Text = "ΑΝΑΚΤΗΣΗ ΣΤΟΙΧΕΙΩΝ";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // pdfVr
            // 
            pdfVr.BackColor = SystemColors.ControlDark;
            pdfVr.CurrentIndex = -1;
            pdfVr.CurrentPageHighlightColor = Color.FromArgb(170, 70, 130, 180);
            pdfVr.Document = null;
            pdfVr.FormHighlightColor = Color.Transparent;
            pdfVr.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY;
            pdfVr.LoadingIconText = "Loading...";
            pdfVr.Location = new Point(648, 69);
            pdfVr.Margin = new Padding(4, 3, 4, 3);
            pdfVr.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.Default;
            pdfVr.Name = "pdfVr";
            pdfVr.OptimizedLoadThreshold = 1000;
            pdfVr.Padding = new Padding(12, 12, 12, 12);
            pdfVr.PageAlign = ContentAlignment.MiddleCenter;
            pdfVr.PageAutoDispose = true;
            pdfVr.PageBackColor = Color.White;
            pdfVr.PageBorderColor = Color.Black;
            pdfVr.PageMargin = new Padding(10);
            pdfVr.PageSeparatorColor = Color.Gray;
            pdfVr.RenderFlags = Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT | Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH;
            pdfVr.ShowCurrentPageHighlight = true;
            pdfVr.ShowLoadingIcon = true;
            pdfVr.ShowPageSeparator = true;
            pdfVr.Size = new Size(773, 821);
            pdfVr.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.FitToWidth;
            pdfVr.TabIndex = 5;
            pdfVr.TextSelectColor = Color.FromArgb(70, 70, 130, 180);
            pdfVr.TilesCount = 2;
            pdfVr.UseProgressiveRender = true;
            pdfVr.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical;
            pdfVr.Zoom = 1F;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = Properties.Resources.icons8_download_50;
            materialButton2.Location = new Point(471, 743);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(145, 36);
            materialButton2.TabIndex = 6;
            materialButton2.Text = "ΚΑΤΑΧΩΡΗΣΗ";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(21, 531);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(612, 10);
            materialDivider1.TabIndex = 7;
            materialDivider1.Text = "materialDivider1";
            // 
            // cmboxDevice
            // 
            cmboxDevice.AutoResize = false;
            cmboxDevice.BackColor = Color.FromArgb(255, 255, 255);
            cmboxDevice.Depth = 0;
            cmboxDevice.DrawMode = DrawMode.OwnerDrawVariable;
            cmboxDevice.DropDownHeight = 174;
            cmboxDevice.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxDevice.DropDownWidth = 121;
            cmboxDevice.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmboxDevice.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmboxDevice.FormattingEnabled = true;
            cmboxDevice.Hint = "Μηχάνημα";
            cmboxDevice.IntegralHeight = false;
            cmboxDevice.ItemHeight = 43;
            cmboxDevice.Items.AddRange(new object[] { "Oxy001", "Oxy003", "Oxy005" });
            cmboxDevice.Location = new Point(366, 566);
            cmboxDevice.MaxDropDownItems = 4;
            cmboxDevice.MouseState = MaterialSkin.MouseState.OUT;
            cmboxDevice.Name = "cmboxDevice";
            cmboxDevice.Size = new Size(250, 49);
            cmboxDevice.StartIndex = 0;
            cmboxDevice.TabIndex = 8;
            // 
            // clndr
            // 
            clndr.Location = new Point(43, 637);
            clndr.Name = "clndr";
            clndr.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleDarkMode;
            clndr.Size = new Size(230, 184);
            clndr.TabIndex = 9;
            // 
            // txtExecutionDate
            // 
            txtExecutionDate.AnimateReadOnly = true;
            txtExecutionDate.BackgroundImageLayout = ImageLayout.None;
            txtExecutionDate.CharacterCasing = CharacterCasing.Normal;
            txtExecutionDate.Depth = 0;
            txtExecutionDate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtExecutionDate.HideSelection = true;
            txtExecutionDate.Hint = "Hμερομηνία Εκτέλεσης";
            txtExecutionDate.LeadingIcon = (Image)resources.GetObject("txtExecutionDate.LeadingIcon");
            txtExecutionDate.Location = new Point(32, 566);
            txtExecutionDate.MaxLength = 32767;
            txtExecutionDate.MouseState = MaterialSkin.MouseState.OUT;
            txtExecutionDate.Name = "txtExecutionDate";
            txtExecutionDate.PasswordChar = '\0';
            txtExecutionDate.PrefixSuffixText = null;
            txtExecutionDate.ReadOnly = false;
            txtExecutionDate.RightToLeft = RightToLeft.No;
            txtExecutionDate.SelectedText = "";
            txtExecutionDate.SelectionLength = 0;
            txtExecutionDate.SelectionStart = 0;
            txtExecutionDate.ShortcutsEnabled = true;
            txtExecutionDate.Size = new Size(250, 48);
            txtExecutionDate.TabIndex = 10;
            txtExecutionDate.TabStop = false;
            txtExecutionDate.TextAlign = HorizontalAlignment.Left;
            txtExecutionDate.TrailingIcon = null;
            txtExecutionDate.UseSystemPasswordChar = false;
            // 
            // materialDivider2
            // 
            materialDivider2.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider2.Depth = 0;
            materialDivider2.Location = new Point(21, 148);
            materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider2.Name = "materialDivider2";
            materialDivider2.Size = new Size(612, 10);
            materialDivider2.TabIndex = 11;
            materialDivider2.Text = "materialDivider2";
            // 
            // txtSurname
            // 
            txtSurname.AnimateReadOnly = true;
            txtSurname.BackgroundImageLayout = ImageLayout.None;
            txtSurname.CharacterCasing = CharacterCasing.Normal;
            txtSurname.Depth = 0;
            txtSurname.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSurname.HideSelection = true;
            txtSurname.Hint = "Επώνυμο Εξεταζόμενου";
            txtSurname.LeadingIcon = (Image)resources.GetObject("txtSurname.LeadingIcon");
            txtSurname.Location = new Point(32, 268);
            txtSurname.MaxLength = 32767;
            txtSurname.MouseState = MaterialSkin.MouseState.OUT;
            txtSurname.Name = "txtSurname";
            txtSurname.PasswordChar = '\0';
            txtSurname.PrefixSuffixText = null;
            txtSurname.ReadOnly = true;
            txtSurname.RightToLeft = RightToLeft.No;
            txtSurname.SelectedText = "";
            txtSurname.SelectionLength = 0;
            txtSurname.SelectionStart = 0;
            txtSurname.ShortcutsEnabled = true;
            txtSurname.Size = new Size(250, 48);
            txtSurname.TabIndex = 12;
            txtSurname.TabStop = false;
            txtSurname.TextAlign = HorizontalAlignment.Left;
            txtSurname.TrailingIcon = null;
            txtSurname.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = true;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "Όνομα Εξεταζόμενου";
            txtName.LeadingIcon = Properties.Resources.icons8_name_50;
            txtName.Location = new Point(32, 350);
            txtName.MaxLength = 32767;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.ReadOnly = true;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(250, 48);
            txtName.TabIndex = 13;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtIssueDate
            // 
            txtIssueDate.AnimateReadOnly = true;
            txtIssueDate.BackgroundImageLayout = ImageLayout.None;
            txtIssueDate.CharacterCasing = CharacterCasing.Normal;
            txtIssueDate.Depth = 0;
            txtIssueDate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIssueDate.HideSelection = true;
            txtIssueDate.Hint = "Ημ/νία Έκδοσης";
            txtIssueDate.LeadingIcon = Properties.Resources.icons8_date_50;
            txtIssueDate.Location = new Point(32, 433);
            txtIssueDate.MaxLength = 32767;
            txtIssueDate.MouseState = MaterialSkin.MouseState.OUT;
            txtIssueDate.Name = "txtIssueDate";
            txtIssueDate.PasswordChar = '\0';
            txtIssueDate.PrefixSuffixText = null;
            txtIssueDate.ReadOnly = true;
            txtIssueDate.RightToLeft = RightToLeft.No;
            txtIssueDate.SelectedText = "";
            txtIssueDate.SelectionLength = 0;
            txtIssueDate.SelectionStart = 0;
            txtIssueDate.ShortcutsEnabled = true;
            txtIssueDate.Size = new Size(250, 48);
            txtIssueDate.TabIndex = 14;
            txtIssueDate.TabStop = false;
            txtIssueDate.TextAlign = HorizontalAlignment.Left;
            txtIssueDate.TrailingIcon = null;
            txtIssueDate.UseSystemPasswordChar = false;
            // 
            // txtNameDoc
            // 
            txtNameDoc.AnimateReadOnly = true;
            txtNameDoc.BackgroundImageLayout = ImageLayout.None;
            txtNameDoc.CharacterCasing = CharacterCasing.Normal;
            txtNameDoc.Depth = 0;
            txtNameDoc.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNameDoc.HideSelection = true;
            txtNameDoc.Hint = "Όνομα Ιατρού";
            txtNameDoc.LeadingIcon = Properties.Resources.icons8_doctor_50;
            txtNameDoc.Location = new Point(366, 350);
            txtNameDoc.MaxLength = 32767;
            txtNameDoc.MouseState = MaterialSkin.MouseState.OUT;
            txtNameDoc.Name = "txtNameDoc";
            txtNameDoc.PasswordChar = '\0';
            txtNameDoc.PrefixSuffixText = null;
            txtNameDoc.ReadOnly = true;
            txtNameDoc.RightToLeft = RightToLeft.No;
            txtNameDoc.SelectedText = "";
            txtNameDoc.SelectionLength = 0;
            txtNameDoc.SelectionStart = 0;
            txtNameDoc.ShortcutsEnabled = true;
            txtNameDoc.Size = new Size(250, 48);
            txtNameDoc.TabIndex = 16;
            txtNameDoc.TabStop = false;
            txtNameDoc.TextAlign = HorizontalAlignment.Left;
            txtNameDoc.TrailingIcon = null;
            txtNameDoc.UseSystemPasswordChar = false;
            // 
            // txtSurnameDoc
            // 
            txtSurnameDoc.AnimateReadOnly = true;
            txtSurnameDoc.BackgroundImageLayout = ImageLayout.None;
            txtSurnameDoc.CharacterCasing = CharacterCasing.Normal;
            txtSurnameDoc.Depth = 0;
            txtSurnameDoc.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSurnameDoc.HideSelection = true;
            txtSurnameDoc.Hint = "Επώνυμο Iατρού";
            txtSurnameDoc.LeadingIcon = Properties.Resources.icons8_doctor_50;
            txtSurnameDoc.Location = new Point(366, 268);
            txtSurnameDoc.MaxLength = 32767;
            txtSurnameDoc.MouseState = MaterialSkin.MouseState.OUT;
            txtSurnameDoc.Name = "txtSurnameDoc";
            txtSurnameDoc.PasswordChar = '\0';
            txtSurnameDoc.PrefixSuffixText = null;
            txtSurnameDoc.ReadOnly = true;
            txtSurnameDoc.RightToLeft = RightToLeft.No;
            txtSurnameDoc.SelectedText = "";
            txtSurnameDoc.SelectionLength = 0;
            txtSurnameDoc.SelectionStart = 0;
            txtSurnameDoc.ShortcutsEnabled = true;
            txtSurnameDoc.Size = new Size(250, 48);
            txtSurnameDoc.TabIndex = 15;
            txtSurnameDoc.TabStop = false;
            txtSurnameDoc.TextAlign = HorizontalAlignment.Left;
            txtSurnameDoc.TrailingIcon = null;
            txtSurnameDoc.UseSystemPasswordChar = false;
            // 
            // txtEndDate
            // 
            txtEndDate.AnimateReadOnly = true;
            txtEndDate.BackgroundImageLayout = ImageLayout.None;
            txtEndDate.CharacterCasing = CharacterCasing.Normal;
            txtEndDate.Depth = 0;
            txtEndDate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndDate.HideSelection = true;
            txtEndDate.Hint = "Ημ/νία Λήξης";
            txtEndDate.LeadingIcon = Properties.Resources.icons8_date_50;
            txtEndDate.Location = new Point(366, 433);
            txtEndDate.MaxLength = 32767;
            txtEndDate.MouseState = MaterialSkin.MouseState.OUT;
            txtEndDate.Name = "txtEndDate";
            txtEndDate.PasswordChar = '\0';
            txtEndDate.PrefixSuffixText = null;
            txtEndDate.ReadOnly = true;
            txtEndDate.RightToLeft = RightToLeft.No;
            txtEndDate.SelectedText = "";
            txtEndDate.SelectionLength = 0;
            txtEndDate.SelectionStart = 0;
            txtEndDate.ShortcutsEnabled = true;
            txtEndDate.Size = new Size(250, 48);
            txtEndDate.TabIndex = 17;
            txtEndDate.TabStop = false;
            txtEndDate.TextAlign = HorizontalAlignment.Left;
            txtEndDate.TrailingIcon = null;
            txtEndDate.UseSystemPasswordChar = false;
            // 
            // addPrescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtEndDate);
            Controls.Add(txtNameDoc);
            Controls.Add(txtSurnameDoc);
            Controls.Add(txtIssueDate);
            Controls.Add(txtName);
            Controls.Add(txtSurname);
            Controls.Add(materialDivider2);
            Controls.Add(txtExecutionDate);
            Controls.Add(clndr);
            Controls.Add(cmboxDevice);
            Controls.Add(materialDivider1);
            Controls.Add(materialButton2);
            Controls.Add(pdfVr);
            Controls.Add(materialButton1);
            Controls.Add(txtAMKADoc);
            Controls.Add(txtAMKA);
            Controls.Add(txtAG);
            Name = "addPrescription";
            Size = new Size(1649, 918);
            Leave += addPrescription_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtAG;
        private MaterialSkin.Controls.MaterialTextBox2 txtAMKA;
        private MaterialSkin.Controls.MaterialTextBox2 txtAMKADoc;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Patagames.Pdf.Net.Controls.WinForms.PdfViewer pdfVr;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialComboBox cmboxDevice;
        private Krypton.Toolkit.KryptonMonthCalendar clndr;
        private MaterialSkin.Controls.MaterialTextBox2 txtExecutionDate;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialTextBox2 txtSurname;
        private MaterialSkin.Controls.MaterialTextBox2 txtName;
        private MaterialSkin.Controls.MaterialTextBox2 txtIssueDate;
        private MaterialSkin.Controls.MaterialTextBox2 txtNameDoc;
        private MaterialSkin.Controls.MaterialTextBox2 txtSurnameDoc;
        private MaterialSkin.Controls.MaterialTextBox2 txtEndDate;
    }
}
