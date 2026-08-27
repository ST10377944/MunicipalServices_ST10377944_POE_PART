using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace MunicipalServices
{
    public partial class ReportIssuesForm : Form
    {
        private string attachmentPath = "";
        private int reportCount = 0;
        private List<IssueReport> issues = new List<IssueReport>();

        // Gamification elements
        private int pointsEarned = 0;
        private const int POINTS_PER_REPORT = 10;
        private const int BONUS_POINTS_ATTACHMENT = 5;

        public ReportIssuesForm()
        {
            InitializeComponent();
        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {
            // Populate category dropdown
            cmbCategory.Items.Add("Sanitation");
            cmbCategory.Items.Add("Roads");
            cmbCategory.Items.Add("Utilities");
            cmbCategory.Items.Add("Public Safety");
            cmbCategory.Items.Add("Waste Management");
            cmbCategory.Items.Add("Housing");
            cmbCategory.Items.Add("Other");

            cmbCategory.SelectedIndex = 0;

            // Initialize engagement
            progressEngagement.Maximum = 100;
            progressEngagement.Value = 0;
            lblEngagementMessage.Text = "Start reporting to earn points!";
            lblEngagementMessage.ForeColor = System.Drawing.Color.FromArgb(0, 120, 200);
        }

        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Document Files|*.pdf;*.doc;*.docx;*.txt|All Files|*.*";
                openFileDialog.Title = "Select Media to Attach";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    attachmentPath = openFileDialog.FileName;
                    lblAttachmentStatus.Text = $"Attached: {Path.GetFileName(attachmentPath)}";
                    lblAttachmentStatus.ForeColor = System.Drawing.Color.Green;

                    // Update engagement - bonus for attachment
                    UpdateEngagement("attachment");
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter a location for the issue.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please provide a description of the issue.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
                return;
            }

            // Create issue report
            IssueReport issue = new IssueReport
            {
                Location = txtLocation.Text,
                Category = cmbCategory.SelectedItem.ToString(),
                Description = txtDescription.Text,
                AttachmentPath = attachmentPath,
                ReportDate = DateTime.Now,
                Status = "Submitted"
            };

            issues.Add(issue);
            reportCount++;

            // Update engagement
            UpdateEngagement("report");

            // Show success message
            MessageBox.Show($"Issue reported successfully!\n\nLocation: {issue.Location}\nCategory: {issue.Category}\nStatus: {issue.Status}\n\nTotal Reports: {reportCount}\nPoints Earned: {pointsEarned}",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Clear form for next entry
            ClearForm();
        }

        private void UpdateEngagement(string actionType)
        {
            // Update points
            if (actionType == "report")
            {
                pointsEarned += POINTS_PER_REPORT;
            }
            else if (actionType == "attachment")
            {
                pointsEarned += BONUS_POINTS_ATTACHMENT;
            }

            // Update progress bar (capped at 100)
            int progressValue = Math.Min(pointsEarned, 100);
            progressEngagement.Value = progressValue;

            // Update engagement messages based on points
            string message = "";
            Color messageColor = System.Drawing.Color.FromArgb(0, 120, 200);

            if (pointsEarned >= 100)
            {
                message = "🌟 Master Reporter! You've earned all possible points!";
                messageColor = System.Drawing.Color.Gold;
            }
            else if (pointsEarned >= 50)
            {
                message = "💪 Community Champion! Keep up the great work!";
                messageColor = System.Drawing.Color.FromArgb(0, 180, 0);
            }
            else if (pointsEarned >= 30)
            {
                message = "👏 Excellent progress! You're making a difference!";
                messageColor = System.Drawing.Color.FromArgb(0, 150, 200);
            }
            else if (pointsEarned >= 20)
            {
                message = "👍 Great start! Continue reporting issues!";
                messageColor = System.Drawing.Color.FromArgb(0, 120, 200);
            }
            else if (pointsEarned >= 10)
            {
                message = "⭐ Good job! Every report helps improve our community!";
                messageColor = System.Drawing.Color.FromArgb(0, 120, 200);
            }
            else
            {
                message = "📝 Submit your first report to earn points!";
                messageColor = System.Drawing.Color.FromArgb(0, 120, 200);
            }

            // Check for badge achievements
            if (reportCount == 1)
            {
                message += "\n🏅 Achievement: First Report!";
            }
            else if (reportCount == 5)
            {
                message += "\n🏅 Achievement: Community Contributor!";
            }
            else if (reportCount == 10)
            {
                message += "\n🏅 Achievement: Community Champion!";
            }

            lblEngagementMessage.Text = message;
            lblEngagementMessage.ForeColor = messageColor;
            lblPointsEarned.Text = $"Points: {pointsEarned}";

            // Update status
            lblStatus.Text = $"Reports: {reportCount} | Status: Active";
        }

        private void ClearForm()
        {
            txtLocation.Clear();
            txtDescription.Clear();
            cmbCategory.SelectedIndex = 0;
            attachmentPath = "";
            lblAttachmentStatus.Text = "No file attached";
            lblAttachmentStatus.ForeColor = System.Drawing.Color.Gray;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear all fields?",
                "Clear Form",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ClearForm();
            }
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            if (issues.Count == 0)
            {
                MessageBox.Show("No reports have been submitted yet.", "Reports",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string reportList = "=== Reported Issues ===\n\n";
            foreach (var issue in issues)
            {
                reportList += $"Location: {issue.Location}\n";
                reportList += $"Category: {issue.Category}\n";
                reportList += $"Description: {issue.Description.Substring(0, Math.Min(issue.Description.Length, 50))}...\n";
                reportList += $"Status: {issue.Status}\n";
                reportList += $"Date: {issue.ReportDate:yyyy-MM-dd HH:mm}\n";
                reportList += new string('-', 40) + "\n\n";
            }

            MessageBox.Show(reportList, "All Reports",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}