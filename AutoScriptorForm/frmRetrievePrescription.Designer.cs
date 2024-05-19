namespace AutoScriptorForm
{
    partial class frmRetrievePrescription
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
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            txtPrsNo = new MaterialSkin.Controls.MaterialTextBox2();
            materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            pdfVr = new Patagames.Pdf.Net.Controls.WinForms.PdfViewer();
            SuspendLayout();
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(97, 199);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(109, 36);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "ΑΝΑΖΗΤΗΣΗ";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // txtPrsNo
            // 
            txtPrsNo.AnimateReadOnly = false;
            txtPrsNo.BackgroundImageLayout = ImageLayout.None;
            txtPrsNo.CharacterCasing = CharacterCasing.Normal;
            txtPrsNo.Depth = 0;
            txtPrsNo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrsNo.HideSelection = true;
            txtPrsNo.LeadingIcon = null;
            txtPrsNo.Location = new Point(26, 31);
            txtPrsNo.MaxLength = 32767;
            txtPrsNo.MouseState = MaterialSkin.MouseState.OUT;
            txtPrsNo.Name = "txtPrsNo";
            txtPrsNo.PasswordChar = '\0';
            txtPrsNo.PrefixSuffixText = null;
            txtPrsNo.ReadOnly = false;
            txtPrsNo.RightToLeft = RightToLeft.No;
            txtPrsNo.SelectedText = "";
            txtPrsNo.SelectionLength = 0;
            txtPrsNo.SelectionStart = 0;
            txtPrsNo.ShortcutsEnabled = true;
            txtPrsNo.Size = new Size(261, 48);
            txtPrsNo.TabIndex = 1;
            txtPrsNo.TabStop = false;
            txtPrsNo.Text = "022022044515845";
            txtPrsNo.TextAlign = HorizontalAlignment.Left;
            txtPrsNo.TrailingIcon = null;
            txtPrsNo.UseSystemPasswordChar = false;
            // 
            // materialTextBox22
            // 
            materialTextBox22.AnimateReadOnly = false;
            materialTextBox22.BackgroundImageLayout = ImageLayout.None;
            materialTextBox22.CharacterCasing = CharacterCasing.Normal;
            materialTextBox22.Depth = 0;
            materialTextBox22.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox22.HideSelection = true;
            materialTextBox22.LeadingIcon = null;
            materialTextBox22.Location = new Point(26, 100);
            materialTextBox22.MaxLength = 32767;
            materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox22.Name = "materialTextBox22";
            materialTextBox22.PasswordChar = '\0';
            materialTextBox22.PrefixSuffixText = null;
            materialTextBox22.ReadOnly = false;
            materialTextBox22.RightToLeft = RightToLeft.No;
            materialTextBox22.SelectedText = "";
            materialTextBox22.SelectionLength = 0;
            materialTextBox22.SelectionStart = 0;
            materialTextBox22.ShortcutsEnabled = true;
            materialTextBox22.Size = new Size(261, 48);
            materialTextBox22.TabIndex = 3;
            materialTextBox22.TabStop = false;
            materialTextBox22.Text = "ΑΜΚΑ";
            materialTextBox22.TextAlign = HorizontalAlignment.Left;
            materialTextBox22.TrailingIcon = null;
            materialTextBox22.UseSystemPasswordChar = false;
            // 
            // pdfVr
            // 
            pdfVr.BackColor = SystemColors.ControlDark;
            pdfVr.CurrentIndex = -1;
            pdfVr.CurrentPageHighlightColor = Color.FromArgb(170, 70, 130, 180);
            pdfVr.Dock = DockStyle.Right;
            pdfVr.Document = null;
            pdfVr.FormHighlightColor = Color.Transparent;
            pdfVr.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY;
            pdfVr.LoadingIconText = "Loading...";
            pdfVr.Location = new Point(354, 0);
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
            pdfVr.Size = new Size(1295, 918);
            pdfVr.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.FitToWidth;
            pdfVr.TabIndex = 4;
            pdfVr.TextSelectColor = Color.FromArgb(70, 70, 130, 180);
            pdfVr.TilesCount = 2;
            pdfVr.UseProgressiveRender = true;
            pdfVr.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical;
            pdfVr.Zoom = 1F;
            // 
            // frmRetrievePrescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1649, 918);
            Controls.Add(pdfVr);
            Controls.Add(materialTextBox22);
            Controls.Add(txtPrsNo);
            Controls.Add(materialButton1);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRetrievePrescription";
            Text = "frmRetrievePrescription";
            Leave += frmRetrievePrescription_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrsNo;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private Patagames.Pdf.Net.Controls.WinForms.PdfViewer pdfVr;
    }
}