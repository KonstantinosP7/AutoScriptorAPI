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
            SuspendLayout();
            // 
            // tblDevices
            // 
            tblDevices.AutoSizeTable = false;
            tblDevices.BackColor = Color.FromArgb(255, 255, 255);
            tblDevices.BorderStyle = BorderStyle.None;
            tblDevices.Depth = 0;
            tblDevices.Dock = DockStyle.Fill;
            tblDevices.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tblDevices.FullRowSelect = true;
            tblDevices.Location = new Point(0, 0);
            tblDevices.MinimumSize = new Size(200, 100);
            tblDevices.MouseLocation = new Point(-1, -1);
            tblDevices.MouseState = MaterialSkin.MouseState.OUT;
            tblDevices.Name = "tblDevices";
            tblDevices.OwnerDraw = true;
            tblDevices.Size = new Size(733, 520);
            tblDevices.TabIndex = 0;
            tblDevices.UseCompatibleStateImageBehavior = false;
            tblDevices.View = View.Details;
            // 
            // frmResource
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(733, 520);
            Controls.Add(tblDevices);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmResource";
            Text = "frmResource";
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView tblDevices;
    }
}