using System;
using System.IO;
using System.Windows.Forms;

namespace ProjectPodman5
{
    public partial class notepad : Form
    {
        // اینجا در ابتدا یک متغیر ساختم که بتونم در صورت نیاز ادرس فایل فعلی رو در اون ذخیره کنم و در بخش های مختلف ازش استفاده کنم
        string currentFilePath = "";

        public notepad()
        {
            InitializeComponent();
        }

        private void exiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // در اینجا برای دکمه خروجی کدی تنظیم کردم که پروژه کاملا بسته شود
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // در اینحا اگر کاربر دکمه نیو را بزنه یا اینکه از شرت کاتش استفاده کنه محتوای درون تکست باکس نوت پد خالی میشود و اینکه مقدار ادرس فعلی هم برابر خالی میشود
            textBox_notepad.Text = "";
            currentFilePath = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // در اینجا از شرطی استفاده شده تا بتوانیم رفتار کاربر در انتخاب فایل را برسی کنیم و متوجه بشویم ایا فایل انتخاب کرده با نه
            // و اینکه برسی شده که ایا پسوند ان فایل تکست است یا نه
            // در اینجا میشد که از روش دیگری برای شناسایی پسوند استفاده کرد که من ترجیح دادم از این روش استفاده کنم (Contains)
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.EndsWith(".txt"))
            {
                //اینجا ما با استفاده از فایل میاییم و اطلاعات فایلی که کاربر انتخاب کرده است را میخونیم و در تکست باکس نوت پد قرار میئیم
                textBox_notepad.Text = File.ReadAllText(openFileDialog1.FileName);
                // و در اینجا هم مقدار مسیر فایل فعلی رو مقدار دهی میکنیم تا در سیو به مشکل نخوریم
                currentFilePath = openFileDialog1.FileName;
            }
            else
            {
                // اگر شرط درست نباشد یک پیغام خطا نشان میدهد تا کاربر مشکل را متوجه شود
                MessageBox.Show("لطفا یک فایل متنی (.txt) انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // اینجا در ابتدا چک میشه که ایا این فایل وجود داد یا خیر ( در صورت باز شدن فایل ذخیره شده )
            if (File.Exists(currentFilePath))
            {
                // اگر باشد با استفاده از فایل و با مسیر فعلی میتونیم محتوای درون تکست باکس نوت پد را ذخیره کنیم
                File.WriteAllText(currentFilePath, textBox_notepad.Text);
                MessageBox.Show("فایل ذخیره شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // در غیر این صورت با استفاده از سیو فایل دیالوگ مسیر و نامی که که کاربر میخواد فایل را ذخیره کند را میگیریم
                // و فیلتر هم میکنیم که باید با پسوند تکست ذخیره شود
                saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                // در اینجا چک میکنیم که کاربر حتما مسیر و نامی انتخاب کرده باشد
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // در اینجا با استفاده از فایل متن درون تکست باکس نوت پد را درون فایلی با اطلاعاتی که کاربر مشخص کرده است میریزیم
                    File.WriteAllText(saveFileDialog1.FileName, textBox_notepad.Text);
                    // و سپس مسیر فعلی فایل را مقدار دهی میکنیم تا بتوانیم در سیو کردن عادی ازش استفاده کنیم
                    currentFilePath = saveFileDialog1.FileName;
                    MessageBox.Show("فایل با موفقیت ذخیره شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // در اینجا دقیقا مانند بخشی در غیر این صورت کد سیو مینویسیم ( به خاطر اینکه در اونجا زمانی میرفت سراغ در غیر این صورت که فایلی وجود نداشت و در اینحا هم ما میخواهیم در مسیر جدیدی ذخیره کنیم)
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
            // این بخش هم برای این است که کاربر بخواهد که به منو اصلی برود
            this.Hide();
            menu mainMenu = new menu();
            mainMenu.Show();
        }

        
    }
}
