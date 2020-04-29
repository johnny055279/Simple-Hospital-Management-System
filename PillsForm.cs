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
    public partial class PillsForm : Form
    {
        public PillsForm()
        {
            InitializeComponent();
        }

        private void PillsForm_Load(object sender, EventArgs e)
        {
            HospitalDBEntities dbContext = new HospitalDBEntities();
            var q = dbContext.Pills.OrderBy(n => n.PillName).Select(n => n.PillName);

            var q1 = dbContext.Diagnosis1.OrderBy(n => n.PatientName).Select(n => n.PatientName);

            foreach (var n in q)
            {
                comboBox.Items.Add(n);
            }
            foreach (var n in q1)
            {
                comboBox1.Items.Add(n);
            }
            comboBox.SelectedIndex = 0;

            label2.Text = LoginForm.UserName;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            HospitalDBEntities dbContext = new HospitalDBEntities();

            var q = dbContext.Pills.Where(n => n.PillName == comboBox.Text).Select(n => n).First();

            if (comboBox1.Text != "")
            {
                if (numericUpDown.Value < q.PillInstore)
                {
                    dataGridView.Rows.Add("刪除", comboBox1.Text, comboBox.Text, numericUpDown.Value);
                    MessageBox.Show("新增成功", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("數量不足", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("請選擇個案", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            HospitalDBEntities dbContext = new HospitalDBEntities();
            try
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    dbContext.Prescriptions.Add(new Prescription
                    {
                        EmployeeID = LoginForm.UserId,
                        PatientID = dbContext.Diagnosis1.AsEnumerable().Where(n => n.PatientName == dataGridView.Rows[i].Cells[1].Value.ToString()).Select(n => n.PatientId).First(),
                        PillsID = dbContext.Pills.AsEnumerable().Where(n => n.PillName == dataGridView.Rows[i].Cells[2].Value.ToString()).Select(n => n.Id).First(),
                        Count = Int32.Parse(dataGridView.Rows[i].Cells[3].Value.ToString()),
                        TotalPrice = (decimal)dataGridView.Rows[0].Cells[3].Value * dbContext.Pills.AsEnumerable().Where(n => n.PillName == dataGridView.Rows[i].Cells[2].Value.ToString()).Select(n => n.PillUnitPrice).First(),
                        CreateDate = DateTime.Now
                    });

                    dbContext.SaveChanges();
                }

                dataGridView.Rows.Clear();

                MessageBox.Show("儲存成功!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:

                    dataGridView.Rows.RemoveAt(e.RowIndex);

                    break;
            }
        }
    }
}