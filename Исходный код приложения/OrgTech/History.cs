using LoginHistoryLibrary;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class History : Form
    {
        private bool isDescending = true;
        private LoginHistoryManager historyManager = new LoginHistoryManager();

        public History()
        {
            InitializeComponent();
            LoadHistory();
            DisplayHistory();
        }

        private void LoadHistory()
        {
            string filePath = "login_history.log";
            historyManager = new LoginHistoryManager(filePath);
        }

        private void DisplayHistory()
        {
            dataGridViewHistory.DataSource = historyManager.GetHistory();
            dataGridViewHistory.Columns["Timestamp"].HeaderText = "Дата входа";
            dataGridViewHistory.Columns["Login"].HeaderText = "Логин";
            dataGridViewHistory.Columns["Success"].HeaderText = "Успешно";
        }

        private void btn_add_filter_name_Click(object sender, EventArgs e)
        {
            string filterLogin = textBoxFilterLogin.Text;
            if (string.IsNullOrEmpty(filterLogin))
            {
                MessageBox.Show("Введите логин для сортировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var filteredAttempts = historyManager.GetFilteredHistory(filterLogin);
            if (filteredAttempts.Count == 0)
            {
                MessageBox.Show("Нет записей, соответствующих указанному фильтру.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridViewHistory.DataSource = filteredAttempts;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            textBoxFilterLogin.Clear();
            DisplayHistory();
        }

        private void btn_back_to_login_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите вернуться в меню?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_date_sort_Click(object sender, EventArgs e)
        {
            isDescending = !isDescending;
            dataGridViewHistory.DataSource = historyManager.SortHistory(isDescending);
            dataGridViewHistory.Columns["Timestamp"].HeaderText = isDescending ? "Дата входа (сначала новые)" : "Дата входа (сначала старые)";
        }
    }
    }

