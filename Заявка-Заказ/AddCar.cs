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
    public partial class AddCar : Form
    {
        int id_Customer;

        public AddCar(int id_customer)
        {
            this.id_Customer = id_customer;
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.TextLength == 17)
            {
                try
                {
                    this.addCarTableAdapter.Fill(this.sTO_DBDataSet.AddCar, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_Customer, typeof(int))))), textBox1.Text, textBox2.Text, textBox3.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(textBox4.Text, typeof(int))))), textBox5.Text, textBox6.Text);
                    this.Close();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Проверьте VIN код машины");
            }
        }
    }
}