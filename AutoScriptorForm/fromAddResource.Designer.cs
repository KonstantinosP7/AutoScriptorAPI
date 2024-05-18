namespace AutoScriptorForm
{
    partial class frmAddResource
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
            txtCode = new MaterialSkin.Controls.MaterialTextBox();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            txtManufacturer = new MaterialSkin.Controls.MaterialTextBox();
            txtDateOfBuy = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.AnimateReadOnly = true;
            txtCode.BorderStyle = BorderStyle.None;
            txtCode.Depth = 0;
            txtCode.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCode.Hint = "Κωδικός Νέου Μηχανήματος";
            txtCode.LeadingIcon = null;
            txtCode.Location = new Point(13, 42);
            txtCode.MaxLength = 50;
            txtCode.MouseState = MaterialSkin.MouseState.OUT;
            txtCode.Multiline = false;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(240, 50);
            txtCode.TabIndex = 0;
            txtCode.Text = "";
            txtCode.TrailingIcon = null;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(74, 237);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(117, 36);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "ΚΑΤΑΧΩΡΗΣΗ";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtManufacturer
            // 
            txtManufacturer.AnimateReadOnly = true;
            txtManufacturer.BorderStyle = BorderStyle.None;
            txtManufacturer.Depth = 0;
            txtManufacturer.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtManufacturer.Hint = "Κατασκευαστής";
            txtManufacturer.LeadingIcon = null;
            txtManufacturer.Location = new Point(13, 178);
            txtManufacturer.MaxLength = 50;
            txtManufacturer.MouseState = MaterialSkin.MouseState.OUT;
            txtManufacturer.Multiline = false;
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(239, 50);
            txtManufacturer.TabIndex = 4;
            txtManufacturer.Text = "";
            txtManufacturer.TrailingIcon = null;
            // 
            // txtDateOfBuy
            // 
            txtDateOfBuy.AnimateReadOnly = true;
            txtDateOfBuy.BorderStyle = BorderStyle.None;
            txtDateOfBuy.Depth = 0;
            txtDateOfBuy.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDateOfBuy.Hint = "Ημ/νία Απόκτησης";
            txtDateOfBuy.LeadingIcon = null;
            txtDateOfBuy.Location = new Point(12, 108);
            txtDateOfBuy.MaxLength = 50;
            txtDateOfBuy.MouseState = MaterialSkin.MouseState.OUT;
            txtDateOfBuy.Multiline = false;
            txtDateOfBuy.Name = "txtDateOfBuy";
            txtDateOfBuy.Size = new Size(240, 50);
            txtDateOfBuy.TabIndex = 5;
            txtDateOfBuy.Text = "";
            txtDateOfBuy.TrailingIcon = null;
            // 
            // frmAddResource
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 282);
            Controls.Add(txtDateOfBuy);
            Controls.Add(txtManufacturer);
            Controls.Add(btnAdd);
            Controls.Add(txtCode);
            FormStyle = FormStyles.ActionBar_None;
            Name = "frmAddResource";
            Padding = new Padding(3, 24, 3, 3);
            Text = "fromAddResource";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtCode;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialTextBox txtManufacturer;
        private MaterialSkin.Controls.MaterialTextBox txtDateOfBuy;
    }
}