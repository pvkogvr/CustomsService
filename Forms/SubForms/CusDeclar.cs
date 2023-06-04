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
    public partial class CusDeclar : Form
    {
        private SqlConnection connection;
        private int supID;
        public CusDeclar(SqlConnection connection, int supID)
        {
            InitializeComponent();
            this.connection = connection;
            this.supID = supID;
            NumbSupply.Text = "" + supID;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateCustDec_Click(object sender, EventArgs e)
        {
            var typeDec = Import.Checked ? "Im" : "Ex";
            int count, price, bild, volQuot;
            var transOut = AutoOut.Checked ? 1 : PlaneOut.Checked ? 2 : 3;
            var transIn = AutoIn.Checked ? 1 : PlaneIn.Checked ? 2 : 3;
            try {
                count = int.Parse(QuanProd.Text);
                price = int.Parse(Price.Text);
                bild = int.Parse(CusPay.Text);
                volQuot = int.Parse(VolQuot.Text);
                if (count <= 0)
                    throw new Exception("Неверное количество");
                if (price <= 0)
                    throw new Exception("Неверная цена");
                if (bild <= 0)
                    throw new Exception("Неверный платеж");
                if (volQuot <= 0)
                    throw new Exception("Неверная квота по объему");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }

            var result = SQLCommands.AddCusDeclar(
                typeDec,
                supID,
                count,
                transOut,
                price,
                transIn,
                bild,
                volQuot,
                connection
            );

            if (result != null) {
                MessageBox.Show(result);
                return;
            }
            ((Form1)Owner).CurrentTab = "CustDeclar";
            Close();
        }
    }
}
