namespace GUI_EKZ_TRBZD.MasterForm
{
    partial class Master
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Role = new System.Windows.Forms.Label();
            this.btn_back_to_menu = new System.Windows.Forms.Button();
            this.Fio = new System.Windows.Forms.Label();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.fio_role_label = new System.Windows.Forms.Label();
            this.btn_found_requests_by_user = new System.Windows.Forms.Button();
            this.btn_reset_filters = new System.Windows.Forms.Button();
            this.textBox_found_requests = new System.Windows.Forms.TextBox();
            this.label_found = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_watch_comments = new System.Windows.Forms.Button();
            this.btn_close_work = new System.Windows.Forms.Button();
            this.btn_add_repair_parts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_count_of_requests = new System.Windows.Forms.Label();
            this.label_requests = new System.Windows.Forms.Label();
            this.dataGridView_requests_by_master = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_requests_by_master)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.Role);
            this.panel1.Controls.Add(this.btn_back_to_menu);
            this.panel1.Controls.Add(this.Fio);
            this.panel1.Controls.Add(this.pictureBox_photo);
            this.panel1.Controls.Add(this.fio_role_label);
            this.panel1.Controls.Add(this.btn_found_requests_by_user);
            this.panel1.Controls.Add(this.btn_reset_filters);
            this.panel1.Controls.Add(this.textBox_found_requests);
            this.panel1.Controls.Add(this.label_found);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 144);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.Role.Location = new System.Drawing.Point(251, 55);
            this.Role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(0, 28);
            this.Role.TabIndex = 20;
            // 
            // btn_back_to_menu
            // 
            this.btn_back_to_menu.BackColor = System.Drawing.Color.LightGray;
            this.btn_back_to_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_to_menu.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.btn_back_to_menu.Location = new System.Drawing.Point(969, 90);
            this.btn_back_to_menu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back_to_menu.Name = "btn_back_to_menu";
            this.btn_back_to_menu.Size = new System.Drawing.Size(132, 39);
            this.btn_back_to_menu.TabIndex = 7;
            this.btn_back_to_menu.Text = "Выйти";
            this.btn_back_to_menu.UseVisualStyleBackColor = false;
            this.btn_back_to_menu.Click += new System.EventHandler(this.btn_back_to_menu_Click);
            // 
            // Fio
            // 
            this.Fio.AutoSize = true;
            this.Fio.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.Fio.ForeColor = System.Drawing.Color.Black;
            this.Fio.Location = new System.Drawing.Point(251, 12);
            this.Fio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(0, 28);
            this.Fio.TabIndex = 6;
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.Location = new System.Drawing.Point(16, 12);
            this.pictureBox_photo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(213, 117);
            this.pictureBox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_photo.TabIndex = 4;
            this.pictureBox_photo.TabStop = false;
            // 
            // fio_role_label
            // 
            this.fio_role_label.AutoSize = true;
            this.fio_role_label.Location = new System.Drawing.Point(232, 12);
            this.fio_role_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fio_role_label.Name = "fio_role_label";
            this.fio_role_label.Size = new System.Drawing.Size(0, 16);
            this.fio_role_label.TabIndex = 5;
            // 
            // btn_found_requests_by_user
            // 
            this.btn_found_requests_by_user.BackColor = System.Drawing.Color.LightGray;
            this.btn_found_requests_by_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_found_requests_by_user.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.btn_found_requests_by_user.ForeColor = System.Drawing.Color.Black;
            this.btn_found_requests_by_user.Location = new System.Drawing.Point(764, 12);
            this.btn_found_requests_by_user.Margin = new System.Windows.Forms.Padding(4);
            this.btn_found_requests_by_user.Name = "btn_found_requests_by_user";
            this.btn_found_requests_by_user.Size = new System.Drawing.Size(179, 60);
            this.btn_found_requests_by_user.TabIndex = 15;
            this.btn_found_requests_by_user.Text = "Поиск заявок";
            this.btn_found_requests_by_user.UseVisualStyleBackColor = false;
            this.btn_found_requests_by_user.Click += new System.EventHandler(this.btn_found_requests_by_user_Click);
            // 
            // btn_reset_filters
            // 
            this.btn_reset_filters.BackColor = System.Drawing.Color.LightGray;
            this.btn_reset_filters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset_filters.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.btn_reset_filters.ForeColor = System.Drawing.Color.Black;
            this.btn_reset_filters.Location = new System.Drawing.Point(764, 76);
            this.btn_reset_filters.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset_filters.Name = "btn_reset_filters";
            this.btn_reset_filters.Size = new System.Drawing.Size(179, 53);
            this.btn_reset_filters.TabIndex = 19;
            this.btn_reset_filters.Text = "Сбросить параметры";
            this.btn_reset_filters.UseVisualStyleBackColor = false;
            this.btn_reset_filters.Click += new System.EventHandler(this.btn_reset_filters_Click);
            // 
            // textBox_found_requests
            // 
            this.textBox_found_requests.BackColor = System.Drawing.Color.White;
            this.textBox_found_requests.Location = new System.Drawing.Point(969, 48);
            this.textBox_found_requests.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_found_requests.Name = "textBox_found_requests";
            this.textBox_found_requests.Size = new System.Drawing.Size(223, 22);
            this.textBox_found_requests.TabIndex = 16;
            // 
            // label_found
            // 
            this.label_found.AutoSize = true;
            this.label_found.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label_found.ForeColor = System.Drawing.Color.Black;
            this.label_found.Location = new System.Drawing.Point(964, 11);
            this.label_found.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_found.Name = "label_found";
            this.label_found.Size = new System.Drawing.Size(144, 28);
            this.label_found.TabIndex = 17;
            this.label_found.Text = "Критерий поиска:";
            this.label_found.Click += new System.EventHandler(this.label_found_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.btn_watch_comments);
            this.panel2.Controls.Add(this.btn_close_work);
            this.panel2.Controls.Add(this.btn_add_repair_parts);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label_count_of_requests);
            this.panel2.Controls.Add(this.label_requests);
            this.panel2.Controls.Add(this.dataGridView_requests_by_master);
            this.panel2.Location = new System.Drawing.Point(0, 137);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 421);
            this.panel2.TabIndex = 2;
            // 
            // btn_watch_comments
            // 
            this.btn_watch_comments.BackColor = System.Drawing.Color.LightGray;
            this.btn_watch_comments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_watch_comments.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.btn_watch_comments.ForeColor = System.Drawing.Color.Black;
            this.btn_watch_comments.Location = new System.Drawing.Point(828, 327);
            this.btn_watch_comments.Margin = new System.Windows.Forms.Padding(4);
            this.btn_watch_comments.Name = "btn_watch_comments";
            this.btn_watch_comments.Size = new System.Drawing.Size(320, 39);
            this.btn_watch_comments.TabIndex = 22;
            this.btn_watch_comments.Text = "Комментарии";
            this.btn_watch_comments.UseVisualStyleBackColor = false;
            this.btn_watch_comments.Click += new System.EventHandler(this.btn_watch_comments_Click);
            // 
            // btn_close_work
            // 
            this.btn_close_work.BackColor = System.Drawing.Color.LightGray;
            this.btn_close_work.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close_work.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.btn_close_work.ForeColor = System.Drawing.Color.Black;
            this.btn_close_work.Location = new System.Drawing.Point(828, 238);
            this.btn_close_work.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close_work.Name = "btn_close_work";
            this.btn_close_work.Size = new System.Drawing.Size(320, 42);
            this.btn_close_work.TabIndex = 21;
            this.btn_close_work.Text = "Завершить работу";
            this.btn_close_work.UseVisualStyleBackColor = false;
            this.btn_close_work.Click += new System.EventHandler(this.btn_close_work_Click);
            // 
            // btn_add_repair_parts
            // 
            this.btn_add_repair_parts.BackColor = System.Drawing.Color.LightGray;
            this.btn_add_repair_parts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_repair_parts.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.btn_add_repair_parts.ForeColor = System.Drawing.Color.Black;
            this.btn_add_repair_parts.Location = new System.Drawing.Point(828, 146);
            this.btn_add_repair_parts.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_repair_parts.Name = "btn_add_repair_parts";
            this.btn_add_repair_parts.Size = new System.Drawing.Size(320, 47);
            this.btn_add_repair_parts.TabIndex = 20;
            this.btn_add_repair_parts.Text = "Заказать запчасти для ремонта";
            this.btn_add_repair_parts.UseVisualStyleBackColor = false;
            this.btn_add_repair_parts.Click += new System.EventHandler(this.btn_add_repair_parts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(856, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(856, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 13;
            // 
            // label_count_of_requests
            // 
            this.label_count_of_requests.AutoSize = true;
            this.label_count_of_requests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_count_of_requests.ForeColor = System.Drawing.Color.White;
            this.label_count_of_requests.Location = new System.Drawing.Point(844, 11);
            this.label_count_of_requests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_count_of_requests.Name = "label_count_of_requests";
            this.label_count_of_requests.Size = new System.Drawing.Size(0, 20);
            this.label_count_of_requests.TabIndex = 18;
            // 
            // label_requests
            // 
            this.label_requests.AutoSize = true;
            this.label_requests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_requests.ForeColor = System.Drawing.Color.White;
            this.label_requests.Location = new System.Drawing.Point(844, 32);
            this.label_requests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_requests.Name = "label_requests";
            this.label_requests.Size = new System.Drawing.Size(0, 20);
            this.label_requests.TabIndex = 14;
            // 
            // dataGridView_requests_by_master
            // 
            this.dataGridView_requests_by_master.AllowUserToAddRows = false;
            this.dataGridView_requests_by_master.AllowUserToDeleteRows = false;
            this.dataGridView_requests_by_master.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_requests_by_master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_requests_by_master.Location = new System.Drawing.Point(16, 146);
            this.dataGridView_requests_by_master.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_requests_by_master.Name = "dataGridView_requests_by_master";
            this.dataGridView_requests_by_master.ReadOnly = true;
            this.dataGridView_requests_by_master.RowHeadersVisible = false;
            this.dataGridView_requests_by_master.RowHeadersWidth = 51;
            this.dataGridView_requests_by_master.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_requests_by_master.Size = new System.Drawing.Size(712, 220);
            this.dataGridView_requests_by_master.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(237, 92);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 37);
            this.button3.TabIndex = 21;
            this.button3.Text = "Изменить фото";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Master";
            this.Text = "Окно мастера";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_requests_by_master)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Fio;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Label fio_role_label;
        private System.Windows.Forms.Button btn_back_to_menu;
        private System.Windows.Forms.DataGridView dataGridView_requests_by_master;
        private System.Windows.Forms.Button btn_reset_filters;
        private System.Windows.Forms.Label label_count_of_requests;
        private System.Windows.Forms.Label label_found;
        private System.Windows.Forms.TextBox textBox_found_requests;
        private System.Windows.Forms.Button btn_found_requests_by_user;
        private System.Windows.Forms.Label label_requests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_repair_parts;
        private System.Windows.Forms.Button btn_close_work;
        private System.Windows.Forms.Button btn_watch_comments;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Button button3;
    }
}