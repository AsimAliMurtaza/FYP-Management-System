using System;
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
        AssignProjects assignProjects;
        AssignAdvisors assignAdvisorsUC;
        ManageEvaluationsUC manageEvaluationsUC;
        ViewEvaluationsUC viewEvaluationsUC;
        UpdateEvaluationUC updateEvaluationUC;
        EvaluateGroupsUC evaluateGroupsUC;
        DeleteStudent deleteStudentUC;
        DeleteAdvisor deleteAdvisorUC;
        DeleteProject deleteProjectUC;
        DeleteEvaluation deleteEvaluationUC;
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
            assignProjects = new AssignProjects(this) { Dock = DockStyle.Fill };
            assignAdvisorsUC = new AssignAdvisors(this) { Dock = DockStyle.Fill };
            manageEvaluationsUC = new ManageEvaluationsUC(this) { Dock = DockStyle.Fill };
            viewEvaluationsUC = new ViewEvaluationsUC(this) { Dock = DockStyle.Fill };
            updateEvaluationUC = new UpdateEvaluationUC(this) { Dock = DockStyle.Fill };
            evaluateGroupsUC = new EvaluateGroupsUC(this) { Dock = DockStyle.Fill };
            deleteStudentUC = new DeleteStudent(this) { Dock = DockStyle.Fill };
            deleteAdvisorUC = new DeleteAdvisor(this) { Dock = DockStyle.Fill };
            deleteProjectUC = new DeleteProject(this) { Dock = DockStyle.Fill };
            deleteEvaluationUC = new DeleteEvaluation(this) { Dock = DockStyle.Fill };

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
        public void addManageProjectControlUC()
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

        public void addAssignProjectsControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(assignProjects);
        }

        public void addDeleteAdvisorControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(deleteAdvisorUC);
        }

        public void addUpdateProjectControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(updateProject);
        }

        public void addAssignAdvisorsControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(assignAdvisorsUC);
        }

        public void addManageEvaluationsControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(manageEvaluationsUC);
        }

        public void addViewEvaluationsControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(viewEvaluationsUC);
        }

        public void addUpdateEvaluationControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(updateEvaluationUC);
        }

        public void addEvaluateGroupsControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(evaluateGroupsUC);
        }

        public void addDeleteStudentControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(deleteStudentUC);
        }

        public void addDeleteProjectControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(deleteProjectUC);
        }

        public void addDeleteEvaluationControl()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(deleteEvaluationUC);
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
