namespace ProjectPodman5
{
    partial class users_data
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbstudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new ProjectPodman5.studentsDataSet();
            this.remove_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.family_txt = new System.Windows.Forms.TextBox();
            this.family_lbl = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.address_lbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_studentsTableAdapter = new ProjectPodman5.studentsDataSetTableAdapters.tb_studentsTableAdapter();
            this.search_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbstudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbstudentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 329);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "family";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            this.familyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbstudentsBindingSource
            // 
            this.tbstudentsBindingSource.DataMember = "tb_students";
            this.tbstudentsBindingSource.DataSource = this.studentsDataSet;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "studentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.Red;
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.ForeColor = System.Drawing.Color.White;
            this.remove_btn.Location = new System.Drawing.Point(12, 403);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(92, 35);
            this.remove_btn.TabIndex = 1;
            this.remove_btn.Text = "Remove user";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Location = new System.Drawing.Point(110, 403);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 35);
            this.edit_btn.TabIndex = 1;
            this.edit_btn.Text = "Edit user";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Lime;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(191, 403);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 35);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Add user";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // name_txt
            // 
            this.name_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_txt.Location = new System.Drawing.Point(688, 412);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 2;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(753, 396);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(35, 13);
            this.name_lbl.TabIndex = 3;
            this.name_lbl.Text = "Name";
            // 
            // family_txt
            // 
            this.family_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.family_txt.Location = new System.Drawing.Point(584, 412);
            this.family_txt.Name = "family_txt";
            this.family_txt.Size = new System.Drawing.Size(100, 20);
            this.family_txt.TabIndex = 2;
            // 
            // family_lbl
            // 
            this.family_lbl.AutoSize = true;
            this.family_lbl.Location = new System.Drawing.Point(649, 396);
            this.family_lbl.Name = "family_lbl";
            this.family_lbl.Size = new System.Drawing.Size(36, 13);
            this.family_lbl.TabIndex = 3;
            this.family_lbl.Text = "Family";
            // 
            // phone_txt
            // 
            this.phone_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_txt.Location = new System.Drawing.Point(478, 412);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(100, 20);
            this.phone_txt.TabIndex = 2;
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.Location = new System.Drawing.Point(543, 396);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(38, 13);
            this.phone_lbl.TabIndex = 3;
            this.phone_lbl.Text = "Phone";
            // 
            // address_txt
            // 
            this.address_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_txt.Location = new System.Drawing.Point(372, 412);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(100, 20);
            this.address_txt.TabIndex = 2;
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.Location = new System.Drawing.Point(437, 396);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(45, 13);
            this.address_lbl.TabIndex = 3;
            this.address_lbl.Text = "Address";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // tb_studentsTableAdapter
            // 
            this.tb_studentsTableAdapter.ClearBeforeFill = true;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Cyan;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(272, 403);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(92, 35);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.Magenta;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Location = new System.Drawing.Point(12, 362);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(352, 35);
            this.refresh_btn.TabIndex = 1;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // users_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.address_lbl);
            this.Controls.Add(this.phone_lbl);
            this.Controls.Add(this.family_lbl);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.family_txt);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "users_data";
            this.Text = "users_data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.users_data_FormClosing);
            this.Load += new System.EventHandler(this.users_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbstudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private studentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource tbstudentsBindingSource;
        private studentsDataSetTableAdapters.tb_studentsTableAdapter tb_studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox family_txt;
        private System.Windows.Forms.Label family_lbl;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button refresh_btn;
    }
}