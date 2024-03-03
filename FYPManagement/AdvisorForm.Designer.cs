namespace FYPManagement
{
    partial class AdvisorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.adminHeader = new System.Windows.Forms.Label();
            this.MainTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.MainTableLayout.ColumnCount = 1;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.Controls.Add(this.MainPanel, 0, 1);
            this.MainTableLayout.Controls.Add(this.adminHeader, 0, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Margin = new System.Windows.Forms.Padding(4);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 2;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.6776F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.3224F));
            this.MainTableLayout.Size = new System.Drawing.Size(1067, 554);
            this.MainTableLayout.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(4, 129);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.ShadowDecoration.Parent = this.MainPanel;
            this.MainPanel.Size = new System.Drawing.Size(1059, 421);
            this.MainPanel.TabIndex = 0;
            // 
            // adminHeader
            // 
            this.adminHeader.AutoSize = true;
            this.adminHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminHeader.Font = new System.Drawing.Font("Comic Sans MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminHeader.ForeColor = System.Drawing.Color.White;
            this.adminHeader.Location = new System.Drawing.Point(4, 0);
            this.adminHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adminHeader.Name = "adminHeader";
            this.adminHeader.Size = new System.Drawing.Size(1059, 125);
            this.adminHeader.TabIndex = 1;
            this.adminHeader.Text = "ADMIN ki DASH mein BOARD";
            this.adminHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminHeader.Click += new System.EventHandler(this.adminHeader_Click);
            // 
            // AdvisorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.MainTableLayout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdvisorForm";
            this.Text = "AdvisorForm";
            this.Load += new System.EventHandler(this.AdvisorForm_Load);
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private System.Windows.Forms.Label adminHeader;
    }
}