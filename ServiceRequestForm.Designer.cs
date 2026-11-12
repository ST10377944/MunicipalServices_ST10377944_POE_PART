namespace MunicipalServices
{
    partial class ServiceRequestForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.ListBox lstRequests;
        private System.Windows.Forms.RichTextBox rtbDetails;
        private System.Windows.Forms.Button btnProcessPriority;
        private System.Windows.Forms.Button btnShowMST;
        private System.Windows.Forms.Button btnBack;

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
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.lstRequests = new System.Windows.Forms.ListBox();
            this.rtbDetails = new System.Windows.Forms.RichTextBox();
            this.btnProcessPriority = new System.Windows.Forms.Button();
            this.btnShowMST = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 70, 140);
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(480, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📊 Service Request Status";

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(0, 70, 140);
            this.panelHeader.Location = new System.Drawing.Point(0, 65);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1920, 6);

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(30, 90);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(160, 22);
            this.lblSearch.Text = "🔍 Search ID (BST):";

            // txtSearchId
            this.txtSearchId.Font = new System.Drawing.Font("Arial", 14F);
            this.txtSearchId.Location = new System.Drawing.Point(200, 87);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(150, 29);

            // btnSearch
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 120, 200);
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(360, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 32);
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnLoadData
            this.btnLoadData.BackColor = System.Drawing.Color.FromArgb(0, 180, 60);
            this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoadData.ForeColor = System.Drawing.Color.White;
            this.btnLoadData.Location = new System.Drawing.Point(480, 85);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(150, 32);
            this.btnLoadData.Text = "📥 Load Data";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);

            // lstRequests
            this.lstRequests.Font = new System.Drawing.Font("Arial", 12F);
            this.lstRequests.FormattingEnabled = true;
            this.lstRequests.ItemHeight = 18;
            this.lstRequests.Location = new System.Drawing.Point(30, 140);
            this.lstRequests.Name = "lstRequests";
            this.lstRequests.Size = new System.Drawing.Size(600, 454);

            // rtbDetails
            this.rtbDetails.Font = new System.Drawing.Font("Arial", 12F);
            this.rtbDetails.Location = new System.Drawing.Point(650, 140);
            this.rtbDetails.Name = "rtbDetails";
            this.rtbDetails.Size = new System.Drawing.Size(650, 454);
            this.rtbDetails.ReadOnly = true;

            // btnProcessPriority
            this.btnProcessPriority.BackColor = System.Drawing.Color.FromArgb(200, 100, 0); // Orange
            this.btnProcessPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessPriority.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnProcessPriority.ForeColor = System.Drawing.Color.White;
            this.btnProcessPriority.Location = new System.Drawing.Point(30, 620);
            this.btnProcessPriority.Name = "btnProcessPriority";
            this.btnProcessPriority.Size = new System.Drawing.Size(280, 50);
            this.btnProcessPriority.Text = "⚠️ Process Priority (Min-Heap)";
            this.btnProcessPriority.UseVisualStyleBackColor = false;
            this.btnProcessPriority.Click += new System.EventHandler(this.btnProcessPriority_Click);

            // btnShowMST
            this.btnShowMST.BackColor = System.Drawing.Color.FromArgb(150, 0, 150); // Purple
            this.btnShowMST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMST.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnShowMST.ForeColor = System.Drawing.Color.White;
            this.btnShowMST.Location = new System.Drawing.Point(330, 620);
            this.btnShowMST.Name = "btnShowMST";
            this.btnShowMST.Size = new System.Drawing.Size(300, 50);
            this.btnShowMST.Text = "🗺️ Optimise Routes (MST)";
            this.btnShowMST.UseVisualStyleBackColor = false;
            this.btnShowMST.Click += new System.EventHandler(this.btnShowMST_Click);

            // btnBack
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(200, 70, 70);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1100, 620);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 50);
            this.btnBack.Text = "↩ Back to Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // ServiceRequestForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnShowMST);
            this.Controls.Add(this.btnProcessPriority);
            this.Controls.Add(this.rtbDetails);
            this.Controls.Add(this.lstRequests);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchId);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.Name = "ServiceRequestForm";
            this.Text = "Service Request Status - Municipal Services";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ServiceRequestForm_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}