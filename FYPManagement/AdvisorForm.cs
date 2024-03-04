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
        ViewGroupsUC viewGroupsUC;
        ViewAdvisorsUC advisorViewUC;
        UpdateAdvisorUC UpdateAdvisorUC;
        ManageProjects manageProjects;
        VIewProjectsUC viewProjectsUC;
        ManageGroupsUC manageGroupsUC;
        UpdateProject updateProject;
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
            viewGroupsUC = new ViewGroupsUC(this) { Dock = DockStyle.Fill };
            advisorViewUC = new ViewAdvisorsUC(this) { Dock = DockStyle.Fill };
            UpdateAdvisorUC = new UpdateAdvisorUC(this) { Dock = DockStyle.Fill };
            manageProjects = new ManageProjects(this) { Dock = DockStyle.Fill };
            viewProjectsUC = new VIewProjectsUC(this) { Dock = DockStyle.Fill };
            manageGroupsUC = new ManageGroupsUC(this) { Dock = DockStyle.Fill };
            updateProject = new UpdateProject(this) { Dock = DockStyle.Fill };

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
        public void addGroupsViewUC()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(viewGroupsUC);
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
        public void addAdvisorViewControls()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(advisorViewUC);
        }

        public void addAdvisorUpdateControlUC()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(UpdateAdvisorUC);
        }

        public void addGroupControlUC()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(manageProjects);
        }

        public void viewProjectsControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(viewProjectsUC);
        }

        public void addManageGroupsControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(manageGroupsUC);
        }

        public void addUpdateProjectControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(updateProject);
        }


        private void AdvisorForm_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(adminMenuUC);
        }

        private void adminHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
