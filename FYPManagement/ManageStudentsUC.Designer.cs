namespace FYPManagement
{
    partial class ManageStudentsUC
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
            this.backBtn = new Guna.UI2.WinForms.Guna2Button();
            this.viewStdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateStdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegNoTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.fNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ContactTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.DoB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.addStdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteStdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.backBtn, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.RegNoTxt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.genderCB, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.LNameTxt, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.fNameTxt, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.emailTxt, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ContactTxt, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.DoB, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.addStdBtn, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.deleteStdBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.viewStdBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.updateStdBtn, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 449);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.BorderRadius = 10;
            this.backBtn.CheckedState.Parent = this.backBtn;
            this.backBtn.CustomImages.Parent = this.backBtn;
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.HoverState.Parent = this.backBtn;
            this.backBtn.Location = new System.Drawing.Point(4, 356);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.ShadowDecoration.Parent = this.backBtn;
            this.backBtn.Size = new System.Drawing.Size(185, 36);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "Back";
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // viewStdBtn
            // 
            this.viewStdBtn.BorderRadius = 10;
            this.viewStdBtn.CheckedState.Parent = this.viewStdBtn;
            this.viewStdBtn.CustomImages.Parent = this.viewStdBtn;
            this.viewStdBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewStdBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.viewStdBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewStdBtn.ForeColor = System.Drawing.Color.White;
            this.viewStdBtn.HoverState.Parent = this.viewStdBtn;
            this.viewStdBtn.Location = new System.Drawing.Point(390, 48);
            this.viewStdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewStdBtn.Name = "viewStdBtn";
            this.viewStdBtn.ShadowDecoration.Parent = this.viewStdBtn;
            this.viewStdBtn.Size = new System.Drawing.Size(185, 36);
            this.viewStdBtn.TabIndex = 11;
            this.viewStdBtn.Text = "View Students";
            this.viewStdBtn.Click += new System.EventHandler(this.viewStdBtn_Click);
            // 
            // updateStdBtn
            // 
            this.updateStdBtn.BorderRadius = 10;
            this.updateStdBtn.CheckedState.Parent = this.updateStdBtn;
            this.updateStdBtn.CustomImages.Parent = this.updateStdBtn;
            this.updateStdBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateStdBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.updateStdBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateStdBtn.ForeColor = System.Drawing.Color.White;
            this.updateStdBtn.HoverState.Parent = this.updateStdBtn;
            this.updateStdBtn.Location = new System.Drawing.Point(197, 48);
            this.updateStdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateStdBtn.Name = "updateStdBtn";
            this.updateStdBtn.ShadowDecoration.Parent = this.updateStdBtn;
            this.updateStdBtn.Size = new System.Drawing.Size(185, 36);
            this.updateStdBtn.TabIndex = 10;
            this.updateStdBtn.Text = "Update Student";
            this.updateStdBtn.Click += new System.EventHandler(this.updateStdBtn_Click);
            // 
            // LNameTxt
            // 
            this.LNameTxt.BorderRadius = 12;
            this.LNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LNameTxt.DefaultText = "";
            this.LNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LNameTxt.DisabledState.Parent = this.LNameTxt;
            this.LNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LNameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LNameTxt.FocusedState.Parent = this.LNameTxt;
            this.LNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LNameTxt.HoverState.Parent = this.LNameTxt;
            this.LNameTxt.Location = new System.Drawing.Point(198, 225);
            this.LNameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.LNameTxt.Name = "LNameTxt";
            this.LNameTxt.PasswordChar = '\0';
            this.LNameTxt.PlaceholderText = "Last Name";
            this.LNameTxt.SelectedText = "";
            this.LNameTxt.ShadowDecoration.Parent = this.LNameTxt;
            this.LNameTxt.Size = new System.Drawing.Size(183, 34);
            this.LNameTxt.TabIndex = 6;
            // 
            // RegNoTxt
            // 
            this.RegNoTxt.BorderRadius = 10;
            this.RegNoTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegNoTxt.DefaultText = "";
            this.RegNoTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegNoTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegNoTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegNoTxt.DisabledState.Parent = this.RegNoTxt;
            this.RegNoTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegNoTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegNoTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegNoTxt.FocusedState.Parent = this.RegNoTxt;
            this.RegNoTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegNoTxt.HoverState.Parent = this.RegNoTxt;
            this.RegNoTxt.Location = new System.Drawing.Point(198, 137);
            this.RegNoTxt.Margin = new System.Windows.Forms.Padding(5);
            this.RegNoTxt.Name = "RegNoTxt";
            this.RegNoTxt.PasswordChar = '\0';
            this.RegNoTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.RegNoTxt.PlaceholderText = "Registeration Number";
            this.RegNoTxt.SelectedText = "";
            this.RegNoTxt.ShadowDecoration.Parent = this.RegNoTxt;
            this.RegNoTxt.Size = new System.Drawing.Size(183, 34);
            this.RegNoTxt.TabIndex = 4;
            // 
            // fNameTxt
            // 
            this.fNameTxt.BorderRadius = 12;
            this.fNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fNameTxt.DefaultText = "";
            this.fNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fNameTxt.DisabledState.Parent = this.fNameTxt;
            this.fNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fNameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fNameTxt.FocusedState.Parent = this.fNameTxt;
            this.fNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fNameTxt.HoverState.Parent = this.fNameTxt;
            this.fNameTxt.Location = new System.Drawing.Point(198, 181);
            this.fNameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.PasswordChar = '\0';
            this.fNameTxt.PlaceholderText = "First Name";
            this.fNameTxt.SelectedText = "";
            this.fNameTxt.ShadowDecoration.Parent = this.fNameTxt;
            this.fNameTxt.Size = new System.Drawing.Size(183, 34);
            this.fNameTxt.TabIndex = 5;
            // 
            // emailTxt
            // 
            this.emailTxt.BorderRadius = 12;
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxt.DefaultText = "";
            this.emailTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.DisabledState.Parent = this.emailTxt;
            this.emailTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTxt.FocusedState.Parent = this.emailTxt;
            this.emailTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTxt.HoverState.Parent = this.emailTxt;
            this.emailTxt.Location = new System.Drawing.Point(198, 269);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(5);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.PlaceholderText = "Email";
            this.emailTxt.SelectedText = "";
            this.emailTxt.ShadowDecoration.Parent = this.emailTxt;
            this.emailTxt.Size = new System.Drawing.Size(183, 34);
            this.emailTxt.TabIndex = 7;
            // 
            // ContactTxt
            // 
            this.ContactTxt.BorderRadius = 12;
            this.ContactTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ContactTxt.DefaultText = "";
            this.ContactTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ContactTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ContactTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ContactTxt.DisabledState.Parent = this.ContactTxt;
            this.ContactTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ContactTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ContactTxt.FocusedState.Parent = this.ContactTxt;
            this.ContactTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ContactTxt.HoverState.Parent = this.ContactTxt;
            this.ContactTxt.Location = new System.Drawing.Point(391, 137);
            this.ContactTxt.Margin = new System.Windows.Forms.Padding(5);
            this.ContactTxt.Name = "ContactTxt";
            this.ContactTxt.PasswordChar = '\0';
            this.ContactTxt.PlaceholderText = "Contact";
            this.ContactTxt.SelectedText = "";
            this.ContactTxt.ShadowDecoration.Parent = this.ContactTxt;
            this.ContactTxt.Size = new System.Drawing.Size(183, 34);
            this.ContactTxt.TabIndex = 0;
            // 
            // DoB
            // 
            this.DoB.BorderRadius = 12;
            this.DoB.CheckedState.Parent = this.DoB;
            this.DoB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.DoB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DoB.HoverState.Parent = this.DoB;
            this.DoB.Location = new System.Drawing.Point(390, 180);
            this.DoB.Margin = new System.Windows.Forms.Padding(4);
            this.DoB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DoB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DoB.Name = "DoB";
            this.DoB.ShadowDecoration.Parent = this.DoB;
            this.DoB.Size = new System.Drawing.Size(185, 36);
            this.DoB.TabIndex = 8;
            this.DoB.Value = new System.DateTime(2024, 3, 2, 12, 56, 47, 890);
            // 
            // genderCB
            // 
            this.genderCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Location = new System.Drawing.Point(390, 230);
            this.genderCB.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(185, 24);
            this.genderCB.TabIndex = 9;
            // 
            // addStdBtn
            // 
            this.addStdBtn.BorderRadius = 10;
            this.addStdBtn.CheckedState.Parent = this.addStdBtn;
            this.addStdBtn.CustomImages.Parent = this.addStdBtn;
            this.addStdBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStdBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.addStdBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addStdBtn.ForeColor = System.Drawing.Color.White;
            this.addStdBtn.HoverState.Parent = this.addStdBtn;
            this.addStdBtn.Location = new System.Drawing.Point(390, 312);
            this.addStdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addStdBtn.Name = "addStdBtn";
            this.addStdBtn.ShadowDecoration.Parent = this.addStdBtn;
            this.addStdBtn.Size = new System.Drawing.Size(185, 36);
            this.addStdBtn.TabIndex = 12;
            this.addStdBtn.Text = "Add Student";
            this.addStdBtn.Click += new System.EventHandler(this.addStdBtn_Click);
            // 
            // deleteStdBtn
            // 
            this.deleteStdBtn.BorderRadius = 10;
            this.deleteStdBtn.CheckedState.Parent = this.deleteStdBtn;
            this.deleteStdBtn.CustomImages.Parent = this.deleteStdBtn;
            this.deleteStdBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteStdBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.deleteStdBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteStdBtn.ForeColor = System.Drawing.Color.White;
            this.deleteStdBtn.HoverState.Parent = this.deleteStdBtn;
            this.deleteStdBtn.Location = new System.Drawing.Point(583, 48);
            this.deleteStdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteStdBtn.Name = "deleteStdBtn";
            this.deleteStdBtn.ShadowDecoration.Parent = this.deleteStdBtn;
            this.deleteStdBtn.Size = new System.Drawing.Size(185, 36);
            this.deleteStdBtn.TabIndex = 18;
            this.deleteStdBtn.Text = "Delete Student";
            // 
            // ManageStudentsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageStudentsUC";
            this.Size = new System.Drawing.Size(965, 449);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox ContactTxt;
        private Guna.UI2.WinForms.Guna2TextBox RegNoTxt;
        private Guna.UI2.WinForms.Guna2TextBox fNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox LNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox emailTxt;
        private Guna.UI2.WinForms.Guna2DateTimePicker DoB;
        private System.Windows.Forms.ComboBox genderCB;
        private Guna.UI2.WinForms.Guna2Button updateStdBtn;
        private Guna.UI2.WinForms.Guna2Button viewStdBtn;
        private Guna.UI2.WinForms.Guna2Button backBtn;
        private Guna.UI2.WinForms.Guna2Button addStdBtn;
        private Guna.UI2.WinForms.Guna2Button deleteStdBtn;
    }
}
