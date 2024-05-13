using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing.Configuration;
using System.Runtime.InteropServices;

namespace AutoScriptorForm;

public partial class Form1 : MaterialForm
{
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );

    private readonly Color _btnHighlightColor = Color.FromArgb(46, 51, 73);
    private readonly Color _btnUnhighlightColor;

    public Form1()
    {
        InitializeComponent();
        //Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        pnlNav.BackColor = Color.White;
        _btnUnhighlightColor = homepageBtn.BackColor;
    }

    private void homepageBtn_Click(object sender, EventArgs e)
    {
        homepageBtn.BackColor = _btnHighlightColor;
        pnlNav.Height = homepageBtn.Height;
        pnlNav.Top = homepageBtn.Top;
        pnlNav.Left = homepageBtn.Left;

        this.pnlFormLoader.Controls.Clear();

        var frmHomepage = new frmResource() { 
            Dock = DockStyle.Fill, 
            TopLevel = false, 
            TopMost = true, 
            FormBorderStyle = FormBorderStyle.None 
        };

        this.pnlFormLoader.Controls.Add(frmHomepage);
        frmHomepage.Show();
    }

    private void executeBtn_Click(object sender, EventArgs e)
    {
        executeBtn.BackColor = _btnHighlightColor;
        pnlNav.Height = executeBtn.Height;
        pnlNav.Top = executeBtn.Top;
        pnlNav.Left = executeBtn.Left;
    }

    private void resourceBtn_Click(object sender, EventArgs e)
    {
        resourceBtn.BackColor = _btnHighlightColor;
        pnlNav.Height = resourceBtn.Height;
        pnlNav.Top = resourceBtn.Top;
        pnlNav.Left = resourceBtn.Left;
    }

    private void settingsBtn_Click(object sender, EventArgs e)
    {
        settingsBtn.BackColor = _btnHighlightColor;
        pnlNav.Height = settingsBtn.Height;
        pnlNav.Top = settingsBtn.Top;
        pnlNav.Left = settingsBtn.Left;
    }

    private void calendarBtn_Click(object sender, EventArgs e)
    {
        calendarBtn.BackColor = _btnHighlightColor;
        pnlNav.Height = calendarBtn.Height;
        pnlNav.Top = calendarBtn.Top;
        pnlNav.Left = calendarBtn.Left;
    }

    private void homepageBtn_Leave(object sender, EventArgs e)
    {
        homepageBtn.BackColor = _btnUnhighlightColor;
    }

    private void executeBtn_Leave(object sender, EventArgs e)
    {
        executeBtn.BackColor = _btnUnhighlightColor;
    }

    private void resourceBtn_Leave(object sender, EventArgs e)
    {
        resourceBtn.BackColor = _btnUnhighlightColor;
    }

    private void settingsBtn_Leave(object sender, EventArgs e)
    {
        settingsBtn.BackColor = _btnUnhighlightColor;
    }

    private void calendarBtn_Leave(object sender, EventArgs e)
    {
        calendarBtn.BackColor = _btnUnhighlightColor;
    }
}
