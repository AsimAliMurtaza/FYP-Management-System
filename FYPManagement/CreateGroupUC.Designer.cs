namespace FYPManagement
{
    partial class CreateGroupUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.createGrpBtn = new Guna.UI2.WinForms.Guna2Button();
            this.createdOn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.9962F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.88973F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.createGrpBtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.createdOn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2Button1, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1052, 571);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(4, 514);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(97, 53);
            this.guna2Button1.TabIndex = 24;
            this.guna2Button1.Text = "Back";
            this.guna2Button1.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // createGrpBtn
            // 
            this.createGrpBtn.BorderRadius = 10;
            this.createGrpBtn.CheckedState.Parent = this.createGrpBtn;
            this.createGrpBtn.CustomImages.Parent = this.createGrpBtn;
            this.createGrpBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createGrpBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.createGrpBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createGrpBtn.ForeColor = System.Drawing.Color.White;
            this.createGrpBtn.HoverState.Parent = this.createGrpBtn;
            this.createGrpBtn.Location = new System.Drawing.Point(393, 259);
            this.createGrpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.createGrpBtn.Name = "createGrpBtn";
            this.createGrpBtn.ShadowDecoration.Parent = this.createGrpBtn;
            this.createGrpBtn.Size = new System.Drawing.Size(338, 77);
            this.createGrpBtn.TabIndex = 23;
            this.createGrpBtn.Text = "Create Group";
            this.createGrpBtn.Click += new System.EventHandler(this.createGrpBtn_Click);
            // 
            // createdOn
            // 
            this.createdOn.BorderRadius = 12;
            this.createdOn.CheckedState.Parent = this.createdOn;
            this.createdOn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createdOn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.createdOn.HoverState.Parent = this.createdOn;
            this.createdOn.Location = new System.Drawing.Point(393, 89);
            this.createdOn.Margin = new System.Windows.Forms.Padding(4);
            this.createdOn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.createdOn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.createdOn.Name = "createdOn";
            this.createdOn.ShadowDecoration.Parent = this.createdOn;
            this.createdOn.Size = new System.Drawing.Size(338, 77);
            this.createdOn.TabIndex = 22;
            this.createdOn.Value = new System.DateTime(2024, 3, 2, 12, 56, 47, 890);
            // 
            // CreateGroupUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreateGroupUC";
            this.Size = new System.Drawing.Size(1052, 571);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button createGrpBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker createdOn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
