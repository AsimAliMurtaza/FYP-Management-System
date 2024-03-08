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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudentsUC));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.viewStdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateStdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteStdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.backBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RegNoTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.fNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.LNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ContactTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.DoB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.addStdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator3 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator4 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator5 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator6 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator7 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator8 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.viewStdBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.updateStdBtn, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.deleteStdBtn, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.backBtn, 0, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(205, 449);
            this.tableLayoutPanel2.TabIndex = 1;
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
            this.viewStdBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewStdBtn.Image")));
            this.viewStdBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.viewStdBtn.Location = new System.Drawing.Point(4, 60);
            this.viewStdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewStdBtn.Name = "viewStdBtn";
            this.viewStdBtn.ShadowDecoration.Parent = this.viewStdBtn;
            this.viewStdBtn.Size = new System.Drawing.Size(197, 48);
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
            this.updateStdBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateStdBtn.Image")));
            this.updateStdBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.updateStdBtn.Location = new System.Drawing.Point(4, 172);
            this.updateStdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateStdBtn.Name = "updateStdBtn";
            this.updateStdBtn.ShadowDecoration.Parent = this.updateStdBtn;
            this.updateStdBtn.Size = new System.Drawing.Size(197, 48);
            this.updateStdBtn.TabIndex = 10;
            this.updateStdBtn.Text = "Update Student";
            this.updateStdBtn.Click += new System.EventHandler(this.updateStdBtn_Click);
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
            this.deleteStdBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteStdBtn.Image")));
            this.deleteStdBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.deleteStdBtn.Location = new System.Drawing.Point(4, 284);
            this.deleteStdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteStdBtn.Name = "deleteStdBtn";
            this.deleteStdBtn.ShadowDecoration.Parent = this.deleteStdBtn;
            this.deleteStdBtn.Size = new System.Drawing.Size(197, 48);
            this.deleteStdBtn.TabIndex = 18;
            this.deleteStdBtn.Text = "Delete Student";
            this.deleteStdBtn.Click += new System.EventHandler(this.deleteStdBtn_Click);
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
            this.backBtn.Location = new System.Drawing.Point(4, 396);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.ShadowDecoration.Parent = this.backBtn;
            this.backBtn.Size = new System.Drawing.Size(197, 49);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "Back";
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.RegNoTxt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fNameTxt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.LNameTxt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ContactTxt, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.emailTxt, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.DoB, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.genderCB, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.addStdBtn, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.guna2VSeparator1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2VSeparator2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2VSeparator3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.guna2VSeparator4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.guna2VSeparator5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.guna2VSeparator6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.guna2VSeparator8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.guna2VSeparator7, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(205, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 449);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.RegNoTxt.Location = new System.Drawing.Point(81, 61);
            this.RegNoTxt.Margin = new System.Windows.Forms.Padding(5);
            this.RegNoTxt.Name = "RegNoTxt";
            this.RegNoTxt.PasswordChar = '\0';
            this.RegNoTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.RegNoTxt.PlaceholderText = "Registeration Number";
            this.RegNoTxt.SelectedText = "";
            this.RegNoTxt.ShadowDecoration.Parent = this.RegNoTxt;
            this.RegNoTxt.Size = new System.Drawing.Size(218, 46);
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
            this.fNameTxt.Location = new System.Drawing.Point(309, 61);
            this.fNameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.PasswordChar = '\0';
            this.fNameTxt.PlaceholderText = "First Name";
            this.fNameTxt.SelectedText = "";
            this.fNameTxt.ShadowDecoration.Parent = this.fNameTxt;
            this.fNameTxt.Size = new System.Drawing.Size(218, 46);
            this.fNameTxt.TabIndex = 5;
            this.fNameTxt.TextChanged += new System.EventHandler(this.fNameTxt_TextChanged);
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
            this.LNameTxt.Location = new System.Drawing.Point(81, 173);
            this.LNameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.LNameTxt.Name = "LNameTxt";
            this.LNameTxt.PasswordChar = '\0';
            this.LNameTxt.PlaceholderText = "Last Name";
            this.LNameTxt.SelectedText = "";
            this.LNameTxt.ShadowDecoration.Parent = this.LNameTxt;
            this.LNameTxt.Size = new System.Drawing.Size(218, 46);
            this.LNameTxt.TabIndex = 6;
            this.LNameTxt.TextChanged += new System.EventHandler(this.LNameTxt_TextChanged);
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
            this.ContactTxt.Location = new System.Drawing.Point(309, 173);
            this.ContactTxt.Margin = new System.Windows.Forms.Padding(5);
            this.ContactTxt.Name = "ContactTxt";
            this.ContactTxt.PasswordChar = '\0';
            this.ContactTxt.PlaceholderText = "Contact";
            this.ContactTxt.SelectedText = "";
            this.ContactTxt.ShadowDecoration.Parent = this.ContactTxt;
            this.ContactTxt.Size = new System.Drawing.Size(218, 46);
            this.ContactTxt.TabIndex = 0;
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
            this.emailTxt.Location = new System.Drawing.Point(81, 285);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(5);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.PlaceholderText = "Email";
            this.emailTxt.SelectedText = "";
            this.emailTxt.ShadowDecoration.Parent = this.emailTxt;
            this.emailTxt.Size = new System.Drawing.Size(218, 46);
            this.emailTxt.TabIndex = 7;
            // 
            // DoB
            // 
            this.DoB.BorderRadius = 12;
            this.DoB.CheckedState.Parent = this.DoB;
            this.DoB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.DoB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DoB.HoverState.Parent = this.DoB;
            this.DoB.Location = new System.Drawing.Point(308, 284);
            this.DoB.Margin = new System.Windows.Forms.Padding(4);
            this.DoB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DoB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DoB.Name = "DoB";
            this.DoB.ShadowDecoration.Parent = this.DoB;
            this.DoB.Size = new System.Drawing.Size(220, 48);
            this.DoB.TabIndex = 8;
            this.DoB.Value = new System.DateTime(2024, 3, 2, 12, 56, 47, 890);
            // 
            // genderCB
            // 
            this.genderCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Location = new System.Drawing.Point(80, 402);
            this.genderCB.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(220, 24);
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
            this.addStdBtn.Image = ((System.Drawing.Image)(resources.GetObject("addStdBtn.Image")));
            this.addStdBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.addStdBtn.Location = new System.Drawing.Point(536, 396);
            this.addStdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addStdBtn.Name = "addStdBtn";
            this.addStdBtn.ShadowDecoration.Parent = this.addStdBtn;
            this.addStdBtn.Size = new System.Drawing.Size(220, 49);
            this.addStdBtn.TabIndex = 12;
            this.addStdBtn.Text = "Add Student";
            this.addStdBtn.Click += new System.EventHandler(this.addStdBtn_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2VSeparator1.Location = new System.Drawing.Point(3, 3);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(62, 50);
            this.guna2VSeparator1.TabIndex = 13;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2VSeparator2.Location = new System.Drawing.Point(3, 59);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(62, 50);
            this.guna2VSeparator2.TabIndex = 14;
            // 
            // guna2VSeparator3
            // 
            this.guna2VSeparator3.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2VSeparator3.Location = new System.Drawing.Point(3, 115);
            this.guna2VSeparator3.Name = "guna2VSeparator3";
            this.guna2VSeparator3.Size = new System.Drawing.Size(62, 50);
            this.guna2VSeparator3.TabIndex = 15;
            // 
            // guna2VSeparator4
            // 
            this.guna2VSeparator4.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2VSeparator4.Location = new System.Drawing.Point(3, 171);
            this.guna2VSeparator4.Name = "guna2VSeparator4";
            this.guna2VSeparator4.Size = new System.Drawing.Size(62, 50);
            this.guna2VSeparator4.TabIndex = 16;
            // 
            // guna2VSeparator5
            // 
            this.guna2VSeparator5.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2VSeparator5.Location = new System.Drawing.Point(3, 227);
            this.guna2VSeparator5.Name = "guna2VSeparator5";
            this.guna2VSeparator5.Size = new System.Drawing.Size(62, 50);
            this.guna2VSeparator5.TabIndex = 17;
            // 
            // guna2VSeparator6
            // 
            this.guna2VSeparator6.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2VSeparator6.Location = new System.Drawing.Point(3, 283);
            this.guna2VSeparator6.Name = "guna2VSeparator6";
            this.guna2VSeparator6.Size = new System.Drawing.Size(62, 50);
            this.guna2VSeparator6.TabIndex = 18;
            // 
            // guna2VSeparator7
            // 
            this.guna2VSeparator7.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2VSeparator7.Location = new System.Drawing.Point(3, 395);
            this.guna2VSeparator7.Name = "guna2VSeparator7";
            this.guna2VSeparator7.Size = new System.Drawing.Size(62, 51);
            this.guna2VSeparator7.TabIndex = 19;
            // 
            // guna2VSeparator8
            // 
            this.guna2VSeparator8.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2VSeparator8.Location = new System.Drawing.Point(3, 339);
            this.guna2VSeparator8.Name = "guna2VSeparator8";
            this.guna2VSeparator8.Size = new System.Drawing.Size(62, 50);
            this.guna2VSeparator8.TabIndex = 20;
            // 
            // ManageStudentsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageStudentsUC";
            this.Size = new System.Drawing.Size(965, 449);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button updateStdBtn;
        private Guna.UI2.WinForms.Guna2Button viewStdBtn;
        private Guna.UI2.WinForms.Guna2Button deleteStdBtn;
        private Guna.UI2.WinForms.Guna2TextBox RegNoTxt;
        private Guna.UI2.WinForms.Guna2TextBox fNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox LNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox ContactTxt;
        private Guna.UI2.WinForms.Guna2TextBox emailTxt;
        private Guna.UI2.WinForms.Guna2DateTimePicker DoB;
        private System.Windows.Forms.ComboBox genderCB;
        private Guna.UI2.WinForms.Guna2Button backBtn;
        private Guna.UI2.WinForms.Guna2Button addStdBtn;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator3;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator4;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator5;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator6;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator8;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator7;
    }
}
