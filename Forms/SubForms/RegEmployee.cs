using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework.Forms.SubForms
{
    public partial class RegEmployee : Form
    {
        public RegEmployee()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddEmpl_Click(object sender, EventArgs e)
        {
            var codeCus = int.Parse(CodeCus.Text);
            var name = NameEmp.Text;
            var surname = Surname.Text;
            var patron = Patrynomic.Text;
            try
            {
                if (codeCus <= 0)
                    throw new Exception("Неверный код");
                if (name == "")
                    throw new Exception("Неверное имя");
                if (surname == "")
                    throw new Exception("Неверная фамилия");
                if (patron == "")
                    throw new Exception("Неверное отчество");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            var id = ((Employee)Owner).AddEmployee(codeCus, name, surname, patron);
            if (id < 1) {
                MessageBox.Show("Не удалось добавить сотрудника");
                return;
            }
            MessageBox.Show("Ваш ID: " + id);
            ((Employee)Owner).Enter(id);
            Close();
        }
    }
}
