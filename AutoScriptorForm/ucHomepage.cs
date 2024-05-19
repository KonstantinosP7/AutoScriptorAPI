using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScriptorForm
{
    public partial class ucHomepage : UserControl
    {
        public ucHomepage()
        {
            InitializeComponent();
            LoadListView1();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void LoadListView1()
        {
            DateTime startDate = DateTime.Now.AddDays(1);

            for (int i = 0; i < 10; i++)
            {
                string prescriptionNumber = $"{i + 1:000}";
                DateTime executionDate = startDate.AddDays(i);
                string aa = $"{i + 1:000}";
                string amka = $"{i + 1:000}";
                DateTime issueDate = DateTime.Now;
                DateTime endDate = DateTime.Now.AddMonths(1);
                string device = $"Device{i + 1}";

                AddListView1(prescriptionNumber, executionDate, aa, amka, issueDate, endDate, device);
            }

            startDate = DateTime.Now.AddDays(-10);

            for (int i = 0; i < 50; i++)
            {
                string prescriptionNumber = $"{i + 1:000}";
                DateTime executionDate = startDate.AddDays(i);
                string aa = $"{i + 1:000}";
                string amka = $"{i + 1:000}";
                DateTime issueDate = DateTime.Now;
                DateTime endDate = DateTime.Now.AddMonths(1);
                string device = $"Device{i + 1}";

                AddListView2(prescriptionNumber, executionDate, aa, amka, issueDate, endDate, device);
            }
        }

        private void AddListView1(string prescriptionNumber, DateTime executionDate, string aa, string amka, DateTime issueDate, DateTime endDate, string device)
        {
            ListViewItem item = new(prescriptionNumber);
            item.SubItems.Add(executionDate.ToString("yyyy-MM-dd"));
            item.SubItems.Add(aa);
            item.SubItems.Add(amka);
            item.SubItems.Add(issueDate.ToString("yyyy-MM-dd"));
            item.SubItems.Add(endDate.ToString("yyyy-MM-dd"));
            item.SubItems.Add(device);

            materialListView1.Items.Add(item);
        }

        private void AddListView2(string prescriptionNumber, DateTime executionDate, string aa, string amka, DateTime issueDate, DateTime endDate, string device)
        {
            ListViewItem item = new(prescriptionNumber);
            item.SubItems.Add(executionDate.ToString("yyyy-MM-dd"));
            item.SubItems.Add(aa);
            item.SubItems.Add(amka);
            item.SubItems.Add(issueDate.ToString("yyyy-MM-dd"));
            item.SubItems.Add(endDate.ToString("yyyy-MM-dd"));
            item.SubItems.Add(device);

            materialListView2.Items.Add(item);
        }
    }
}
