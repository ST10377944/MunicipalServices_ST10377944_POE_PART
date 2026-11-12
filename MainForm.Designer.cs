namespace MunicipalServices
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblTitle;
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
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();

            this.SuspendLayout();

            // ═══════════════════════════════════════════════════════════
            // TITLE
            // ═══════════════════════════════════════════════════════════
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 70, 140);
            this.lblTitle.Location = new System.Drawing.Point(50, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(620, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Municipal Services Application";

            // ═══════════════════════════════════════════════════════════
            // HEADER LINE
            // ═══════════════════════════════════════════════════════════
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(0, 70, 140);
            this.panelHeader.Location = new System.Drawing.Point(0, 110);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1920, 8);
            this.panelHeader.TabIndex = 1;

            // ═══════════════════════════════════════════════════════════
            // WELCOME LABEL
            // ═══════════════════════════════════════════════════════════
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(0, 70, 140);
            this.lblWelcome.Location = new System.Drawing.Point(50, 150);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(150, 32);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome!";

            // ═══════════════════════════════════════════════════════════
            // INSTRUCTIONS LABEL
            // ═══════════════════════════════════════════════════════════
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular);
            this.lblInstructions.Location = new System.Drawing.Point(50, 200);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(520, 25);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Please select one of the options below to continue.";

            // ═══════════════════════════════════════════════════════════
            // REPORT ISSUES BUTTON
            // ═══════════════════════════════════════════════════════════
            this.btnReportIssues.BackColor = System.Drawing.Color.FromArgb(0, 120, 200);
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssues.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnReportIssues.ForeColor = System.Drawing.Color.White;
            this.btnReportIssues.Location = new System.Drawing.Point(55, 260);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(700, 80);
            this.btnReportIssues.TabIndex = 4;
            this.btnReportIssues.Text = "📋 Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);

            // ═══════════════════════════════════════════════════════════
            // EVENTS BUTTON
            // ═══════════════════════════════════════════════════════════
            this.btnEvents.BackColor = System.Drawing.Color.FromArgb(0, 120, 200);
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnEvents.ForeColor = System.Drawing.Color.White;
            this.btnEvents.Location = new System.Drawing.Point(55, 360);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(700, 80);
            this.btnEvents.TabIndex = 5;
            this.btnEvents.Text = "📅 Local Events and Announcements";
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);

            // ═══════════════════════════════════════════════════════════
            // STATUS BUTTON (Disabled)
            // ═══════════════════════════════════════════════════════════
            this.btnStatus.BackColor = System.Drawing.Color.FromArgb(0, 120, 200);
            this.btnStatus.Enabled = true;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(55, 460);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(700, 80);
            this.btnStatus.TabIndex = 6;
            this.btnStatus.Text = "📊 Service Request Status";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);

            // ═══════════════════════════════════════════════════════════
            // EXIT BUTTON
            // ═══════════════════════════════════════════════════════════
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(200, 70, 70);
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(55, 570);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 60);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "✖ Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // ═══════════════════════════════════════════════════════════
            // MAIN FORM - SCROLLABLE
            // ═══════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municipal Services Application - South Africa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}