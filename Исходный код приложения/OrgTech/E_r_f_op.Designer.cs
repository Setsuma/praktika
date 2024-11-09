namespace GUI
{
    partial class E_r_f_op
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
            this.label_info = new System.Windows.Forms.Label();
            this.back_to_menu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_masters = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_repair_parts = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_end_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Status_request = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_start_date = new System.Windows.Forms.DateTimePicker();
            this.button_add_request = new System.Windows.Forms.Button();
            this.textBox_Description_problem = new System.Windows.Forms.TextBox();
            this.label_dicription = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label_info);
            this.panel1.Controls.Add(this.back_to_menu);
            this.panel1.Location = new System.Drawing.Point(-29, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 123);
            this.panel1.TabIndex = 1;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label_info.Location = new System.Drawing.Point(171, 75);
            this.label_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(274, 28);
            this.label_info.TabIndex = 3;
            this.label_info.Text = "Редактирование заявки на ремонт";
            // 
            // back_to_menu
            // 
            this.back_to_menu.BackColor = System.Drawing.Color.LightGray;
            this.back_to_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_to_menu.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.back_to_menu.Location = new System.Drawing.Point(349, 15);
            this.back_to_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_to_menu.Name = "back_to_menu";
            this.back_to_menu.Size = new System.Drawing.Size(207, 43);
            this.back_to_menu.TabIndex = 4;
            this.back_to_menu.Text = "Вернуться в меню";
            this.back_to_menu.UseVisualStyleBackColor = false;
            this.back_to_menu.Click += new System.EventHandler(this.back_to_menu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.comboBox_masters);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBox_repair_parts);
            this.panel2.Controls.Add(this.dateTimePicker_end_date);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBox_Status_request);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTimePicker_start_date);
            this.panel2.Controls.Add(this.button_add_request);
            this.panel2.Controls.Add(this.textBox_Description_problem);
            this.panel2.Controls.Add(this.label_dicription);
            this.panel2.Location = new System.Drawing.Point(-1, 106);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 368);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // comboBox_masters
            // 
            this.comboBox_masters.FormattingEnabled = true;
            this.comboBox_masters.Location = new System.Drawing.Point(190, 218);
            this.comboBox_masters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_masters.Name = "comboBox_masters";
            this.comboBox_masters.Size = new System.Drawing.Size(307, 24);
            this.comboBox_masters.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(107, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 28);
            this.label6.TabIndex = 46;
            this.label6.Text = "Мастер:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(49, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 28);
            this.label5.TabIndex = 45;
            this.label5.Text = "Части ремонта:";
            // 
            // comboBox_repair_parts
            // 
            this.comboBox_repair_parts.FormattingEnabled = true;
            this.comboBox_repair_parts.Location = new System.Drawing.Point(190, 185);
            this.comboBox_repair_parts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_repair_parts.Name = "comboBox_repair_parts";
            this.comboBox_repair_parts.Size = new System.Drawing.Size(307, 24);
            this.comboBox_repair_parts.TabIndex = 44;
            // 
            // dateTimePicker_end_date
            // 
            this.dateTimePicker_end_date.Location = new System.Drawing.Point(190, 153);
            this.dateTimePicker_end_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_end_date.Name = "dateTimePicker_end_date";
            this.dateTimePicker_end_date.Size = new System.Drawing.Size(305, 22);
            this.dateTimePicker_end_date.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(71, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 28);
            this.label4.TabIndex = 42;
            this.label4.Text = "Дата конца:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(107, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Статус:";
            // 
            // comboBox_Status_request
            // 
            this.comboBox_Status_request.FormattingEnabled = true;
            this.comboBox_Status_request.Location = new System.Drawing.Point(192, 119);
            this.comboBox_Status_request.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Status_request.Name = "comboBox_Status_request";
            this.comboBox_Status_request.Size = new System.Drawing.Size(305, 24);
            this.comboBox_Status_request.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 38;
            this.label2.Text = "Дата начала:";
            // 
            // dateTimePicker_start_date
            // 
            this.dateTimePicker_start_date.Location = new System.Drawing.Point(192, 55);
            this.dateTimePicker_start_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_start_date.Name = "dateTimePicker_start_date";
            this.dateTimePicker_start_date.Size = new System.Drawing.Size(305, 22);
            this.dateTimePicker_start_date.TabIndex = 37;
            // 
            // button_add_request
            // 
            this.button_add_request.BackColor = System.Drawing.Color.LightGray;
            this.button_add_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_request.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.button_add_request.Location = new System.Drawing.Point(179, 284);
            this.button_add_request.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_add_request.Name = "button_add_request";
            this.button_add_request.Size = new System.Drawing.Size(215, 42);
            this.button_add_request.TabIndex = 32;
            this.button_add_request.Text = "Сохранить\r\n";
            this.button_add_request.UseVisualStyleBackColor = false;
            this.button_add_request.Click += new System.EventHandler(this.button_add_request_Click);
            // 
            // textBox_Description_problem
            // 
            this.textBox_Description_problem.Location = new System.Drawing.Point(192, 87);
            this.textBox_Description_problem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Description_problem.Name = "textBox_Description_problem";
            this.textBox_Description_problem.Size = new System.Drawing.Size(305, 22);
            this.textBox_Description_problem.TabIndex = 29;
            // 
            // label_dicription
            // 
            this.label_dicription.AutoSize = true;
            this.label_dicription.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label_dicription.ForeColor = System.Drawing.Color.Black;
            this.label_dicription.Location = new System.Drawing.Point(84, 81);
            this.label_dicription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dicription.Name = "label_dicription";
            this.label_dicription.Size = new System.Drawing.Size(89, 28);
            this.label_dicription.TabIndex = 28;
            this.label_dicription.Text = "Описание:";
            // 
            // E_r_f_op
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(554, 504);
            this.MinimumSize = new System.Drawing.Size(554, 504);
            this.Name = "E_r_f_op";
            this.Text = "Заполнение заявки";
            this.Load += new System.EventHandler(this.Edit_request_form_operator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button back_to_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start_date;
        private System.Windows.Forms.Button button_add_request;
        private System.Windows.Forms.TextBox textBox_Description_problem;
        private System.Windows.Forms.Label label_dicription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Status_request;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_repair_parts;
        private System.Windows.Forms.ComboBox comboBox_masters;
    }
}