using System;
using System.Windows.Forms;

namespace MunicipalServices
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnEvents.Enabled = false;
            btnStatus.Enabled = false;
            this.Text = "Municipal Services Application - South Africa";
            lblWelcome.Text = "Welcome to Municipal Services!";
            lblWelcome.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportForm = new ReportIssuesForm();
            reportForm.ShowDialog();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be available in a future update.",
                "Not Available",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be available in a future update.",
                "Not Available",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}