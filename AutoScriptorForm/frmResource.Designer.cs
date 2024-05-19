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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResource));
            tblDevices = new MaterialSkin.Controls.MaterialListView();
            addResource = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // tblDevices
            // 
            tblDevices.AutoSizeTable = false;
            tblDevices.BackColor = Color.FromArgb(255, 255, 255);
            tblDevices.BorderStyle = BorderStyle.None;
            tblDevices.CheckBoxes = true;
            tblDevices.Depth = 0;
            tblDevices.Dock = DockStyle.Left;
            tblDevices.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblDevices.FullRowSelect = true;
            tblDevices.Location = new Point(3, 0);
            tblDevices.Margin = new Padding(0);
            tblDevices.MinimumSize = new Size(200, 100);
            tblDevices.MouseLocation = new Point(-1, -1);
            tblDevices.MouseState = MaterialSkin.MouseState.OUT;
            tblDevices.Name = "tblDevices";
            tblDevices.OwnerDraw = true;
            tblDevices.Size = new Size(1323, 915);
            tblDevices.Sorting = SortOrder.Ascending;
            tblDevices.TabIndex = 0;
            tblDevices.TileSize = new Size(25, 25);
            tblDevices.UseCompatibleStateImageBehavior = false;
            tblDevices.View = View.Details;
            // 
            // addResource
            // 
            addResource.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addResource.Cursor = Cursors.Hand;
            addResource.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addResource.Depth = 0;
            addResource.FlatAppearance.BorderSize = 5;
            addResource.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addResource.HighEmphasis = true;
            addResource.Icon = Properties.Resources.plus_black_symbol_icon_icons_com_73453;
            addResource.Location = new Point(1331, 0);
            addResource.Margin = new Padding(0);
            addResource.MouseState = MaterialSkin.MouseState.HOVER;
            addResource.Name = "addResource";
            addResource.NoAccentTextColor = Color.Empty;
            addResource.Padding = new Padding(0, 0, 5, 0);
            addResource.Size = new Size(128, 36);
            addResource.TabIndex = 1;
            addResource.Text = "ΠΡΟΣΘΗΚΗ";
            addResource.TextImageRelation = TextImageRelation.ImageAboveText;
            addResource.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addResource.UseAccentColor = true;
            addResource.UseVisualStyleBackColor = true;
            addResource.Click += addResource_Click;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Cursor = Cursors.Hand;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.FlatAppearance.BorderSize = 20;
            materialButton1.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = (Image)resources.GetObject("materialButton1.Icon");
            materialButton1.Location = new Point(1331, 36);
            materialButton1.Margin = new Padding(0);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(138, 36);
            materialButton1.TabIndex = 2;
            materialButton1.Text = "ΕΝΗΜΕΡΩΣΗ";
            materialButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = true;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // frmResource
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1472, 918);
            Controls.Add(addResource);
            Controls.Add(materialButton1);
            Controls.Add(tblDevices);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "frmResource";
            Padding = new Padding(3, 0, 3, 3);
            Text = "frmResource";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView tblDevices;
        private MaterialSkin.Controls.MaterialButton addResource;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}