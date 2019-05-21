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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        List<string> FiltOpt = new List<string>();

        private void UpdateDatabase()
        {
            this.carTableAdapter.Fill(this.sTO_DBDataSet.Car);
            this.customersTableAdapter.Fill(this.sTO_DBDataSet.Customers);
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            try
            {
                this.UpdateDatabase();
                int k = Convert.ToInt32(customersDataGridView.CurrentRow.Cells[0].Value);
                carBindingSource.Filter = string.Format("id_Customer = {0}", k);
                FiltOpt.AddRange(new List<string> { "customer", "telephone", "owner", "N_book" });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            customersBindingSource.Filter = string.Format("{0} like '%{1}%'", FiltOpt[comboBox1.SelectedIndex] ,textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTO_DBDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.onDeleteCustomerTableAdapter.Fill(this.sTO_DBDataSet.OnDeleteCustomer, new System.Nullable<int>(((int)(System.Convert.ChangeType(customersDataGridView.CurrentRow.Cells[0].Value, typeof(int))))));
                this.UpdateDatabase();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddCustomer().ShowDialog();
        }

        private void Customers_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new Form2().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            customersBindingSource.Filter = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new AddCar(Convert.ToInt32(customersDataGridView.CurrentRow.Cells[0].Value)).ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTO_DBDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.carBindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customersDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(customersDataGridView.CurrentRow.Cells[0].Value);
                carBindingSource.Filter = string.Format("id_Customer = {0}", k);
            }
            catch
            {

            }
        }

        private void Customers_Enter(object sender, EventArgs e)
        {
            this.Customers_Load(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.UpdateDatabase();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.UpdateDatabase();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                new ChangeCustomers(Convert.ToInt32(customersDataGridView.CurrentRow.Cells[0].Value)).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                new ChangeCars(Convert.ToInt32(carDataGridView.CurrentRow.Cells[0].Value)).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }  
        }
    } 
}
