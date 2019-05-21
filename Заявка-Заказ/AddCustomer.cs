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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.addCustomerTableAdapter.Fill(this.stO_DBDataSet.AddCustomer, textBox2.Text, textBox4.Text, textBox3.Text, textBox5.Text, textBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }           
            this.Close();
        }
    }
}
