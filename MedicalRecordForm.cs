using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManageSystem
{
    public partial class MedicalRecordForm : Form
    {
        public MedicalRecordForm()
        {
            InitializeComponent();
        }

        private Bitmap memoryImage;
        private Random random = new Random();
        private string fileStreamPath = "";
        private HospitalDBEntities dbContext = new HospitalDBEntities();

        private void MedicalRecordForm_Load(object sender, EventArgs e)
        {
            int i = random.Next(100000, 999999);
            numberLabel.Text = $"診字第{i}號";
            label17.Text = LoginForm.UserName;
            label18.Text = LoginForm.PhysicianID;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(this.PrintDocument_PrintPage);
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                CaptureScreen();
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fileStream = new FileStream(fileStreamPath, FileMode.Open, FileAccess.Read);
                byte[] data = new byte[fileStream.Length];
                fileStream.Read(data, 0, (int)fileStream.Length);

                dbContext.Diagnosis1.Add(new Diagnosis
                {
                    PatientName = patientNameTextBox.Text,
                    Sexual = sexualTextBox.Text,
                    MRN = mrnTextBox.Text,
                    IdNumber = idTextBox.Text,
                    Birthday = birthdayDTP.Value,
                    Address = addressTextBox.Text,
                    Symptoms = SymptomsRichTextBox.Text,
                    Advice = adviceRichTextBox.Text,
                    DocterID = LoginForm.UserId,
                    CreateDate = creatDTP.Value,
                    PrintDate = printDTP.Value,
                    Picture = data
                });

                dbContext.SaveChanges();

                MessageBox.Show("存檔成功!");
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image(*.JPG; *.JPEG; *.PNG)|*.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileStreamPath = pictureBox.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}