using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СТО
{
    public partial class ChangeCustomers : Form
    {
        int id_Customer;
        public ChangeCustomers(int Id)
        {
            InitializeComponent();
            this.id_Customer = Id;
        }

        private void ChangeCustomers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTO_DBDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.sTO_DBDataSet.Customers);
            customersBindingSource.Filter = string.Format(" id = {0}", id_Customer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTO_DBDataSet);
            this.Close();
        }
    }
}
