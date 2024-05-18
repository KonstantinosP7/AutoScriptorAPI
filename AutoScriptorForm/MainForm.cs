using MaterialSkin;
using MaterialSkin.Controls;

namespace AutoScriptorForm;

public partial class MainForm : MaterialForm
{
    private readonly Color _btnHighlightColor = Color.FromArgb(46, 51, 73);
    private readonly Color _btnUnhighlightColor;

    public MainForm()
    {
        InitializeComponent();
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
        moveNavigationPanel(homepageBtn);

        this.pnlFormLoader.Controls.Clear();
    }

    private void executeBtn_Click(object sender, EventArgs e)
    {
        executeBtn.BackColor = _btnHighlightColor;
        moveNavigationPanel(executeBtn);
        this.pnlFormLoader.Controls.Clear();
    }

    private void resourceBtn_Click(object sender, EventArgs e)
    {
        resourceBtn.BackColor = _btnHighlightColor;
        moveNavigationPanel(resourceBtn);

        this.pnlFormLoader.Controls.Clear();


        var frmHomepage = new frmResource()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };

        this.pnlFormLoader.Controls.Add(frmHomepage);
        frmHomepage.Show();
    }

    private void settingsBtn_Click(object sender, EventArgs e)
    {
        settingsBtn.BackColor = _btnHighlightColor;
        moveNavigationPanel(settingsBtn);
        this.pnlFormLoader.Controls.Clear();
    }

    private void calendarBtn_Click(object sender, EventArgs e)
    {
        calendarBtn.BackColor = _btnHighlightColor;
        moveNavigationPanel(calendarBtn);
        this.pnlFormLoader.Controls.Clear();
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

    private void btnRetrieve_Click(object sender, EventArgs e)
    {
        btnRetrieve.BackColor = _btnHighlightColor;
        moveNavigationPanel(btnRetrieve);
        this.pnlFormLoader.Controls.Clear();

        var frmHomepage = new frmRetrievePrescription()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };

        this.pnlFormLoader.Controls.Add(frmHomepage);
        frmHomepage.Show();
    }

    private void moveNavigationPanel(Button pressedBtn)
    {
        pnlNav.Height = pressedBtn.Height;
        pnlNav.Top = pressedBtn.Top;
        pnlNav.Left = pressedBtn.Left;
    }
}
