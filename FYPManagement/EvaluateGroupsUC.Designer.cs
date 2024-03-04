namespace FYPManagement
{
    partial class EvaluateGroupsUC
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
            this.backBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EvalIDCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.evalDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupIDCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ObtmarksUD = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.EvaluateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObtmarksUD)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.backBtn, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.EvalIDCB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.evalDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupIDCB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ObtmarksUD, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.EvaluateBtn, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 500);
            this.tableLayoutPanel1.TabIndex = 12;
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
            this.backBtn.Location = new System.Drawing.Point(4, 454);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.ShadowDecoration.Parent = this.backBtn;
            this.backBtn.Size = new System.Drawing.Size(217, 42);
            this.backBtn.TabIndex = 19;
            this.backBtn.Text = "Back";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // EvalIDCB
            // 
            this.EvalIDCB.BackColor = System.Drawing.Color.Transparent;
            this.EvalIDCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvalIDCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EvalIDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EvalIDCB.FocusedColor = System.Drawing.Color.Empty;
            this.EvalIDCB.FocusedState.Parent = this.EvalIDCB;
            this.EvalIDCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EvalIDCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.EvalIDCB.FormattingEnabled = true;
            this.EvalIDCB.HoverState.Parent = this.EvalIDCB;
            this.EvalIDCB.ItemHeight = 30;
            this.EvalIDCB.ItemsAppearance.Parent = this.EvalIDCB;
            this.EvalIDCB.Location = new System.Drawing.Point(228, 103);
            this.EvalIDCB.Name = "EvalIDCB";
            this.EvalIDCB.ShadowDecoration.Parent = this.EvalIDCB;
            this.EvalIDCB.Size = new System.Drawing.Size(220, 36);
            this.EvalIDCB.TabIndex = 22;
            // 
            // evalDate
            // 
            this.evalDate.CheckedState.Parent = this.evalDate;
            this.evalDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evalDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.evalDate.HoverState.Parent = this.evalDate;
            this.evalDate.Location = new System.Drawing.Point(228, 203);
            this.evalDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.evalDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.evalDate.Name = "evalDate";
            this.evalDate.ShadowDecoration.Parent = this.evalDate;
            this.evalDate.Size = new System.Drawing.Size(220, 44);
            this.evalDate.TabIndex = 23;
            this.evalDate.Value = new System.DateTime(2024, 3, 4, 21, 56, 1, 244);
            // 
            // groupIDCB
            // 
            this.groupIDCB.BackColor = System.Drawing.Color.Transparent;
            this.groupIDCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupIDCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.groupIDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupIDCB.FocusedColor = System.Drawing.Color.Empty;
            this.groupIDCB.FocusedState.Parent = this.groupIDCB;
            this.groupIDCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupIDCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.groupIDCB.FormattingEnabled = true;
            this.groupIDCB.HoverState.Parent = this.groupIDCB;
            this.groupIDCB.ItemHeight = 30;
            this.groupIDCB.ItemsAppearance.Parent = this.groupIDCB;
            this.groupIDCB.Location = new System.Drawing.Point(3, 103);
            this.groupIDCB.Name = "groupIDCB";
            this.groupIDCB.ShadowDecoration.Parent = this.groupIDCB;
            this.groupIDCB.Size = new System.Drawing.Size(219, 36);
            this.groupIDCB.TabIndex = 21;
            // 
            // ObtmarksUD
            // 
            this.ObtmarksUD.BackColor = System.Drawing.Color.Transparent;
            this.ObtmarksUD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ObtmarksUD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ObtmarksUD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ObtmarksUD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ObtmarksUD.DisabledState.Parent = this.ObtmarksUD;
            this.ObtmarksUD.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.ObtmarksUD.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.ObtmarksUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObtmarksUD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ObtmarksUD.FocusedState.Parent = this.ObtmarksUD;
            this.ObtmarksUD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObtmarksUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ObtmarksUD.Location = new System.Drawing.Point(3, 203);
            this.ObtmarksUD.Name = "ObtmarksUD";
            this.ObtmarksUD.ShadowDecoration.Parent = this.ObtmarksUD;
            this.ObtmarksUD.Size = new System.Drawing.Size(219, 44);
            this.ObtmarksUD.TabIndex = 20;
            // 
            // EvaluateBtn
            // 
            this.EvaluateBtn.BorderRadius = 10;
            this.EvaluateBtn.CheckedState.Parent = this.EvaluateBtn;
            this.EvaluateBtn.CustomImages.Parent = this.EvaluateBtn;
            this.EvaluateBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvaluateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.EvaluateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EvaluateBtn.ForeColor = System.Drawing.Color.White;
            this.EvaluateBtn.HoverState.Parent = this.EvaluateBtn;
            this.EvaluateBtn.Location = new System.Drawing.Point(229, 304);
            this.EvaluateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EvaluateBtn.Name = "EvaluateBtn";
            this.EvaluateBtn.ShadowDecoration.Parent = this.EvaluateBtn;
            this.EvaluateBtn.Size = new System.Drawing.Size(218, 42);
            this.EvaluateBtn.TabIndex = 12;
            this.EvaluateBtn.Text = "Evaluate Group";
            this.EvaluateBtn.Click += new System.EventHandler(this.EvaluateBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.guna2DataGridView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(451, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(437, 500);
            this.tableLayoutPanel2.TabIndex = 14;
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
            this.guna2DataGridView1.ColumnHeadersHeight = 20;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.guna2DataGridView1.Size = new System.Drawing.Size(431, 494);
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
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 20;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // EvaluateGroupsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EvaluateGroupsUC";
            this.Size = new System.Drawing.Size(888, 500);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ObtmarksUD)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button backBtn;
        private Guna.UI2.WinForms.Guna2NumericUpDown ObtmarksUD;
        private Guna.UI2.WinForms.Guna2Button EvaluateBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2ComboBox groupIDCB;
        private Guna.UI2.WinForms.Guna2ComboBox EvalIDCB;
        private Guna.UI2.WinForms.Guna2DateTimePicker evalDate;
    }
}
