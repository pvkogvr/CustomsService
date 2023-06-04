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
using Coursework.Classes;

namespace Coursework.Forms.SubForms
{
    public partial class AddSupplier : Form
    {
        private SqlConnection connection;
        private string type;
        private string mode;
        private int id;
        public AddSupplier(SqlConnection connection, string type)
        {
            InitializeComponent();
            this.connection = connection;
            this.type = type;
            mode = "insert";
            id = -1;
        }

        public AddSupplier(SqlConnection connection, string type, string fio, string phone, string address, string email, int id) {
            InitializeComponent();
            this.connection = connection;
            this.type = type;
            mode = "update";
            FIOSupplier.Text = fio;
            TelSupplier.Text = phone;
            AddressSupplier.Text = address;
            EmailSupplier.Text = email;
            this.id = id;
            ButAddSup.Text = "Изменить";
        }

        private void ButAddSup_Click(object sender, EventArgs e)
        {
            var fio = FIOSupplier.Text;
            var phone = TelSupplier.Text;
            var address = AddressSupplier.Text;
            var email = EmailSupplier.Text;
            
            if (fio == "")
            {
                MessageBox.Show("Введите ФИО");
                return;
            }
            if (phone == "" || phone == "0" || phone[0] == '-')
            {
                MessageBox.Show("Введите номер телефона");
                return;
            }
            if (address == "")
            {
                MessageBox.Show("Введите адрес");
                return;
            }
            if (email == "")
            {
                MessageBox.Show("Введите Email");
                return;
            }

            var response = "";
            if (mode == "insert") {
                response = type == "Supplier" 
                ? SQLCommands.AddSupplier(fio, phone, address, email, connection)
                : SQLCommands.AddCustomer(fio, phone, address, email, connection);
            }
            else if (mode == "update") {
                response = type == "Supplier" 
                ? SQLCommands.UpdateSupplier(id, fio, phone, address, email, connection)
                : SQLCommands.UpdateCustomer(id, fio, phone, address, email, connection);
            }

            if (response != null) {
                MessageBox.Show(response);
                return;
            }
            ((Form1)Owner).CurrentTab = type;
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
