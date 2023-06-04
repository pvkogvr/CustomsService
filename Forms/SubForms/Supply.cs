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
using System.Data;
using Coursework.Classes;

namespace Coursework.Forms.SubForms
{
    public partial class Supply : Form
    {
        private SqlConnection connection;
        public Supply(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            InitCustomers();
            InitSuppliers();
        }

        private void InitCustomers() {
            try {
                var sql = "select CusIdCompany, CusFIO, CusTelNumber from Customer";
                var adapter = new SqlDataAdapter(sql, connection);
                var ds = new DataSet();

                adapter.Fill(ds);
                CustomersList.DataSource = ds.Tables[0];
                CustomersList.Columns[1].HeaderText = "Фамилия заказчика";
                CustomersList.Columns[2].HeaderText = "№ Телефона";
                CustomersList.Columns[0].Visible = false;
                CustomersList.RowHeadersVisible = false;
            }
            catch (InvalidOperationException ex) {
                MessageBox.Show("Не удается загрузить данные");
                this.Close();
            }
        }

        private void InitSuppliers() {
            try {
                var sql = "select SupIdCompany, SupFIO, SupTelNumber from Supplier";
                var adapter = new SqlDataAdapter(sql, connection);
                var ds = new DataSet();

                adapter.Fill(ds);
                SuppliersList.DataSource = ds.Tables[0];
                SuppliersList.Columns[1].HeaderText = "Фамилия поставщика";
                SuppliersList.Columns[2].HeaderText = "№ Телефона";
                SuppliersList.Columns[0].Visible = false;
                SuppliersList.RowHeadersVisible = false;
            }
            catch (InvalidOperationException) {
                MessageBox.Show("Не удается загрузить данные");
                this.Close();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddSupply_Click(object sender, EventArgs e)
        {
            var supId = int.Parse(SuppliersList.SelectedRows[0].Cells[0].Value.ToString());
            var cusId = int.Parse(CustomersList.SelectedRows[0].Cells[0].Value.ToString());
            try {
                var code = CBCNFEA.SelectedItem != null ? int.Parse(CBCNFEA.SelectedItem.ToString().Split(':')[0]) : -1;
                var weight = int.Parse(WeightSup.Text);

                if (weight <= 0)
                    throw new Exception();

                if (code <= 0)
                    throw new Exception();

                var result = SQLCommands.AddSupply(
                    supId,
                    cusId,
                    code,
                    weight,
                    connection
                );

                if (result != null) {
                    MessageBox.Show("Не удалось добавить поставку");
                    Close();
                }

                ((Form1)Owner).CurrentTab = "Supply";
            }
            catch (NullReferenceException) {
                MessageBox.Show("Неверные данные");
                return;
            }
            catch (Exception) {
                MessageBox.Show("Неверные данные");
                return;
            }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}