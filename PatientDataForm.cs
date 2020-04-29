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
    public partial class PatientDataForm : Form
    {
        public PatientDataForm()
        {
            InitializeComponent();
        }

        private HospitalDBEntities dbContext = new HospitalDBEntities();

        private void allDataButton_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = dbContext.Diagnosis1.AsEnumerable().Select(n => new
            {
                個案編號 = n.PatientId,
                個案姓名 = n.PatientName,
                身分證 = n.IdNumber,
                性別 = n.Sexual,
                出生日期 = n.Birthday.ToShortDateString(),
                病歷號碼 = n.MRN,
                診斷日 = n.CreateDate.ToShortDateString(),
                主治醫師 = $"{n.Employee1.FirstName} {n.Employee1.LastName}"
            }).ToList();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)this.dataGridView.Rows[e.RowIndex].Cells[0].Value;

            symptomsRTB.Text = dbContext.Diagnosis1.Where(n => n.PatientId == id).Select(n => n.Symptoms).ToList().First();
            adviceRTB.Text = dbContext.Diagnosis1.Where(n => n.PatientId == id).Select(n => n.Advice).ToList().First();
        }

        private void dateSelectButton_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = dbContext.Diagnosis1.AsEnumerable().Where(n => DatePick(n.CreateDate)).Select(n => new
            {
                個案編號 = n.PatientId,
                個案姓名 = n.PatientName,
                身分證 = n.IdNumber,
                性別 = n.Sexual,
                出生日期 = n.Birthday.ToShortDateString(),
                病歷號碼 = n.MRN,
                診斷日 = n.CreateDate.ToShortDateString(),
                主治醫師 = $"{n.Employee1.FirstName} {n.Employee1.LastName}"
            }).ToList();
        }

        private bool DatePick(DateTime createDate)
        {
            if (minDTP.Value <= createDate && createDate <= maxDTP.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PatientDataForm_Load(object sender, EventArgs e)
        {
            var q = from n in dbContext.Employees.AsEnumerable()
                    where n.Occupation == "外科醫生" || n.Occupation == "內科醫生"
                    orderby $"{n.FirstName} {n.LastName}"
                    select $"{n.FirstName} {n.LastName}";

            foreach (var n in q)
            {
                comboBox.Items.Add(n);
            }
        }

        private void docterSelectButton_Click(object sender, EventArgs e)
        {
            if (comboBox.Text != "")
            {
                dataGridView.DataSource = dbContext.Diagnosis1.AsEnumerable().Where(n => $"{n.Employee1.FirstName} {n.Employee1.LastName}" == comboBox.Text).Select(n => new
                {
                    個案編號 = n.PatientId,
                    個案姓名 = n.PatientName,
                    身分證 = n.IdNumber,
                    性別 = n.Sexual,
                    出生日期 = n.Birthday.ToShortDateString(),
                    病歷號碼 = n.MRN,
                    診斷日 = n.CreateDate.ToShortDateString(),
                    主治醫師 = $"{n.Employee1.FirstName} {n.Employee1.LastName}"
                }).ToList();
            }
            else
            {
                MessageBox.Show("請選擇醫師", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}