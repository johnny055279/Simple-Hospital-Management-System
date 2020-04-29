using ControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManageSystem
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private HospitalDBEntities dBContext = new HospitalDBEntities();

        public static int EmpID = 0;

        private void undoButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            var q = from n in dBContext.Employees
                    orderby n.Department
                    select n;

            string strDepartment = "";
            string strOccupation = "";
            TreeNode departmentNode = null;
            TreeNode occupationNode = null;
            foreach (var n in q)
            {
                if (strDepartment != n.Department)
                {
                    departmentNode = profileTreeView.Nodes.Add(n.Department);
                    strDepartment = n.Department;
                    strOccupation = "";
                    departmentNode.Tag = "Department";
                }
                if (strOccupation != n.Occupation)
                {
                    occupationNode = departmentNode.Nodes.Add(n.Occupation);
                    strOccupation = n.Occupation;
                    occupationNode.Tag = "Occupation";
                }
            }
        }

        private void profileTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            flowLayoutPanel.Controls.Clear();

            switch (e.Node.Tag.ToString())
            {
                case "Department":

                    var q = from n in dBContext.Employees
                            where n.Department == e.Node.Text
                            select n;

                    foreach (var n in q)
                    {
                        EmployeeControl employeeControl = new EmployeeControl();

                        employeeControl.Picture = n.Picture;

                        employeeControl.EmployeeName = $"{n.FirstName} {n.LastName}";

                        employeeControl.label2.Text = n.EmployeeId.ToString();

                        flowLayoutPanel.Controls.Add(employeeControl);

                        employeeControl.detailButton.Click += delegate (object sender1, EventArgs e1)
                        {
                            EmployeeDetailForm employeeDetailForm = new EmployeeDetailForm();

                            EmpID = int.Parse(employeeControl.label2.Text);

                            employeeDetailForm.ShowDialog();
                        };
                    }

                    break;

                case "Occupation":

                    var q1 = from n in dBContext.Employees
                             where n.Department == e.Node.Parent.Text && n.Occupation == e.Node.Text
                             select n;

                    foreach (var n in q1)
                    {
                        EmployeeControl employeeControl = new EmployeeControl();

                        employeeControl.Picture = n.Picture;

                        employeeControl.EmployeeName = $"{n.FirstName} {n.LastName}";

                        employeeControl.label2.Text = n.EmployeeId.ToString();

                        flowLayoutPanel.Controls.Add(employeeControl);

                        employeeControl.detailButton.Click += delegate (object sender1, EventArgs e1)
                        {
                            EmployeeDetailForm employeeDetailForm = new EmployeeDetailForm();

                            EmpID = int.Parse(employeeControl.label2.Text);

                            employeeDetailForm.ShowDialog();
                        };
                    }

                    break;
            }
        }
    }
}