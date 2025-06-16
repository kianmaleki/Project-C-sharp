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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void notepad_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            notepad notepad = new notepad();
            notepad.Show();
        }

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void users_data_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            users_data usersData = new users_data();
            usersData.Show();
        }
    }
}
