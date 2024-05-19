using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScriptorForm;

public partial class ucSettings : UserControl
{
    public ucSettings()
    {
        InitializeComponent();
        PreLoadThemeSwitch();
    }

    private void swtMode_CheckedChanged(object sender, EventArgs e)
    {
        ChangeTheme();
    }

    private void ChangeTheme()
    {
        var materialSkinManager = MaterialSkinManager.Instance;
        if(swtMode.Checked) 
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
        else
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }        
    }

    private void PreLoadThemeSwitch()
    {
        var materialSkinManager = MaterialSkinManager.Instance;
        if(materialSkinManager.Theme == MaterialSkinManager.Themes.LIGHT)
        {
            swtMode.Checked = true;
        }
        else
        {
            swtMode.Checked = false;
        }
    }
}
