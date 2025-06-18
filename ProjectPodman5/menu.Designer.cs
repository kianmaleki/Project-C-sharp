namespace ProjectPodman5
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.notepad_btn = new System.Windows.Forms.Button();
            this.users_data_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notepad_btn
            // 
            this.notepad_btn.Location = new System.Drawing.Point(18, 18);
            this.notepad_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.notepad_btn.Name = "notepad_btn";
            this.notepad_btn.Size = new System.Drawing.Size(447, 85);
            this.notepad_btn.TabIndex = 0;
            this.notepad_btn.Text = "Notepad";
            this.notepad_btn.UseVisualStyleBackColor = true;
            this.notepad_btn.Click += new System.EventHandler(this.notepad_btn_Click);
            // 
            // users_data_btn
            // 
            this.users_data_btn.Location = new System.Drawing.Point(18, 117);
            this.users_data_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.users_data_btn.Name = "users_data_btn";
            this.users_data_btn.Size = new System.Drawing.Size(447, 85);
            this.users_data_btn.TabIndex = 0;
            this.users_data_btn.Text = "Users data";
            this.users_data_btn.UseVisualStyleBackColor = true;
            this.users_data_btn.Click += new System.EventHandler(this.users_data_btn_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 220);
            this.Controls.Add(this.users_data_btn);
            this.Controls.Add(this.notepad_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "menu";
            this.Text = "menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_FormClosing);
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button notepad_btn;
        private System.Windows.Forms.Button users_data_btn;
    }
}