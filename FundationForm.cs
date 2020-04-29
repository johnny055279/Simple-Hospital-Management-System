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
    public partial class FundationForm : Form
    {
        public FundationForm()
        {
            InitializeComponent();
        }

        private void FundationForm_Load(object sender, EventArgs e)
        {
            HospitalDBEntities dbContext = new HospitalDBEntities();

            var q = dbContext.Prescriptions.AsEnumerable().OrderByDescending(n => n.Diagnosi.PatientName).Select(n => n.Diagnosi.PatientName);

            foreach (var n in q.Distinct())
            {
                comboBox.Items.Add(n);
            }

            var q1 = dbContext.Pills.AsEnumerable().OrderByDescending(n => n.PillName).Select(n => n.PillName);

            foreach (var n in q1.Distinct())
            {
                comboBox1.Items.Add(n);
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HospitalDBEntities dbContext = new HospitalDBEntities();

            var q = dbContext.Prescriptions.AsEnumerable().Where(n => n.Diagnosi.PatientName == comboBox.Text).Select(n => new
            {
                編號 = n.Id,
                藥品編號 = n.PillsID,
                藥品名稱 = n.Pill.PillName,
                藥品單價 = n.Pill.PillUnitPrice,
                藥品數量 = n.Count,
                總額 = n.TotalPrice,
                個案編號 = n.PatientID,
                個案姓名 = n.Diagnosi.PatientName,
                開單日 = n.CreateDate,
            });

            dataGridView.DataSource = q.ToList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            HospitalDBEntities dbContext = new HospitalDBEntities();

            var q = dbContext.Prescriptions.AsEnumerable().Where(n => n.Diagnosi.PatientName == comboBox.Text && n.CreateDate.Date == dateTimePicker1.Value.Date).Select(n => new
            {
                編號 = n.Id,
                藥品編號 = n.PillsID,
                藥品名稱 = n.Pill.PillName,
                藥品單價 = n.Pill.PillUnitPrice,
                藥品數量 = n.Count,
                總額 = n.TotalPrice,
                個案編號 = n.PatientID,
                個案姓名 = n.Diagnosi.PatientName,
                開單日 = n.CreateDate
            });

            dataGridView.DataSource = q.ToList();

            dbContext.Dispose();
        }

        private void caculateBtn_Click(object sender, EventArgs e)
        {
            decimal sum = 0;

            if (dataGridView.Rows != null)
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (checkBox1.Checked)
                    {
                        sum += (decimal)(dataGridView.Rows[i].Cells[5].Value) * 0.8m;
                    }
                    else
                    {
                        sum += (decimal)dataGridView.Rows[i].Cells[5].Value;
                    }
                }

                label3.Text = $"應繳金額：{sum:c2}";
            }
            else
            {
                MessageBox.Show("請先獲取資料", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1 != null)
            {
                try
                {
                    HospitalDBEntities dbContext = new HospitalDBEntities();

                    var q = dbContext.Pills.AsEnumerable().Where(n => n.PillName == comboBox1.Text).Select(n => n);

                    foreach (var n in q)
                    {
                        n.PillName = comboBox1.Text;
                        n.PillInstore += (int)numericUpDown1.Value;
                    }

                    dbContext.SaveChanges();

                    MessageBox.Show("訂購成功!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dbContext.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("請選擇購買品項", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            HospitalDBEntities dbContext = new HospitalDBEntities();

            var q = dbContext.Pills.AsEnumerable().OrderByDescending(n => n.PillName).Select(n => new
            {
                藥品編號 = n.Id,
                藥品名稱 = n.PillName,
                藥品單價 = n.PillUnitPrice,
                藥品庫存 = n.PillInstore
            });

            dataGridView1.DataSource = q.ToList();

            dbContext.Dispose();
        }
    }
}