namespace MunicipalServices
{
    partial class LocalEventsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Label lblCategoryFilter;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.RichTextBox txtEventDetails;
        private System.Windows.Forms.Label lblRecommendations;
        private System.Windows.Forms.ListBox lstRecommendations;
        private System.Windows.Forms.Button btnLoadEvents;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblQueueInfo;

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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.lblCategoryFilter = new System.Windows.Forms.Label();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.txtEventDetails = new System.Windows.Forms.RichTextBox();
            this.lblRecommendations = new System.Windows.Forms.Label();
            this.lstRecommendations = new System.Windows.Forms.ListBox();
            this.btnLoadEvents = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblQueueInfo = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // ═══════════════════════════════════════════════════════════
            // TITLE
            // ═══════════════════════════════════════════════════════════
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 70, 140);
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(560, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📅 Local Events & Announcements";

            // ═══════════════════════════════════════════════════════════
            // HEADER LINE
            // ═══════════════════════════════════════════════════════════
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(0, 70, 140);
            this.panelHeader.Location = new System.Drawing.Point(0, 65);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1920, 6);
            this.panelHeader.TabIndex = 1;

            // ═══════════════════════════════════════════════════════════
            // SEARCH
            // ═══════════════════════════════════════════════════════════
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(30, 90);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(80, 22);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "🔍 Search:";

            this.txtSearch.Font = new System.Drawing.Font("Arial", 14F);
            this.txtSearch.Location = new System.Drawing.Point(125, 87);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(350, 29);
            this.txtSearch.TabIndex = 3;

            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 120, 200);
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(490, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 32);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.Font = new System.Drawing.Font("Arial", 14F);
            this.btnClearSearch.Location = new System.Drawing.Point(620, 85);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(110, 32);
            this.btnClearSearch.TabIndex = 5;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);

            // ═══════════════════════════════════════════════════════════
            // CATEGORY FILTER
            // ═══════════════════════════════════════════════════════════
            this.lblCategoryFilter.AutoSize = true;
            this.lblCategoryFilter.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblCategoryFilter.Location = new System.Drawing.Point(780, 90);
            this.lblCategoryFilter.Name = "lblCategoryFilter";
            this.lblCategoryFilter.Size = new System.Drawing.Size(100, 22);
            this.lblCategoryFilter.TabIndex = 6;
            this.lblCategoryFilter.Text = "📂 Category:";

            this.cmbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFilter.Font = new System.Drawing.Font("Arial", 14F);
            this.cmbCategoryFilter.Location = new System.Drawing.Point(890, 87);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(300, 30);
            this.cmbCategoryFilter.TabIndex = 7;
            this.cmbCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryFilter_SelectedIndexChanged);

            // ═══════════════════════════════════════════════════════════
            // EVENTS LISTBOX
            // ═══════════════════════════════════════════════════════════
            this.lstEvents.Font = new System.Drawing.Font("Arial", 13F);
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 20;
            this.lstEvents.Location = new System.Drawing.Point(30, 135);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(700, 544);
            this.lstEvents.TabIndex = 8;
            this.lstEvents.SelectedIndexChanged += new System.EventHandler(this.lstEvents_SelectedIndexChanged);

            // ═══════════════════════════════════════════════════════════
            // EVENT DETAILS
            // ═══════════════════════════════════════════════════════════
            this.txtEventDetails.Font = new System.Drawing.Font("Arial", 13F);
            this.txtEventDetails.Location = new System.Drawing.Point(750, 135);
            this.txtEventDetails.Name = "txtEventDetails";
            this.txtEventDetails.Size = new System.Drawing.Size(650, 340);
            this.txtEventDetails.TabIndex = 9;
            this.txtEventDetails.ReadOnly = true;

            // ═══════════════════════════════════════════════════════════
            // RECOMMENDATIONS
            // ═══════════════════════════════════════════════════════════
            this.lblRecommendations.AutoSize = true;
            this.lblRecommendations.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblRecommendations.ForeColor = System.Drawing.Color.FromArgb(0, 120, 200);
            this.lblRecommendations.Location = new System.Drawing.Point(750, 495);
            this.lblRecommendations.Name = "lblRecommendations";
            this.lblRecommendations.Size = new System.Drawing.Size(230, 22);
            this.lblRecommendations.TabIndex = 10;
            this.lblRecommendations.Text = "⭐ Recommended for You:";

            this.lstRecommendations.Font = new System.Drawing.Font("Arial", 13F);
            this.lstRecommendations.FormattingEnabled = true;
            this.lstRecommendations.ItemHeight = 20;
            this.lstRecommendations.Location = new System.Drawing.Point(750, 520);
            this.lstRecommendations.Name = "lstRecommendations";
            this.lstRecommendations.Size = new System.Drawing.Size(650, 160);
            this.lstRecommendations.TabIndex = 11;
            this.lstRecommendations.SelectedIndexChanged += new System.EventHandler(this.lstRecommendations_SelectedIndexChanged);

            // ═══════════════════════════════════════════════════════════
            // BUTTONS
            // ═══════════════════════════════════════════════════════════
            this.btnLoadEvents.BackColor = System.Drawing.Color.FromArgb(0, 180, 60);
            this.btnLoadEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadEvents.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnLoadEvents.ForeColor = System.Drawing.Color.White;
            this.btnLoadEvents.Location = new System.Drawing.Point(30, 700);
            this.btnLoadEvents.Name = "btnLoadEvents";
            this.btnLoadEvents.Size = new System.Drawing.Size(220, 50);
            this.btnLoadEvents.TabIndex = 12;
            this.btnLoadEvents.Text = "📥 Load Events";
            this.btnLoadEvents.UseVisualStyleBackColor = false;
            this.btnLoadEvents.Click += new System.EventHandler(this.btnLoadEvents_Click);

            this.btnBack.BackColor = System.Drawing.Color.FromArgb(200, 70, 70);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1200, 700);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 50);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "↩ Back to Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // ═══════════════════════════════════════════════════════════
            // STATUS LABELS
            // ═══════════════════════════════════════════════════════════
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic);
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(30, 765);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(180, 17);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Ready to load events...";

            this.lblQueueInfo.AutoSize = true;
            this.lblQueueInfo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic);
            this.lblQueueInfo.ForeColor = System.Drawing.Color.FromArgb(0, 120, 200);
            this.lblQueueInfo.Location = new System.Drawing.Point(750, 765);
            this.lblQueueInfo.Name = "lblQueueInfo";
            this.lblQueueInfo.Size = new System.Drawing.Size(200, 17);
            this.lblQueueInfo.TabIndex = 15;
            this.lblQueueInfo.Text = "Priority Queue: 0 events";

            // ═══════════════════════════════════════════════════════════
            // LOCAL EVENTS FORM - SCROLLABLE
            // ═══════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.lblQueueInfo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLoadEvents);
            this.Controls.Add(this.lstRecommendations);
            this.Controls.Add(this.lblRecommendations);
            this.Controls.Add(this.txtEventDetails);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.cmbCategoryFilter);
            this.Controls.Add(this.lblCategoryFilter);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "LocalEventsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Events and Announcements - Municipal Services";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LocalEventsForm_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}