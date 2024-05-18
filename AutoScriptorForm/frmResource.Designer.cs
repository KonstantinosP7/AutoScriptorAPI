namespace AutoScriptorForm
{
    partial class frmResource
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
            tblDevices = new MaterialSkin.Controls.MaterialListView();
            addResource = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // tblDevices
            // 
            tblDevices.AutoSizeTable = false;
            tblDevices.BackColor = Color.FromArgb(255, 255, 255);
            tblDevices.BorderStyle = BorderStyle.None;
            tblDevices.Depth = 0;
            tblDevices.Dock = DockStyle.Bottom;
            tblDevices.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tblDevices.FullRowSelect = true;
            tblDevices.Location = new Point(0, 56);
            tblDevices.MinimumSize = new Size(200, 100);
            tblDevices.MouseLocation = new Point(-1, -1);
            tblDevices.MouseState = MaterialSkin.MouseState.OUT;
            tblDevices.Name = "tblDevices";
            tblDevices.OwnerDraw = true;
            tblDevices.Size = new Size(889, 493);
            tblDevices.Sorting = SortOrder.Ascending;
            tblDevices.TabIndex = 0;
            tblDevices.TileSize = new Size(10, 10);
            tblDevices.UseCompatibleStateImageBehavior = false;
            tblDevices.View = View.Details;
            // 
            // addResource
            // 
            addResource.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addResource.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addResource.Depth = 0;
            addResource.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addResource.HighEmphasis = true;
            addResource.Icon = null;
            addResource.Location = new Point(812, 11);
            addResource.Margin = new Padding(4, 6, 4, 6);
            addResource.MouseState = MaterialSkin.MouseState.HOVER;
            addResource.Name = "addResource";
            addResource.NoAccentTextColor = Color.Empty;
            addResource.Size = new Size(64, 36);
            addResource.TabIndex = 1;
            addResource.Text = "+";
            addResource.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addResource.UseAccentColor = false;
            addResource.UseVisualStyleBackColor = true;
            addResource.Click += addResource_Click;
            // 
            // frmResource
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(889, 549);
            Controls.Add(addResource);
            Controls.Add(tblDevices);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmResource";
            Text = "frmResource";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView tblDevices;
        private MaterialSkin.Controls.MaterialButton addResource;
    }
}