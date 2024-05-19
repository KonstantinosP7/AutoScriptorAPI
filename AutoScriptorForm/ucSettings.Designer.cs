namespace AutoScriptorForm
{
    partial class ucSettings
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
            swtMode = new MaterialSkin.Controls.MaterialSwitch();
            SuspendLayout();
            // 
            // swtMode
            // 
            swtMode.AutoSize = true;
            swtMode.Depth = 0;
            swtMode.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            swtMode.Location = new Point(76, 59);
            swtMode.Margin = new Padding(0);
            swtMode.MouseLocation = new Point(-1, -1);
            swtMode.MouseState = MaterialSkin.MouseState.HOVER;
            swtMode.Name = "swtMode";
            swtMode.Ripple = true;
            swtMode.Size = new Size(103, 37);
            swtMode.TabIndex = 0;
            swtMode.Text = "Φόντο";
            swtMode.UseVisualStyleBackColor = true;
            swtMode.CheckedChanged += swtMode_CheckedChanged;
            // 
            // ucSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(swtMode);
            Name = "ucSettings";
            Size = new Size(1661, 812);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialSwitch swtMode;
    }
}
