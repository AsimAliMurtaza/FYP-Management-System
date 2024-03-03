namespace FYPManagement
{
    partial class StudentsToGroupUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BackBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.studentCB = new System.Windows.Forms.ComboBox();
            this.groupCB = new System.Windows.Forms.ComboBox();
            this.addToGrpBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RemStdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.remStdCB = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.BackBtn, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.studentCB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupCB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.addToGrpBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.RemStdBtn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.remStdCB, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(497, 491);
            this.tableLayoutPanel1.TabIndex = 4;
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
            this.BackBtn.Location = new System.Drawing.Point(4, 436);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BackBtn.ShadowDecoration.Parent = this.BackBtn;
            this.BackBtn.Size = new System.Drawing.Size(49, 51);
            this.BackBtn.TabIndex = 13;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // studentCB
            // 
            this.studentCB.DropDownHeight = 110;
            this.studentCB.FormattingEnabled = true;
            this.studentCB.IntegralHeight = false;
            this.studentCB.Location = new System.Drawing.Point(4, 58);
            this.studentCB.Margin = new System.Windows.Forms.Padding(4);
            this.studentCB.Name = "studentCB";
            this.studentCB.Size = new System.Drawing.Size(157, 24);
            this.studentCB.TabIndex = 9;
            // 
            // groupCB
            // 
            this.groupCB.DropDownHeight = 110;
            this.groupCB.FormattingEnabled = true;
            this.groupCB.IntegralHeight = false;
            this.groupCB.Location = new System.Drawing.Point(4, 112);
            this.groupCB.Margin = new System.Windows.Forms.Padding(4);
            this.groupCB.Name = "groupCB";
            this.groupCB.Size = new System.Drawing.Size(157, 24);
            this.groupCB.TabIndex = 14;
            // 
            // addToGrpBtn
            // 
            this.addToGrpBtn.BorderRadius = 10;
            this.addToGrpBtn.CheckedState.Parent = this.addToGrpBtn;
            this.addToGrpBtn.CustomImages.Parent = this.addToGrpBtn;
            this.addToGrpBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.addToGrpBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addToGrpBtn.ForeColor = System.Drawing.Color.White;
            this.addToGrpBtn.HoverState.Parent = this.addToGrpBtn;
            this.addToGrpBtn.Location = new System.Drawing.Point(4, 220);
            this.addToGrpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addToGrpBtn.Name = "addToGrpBtn";
            this.addToGrpBtn.ShadowDecoration.Parent = this.addToGrpBtn;
            this.addToGrpBtn.Size = new System.Drawing.Size(157, 46);
            this.addToGrpBtn.TabIndex = 12;
            this.addToGrpBtn.Text = "Add Student";
            this.addToGrpBtn.Click += new System.EventHandler(this.addToGrpBtn_Click);
            // 
            // RemStdBtn
            // 
            this.RemStdBtn.BorderRadius = 10;
            this.RemStdBtn.CheckedState.Parent = this.RemStdBtn;
            this.RemStdBtn.CustomImages.Parent = this.RemStdBtn;
            this.RemStdBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.RemStdBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemStdBtn.ForeColor = System.Drawing.Color.White;
            this.RemStdBtn.HoverState.Parent = this.RemStdBtn;
            this.RemStdBtn.Location = new System.Drawing.Point(169, 220);
            this.RemStdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RemStdBtn.Name = "RemStdBtn";
            this.RemStdBtn.ShadowDecoration.Parent = this.RemStdBtn;
            this.RemStdBtn.Size = new System.Drawing.Size(157, 46);
            this.RemStdBtn.TabIndex = 15;
            this.RemStdBtn.Text = "Remove Student";
            this.RemStdBtn.Click += new System.EventHandler(this.RemStdBtn_Click);
            // 
            // remStdCB
            // 
            this.remStdCB.DropDownHeight = 110;
            this.remStdCB.FormattingEnabled = true;
            this.remStdCB.IntegralHeight = false;
            this.remStdCB.Location = new System.Drawing.Point(169, 58);
            this.remStdCB.Margin = new System.Windows.Forms.Padding(4);
            this.remStdCB.Name = "remStdCB";
            this.remStdCB.Size = new System.Drawing.Size(157, 24);
            this.remStdCB.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.Controls.Add(this.guna2DataGridView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(497, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(516, 491);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(3, 3);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(510, 485);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.SelectionChanged += new System.EventHandler(this.dataGridViewGroupStudents_SelectionChanged);
            // 
            // StudentsToGroupUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StudentsToGroupUC";
            this.Size = new System.Drawing.Size(1013, 491);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton BackBtn;
        private System.Windows.Forms.ComboBox studentCB;
        private System.Windows.Forms.ComboBox groupCB;
        private Guna.UI2.WinForms.Guna2Button addToGrpBtn;
        private Guna.UI2.WinForms.Guna2Button RemStdBtn;
        private System.Windows.Forms.ComboBox remStdCB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}
