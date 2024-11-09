namespace GUI_EKZ_TRBZD.MasterForm
{
    partial class Add_repair_parts
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
            this.back_to_menu = new System.Windows.Forms.Button();
            this.label_info = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_add_repair_parts = new System.Windows.Forms.Button();
            this.label_repair_parts = new System.Windows.Forms.Label();
            this.comboBox_repair_parts = new System.Windows.Forms.ComboBox();
            this.label_id_request = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.back_to_menu);
            this.panel1.Controls.Add(this.label_info);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 123);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // back_to_menu
            // 
            this.back_to_menu.BackColor = System.Drawing.Color.LightGray;
            this.back_to_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_to_menu.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.back_to_menu.Location = new System.Drawing.Point(297, 15);
            this.back_to_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_to_menu.Name = "back_to_menu";
            this.back_to_menu.Size = new System.Drawing.Size(201, 46);
            this.back_to_menu.TabIndex = 1;
            this.back_to_menu.Text = "Вернуться в меню";
            this.back_to_menu.UseVisualStyleBackColor = false;
            this.back_to_menu.Click += new System.EventHandler(this.back_to_menu_Click);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label_info.Location = new System.Drawing.Point(133, 85);
            this.label_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(237, 28);
            this.label_info.TabIndex = 2;
            this.label_info.Text = "Заказ запчастей для ремонта";
            this.label_info.Click += new System.EventHandler(this.label_info_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.button_add_repair_parts);
            this.panel2.Controls.Add(this.label_repair_parts);
            this.panel2.Controls.Add(this.comboBox_repair_parts);
            this.panel2.Controls.Add(this.label_id_request);
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 447);
            this.panel2.TabIndex = 2;
            // 
            // button_add_repair_parts
            // 
            this.button_add_repair_parts.BackColor = System.Drawing.Color.LightGray;
            this.button_add_repair_parts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_repair_parts.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.button_add_repair_parts.Location = new System.Drawing.Point(139, 295);
            this.button_add_repair_parts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_add_repair_parts.Name = "button_add_repair_parts";
            this.button_add_repair_parts.Size = new System.Drawing.Size(232, 42);
            this.button_add_repair_parts.TabIndex = 33;
            this.button_add_repair_parts.Text = "Отправить";
            this.button_add_repair_parts.UseVisualStyleBackColor = false;
            this.button_add_repair_parts.Click += new System.EventHandler(this.button_add_repair_parts_Click);
            // 
            // label_repair_parts
            // 
            this.label_repair_parts.AutoSize = true;
            this.label_repair_parts.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Underline);
            this.label_repair_parts.ForeColor = System.Drawing.Color.Black;
            this.label_repair_parts.Location = new System.Drawing.Point(19, 98);
            this.label_repair_parts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_repair_parts.Name = "label_repair_parts";
            this.label_repair_parts.Size = new System.Drawing.Size(157, 28);
            this.label_repair_parts.TabIndex = 2;
            this.label_repair_parts.Text = "Выберите запчасть";
            // 
            // comboBox_repair_parts
            // 
            this.comboBox_repair_parts.FormattingEnabled = true;
            this.comboBox_repair_parts.Location = new System.Drawing.Point(23, 135);
            this.comboBox_repair_parts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_repair_parts.Name = "comboBox_repair_parts";
            this.comboBox_repair_parts.Size = new System.Drawing.Size(329, 24);
            this.comboBox_repair_parts.TabIndex = 1;
            // 
            // label_id_request
            // 
            this.label_id_request.AutoSize = true;
            this.label_id_request.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_id_request.ForeColor = System.Drawing.Color.White;
            this.label_id_request.Location = new System.Drawing.Point(47, 53);
            this.label_id_request.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id_request.Name = "label_id_request";
            this.label_id_request.Size = new System.Drawing.Size(0, 20);
            this.label_id_request.TabIndex = 0;
            // 
            // Add_repair_parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Add_repair_parts";
            this.Text = "Заказ запчастей";
            this.Load += new System.EventHandler(this.Add_repair_parts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back_to_menu;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_id_request;
        private System.Windows.Forms.Label label_repair_parts;
        private System.Windows.Forms.ComboBox comboBox_repair_parts;
        private System.Windows.Forms.Button button_add_repair_parts;
    }
}