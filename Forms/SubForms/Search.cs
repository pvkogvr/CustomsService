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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Searrch_Click(object sender, EventArgs e)
        {
            ((Form1)Owner).ID = SearchTB.Text;
            ((Form1)Owner).isCustomer = SearchCus.Checked == true;
            Close();
        }
    }
}
