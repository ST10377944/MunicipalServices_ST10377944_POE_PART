namespace MunicipalServices
{
    partial class ReportIssuesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.Button btnAttachMedia;
        private System.Windows.Forms.Label lblAttachmentStatus;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblEngagementMessage;
        private System.Windows.Forms.ProgressBar progressEngagement;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPointsEarned;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Panel panelHeader;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.btnAttachMedia = new System.Windows.Forms.Button();
            this.lblAttachmentStatus = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblEngagementMessage = new System.Windows.Forms.Label();
            this.progressEngagement = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPointsEarned = new System.Windows.Forms.Label();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();

            this.SuspendLayout();

            // ═══════════════════════════════════════════════════════════
            // TITLE
            // ═══════════════════════════════════════════════════════════
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 70, 140);
            this.lblTitle.Location = new System.Drawing.Point(40, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📝 Report Issues";

            // ═══════════════════════════════════════════════════════════
            // HEADER LINE
            // ═══════════════════════════════════════════════════════════
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(0, 70, 140);
            this.panelHeader.Location = new System.Drawing.Point(0, 85);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1920, 6);
            this.panelHeader.TabIndex = 1;

            // ═══════════════════════════════════════════════════════════
            // LOCATION
            // ═══════════════════════════════════════════════════════════
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblLocation.Location = new System.Drawing.Point(40, 120);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(105, 25);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "📍 Location:*";

            this.txtLocation.Font = new System.Drawing.Font("Arial", 16F);
            this.txtLocation.Location = new System.Drawing.Point(40, 155);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(1000, 32);
            this.txtLocation.TabIndex = 3;

            // ═══════════════════════════════════════════════════════════
            // CATEGORY
            // ═══════════════════════════════════════════════════════════
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(40, 210);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(108, 25);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "📂 Category:*";

            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Arial", 16F);
            this.cmbCategory.Location = new System.Drawing.Point(40, 245);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(1000, 33);
            this.cmbCategory.TabIndex = 5;

            // ═══════════════════════════════════════════════════════════
            // DESCRIPTION
            // ═══════════════════════════════════════════════════════════
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(40, 300);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(128, 25);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "📝 Description:*";

            this.txtDescription.Font = new System.Drawing.Font("Arial", 14F);
            this.txtDescription.Location = new System.Drawing.Point(40, 335);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(1000, 160);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Text = "";

            // ═══════════════════════════════════════════════════════════
            // ATTACHMENT
            // ═══════════════════════════════════════════════════════════
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblAttachment.Location = new System.Drawing.Point(40, 510);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(118, 25);
            this.lblAttachment.TabIndex = 8;
            this.lblAttachment.Text = "📎 Attachment:";

            this.btnAttachMedia.BackColor = System.Drawing.Color.FromArgb(0, 120, 200);
            this.btnAttachMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachMedia.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnAttachMedia.ForeColor = System.Drawing.Color.White;
            this.btnAttachMedia.Location = new System.Drawing.Point(40, 545);
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.Size = new System.Drawing.Size(220, 45);
            this.btnAttachMedia.TabIndex = 9;
            this.btnAttachMedia.Text = "📁 Attach Media";
            this.btnAttachMedia.UseVisualStyleBackColor = false;
            this.btnAttachMedia.Click += new System.EventHandler(this.btnAttachMedia_Click);

            this.lblAttachmentStatus.AutoSize = true;
            this.lblAttachmentStatus.Font = new System.Drawing.Font("Arial", 14F);
            this.lblAttachmentStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblAttachmentStatus.Location = new System.Drawing.Point(280, 555);
            this.lblAttachmentStatus.Name = "lblAttachmentStatus";
            this.lblAttachmentStatus.Size = new System.Drawing.Size(140, 22);
            this.lblAttachmentStatus.TabIndex = 10;
            this.lblAttachmentStatus.Text = "No file attached";

            // ═══════════════════════════════════════════════════════════
            // ENGAGEMENT FEATURES
            // ═══════════════════════════════════════════════════════════
            this.lblEngagementMessage.AutoSize = true;
            this.lblEngagementMessage.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblEngagementMessage.ForeColor = System.Drawing.Color.FromArgb(0, 120, 200);
            this.lblEngagementMessage.Location = new System.Drawing.Point(40, 620);
            this.lblEngagementMessage.Name = "lblEngagementMessage";
            this.lblEngagementMessage.Size = new System.Drawing.Size(380, 25);
            this.lblEngagementMessage.TabIndex = 11;
            this.lblEngagementMessage.Text = "⭐ Start reporting to earn points!";

            this.progressEngagement.Location = new System.Drawing.Point(40, 660);
            this.progressEngagement.Name = "progressEngagement";
            this.progressEngagement.Size = new System.Drawing.Size(600, 40);
            this.progressEngagement.TabIndex = 12;

            this.lblPointsEarned.AutoSize = true;
            this.lblPointsEarned.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblPointsEarned.ForeColor = System.Drawing.Color.FromArgb(0, 70, 140);
            this.lblPointsEarned.Location = new System.Drawing.Point(660, 670);
            this.lblPointsEarned.Name = "lblPointsEarned";
            this.lblPointsEarned.Size = new System.Drawing.Size(110, 25);
            this.lblPointsEarned.TabIndex = 13;
            this.lblPointsEarned.Text = "🏆 Points: 0";

            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(40, 715);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(220, 18);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "📊 Reports: 0 | Status: Active";

            // ═══════════════════════════════════════════════════════════
            // BUTTONS
            // ═══════════════════════════════════════════════════════════
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(0, 180, 60);
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(40, 760);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 55);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "✓ Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.btnClear.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 16F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnClear.Location = new System.Drawing.Point(260, 760);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 55);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "🗑 Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnViewReports.BackColor = System.Drawing.Color.FromArgb(0, 120, 200);
            this.btnViewReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReports.Font = new System.Drawing.Font("Arial", 16F);
            this.btnViewReports.ForeColor = System.Drawing.Color.White;
            this.btnViewReports.Location = new System.Drawing.Point(430, 760);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(200, 55);
            this.btnViewReports.TabIndex = 17;
            this.btnViewReports.Text = "📋 View Reports";
            this.btnViewReports.UseVisualStyleBackColor = false;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);

            this.btnBack.BackColor = System.Drawing.Color.FromArgb(200, 70, 70);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(650, 760);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 55);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "↩ Back to Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // ═══════════════════════════════════════════════════════════
            // REPORT ISSUES FORM - SCROLLABLE
            // ═══════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPointsEarned);
            this.Controls.Add(this.progressEngagement);
            this.Controls.Add(this.lblEngagementMessage);
            this.Controls.Add(this.lblAttachmentStatus);
            this.Controls.Add(this.btnAttachMedia);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "ReportIssuesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Issues - Municipal Services";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportIssuesForm_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}