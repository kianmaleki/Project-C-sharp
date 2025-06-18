using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPodman5
{
    public partial class users_data : Form
    {
        public users_data()
        {
            InitializeComponent();
        }

        private void users_data_Load(object sender, EventArgs e)
        {
            // این تکه کد برای نمایش اطلاعات دیتا بیس است
            this.tb_studentsTableAdapter.Fill(this.studentsDataSet.tb_students);

        }

        private void users_data_FormClosing(object sender, FormClosingEventArgs e)
        {
            // برای خروج از برنامه
            Application.Exit();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // برای بازگشت به منو اصلی
            this.Hide();
            menu menu = new menu();
            menu.Show();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // در زمانی که روی ردیفی کلیک شود یا انتخاب تغیر کنه این بخش کد کار میکنه
            // در ابتدا با چک کردن ردیف های انتخاب شده مطمعن میشم که کاربر یک ردیف رو انتخاب کرده باشد
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // از این روش استفاده کردم چون قابلیت اینکه چند ردیف رو انتخاب کنه کاربر را غیرفعال کردم برای همین همیشه ردیف انتخاب شده ایندکس صفر داره
                int row_sel = dataGridView1.SelectedRows[0].Index;

                // در اینجا مقدار ردیف انتخاب شده را در تکست باکس های مربوط به خودش قرار دادم تا در انجام عملیات های دیگه ازش استفاده کنم
                name_txt.Text = dataGridView1.Rows[row_sel].Cells[1].Value.ToString();
                family_txt.Text = dataGridView1.Rows[row_sel].Cells[2].Value.ToString();
                phone_txt.Text = dataGridView1.Rows[row_sel].Cells[3].Value.ToString();
                address_txt.Text = dataGridView1.Rows[row_sel].Cells[4].Value.ToString();

                 
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            // در ابتدا با چک کردن ردیف های انتخاب شده مطمعن میشم که کاربر یک ردیف رو انتخاب کرده باشد
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //با نمایش یک پیغام مطعن میشم که کاربر میخواهد حذف کنه
                // اگر نخواهد عملیات ادامه پیدا نمیکنه
                if (MessageBox.Show("آیا مطمئن هستید که می‌خواهید این رکورد را حذف کنید؟", "تأیید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                // در اینجا اول ردیف انتخاب شده را پیدا میکنم
                int row_sel = dataGridView1.SelectedRows[0].Index;
                // و بعد برای حذف کردنش ایدیش رو برمیدارم و ذخیره میکنم
                int user_id = int.Parse(dataGridView1.Rows[row_sel].Cells[0].Value.ToString());
                // در اینجا با استفاده از کوئری حذفی که اماده کردم ردیف را از دیتا بیس حذف میکنم
                tb_studentsTableAdapter.DeleteQuery(user_id);
                // در اینجا پس از حذف کردن دوباره جدول را از نو نمایش میدهیم تا تغیرات نمایان شوند
                this.tb_studentsTableAdapter.Fill(this.studentsDataSet.tb_students);

                MessageBox.Show("رکورد حذف شد");
            }
            else
            {
                MessageBox.Show("لطفاً یک ردیف را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            // در ابتدا چک میکنم که تمامی تکست باکس ها پر شده باشد
            if (name_txt.Text == "" || family_txt.Text == "" || phone_txt.Text == "" || address_txt.Text == "")
            {
                MessageBox.Show("لطفاً تمام فیلدها را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // در صورتی که پر شده باشد مقدارشو در متغیر های مربوط به خودشون ذخیره میکنم

            string name = name_txt.Text;
            string family = family_txt.Text;
            string phone = phone_txt.Text;
            string address = address_txt.Text;

            // در این مرحله داده هارا با استفاده از کوئری که برای اضافه کردن اماده کردم داده هارا به دیتا بیس اضافه میکنم
            tb_studentsTableAdapter.InsertQuery(name , family , phone , address);
            // در اینجا پس از اضافه کردن دوباره جدول را از نو نمایش میدهیم تا تغیرات نمایان شوند
            this.tb_studentsTableAdapter.Fill(this.studentsDataSet.tb_students);
            
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            // این مرحله شبیه مرحله حذف است فقط با این فرق که کوئری متفاوتی داره

            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (name_txt.Text == "" || family_txt.Text == "" || phone_txt.Text == "" || address_txt.Text == "")
                {
                    MessageBox.Show("لطفاً تمام فیلدها را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int row_sel = dataGridView1.SelectedRows[0].Index;
                int user_id = int.Parse(dataGridView1.Rows[row_sel].Cells[0].Value.ToString());

                string name = name_txt.Text;
                string family = family_txt.Text;
                string phone = phone_txt.Text;
                string address = address_txt.Text;

                tb_studentsTableAdapter.UpdateQuery(name, family, phone, address, user_id);

                this.tb_studentsTableAdapter.Fill(this.studentsDataSet.tb_students);
            }
            else
            {
                MessageBox.Show("لطفاً یک ردیف را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            // در ابتدا مقدار تکست باکس فامیل را میگیریم

            string family = family_txt.Text.Trim();

            // در اینجا با استفاده از کوئری سرچی که نوشتم در دیتا بیس بر اساس فامیلی جستجو میکنم و دیتای به دست امده را در متغیری ذخیره میکنم
            var results = tb_studentsTableAdapter.search(family);
            // و در اینجا هم اطلاعات را در دیتا گرید ویو نمایش میدهم
            dataGridView1.DataSource = results;
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {

            // در اینجا ما مقدار تکست باکس هامون رو خالی میکنیم
            name_txt.Text = "";
            family_txt.Text = "";
            phone_txt.Text = "";
            address_txt.Text = "";
            // و دوباره دیتاست خودمون رو برابر تمام دیتا ها قرار میدیم
            dataGridView1.DataSource = studentsDataSet.tb_students;

        }
    }
}
