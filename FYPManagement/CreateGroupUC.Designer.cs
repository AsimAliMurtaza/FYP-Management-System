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
            this.createdOn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BackBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.createGrpBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createdOn
            // 
            this.createdOn.BorderRadius = 12;
            this.createdOn.CheckedState.Parent = this.createdOn;
            this.createdOn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createdOn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.createdOn.HoverState.Parent = this.createdOn;
            this.createdOn.Location = new System.Drawing.Point(327, 160);
            this.createdOn.Margin = new System.Windows.Forms.Padding(4);
            this.createdOn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.createdOn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.createdOn.Name = "createdOn";
            this.createdOn.ShadowDecoration.Parent = this.createdOn;
            this.createdOn.Size = new System.Drawing.Size(278, 44);
            this.createdOn.TabIndex = 8;
            this.createdOn.Value = new System.DateTime(2024, 3, 2, 12, 56, 47, 890);
            this.createdOn.ValueChanged += new System.EventHandler(this.createdOn_ValueChanged);
            // 
            // BackBtn
            // 
            this.BackBtn.CheckedState.Parent = this.BackBtn;
            this.BackBtn.CustomImages.Parent = this.BackBtn;
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.HoverState.Parent = this.BackBtn;
            this.BackBtn.Location = new System.Drawing.Point(4, 419);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BackBtn.ShadowDecoration.Parent = this.BackBtn;
            this.BackBtn.Size = new System.Drawing.Size(44, 45);
            this.BackBtn.TabIndex = 13;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.768555F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.38467F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.92338F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.92339F));
            this.tableLayoutPanel1.Controls.Add(this.BackBtn, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.createdOn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.createGrpBtn, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.85185F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.37037F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(896, 468);
            this.tableLayoutPanel1.TabIndex = 5;
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
            this.createGrpBtn.Location = new System.Drawing.Point(327, 264);
            this.createGrpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.createGrpBtn.Name = "createGrpBtn";
            this.createGrpBtn.ShadowDecoration.Parent = this.createGrpBtn;
            this.createGrpBtn.Size = new System.Drawing.Size(278, 44);
            this.createGrpBtn.TabIndex = 12;
            this.createGrpBtn.Text = "Create Group";
            this.createGrpBtn.Click += new System.EventHandler(this.createGrpBtn_Click);
            // 
            // CreateGroupUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreateGroupUC";
            this.Size = new System.Drawing.Size(896, 468);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker createdOn;
        private Guna.UI2.WinForms.Guna2CircleButton BackBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button createGrpBtn;
    }
}
