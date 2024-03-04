namespace FYPManagement
{
    partial class ManageEvaluationsUC
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
            this.viewEvalBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateEvalBtn = new Guna.UI2.WinForms.Guna2Button();
            this.doEvalBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteEvalBtn = new Guna.UI2.WinForms.Guna2Button();
            this.evalNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.addEvalBtn = new Guna.UI2.WinForms.Guna2Button();
            this.marksUD = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.weightageUD = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightageUD)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.backBtn, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.viewEvalBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.updateEvalBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addEvalBtn, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.DeleteEvalBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.doEvalBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.evalNameTxt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.marksUD, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.weightageUD, 1, 5);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 520);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.backBtn.Location = new System.Drawing.Point(4, 420);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.ShadowDecoration.Parent = this.backBtn;
            this.backBtn.Size = new System.Drawing.Size(218, 44);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "Back";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // viewEvalBtn
            // 
            this.viewEvalBtn.BorderRadius = 10;
            this.viewEvalBtn.CheckedState.Parent = this.viewEvalBtn;
            this.viewEvalBtn.CustomImages.Parent = this.viewEvalBtn;
            this.viewEvalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewEvalBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.viewEvalBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewEvalBtn.ForeColor = System.Drawing.Color.White;
            this.viewEvalBtn.HoverState.Parent = this.viewEvalBtn;
            this.viewEvalBtn.Location = new System.Drawing.Point(4, 4);
            this.viewEvalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewEvalBtn.Name = "viewEvalBtn";
            this.viewEvalBtn.ShadowDecoration.Parent = this.viewEvalBtn;
            this.viewEvalBtn.Size = new System.Drawing.Size(218, 44);
            this.viewEvalBtn.TabIndex = 11;
            this.viewEvalBtn.Text = "View Evaluations";
            this.viewEvalBtn.Click += new System.EventHandler(this.viewEvalBtn_Click);
            // 
            // updateEvalBtn
            // 
            this.updateEvalBtn.BorderRadius = 10;
            this.updateEvalBtn.CheckedState.Parent = this.updateEvalBtn;
            this.updateEvalBtn.CustomImages.Parent = this.updateEvalBtn;
            this.updateEvalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateEvalBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.updateEvalBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateEvalBtn.ForeColor = System.Drawing.Color.White;
            this.updateEvalBtn.HoverState.Parent = this.updateEvalBtn;
            this.updateEvalBtn.Location = new System.Drawing.Point(230, 4);
            this.updateEvalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateEvalBtn.Name = "updateEvalBtn";
            this.updateEvalBtn.ShadowDecoration.Parent = this.updateEvalBtn;
            this.updateEvalBtn.Size = new System.Drawing.Size(218, 44);
            this.updateEvalBtn.TabIndex = 10;
            this.updateEvalBtn.Text = "Update Evaluation";
            this.updateEvalBtn.Click += new System.EventHandler(this.updateEvalBtn_Click);
            // 
            // doEvalBtn
            // 
            this.doEvalBtn.BorderRadius = 10;
            this.doEvalBtn.CheckedState.Parent = this.doEvalBtn;
            this.doEvalBtn.CustomImages.Parent = this.doEvalBtn;
            this.doEvalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doEvalBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.doEvalBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.doEvalBtn.ForeColor = System.Drawing.Color.White;
            this.doEvalBtn.HoverState.Parent = this.doEvalBtn;
            this.doEvalBtn.Location = new System.Drawing.Point(682, 4);
            this.doEvalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.doEvalBtn.Name = "doEvalBtn";
            this.doEvalBtn.ShadowDecoration.Parent = this.doEvalBtn;
            this.doEvalBtn.Size = new System.Drawing.Size(221, 44);
            this.doEvalBtn.TabIndex = 14;
            this.doEvalBtn.Text = "Evaluate Groups";
            // 
            // DeleteEvalBtn
            // 
            this.DeleteEvalBtn.BorderRadius = 10;
            this.DeleteEvalBtn.CheckedState.Parent = this.DeleteEvalBtn;
            this.DeleteEvalBtn.CustomImages.Parent = this.DeleteEvalBtn;
            this.DeleteEvalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteEvalBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.DeleteEvalBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteEvalBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteEvalBtn.HoverState.Parent = this.DeleteEvalBtn;
            this.DeleteEvalBtn.Location = new System.Drawing.Point(456, 4);
            this.DeleteEvalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteEvalBtn.Name = "DeleteEvalBtn";
            this.DeleteEvalBtn.ShadowDecoration.Parent = this.DeleteEvalBtn;
            this.DeleteEvalBtn.Size = new System.Drawing.Size(218, 44);
            this.DeleteEvalBtn.TabIndex = 16;
            this.DeleteEvalBtn.Text = "Remove Evaluation";
            // 
            // evalNameTxt
            // 
            this.evalNameTxt.BorderRadius = 12;
            this.evalNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.evalNameTxt.DefaultText = "";
            this.evalNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.evalNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.evalNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.evalNameTxt.DisabledState.Parent = this.evalNameTxt;
            this.evalNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.evalNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.evalNameTxt.FocusedState.Parent = this.evalNameTxt;
            this.evalNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.evalNameTxt.HoverState.Parent = this.evalNameTxt;
            this.evalNameTxt.Location = new System.Drawing.Point(231, 161);
            this.evalNameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.evalNameTxt.Name = "evalNameTxt";
            this.evalNameTxt.PasswordChar = '\0';
            this.evalNameTxt.PlaceholderText = "Type of Evaluation";
            this.evalNameTxt.SelectedText = "";
            this.evalNameTxt.ShadowDecoration.Parent = this.evalNameTxt;
            this.evalNameTxt.Size = new System.Drawing.Size(216, 33);
            this.evalNameTxt.TabIndex = 5;
            // 
            // addEvalBtn
            // 
            this.addEvalBtn.BorderRadius = 10;
            this.addEvalBtn.CheckedState.Parent = this.addEvalBtn;
            this.addEvalBtn.CustomImages.Parent = this.addEvalBtn;
            this.addEvalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEvalBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.addEvalBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addEvalBtn.ForeColor = System.Drawing.Color.White;
            this.addEvalBtn.HoverState.Parent = this.addEvalBtn;
            this.addEvalBtn.Location = new System.Drawing.Point(456, 316);
            this.addEvalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addEvalBtn.Name = "addEvalBtn";
            this.addEvalBtn.ShadowDecoration.Parent = this.addEvalBtn;
            this.addEvalBtn.Size = new System.Drawing.Size(218, 44);
            this.addEvalBtn.TabIndex = 12;
            this.addEvalBtn.Text = "Add Evaluation";
            this.addEvalBtn.Click += new System.EventHandler(this.addEvalBtn_Click);
            // 
            // marksUD
            // 
            this.marksUD.BackColor = System.Drawing.Color.Transparent;
            this.marksUD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.marksUD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.marksUD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.marksUD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.marksUD.DisabledState.Parent = this.marksUD;
            this.marksUD.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.marksUD.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.marksUD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.marksUD.FocusedState.Parent = this.marksUD;
            this.marksUD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marksUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.marksUD.Location = new System.Drawing.Point(229, 211);
            this.marksUD.Name = "marksUD";
            this.marksUD.ShadowDecoration.Parent = this.marksUD;
            this.marksUD.Size = new System.Drawing.Size(100, 36);
            this.marksUD.TabIndex = 19;
            // 
            // weightageUD
            // 
            this.weightageUD.BackColor = System.Drawing.Color.Transparent;
            this.weightageUD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.weightageUD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.weightageUD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.weightageUD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.weightageUD.DisabledState.Parent = this.weightageUD;
            this.weightageUD.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.weightageUD.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.weightageUD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.weightageUD.FocusedState.Parent = this.weightageUD;
            this.weightageUD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightageUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.weightageUD.Location = new System.Drawing.Point(229, 263);
            this.weightageUD.Name = "weightageUD";
            this.weightageUD.ShadowDecoration.Parent = this.weightageUD;
            this.weightageUD.Size = new System.Drawing.Size(100, 36);
            this.weightageUD.TabIndex = 20;
            // 
            // ManageEvaluationsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageEvaluationsUC";
            this.Size = new System.Drawing.Size(907, 520);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marksUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightageUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button backBtn;
        private Guna.UI2.WinForms.Guna2Button viewEvalBtn;
        private Guna.UI2.WinForms.Guna2Button updateEvalBtn;
        private Guna.UI2.WinForms.Guna2Button doEvalBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteEvalBtn;
        private Guna.UI2.WinForms.Guna2TextBox evalNameTxt;
        private Guna.UI2.WinForms.Guna2Button addEvalBtn;
        private Guna.UI2.WinForms.Guna2NumericUpDown marksUD;
        private Guna.UI2.WinForms.Guna2NumericUpDown weightageUD;
    }
}
