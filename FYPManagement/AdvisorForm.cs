﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYPManagement
{
    public partial class AdvisorForm : Form
    {
        AdminMenuUC adminMenuUC;
        ManageStudentsUC manageStudentsUC;
        ManageAdvisorsUC manageAdvisorsUC;
        ViewStudentsUC viewStudentsUC;
        UpdateStudentUC updateStudentUC;
        CreateGroupUC CreateGroupUC;
        StudentsToGroupUC studentsToGroupUC;
        public AdvisorForm()
        {
            InitializeComponent();
            adminMenuUC = new AdminMenuUC(this) { Dock = DockStyle.Fill};
            manageStudentsUC = new ManageStudentsUC(this) { Dock = DockStyle.Fill };
            manageAdvisorsUC = new ManageAdvisorsUC(this) { Dock = DockStyle.Fill };
            viewStudentsUC = new ViewStudentsUC(this) { Dock = DockStyle.Fill };
            updateStudentUC = new UpdateStudentUC(this) { Dock = DockStyle.Fill };
            CreateGroupUC = new CreateGroupUC(this) { Dock = DockStyle.Fill };
            studentsToGroupUC = new StudentsToGroupUC(this) { Dock = DockStyle.Fill };

        }

        public void addStudentsControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(manageStudentsUC);
        }
        public void addAdvisorsControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(manageAdvisorsUC);
        }
        public void addStudentViewControls()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(viewStudentsUC);
        }
        public void addAdminDashboardControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(adminMenuUC);
        }
        public void addStudentUpdateControls()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(updateStudentUC);
        }

        public void addCreateGroupControls()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(CreateGroupUC);
        }

        public void addStudentsToGroupControls()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(studentsToGroupUC);
        }


        private void AdvisorForm_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(adminMenuUC);
        }

    }
}
