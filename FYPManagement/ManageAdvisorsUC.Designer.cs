namespace FYPManagement
{
    partial class ManageAdvisorsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAdvisorsUC));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.viewAdvBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateAdvbtn = new Guna.UI2.WinForms.Guna2Button();
            this.delBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.LNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ContactTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.DOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.EmailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SalaryTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.designationsCB = new System.Windows.Forms.ComboBox();
            this.addAdvBtn = new Guna.UI2.WinForms.Guna2Button();
            this.GenderCB = new System.Windows.Forms.ComboBox();
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 295F));
            this.tableLayoutPanel2.Controls.Add(this.viewAdvBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.updateAdvbtn, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.delBtn, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.BackBtn, 0, 7);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(295, 519);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // viewAdvBtn
            // 
            this.viewAdvBtn.BorderRadius = 10;
            this.viewAdvBtn.CheckedState.Parent = this.viewAdvBtn;
            this.viewAdvBtn.CustomImages.Parent = this.viewAdvBtn;
            this.viewAdvBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAdvBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.viewAdvBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewAdvBtn.ForeColor = System.Drawing.Color.White;
            this.viewAdvBtn.HoverState.Parent = this.viewAdvBtn;
            this.viewAdvBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewAdvBtn.Image")));
            this.viewAdvBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.viewAdvBtn.Location = new System.Drawing.Point(4, 68);
            this.viewAdvBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewAdvBtn.Name = "viewAdvBtn";
            this.viewAdvBtn.ShadowDecoration.Parent = this.viewAdvBtn;
            this.viewAdvBtn.Size = new System.Drawing.Size(287, 56);
            this.viewAdvBtn.TabIndex = 11;
            this.viewAdvBtn.Text = "View Advisors";
            this.viewAdvBtn.Click += new System.EventHandler(this.viewAdvBtn_Click);
            // 
            // updateAdvbtn
            // 
            this.updateAdvbtn.BorderRadius = 10;
            this.updateAdvbtn.CheckedState.Parent = this.updateAdvbtn;
            this.updateAdvbtn.CustomImages.Parent = this.updateAdvbtn;
            this.updateAdvbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateAdvbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.updateAdvbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateAdvbtn.ForeColor = System.Drawing.Color.White;
            this.updateAdvbtn.HoverState.Parent = this.updateAdvbtn;
            this.updateAdvbtn.Image = ((System.Drawing.Image)(resources.GetObject("updateAdvbtn.Image")));
            this.updateAdvbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.updateAdvbtn.Location = new System.Drawing.Point(4, 196);
            this.updateAdvbtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateAdvbtn.Name = "updateAdvbtn";
            this.updateAdvbtn.ShadowDecoration.Parent = this.updateAdvbtn;
            this.updateAdvbtn.Size = new System.Drawing.Size(287, 56);
            this.updateAdvbtn.TabIndex = 10;
            this.updateAdvbtn.Text = "Update Advisor";
            this.updateAdvbtn.Click += new System.EventHandler(this.updateAdvbtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BorderRadius = 10;
            this.delBtn.CheckedState.Parent = this.delBtn;
            this.delBtn.CustomImages.Parent = this.delBtn;
            this.delBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.delBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delBtn.ForeColor = System.Drawing.Color.White;
            this.delBtn.HoverState.Parent = this.delBtn;
            this.delBtn.Image = ((System.Drawing.Image)(resources.GetObject("delBtn.Image")));
            this.delBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.delBtn.Location = new System.Drawing.Point(4, 324);
            this.delBtn.Margin = new System.Windows.Forms.Padding(4);
            this.delBtn.Name = "delBtn";
            this.delBtn.ShadowDecoration.Parent = this.delBtn;
            this.delBtn.Size = new System.Drawing.Size(287, 56);
            this.delBtn.TabIndex = 26;
            this.delBtn.Text = "Delete Advisor";
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BorderRadius = 10;
            this.BackBtn.CheckedState.Parent = this.BackBtn;
            this.BackBtn.CustomImages.Parent = this.BackBtn;
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.HoverState.Parent = this.BackBtn;
            this.BackBtn.Location = new System.Drawing.Point(4, 452);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.ShadowDecoration.Parent = this.BackBtn;
            this.BackBtn.Size = new System.Drawing.Size(287, 63);
            this.BackBtn.TabIndex = 25;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.guna2VSeparator2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FNameTxt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LNameTxt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ContactTxt, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.DOB, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.EmailTxt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.SalaryTxt, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.designationsCB, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.addAdvBtn, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.GenderCB, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.guna2VSeparator1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2VSeparator3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.guna2VSeparator4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.guna2VSeparator5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.guna2VSeparator6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.guna2VSeparator7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.guna2VSeparator8, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(295, 0);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 519);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // FNameTxt
            // 
            this.FNameTxt.BorderRadius = 10;
            this.FNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FNameTxt.DefaultText = "";
            this.FNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FNameTxt.DisabledState.Parent = this.FNameTxt;
            this.FNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FNameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FNameTxt.FocusedState.Parent = this.FNameTxt;
            this.FNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FNameTxt.HoverState.Parent = this.FNameTxt;
            this.FNameTxt.Location = new System.Drawing.Point(70, 69);
            this.FNameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.FNameTxt.Name = "FNameTxt";
            this.FNameTxt.PasswordChar = '\0';
            this.FNameTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.FNameTxt.PlaceholderText = "First Name";
            this.FNameTxt.SelectedText = "";
            this.FNameTxt.ShadowDecoration.Parent = this.FNameTxt;
            this.FNameTxt.Size = new System.Drawing.Size(242, 54);
            this.FNameTxt.TabIndex = 4;
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
            this.LNameTxt.Location = new System.Drawing.Point(322, 69);
            this.LNameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.LNameTxt.Name = "LNameTxt";
            this.LNameTxt.PasswordChar = '\0';
            this.LNameTxt.PlaceholderText = "Last Name";
            this.LNameTxt.SelectedText = "";
            this.LNameTxt.ShadowDecoration.Parent = this.LNameTxt;
            this.LNameTxt.Size = new System.Drawing.Size(242, 54);
            this.LNameTxt.TabIndex = 5;
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
            this.ContactTxt.Location = new System.Drawing.Point(322, 197);
            this.ContactTxt.Margin = new System.Windows.Forms.Padding(5);
            this.ContactTxt.Name = "ContactTxt";
            this.ContactTxt.PasswordChar = '\0';
            this.ContactTxt.PlaceholderText = "Contact";
            this.ContactTxt.SelectedText = "";
            this.ContactTxt.ShadowDecoration.Parent = this.ContactTxt;
            this.ContactTxt.Size = new System.Drawing.Size(242, 54);
            this.ContactTxt.TabIndex = 7;
            // 
            // DOB
            // 
            this.DOB.BorderRadius = 12;
            this.DOB.CheckedState.Parent = this.DOB;
            this.DOB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DOB.HoverState.Parent = this.DOB;
            this.DOB.Location = new System.Drawing.Point(69, 324);
            this.DOB.Margin = new System.Windows.Forms.Padding(4);
            this.DOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DOB.Name = "DOB";
            this.DOB.ShadowDecoration.Parent = this.DOB;
            this.DOB.Size = new System.Drawing.Size(244, 56);
            this.DOB.TabIndex = 8;
            this.DOB.Value = new System.DateTime(2024, 3, 2, 12, 56, 47, 890);
            // 
            // EmailTxt
            // 
            this.EmailTxt.BorderRadius = 12;
            this.EmailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTxt.DefaultText = "";
            this.EmailTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxt.DisabledState.Parent = this.EmailTxt;
            this.EmailTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxt.FocusedState.Parent = this.EmailTxt;
            this.EmailTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxt.HoverState.Parent = this.EmailTxt;
            this.EmailTxt.Location = new System.Drawing.Point(70, 197);
            this.EmailTxt.Margin = new System.Windows.Forms.Padding(5);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.PasswordChar = '\0';
            this.EmailTxt.PlaceholderText = "Email";
            this.EmailTxt.SelectedText = "";
            this.EmailTxt.ShadowDecoration.Parent = this.EmailTxt;
            this.EmailTxt.Size = new System.Drawing.Size(242, 54);
            this.EmailTxt.TabIndex = 6;
            // 
            // SalaryTxt
            // 
            this.SalaryTxt.BorderRadius = 12;
            this.SalaryTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SalaryTxt.DefaultText = "";
            this.SalaryTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SalaryTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SalaryTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalaryTxt.DisabledState.Parent = this.SalaryTxt;
            this.SalaryTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalaryTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalaryTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalaryTxt.FocusedState.Parent = this.SalaryTxt;
            this.SalaryTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalaryTxt.HoverState.Parent = this.SalaryTxt;
            this.SalaryTxt.Location = new System.Drawing.Point(322, 325);
            this.SalaryTxt.Margin = new System.Windows.Forms.Padding(5);
            this.SalaryTxt.Name = "SalaryTxt";
            this.SalaryTxt.PasswordChar = '\0';
            this.SalaryTxt.PlaceholderText = "Salary";
            this.SalaryTxt.SelectedText = "";
            this.SalaryTxt.ShadowDecoration.Parent = this.SalaryTxt;
            this.SalaryTxt.Size = new System.Drawing.Size(242, 54);
            this.SalaryTxt.TabIndex = 0;
            // 
            // designationsCB
            // 
            this.designationsCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designationsCB.FormattingEnabled = true;
            this.designationsCB.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assistant Professor",
            "Lecturer"});
            this.designationsCB.Location = new System.Drawing.Point(69, 452);
            this.designationsCB.Margin = new System.Windows.Forms.Padding(4);
            this.designationsCB.Name = "designationsCB";
            this.designationsCB.Size = new System.Drawing.Size(244, 24);
            this.designationsCB.TabIndex = 14;
            // 
            // addAdvBtn
            // 
            this.addAdvBtn.BorderRadius = 10;
            this.addAdvBtn.CheckedState.Parent = this.addAdvBtn;
            this.addAdvBtn.CustomImages.Parent = this.addAdvBtn;
            this.addAdvBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addAdvBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.addAdvBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addAdvBtn.ForeColor = System.Drawing.Color.White;
            this.addAdvBtn.HoverState.Parent = this.addAdvBtn;
            this.addAdvBtn.Image = ((System.Drawing.Image)(resources.GetObject("addAdvBtn.Image")));
            this.addAdvBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.addAdvBtn.Location = new System.Drawing.Point(573, 452);
            this.addAdvBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addAdvBtn.Name = "addAdvBtn";
            this.addAdvBtn.ShadowDecoration.Parent = this.addAdvBtn;
            this.addAdvBtn.Size = new System.Drawing.Size(245, 63);
            this.addAdvBtn.TabIndex = 12;
            this.addAdvBtn.Text = "Add Advisor";
            this.addAdvBtn.Click += new System.EventHandler(this.addAdvBtn_Click);
            // 
            // GenderCB
            // 
            this.GenderCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCB.Location = new System.Drawing.Point(321, 452);
            this.GenderCB.Margin = new System.Windows.Forms.Padding(4);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(244, 24);
            this.GenderCB.TabIndex = 9;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2VSeparator1.Location = new System.Drawing.Point(3, 67);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(59, 58);
            this.guna2VSeparator1.TabIndex = 15;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2VSeparator2.Location = new System.Drawing.Point(3, 3);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(59, 58);
            this.guna2VSeparator2.TabIndex = 16;
            // 
            // guna2VSeparator3
            // 
            this.guna2VSeparator3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2VSeparator3.Location = new System.Drawing.Point(3, 131);
            this.guna2VSeparator3.Name = "guna2VSeparator3";
            this.guna2VSeparator3.Size = new System.Drawing.Size(59, 58);
            this.guna2VSeparator3.TabIndex = 17;
            // 
            // guna2VSeparator4
            // 
            this.guna2VSeparator4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2VSeparator4.Location = new System.Drawing.Point(3, 195);
            this.guna2VSeparator4.Name = "guna2VSeparator4";
            this.guna2VSeparator4.Size = new System.Drawing.Size(59, 58);
            this.guna2VSeparator4.TabIndex = 18;
            // 
            // guna2VSeparator5
            // 
            this.guna2VSeparator5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2VSeparator5.Location = new System.Drawing.Point(3, 259);
            this.guna2VSeparator5.Name = "guna2VSeparator5";
            this.guna2VSeparator5.Size = new System.Drawing.Size(59, 58);
            this.guna2VSeparator5.TabIndex = 19;
            // 
            // guna2VSeparator6
            // 
            this.guna2VSeparator6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2VSeparator6.Location = new System.Drawing.Point(3, 323);
            this.guna2VSeparator6.Name = "guna2VSeparator6";
            this.guna2VSeparator6.Size = new System.Drawing.Size(59, 58);
            this.guna2VSeparator6.TabIndex = 20;
            // 
            // guna2VSeparator7
            // 
            this.guna2VSeparator7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2VSeparator7.Location = new System.Drawing.Point(3, 387);
            this.guna2VSeparator7.Name = "guna2VSeparator7";
            this.guna2VSeparator7.Size = new System.Drawing.Size(59, 58);
            this.guna2VSeparator7.TabIndex = 21;
            // 
            // guna2VSeparator8
            // 
            this.guna2VSeparator8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2VSeparator8.Location = new System.Drawing.Point(3, 451);
            this.guna2VSeparator8.Name = "guna2VSeparator8";
            this.guna2VSeparator8.Size = new System.Drawing.Size(59, 65);
            this.guna2VSeparator8.TabIndex = 22;
            // 
            // ManageAdvisorsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageAdvisorsUC";
            this.Size = new System.Drawing.Size(1117, 519);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
        private Guna.UI2.WinForms.Guna2Button viewAdvBtn;
        private Guna.UI2.WinForms.Guna2Button delBtn;
        private Guna.UI2.WinForms.Guna2Button updateAdvbtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox FNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox LNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox EmailTxt;
        private Guna.UI2.WinForms.Guna2TextBox ContactTxt;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOB;
        private Guna.UI2.WinForms.Guna2TextBox SalaryTxt;
        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.ComboBox designationsCB;
        private Guna.UI2.WinForms.Guna2Button addAdvBtn;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator3;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator4;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator5;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator6;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator7;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator8;
    }
}
