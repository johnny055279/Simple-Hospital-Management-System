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
    public partial class MessageEdit : Form
    {
        public MessageEdit()
        {
            InitializeComponent();
        }

        private HospitalDBEntities dbContext = new HospitalDBEntities();

        private void confirmButton_Click(object sender, EventArgs e)
        {
            var q = dbContext.Messageboards.Where(n => n.Id == MainPage.PostID).Select(n => n);
            try
            {
                foreach (var n in q)
                {
                    n.Content = richTextBox.Text;
                }
                dbContext.SaveChanges();
                MessageBox.Show("修改成功!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox.Enabled = false;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #region 文字編輯器功能

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBox.SelectionFont;
            Font newFont;
            if (oldFont.Underline)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            }
            richTextBox.SelectionFont = newFont;
            richTextBox.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                FontFamily family = fontDialog.Font.FontFamily;
                richTextBox.SelectionFont = new Font(family, richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);
            }
            richTextBox.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionColor = colorDialog.Color;
            }
            richTextBox.Focus();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionIndent = richTextBox.SelectionIndent + 10;
            richTextBox.Focus();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionIndent = richTextBox.SelectionIndent - 10;
            richTextBox.Focus();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBox.SelectionFont;
            Font newFont;
            if (oldFont.Bold)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);//支援位於運算
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            }
            richTextBox.SelectionFont = newFont;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBox.SelectionFont;
            Font newFont;
            if (oldFont.Underline)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Strikeout);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Strikeout);
            }
            richTextBox.SelectionFont = newFont;
            richTextBox.Focus();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBox.SelectionFont;
            Font newFont;
            if (oldFont.Italic)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            }
            richTextBox.SelectionFont = newFont;
            richTextBox.Focus();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionAlignment == HorizontalAlignment.Center)
            {
                richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            }

            richTextBox.Focus();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.Focus();
        }

        #endregion 文字編輯器功能

        private void MessageEdit_Load(object sender, EventArgs e)
        {
            var q = dbContext.Messageboards.AsEnumerable().Where(n => n.Id == MainPage.PostID).Select(n => n).ToList();

            foreach (var n in q)
            {
                label5.Text = n.Name;
                richTextBox.Text = n.Content;
                titleTextBox.Text = n.Title;
            }
        }
    }
}