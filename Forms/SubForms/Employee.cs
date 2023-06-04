using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework.Classes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Coursework.Forms.SubForms
{
    public partial class Employee : Form
    {
        private SqlConnection connection;
        public Employee()
        {
            InitializeComponent();
            OpenConnection();
        }

        private void OpenConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка подключения к БД...");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToComIn_Click(object sender, EventArgs e)
        {
            int id;
            try {
                id = int.Parse(IdEmpl.Text);
            }
            catch (Exception) {
                MessageBox.Show("Неверный ID");
                return;
            }
            Enter(id);
        }

        public void Enter(int id) 
        {
            var count = SQLCommands.GetCountEmployee(id, connection);
            if (count < 1) {
                MessageBox.Show(count == -1 ? "Не удалось войти в систему" : "Сотрудника с таким ID не существует");
                return;
            }
            var mainFrm = new Form1(id);
            mainFrm.Show();
            Hide();
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Невозможно закрыть соединение");
            }

            Application.Exit();
        }

        public int AddEmployee(int code, string name, string surname, string patron) {
            return SQLCommands.AddEmployee(code, name, surname, patron, connection);
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            var regina = new RegEmployee();
            regina.ShowDialog(this);
        }
    }
}
