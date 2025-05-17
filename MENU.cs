using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Net.NetworkInformation;

namespace GLADKOVDB
{
    public partial class MENU : Form
    {
        private string connectionString = @"Data Source=PILOTPC\SQLEXPRESS;Initial Catalog=GLADKOVDB;Integrated Security=True;Encrypt=False";
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private string currentQuery;
        db dataBase = new db();
        public MENU()
        {
            InitializeComponent();
            LoadQueries();
        }
        private void LoadData(string query)
        {
           try
            {
                // Создаем соединение с базой данных
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(query, connection);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    currentQuery = query;
                }
            }
           catch (Exception ex)
           {
               MessageBox.Show("Ошибка: " + ex.Message);
           }
        }

        private void btn_empl_Click(object sender, EventArgs e)
        {
            LoadData("select * from Employees");
        }

        private void btn_pos_Click(object sender, EventArgs e)
        {
            LoadData("select * from Positions");
        }

        private void btn_graf_Click(object sender, EventArgs e)
        {
            LoadData("select * from WorkSchedules");
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            LoadData("select * from LeaveRecords");
        }

        private void btn_train_Click(object sender, EventArgs e)
        {
            LoadData("select * from TrainingRecords");

        }        

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (adapter == null || dataTable == null)
            {
                MessageBox.Show("Нет данных для сохранения. Пожалуйста, загрузите данные сначала.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    adapter.SelectCommand = new SqlCommand(currentQuery, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    adapter.Update(dataTable);
                    MessageBox.Show("Таблица сохранена!");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Ошибка SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }
        private void LoadQueries()
        {
            // Добавляем запросы в ComboBox
            comboBoxQueries.Items.Add(new QueryItem("Получить список всех сотрудников::", "SELECT * FROM Employees;"));
            comboBoxQueries.Items.Add(new QueryItem("Получить всех активных сотрудников:", "SELECT * FROM Employees WHERE IsActive = 1;"));
            comboBoxQueries.Items.Add(new QueryItem("Получить все должности:", "SELECT * FROM Positions;"));
            comboBoxQueries.Items.Add(new QueryItem("Получить расписание работы конкретного сотрудника по ID:", "SELECT * FROM WorkSchedules WHERE EmployeeID = 1;"));
            comboBoxQueries.Items.Add(new QueryItem("Получить записи об отпусках для конкретного сотрудника:", "SELECT * FROM LeaveRecords WHERE EmployeeID = 2;"));
            comboBoxQueries.Items.Add(new QueryItem("Получить список сотрудников с их должностями:", "SELECT e.FirstName, e.LastName, p.PositionName\r\n   FROM Employees e\r\n   JOIN Positions p ON e.PositionID = p.PositionID;"));
            comboBoxQueries.Items.Add(new QueryItem("Получить количество отпусков, взятых каждым сотрудником:", "SELECT e.FirstName, e.LastName, COUNT(l.LeaveID) AS LeaveCount\r\n   FROM Employees e\r\n   LEFT JOIN LeaveRecords l ON e.EmployeeID = l.EmployeeID\r\n   GROUP BY e.FirstName, e.LastName;"));
            comboBoxQueries.Items.Add(new QueryItem("Получить сотрудников, которые прошли тренинг за последний год:", "SELECT e.FirstName, e.LastName, t.TrainingName, t.TrainingDate\r\n   FROM Employees e\r\n   JOIN TrainingRecords t ON e.EmployeeID = t.EmployeeID\r\n   WHERE t.TrainingDate >= DATEADD(YEAR, -2, GETDATE());"));
            comboBoxQueries.Items.Add(new QueryItem("Получить среднюю зарплату сотрудников по должностям:", "SELECT p.PositionName, AVG(e.Salary) AS AverageSalary\r\n   FROM Employees e\r\n   JOIN Positions p ON e.PositionID = p.PositionID\r\n   GROUP BY p.PositionName;"));
            comboBoxQueries.Items.Add(new QueryItem("Получить расписание работы всех сотрудников на конкретную дату:", "SELECT e.FirstName, e.LastName, w.WorkDate, w.StartTime, w.EndTime\r\n   FROM WorkSchedules w\r\n   JOIN Employees e ON w.EmployeeID = e.EmployeeID\r\n   WHERE w.WorkDate = '2023-10-01';"));
            // Добавьте свои запросы здесь
        }
        public class QueryItem
        {
            public string DisplayName { get; set; }
            public string Query { get; set; }

            public QueryItem(string displayName, string query)
            {
                DisplayName = displayName;
                Query = query;
            }

            public override string ToString()
            {
                return DisplayName; // Это то, что будет отображаться в ComboBox
            }
        }
        private void ExecuteQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewResults.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedItem = comboBoxQueries.SelectedItem as QueryItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите запрос из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ExecuteQuery(selectedItem.Query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string customQuery = textBoxCustomQuery.Text.Trim();
            if (string.IsNullOrEmpty(customQuery))
            {
                MessageBox.Show("Пожалуйста, введите свой SQL-запрос.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ExecuteQuery(customQuery);
            textBoxCustomQuery.Text = "";
        }
        private void btn_refresh_Click_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter($"select * from Izmeneniya", connection);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView_logi.DataSource = dataTable;              
            }
        }

        private void btn_deleteAll_Click(object sender, EventArgs e)
        {
            // Подтверждение удаления
            var result = MessageBox.Show("Вы уверены, что хотите удалить все записи?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return; // Если пользователь не подтвердил, выходим из метода
            }

            try
            {
                // Создаем команду для удаления всех записей
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM Izmeneniya", connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} записей было удалено.");
                    }
                }

                // После удаления можно обновить данные в DataTable
                dataTable.Clear(); // Очищаем DataTable
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Ошибка SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
