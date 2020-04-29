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
    public partial class CreateIssueForm : Form
    {
        public CreateIssueForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                HospitalDBEntities dbContext = new HospitalDBEntities();

                dbContext.Issues.Add(new Issue
                {
                    Title = titleTextBox.Text,
                    Content = contentRichTextBox.Text,
                    Date = monthCalendar.SelectionStart,
                    EmployeeID = LoginForm.UserId
                });

                dbContext.SaveChanges();

                MessageBox.Show("新增成功!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                titleTextBox.Enabled = contentRichTextBox.Enabled = confirmButton.Enabled = monthCalendar.Enabled = false;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}