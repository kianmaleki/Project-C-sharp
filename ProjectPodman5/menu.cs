﻿using System;
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

        // منو شامل دو دکمه است که با انها میتوان به پروژه مربوط رفت

        private void notepad_btn_Click(object sender, EventArgs e)
        {
            // در اینجا فرم منو مخفی میشود و فرم نوت پد ظاهر میشود
            this.Hide();
            notepad notepad = new notepad();
            notepad.Show();
        }

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // در این بخش با بسته شدن فرم کل پروژه بسته میشود
            Application.Exit();
        }

        private void users_data_btn_Click(object sender, EventArgs e)
        {
            // در اینجا فرم منو مخفی میشود و فرم اطلاعات کاربران ظاهر میشود

            this.Hide();
            users_data usersData = new users_data();
            usersData.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
