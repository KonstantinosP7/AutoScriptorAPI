using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoScriptorForm
{
    public partial class frmResource : Form
    {
        public frmResource()
        {
            InitializeComponent();
            PopulateListView();
        }

        private void PopulateListView()
        {
            // Add columns to the ListView
            tblDevices.Columns.Add("Code", 100);
            tblDevices.Columns.Add("Machine State", 100);
            tblDevices.Columns.Add("Used Until", 100);
            tblDevices.Columns.Add("Date of Buy", 100);
            tblDevices.Columns.Add("Times Used", 100);
            tblDevices.Columns.Add("Manufacturer", 100);

            // Add items for oxygen devices
            AddOxygenDevice("Oxy001", "Working", DateTime.Now.AddDays(30), DateTime.Now.AddMonths(-6), 50, "ABC Company");
            AddOxygenDevice("Oxy002", "Not Working", DateTime.Now.AddDays(-5), DateTime.Now.AddYears(-1), 100, "XYZ Corp");
            AddOxygenDevice("Oxy003", "Working", DateTime.Now.AddDays(15), DateTime.Now.AddMonths(-3), 25, "ABC Company");
            AddOxygenDevice("Oxy004", "Working", DateTime.Now.AddDays(10), DateTime.Now.AddMonths(-2), 75, "XYZ Corp");
            AddOxygenDevice("Oxy005", "Not Working", DateTime.Now.AddDays(20), DateTime.Now.AddMonths(-4), 30, "ABC Company");
            AddOxygenDevice("Oxy006", "Working", DateTime.Now.AddDays(25), DateTime.Now.AddMonths(-1), 40, "XYZ Corp");
            AddOxygenDevice("Oxy007", "Working", DateTime.Now.AddDays(40), DateTime.Now.AddMonths(-5), 90, "ABC Company");
            AddOxygenDevice("Oxy008", "Not Working", DateTime.Now.AddDays(5), DateTime.Now.AddYears(-2), 20, "XYZ Corp");
            AddOxygenDevice("Oxy009", "Working", DateTime.Now.AddDays(12), DateTime.Now.AddMonths(-3), 55, "ABC Company");
            AddOxygenDevice("Oxy010", "Working", DateTime.Now.AddDays(8), DateTime.Now.AddMonths(-1), 65, "XYZ Corp");
            AddOxygenDevice("Oxy011", "Not Working", DateTime.Now.AddDays(22), DateTime.Now.AddMonths(-4), 85, "ABC Company");
            AddOxygenDevice("Oxy012", "Working", DateTime.Now.AddDays(18), DateTime.Now.AddYears(-1), 95, "XYZ Corp");
        }

        private void AddOxygenDevice(string code, string machineState, DateTime usedUntil, DateTime dateOfBuy, int timesUsed, string manufacturer)
        {
            ListViewItem item = new ListViewItem(code);
            item.SubItems.Add(machineState);
            item.SubItems.Add(usedUntil.ToString("yyyy-MM-dd"));
            item.SubItems.Add(dateOfBuy.ToString("yyyy-MM-dd"));
            item.SubItems.Add(timesUsed.ToString());
            item.SubItems.Add(manufacturer);

            tblDevices.Items.Add(item);
        }
    }
}
