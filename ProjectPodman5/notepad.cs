using System;
using System.IO;
using System.Windows.Forms;

namespace ProjectPodman5
{
    public partial class notepad : Form
    {

        string currentFilePath = "";

        public notepad()
        {
            InitializeComponent();
        }

        private void exiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_notepad.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.EndsWith(".txt"))
            {
                textBox_notepad.Text = File.ReadAllText(openFileDialog1.FileName);
                currentFilePath = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("لطفا یک فایل متنی (.txt) انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(currentFilePath))
            {
                File.WriteAllText(currentFilePath, textBox_notepad.Text);
                MessageBox.Show("فایل ذخیره شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, textBox_notepad.Text);
                    currentFilePath = saveFileDialog1.FileName;
                    MessageBox.Show("فایل با موفقیت ذخیره شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox_notepad.Text);
                currentFilePath = saveFileDialog1.FileName;
                MessageBox.Show("فایل با موفقیت ذخیره شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mainMenu = new menu();
            mainMenu.Show();
        }
    }
}
