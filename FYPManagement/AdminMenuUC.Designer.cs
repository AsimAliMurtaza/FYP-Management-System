﻿namespace FYPManagement
{
    partial class AdminMenuUC
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
            this.mngStdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.mngAdvBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ManageProjectsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ManageEvalBtn = new Guna.UI2.WinForms.Guna2Button();
            this.logOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.manageGroupsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.mngStdBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mngAdvBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ManageProjectsBtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ManageEvalBtn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.logOutBtn, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.manageGroupsBtn, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1043, 486);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // mngStdBtn
            // 
            this.mngStdBtn.BorderRadius = 20;
            this.mngStdBtn.CheckedState.Parent = this.mngStdBtn;
            this.mngStdBtn.CustomImages.Parent = this.mngStdBtn;
            this.mngStdBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mngStdBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.mngStdBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mngStdBtn.ForeColor = System.Drawing.Color.White;
            this.mngStdBtn.HoverState.Parent = this.mngStdBtn;
            this.mngStdBtn.Location = new System.Drawing.Point(264, 73);
            this.mngStdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.mngStdBtn.Name = "mngStdBtn";
            this.mngStdBtn.ShadowDecoration.Parent = this.mngStdBtn;
            this.mngStdBtn.Size = new System.Drawing.Size(513, 61);
            this.mngStdBtn.TabIndex = 0;
            this.mngStdBtn.Text = "Manage Students";
            this.mngStdBtn.Click += new System.EventHandler(this.mngStdBtn_Click);
            // 
            // mngAdvBtn
            // 
            this.mngAdvBtn.BorderRadius = 20;
            this.mngAdvBtn.CheckedState.Parent = this.mngAdvBtn;
            this.mngAdvBtn.CustomImages.Parent = this.mngAdvBtn;
            this.mngAdvBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mngAdvBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.mngAdvBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mngAdvBtn.ForeColor = System.Drawing.Color.White;
            this.mngAdvBtn.HoverState.Parent = this.mngAdvBtn;
            this.mngAdvBtn.Location = new System.Drawing.Point(264, 142);
            this.mngAdvBtn.Margin = new System.Windows.Forms.Padding(4);
            this.mngAdvBtn.Name = "mngAdvBtn";
            this.mngAdvBtn.ShadowDecoration.Parent = this.mngAdvBtn;
            this.mngAdvBtn.Size = new System.Drawing.Size(513, 61);
            this.mngAdvBtn.TabIndex = 1;
            this.mngAdvBtn.Text = "Manage Advisors";
            this.mngAdvBtn.Click += new System.EventHandler(this.mngAdvBtn_Click);
            // 
            // ManageProjectsBtn
            // 
            this.ManageProjectsBtn.BorderRadius = 20;
            this.ManageProjectsBtn.CheckedState.Parent = this.ManageProjectsBtn;
            this.ManageProjectsBtn.CustomImages.Parent = this.ManageProjectsBtn;
            this.ManageProjectsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageProjectsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.ManageProjectsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ManageProjectsBtn.ForeColor = System.Drawing.Color.White;
            this.ManageProjectsBtn.HoverState.Parent = this.ManageProjectsBtn;
            this.ManageProjectsBtn.Location = new System.Drawing.Point(264, 211);
            this.ManageProjectsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ManageProjectsBtn.Name = "ManageProjectsBtn";
            this.ManageProjectsBtn.ShadowDecoration.Parent = this.ManageProjectsBtn;
            this.ManageProjectsBtn.Size = new System.Drawing.Size(513, 61);
            this.ManageProjectsBtn.TabIndex = 2;
            this.ManageProjectsBtn.Text = "Manage Projects";
            this.ManageProjectsBtn.Click += new System.EventHandler(this.ManageProjectsBtn_Click);
            // 
            // ManageEvalBtn
            // 
            this.ManageEvalBtn.BorderRadius = 20;
            this.ManageEvalBtn.CheckedState.Parent = this.ManageEvalBtn;
            this.ManageEvalBtn.CustomImages.Parent = this.ManageEvalBtn;
            this.ManageEvalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageEvalBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.ManageEvalBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ManageEvalBtn.ForeColor = System.Drawing.Color.White;
            this.ManageEvalBtn.HoverState.Parent = this.ManageEvalBtn;
            this.ManageEvalBtn.Location = new System.Drawing.Point(264, 280);
            this.ManageEvalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ManageEvalBtn.Name = "ManageEvalBtn";
            this.ManageEvalBtn.ShadowDecoration.Parent = this.ManageEvalBtn;
            this.ManageEvalBtn.Size = new System.Drawing.Size(513, 61);
            this.ManageEvalBtn.TabIndex = 3;
            this.ManageEvalBtn.Text = "Manage Evaluations";
            this.ManageEvalBtn.Click += new System.EventHandler(this.ManageEvalBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BorderRadius = 20;
            this.logOutBtn.CheckedState.Parent = this.logOutBtn;
            this.logOutBtn.CustomImages.Parent = this.logOutBtn;
            this.logOutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.logOutBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.HoverState.Parent = this.logOutBtn;
            this.logOutBtn.Location = new System.Drawing.Point(4, 418);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.ShadowDecoration.Parent = this.logOutBtn;
            this.logOutBtn.Size = new System.Drawing.Size(252, 64);
            this.logOutBtn.TabIndex = 4;
            this.logOutBtn.Text = "Log Out";
            // 
            // manageGroupsBtn
            // 
            this.manageGroupsBtn.BorderRadius = 20;
            this.manageGroupsBtn.CheckedState.Parent = this.manageGroupsBtn;
            this.manageGroupsBtn.CustomImages.Parent = this.manageGroupsBtn;
            this.manageGroupsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageGroupsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.manageGroupsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.manageGroupsBtn.ForeColor = System.Drawing.Color.White;
            this.manageGroupsBtn.HoverState.Parent = this.manageGroupsBtn;
            this.manageGroupsBtn.Location = new System.Drawing.Point(264, 349);
            this.manageGroupsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.manageGroupsBtn.Name = "manageGroupsBtn";
            this.manageGroupsBtn.ShadowDecoration.Parent = this.manageGroupsBtn;
            this.manageGroupsBtn.Size = new System.Drawing.Size(513, 61);
            this.manageGroupsBtn.TabIndex = 5;
            this.manageGroupsBtn.Text = "Manage Groups";
            this.manageGroupsBtn.Click += new System.EventHandler(this.manageGroupsBtn_Click);
            // 
            // AdminMenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMenuUC";
            this.Size = new System.Drawing.Size(1043, 486);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button mngStdBtn;
        private Guna.UI2.WinForms.Guna2Button mngAdvBtn;
        private Guna.UI2.WinForms.Guna2Button ManageProjectsBtn;
        private Guna.UI2.WinForms.Guna2Button ManageEvalBtn;
        private Guna.UI2.WinForms.Guna2Button logOutBtn;
        private Guna.UI2.WinForms.Guna2Button manageGroupsBtn;
    }
}
