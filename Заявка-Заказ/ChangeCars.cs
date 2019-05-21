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
    public partial class ChangeCars : Form
    {
        int id_Car;
        public ChangeCars(int Id)
        {
            InitializeComponent();
            this.id_Car = Id;
        }
        private void ChangeCars_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTO_DBDataSet.Car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.sTO_DBDataSet.Car);
            carBindingSource.Filter = string.Format(" id = {0}", id_Car);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTO_DBDataSet);
            this.Close();
        }
    }
}
