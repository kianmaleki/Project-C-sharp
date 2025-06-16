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
            // TODO: This line of code loads data into the 'studentsDataSet.tb_students' table. You can move, or remove it, as needed.
            this.tb_studentsTableAdapter.Fill(this.studentsDataSet.tb_students);

        }

        private void users_data_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.Show();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int row_sel = dataGridView1.SelectedRows[0].Index;

                name_txt.Text = dataGridView1.Rows[row_sel].Cells[1].Value.ToString();
                family_txt.Text = dataGridView1.Rows[row_sel].Cells[2].Value.ToString();
                phone_txt.Text = dataGridView1.Rows[row_sel].Cells[3].Value.ToString();
                address_txt.Text = dataGridView1.Rows[row_sel].Cells[4].Value.ToString();

                 
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                if (MessageBox.Show("آیا مطمئن هستید که می‌خواهید این رکورد را حذف کنید؟", "تأیید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                int row_sel = dataGridView1.SelectedRows[0].Index;
                int user_id = int.Parse(dataGridView1.Rows[row_sel].Cells[0].Value.ToString());

                tb_studentsTableAdapter.DeleteQuery(user_id);

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

            if (name_txt.Text == "" || family_txt.Text == "" || phone_txt.Text == "" || address_txt.Text == "")
            {
                MessageBox.Show("لطفاً تمام فیلدها را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = name_txt.Text;
            string family = family_txt.Text;
            string phone = phone_txt.Text;
            string address = address_txt.Text;

            tb_studentsTableAdapter.InsertQuery(name , family , phone , address);

            this.tb_studentsTableAdapter.Fill(this.studentsDataSet.tb_students);
            
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
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
            string family = family_txt.Text.Trim();

            var results = tb_studentsTableAdapter.search(family);
            dataGridView1.DataSource = results;
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            name_txt.Text = "";
            family_txt.Text = "";
            phone_txt.Text = "";
            address_txt.Text = "";

            this.tb_studentsTableAdapter.Fill(this.studentsDataSet.tb_students);

            dataGridView1.DataSource = studentsDataSet.tb_students;

        }
    }
}
