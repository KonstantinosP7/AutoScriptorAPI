using MaterialSkin.Controls;

namespace AutoScriptorForm;

public partial class frmAddResource : MaterialForm
{
    public OxygenDevice? device;
    public frmAddResource()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        device = new OxygenDevice()
        {
            Code = txtCode.Text,
            DateCreated = txtDateOfBuy.Text,
            TimesUsed = 0,
            Manufacturer = txtManufacturer.Text
        };

        if (!string.IsNullOrEmpty(device.Code))
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        else
        {
            MessageBox.Show("Παρακαλώ εισάγετε κωδικό νέου μηχανήματος", "Λάθος Εισόδου", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
