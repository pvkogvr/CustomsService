using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Coursework.Forms.SubForms;
using Coursework.Classes;

namespace Coursework
{
    public partial class Form1 : Form
    {
        private string currentTab;
        private const string SelectSQL = "select * from ";
        private string sql;
        private DataSet ds;
        private SqlDataAdapter adapter;
        public string ID { get; set; }
        public bool isCustomer { get; set; }
        public string CurrentTab
        {
            get { return currentTab; }
            set
            {
                currentTab = value;
                try
                {
                    sql = SelectSQL + currentTab;
                    adapter = new SqlDataAdapter(sql, connection);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    DGV.Visible = true;
                    DGV.DataSource = ds.Tables[0];
                    switch (currentTab) {
                        case "Supply":
                            DGV.Columns[0].HeaderText = "Номер поставки";
                            DGV.Columns[1].HeaderText = "ID номер поставщика";
                            DGV.Columns[2].HeaderText = "ID номер заказчика";
                            DGV.Columns[3].HeaderText = "ТНВЭД";
                            DGV.Columns[4].HeaderText = "Общая масса";
                            AddSupl.Visible = true;
                            break;
                        case "Customer":
                            DGV.Columns[0].HeaderText = "ID Компании заказчика";
                            DGV.Columns[1].HeaderText = "Фамилия заказчика";
                            DGV.Columns[2].HeaderText = "№ Телефона";
                            DGV.Columns[3].HeaderText = "Адрес заказчика";
                            DGV.Columns[4].HeaderText = "Email заказчика";
                            AddSupl.Visible = false;
                            break;
                        case "Supplier":
                            DGV.Columns[0].HeaderText = "ID Компании поставщика";
                            DGV.Columns[1].HeaderText = "Фамилия поставщика";
                            DGV.Columns[2].HeaderText = "№ Телефона";
                            DGV.Columns[3].HeaderText = "Адрес поставщика";
                            DGV.Columns[4].HeaderText = "Email поставщика";
                            AddSupl.Visible = false;
                            break;
                        case "CustDeclar":
                            DGV.Columns[0].HeaderText = "№ Таможенной декларации";
                            DGV.Columns[1].HeaderText = "Тип декларации";
                            DGV.Columns[2].HeaderText = "№ Поставки";
                            DGV.Columns[3].HeaderText = "Количество товаров";
                            DGV.Columns[4].HeaderText = "ID ТС вне страны";
                            DGV.Columns[5].HeaderText = "Цена";
                            DGV.Columns[6].HeaderText = "ID ТС в стране";
                            DGV.Columns[7].HeaderText = "№ Таможни";
                            DGV.Columns[8].HeaderText = "Таможенный налог";
                            DGV.Columns[9].HeaderText = "Квота по объему";
                            DGV.Columns[10].HeaderText = "ID Сотрудника";
                            DGV.Columns[11].HeaderText = "Дата декларации";
                            AddSupl.Visible = false;
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Не удается загрузить данные");
                }
            }
        }
        private string connectionString;
        private SqlConnection connection;
        private int EmployeeId;

        public Form1(int id)
        {
            InitializeComponent();
            Init(id); 
        }

        private void OpenConnection()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
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

        private void Init(int id)
        {
            OpenConnection();
            CurrentTab = "Supply";
            DGV.Visible = false;
            AddSupl.Visible = false;
            EmployeeId = id;
        }

        private void PostavkaS(object sender, EventArgs e)
        {
            CurrentTab = "Supply";
            DGV.Visible = true;
            DeleteCustDec.Visible = false;
            DelSupply.Visible = true;
            Update.Visible = false;
            Search.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void CustomersList(object sender, EventArgs e)
        {
            CurrentTab = "Customer";
            DGV.Visible = true;
            DeleteCustDec.Visible = false;
            DelSupply.Visible = false;
            Update.Visible = true;
            Search.Visible = false;
        }

        private void SuppliersList(object sender, EventArgs e)
        {
            CurrentTab = "Supplier";
            DGV.Visible = true;
            DeleteCustDec.Visible = false;
            DelSupply.Visible = false;
            Update.Visible = true;
            Search.Visible = false;
        }

        private void Declra(object sender, EventArgs e)
        {
            CurrentTab = "CustDeclar";
            DGV.Visible = true;
            DeleteCustDec.Visible = true;
            DelSupply.Visible = false;
            Update.Visible = false;
            Search.Visible = false;
        }

        private void DGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {   if(CurrentTab != "Supply")
            {
                return;
            }
            var numbSupply = int.Parse(DGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (SQLCommands.NotAddSupply(numbSupply, connection) != 0) {
                MessageBox.Show("Невозможно добавить декларацию для данной поставки");
                return;
            }
            var addSub = new CusDeclar(connection, numbSupply);
            addSub.ShowDialog(this);
        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            var addSub = new AddSupplier(connection, "Supplier");
            addSub.ShowDialog(this);
        }

        private void AddCustomerMenu_Click(object sender, EventArgs e)
        {
            var addSub = new AddSupplier(connection, "Customer");
            addSub.ShowDialog(this);
        }

        private void AddSupl_Click(object sender, EventArgs e)
        {
            var addSup = new Supply(connection);
            addSup.ShowDialog(this);
        }

        private void EmplList_Click(object sender, EventArgs e)
        {
            CurrentTab = "Employee";
            DGV.Visible = true;
            DeleteCustDec.Visible = false;
            AddSupl.Visible = false;
            Update.Visible = false;
            Search.Visible = false;
            DelSupply.Visible = false;
        }

        private void DeleteCustDec_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < DGV.SelectedRows.Count; i++) {
                var res = SQLCommands.DeleteCustDec(int.Parse(DGV.SelectedRows[i].Cells[0].Value.ToString()), connection);
                if (res != null) {
                    MessageBox.Show(res);
                    return;
                }
            } 
            CurrentTab = "CustDeclar";

            MessageBox.Show("Удаление прошло успешно!");
        }

        private void DelSupply_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < DGV.SelectedRows.Count; i++)
            {
                var res = SQLCommands.DeleteSupply(int.Parse(DGV.SelectedRows[i].Cells[0].Value.ToString()), connection);
                if (res != null)
                {
                    MessageBox.Show(res);
                    return;
                }
            }
            CurrentTab = "Supply";

            MessageBox.Show("Удаление прошло успешно!");
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var id = int.Parse(DGV.SelectedRows[0].Cells[0].Value.ToString());
            var fio = DGV.SelectedRows[0].Cells[1].Value.ToString();
            var phone = DGV.SelectedRows[0].Cells[2].Value.ToString();
            var address = DGV.SelectedRows[0].Cells[3].Value.ToString();
            var email = DGV.SelectedRows[0].Cells[4].Value.ToString();

            var upd = new AddSupplier(
                connection,
                CurrentTab, 
                fio,
                phone,
                address,
                email,
                id
            );
            upd.ShowDialog(this);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var addSub = new Search();
            addSub.ShowDialog(this);

            DGV.CurrentCell = null;
            for (var i = 0; i < DGV.Rows.Count; i++)
                if (DGV.Rows[i].Cells[2].Value.ToString() == ID && isCustomer)
                    DGV.Rows[i].Visible = true;
                else if (DGV.Rows[i].Cells[1].Value.ToString() == ID && !isCustomer)
                    DGV.Rows[i].Visible = true;
                else
                    DGV.Rows[i].Visible = false;
        }
    }
}
