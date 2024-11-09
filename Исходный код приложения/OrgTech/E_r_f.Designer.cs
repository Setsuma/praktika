namespace GUI
{
    partial class E_r_f
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
            this.comboBox_DeviceModels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add_request = new System.Windows.Forms.Button();
            this.textBox_Description_problem = new System.Windows.Forms.TextBox();
            this.label_dicription = new System.Windows.Forms.Label();
            this.comboBox_DeviceTypes = new System.Windows.Forms.ComboBox();
            this.label_device = new System.Windows.Forms.Label();
            this.textBox_FIO = new System.Windows.Forms.TextBox();
            this.label_FIO = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label_info);
            this.panel1.Controls.Add(this.back_to_menu);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 123);
            this.panel1.TabIndex = 0;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label_info.Location = new System.Drawing.Point(131, 78);
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
            this.back_to_menu.Location = new System.Drawing.Point(300, 15);
            this.back_to_menu.Margin = new System.Windows.Forms.Padding(4);
            this.back_to_menu.Name = "back_to_menu";
            this.back_to_menu.Size = new System.Drawing.Size(225, 54);
            this.back_to_menu.TabIndex = 4;
            this.back_to_menu.Text = "Вернуться в меню";
            this.back_to_menu.UseVisualStyleBackColor = false;
            this.back_to_menu.Click += new System.EventHandler(this.back_to_menu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.comboBox_DeviceModels);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_add_request);
            this.panel2.Controls.Add(this.textBox_Description_problem);
            this.panel2.Controls.Add(this.label_dicription);
            this.panel2.Controls.Add(this.comboBox_DeviceTypes);
            this.panel2.Controls.Add(this.label_device);
            this.panel2.Controls.Add(this.textBox_FIO);
            this.panel2.Controls.Add(this.label_FIO);
            this.panel2.Location = new System.Drawing.Point(-1, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.MaximumSize = new System.Drawing.Size(533, 394);
            this.panel2.MinimumSize = new System.Drawing.Size(533, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 394);
            this.panel2.TabIndex = 1;
            // 
            // comboBox_DeviceModels
            // 
            this.comboBox_DeviceModels.FormattingEnabled = true;
            this.comboBox_DeviceModels.Location = new System.Drawing.Point(187, 143);
            this.comboBox_DeviceModels.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_DeviceModels.Name = "comboBox_DeviceModels";
            this.comboBox_DeviceModels.Size = new System.Drawing.Size(303, 24);
            this.comboBox_DeviceModels.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(99, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Модель:";
            // 
            // button_add_request
            // 
            this.button_add_request.BackColor = System.Drawing.Color.LightGray;
            this.button_add_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_request.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.button_add_request.Location = new System.Drawing.Point(189, 297);
            this.button_add_request.Margin = new System.Windows.Forms.Padding(4);
            this.button_add_request.Name = "button_add_request";
            this.button_add_request.Size = new System.Drawing.Size(215, 42);
            this.button_add_request.TabIndex = 19;
            this.button_add_request.Text = "Изменить заявку";
            this.button_add_request.UseVisualStyleBackColor = false;
            this.button_add_request.Click += new System.EventHandler(this.button_add_request_Click);
            // 
            // textBox_Description_problem
            // 
            this.textBox_Description_problem.Location = new System.Drawing.Point(187, 193);
            this.textBox_Description_problem.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Description_problem.Name = "textBox_Description_problem";
            this.textBox_Description_problem.Size = new System.Drawing.Size(303, 22);
            this.textBox_Description_problem.TabIndex = 16;
            // 
            // label_dicription
            // 
            this.label_dicription.AutoSize = true;
            this.label_dicription.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label_dicription.ForeColor = System.Drawing.Color.Black;
            this.label_dicription.Location = new System.Drawing.Point(91, 186);
            this.label_dicription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dicription.Name = "label_dicription";
            this.label_dicription.Size = new System.Drawing.Size(89, 28);
            this.label_dicription.TabIndex = 15;
            this.label_dicription.Text = "Описание:";
            // 
            // comboBox_DeviceTypes
            // 
            this.comboBox_DeviceTypes.FormattingEnabled = true;
            this.comboBox_DeviceTypes.Location = new System.Drawing.Point(189, 103);
            this.comboBox_DeviceTypes.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_DeviceTypes.Name = "comboBox_DeviceTypes";
            this.comboBox_DeviceTypes.Size = new System.Drawing.Size(303, 24);
            this.comboBox_DeviceTypes.TabIndex = 14;
            // 
            // label_device
            // 
            this.label_device.AutoSize = true;
            this.label_device.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label_device.ForeColor = System.Drawing.Color.Black;
            this.label_device.Location = new System.Drawing.Point(71, 103);
            this.label_device.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_device.Name = "label_device";
            this.label_device.Size = new System.Drawing.Size(110, 28);
            this.label_device.TabIndex = 13;
            this.label_device.Text = "Вид техники:";
            // 
            // textBox_FIO
            // 
            this.textBox_FIO.Location = new System.Drawing.Point(187, 60);
            this.textBox_FIO.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_FIO.Name = "textBox_FIO";
            this.textBox_FIO.Size = new System.Drawing.Size(303, 22);
            this.textBox_FIO.TabIndex = 12;
            // 
            // label_FIO
            // 
            this.label_FIO.AutoSize = true;
            this.label_FIO.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label_FIO.ForeColor = System.Drawing.Color.Black;
            this.label_FIO.Location = new System.Drawing.Point(119, 65);
            this.label_FIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FIO.Name = "label_FIO";
            this.label_FIO.Size = new System.Drawing.Size(48, 28);
            this.label_FIO.TabIndex = 11;
            this.label_FIO.Text = "ФИО:";
            // 
            // E_r_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(554, 542);
            this.MinimumSize = new System.Drawing.Size(554, 542);
            this.Name = "E_r_f";
            this.Text = "Изменение заявки на ремонт";
            this.Load += new System.EventHandler(this.Edit_request_form_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add_request;
        private System.Windows.Forms.TextBox textBox_Description_problem;
        private System.Windows.Forms.Label label_dicription;
        private System.Windows.Forms.ComboBox comboBox_DeviceTypes;
        private System.Windows.Forms.Label label_device;
        private System.Windows.Forms.TextBox textBox_FIO;
        private System.Windows.Forms.Label label_FIO;
        private System.Windows.Forms.ComboBox comboBox_DeviceModels;
    }
}