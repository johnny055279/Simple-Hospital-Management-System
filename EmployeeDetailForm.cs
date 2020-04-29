using HospitalManageSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class EmployeeDetailForm : Form
    {
        public EmployeeDetailForm()
        {
            InitializeComponent();
        }

        private void EmployeeDetailForm_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != typeof(Button))
                {
                    control.Enabled = false;
                }
            }

            HospitalDBControlEntities dBContext = new HospitalDBControlEntities();

            var q = from n in dBContext.Employees.AsEnumerable()
                    where n.EmployeeId == (ProfileForm.EmpID)
                    select n;

            foreach (var n in q)
            {
                employeeIdTextBox.Text = n.EmployeeId.ToString();
                firstNameTextBox.Text = n.FirstName;
                lastNameTextBox.Text = n.LastName;
                accountTextBox.Text = n.Account;
                birthdayDateTimePicker.Value = n.Birthday;
                sexualTextBox.Text = n.Sexual;
                emailTextBox.Text = n.Email;
                occupationTextBox.SelectedItem = n.Occupation;
                departmentTextBox.SelectedItem = n.Department;
                physicianIDTextBox.Text = n.PhysicianID;
                pictureBox.Image = new Bitmap(new MemoryStream(n.Picture));
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                if (n.EmployeeId == LoginForm.UserId)
                {
                    button1.Enabled = button2.Enabled = button3.Enabled = true;
                    button1.Visible = true;
                }
                else
                {
                    button1.Enabled = button2.Enabled = button3.Enabled = false;
                    button1.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = button3.Visible = button2.Enabled = button3.Enabled = true;
            button1.Enabled = button1.Visible = false;

            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    ((TextBox)control).ReadOnly = false;
                }
            }
            departmentTextBox.Enabled =
            occupationTextBox.Enabled =
            firstNameTextBox.Enabled =
            lastNameTextBox.Enabled =
            emailTextBox.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HospitalDBControlEntities dbContext = new HospitalDBControlEntities();

            var q = dbContext.Employees.Where(n => n.EmployeeId == LoginForm.UserId).Select(n => n);
            try
            {
                foreach (var n in q)
                {
                    n.FirstName = firstNameTextBox.Text;
                    n.LastName = lastNameTextBox.Text;
                    n.Account = accountTextBox.Text;
                    n.Birthday = birthdayDateTimePicker.Value;

                    if (Check.HasChinese(emailTextBox.Text) || !Check.IsValidEMailAddress(emailTextBox.Text))
                    {
                        MessageBox.Show("Email欄位錯誤");
                    }
                    else
                    {
                        n.Email = emailTextBox.Text;
                    }

                    n.Occupation = occupationTextBox.SelectedItem.ToString();
                    n.Department = departmentTextBox.SelectedItem.ToString();
                }
                dbContext.SaveChanges();
                MessageBox.Show("修改成功!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = button3.Visible = button2.Enabled = button3.Enabled = false;
            button1.Enabled = button1.Visible = true;

            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    ((TextBox)control).ReadOnly = true;
                }
            }
            departmentTextBox.Enabled =
            occupationTextBox.Enabled =
            firstNameTextBox.Enabled =
            lastNameTextBox.Enabled =
            emailTextBox.Enabled = false;
        }
    }
}