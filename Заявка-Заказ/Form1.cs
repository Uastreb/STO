using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace СТО
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTO_DBDataSet.Car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.sTO_DBDataSet.Car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTO_DBDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.sTO_DBDataSet.Customers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ownerTextBox.Text = customerTextBox.Text;
        }

        private void PrintDoc()
        {

            Word.Application application = new Word.Application();
            Word.Document document = application.Documents.Add(Environment.CurrentDirectory + "\\Заявка-заказ.doc");
            document.Tables[1].Cell(2, 1).Range.Text = "ЗАЯВКА - ЗАКАЗ на обслуживание  №" + textBox1.Text;
            document.Tables[1].Cell(2, 2).Range.Text = "Дата составления: " + dateTimePicker1.Value.ToShortDateString();
            document.Tables[1].Cell(3, 2).Range.Text = customerTextBox.Text;
            document.Tables[1].Cell(4, 2).Range.Text = addressTextBox.Text;
            document.Tables[1].Cell(6, 2).Range.Text = ownerTextBox.Text;
            document.Tables[1].Cell(5, 2).Range.Text = telephoneTextBox.Text;


            document.Tables[2].Cell(2, 1).Range.Text = markTextBox.Text;
            document.Tables[2].Cell(2, 2).Range.Text = modelTextBox.Text;
            document.Tables[2].Cell(2, 3).Range.Text = reg_numberTextBox.Text;
            document.Tables[2].Cell(2, 4).Range.Text = yearTextBox.Text;
            document.Tables[2].Cell(2, 5).Range.Text = body_numberTextBox.Text;
            document.Tables[2].Cell(2, 6).Range.Text = engine_capacityTextBox.Text + " л. ";
            document.Tables[2].Cell(4, 1).Range.Text = richTextBox1.Text;

            document.PrintOut();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDoc();
            MessageBox.Show("Идет печать");
        }

        private void AddDateInDB()
        {
            try
            {
                this.addCustomerTableAdapter.Fill(this.sTO_DBDataSet.AddCustomer, customerTextBox.Text, telephoneTextBox.Text, addressTextBox.Text, ownerTextBox.Text, "");

                customersTableAdapter.Fill(sTO_DBDataSet.Customers);

                var f = sTO_DBDataSet.Customers.First(x => x.customer == customerTextBox.Text && x.telephone == telephoneTextBox.Text && x.address == addressTextBox.Text && x.owner == ownerTextBox.Text);

                this.addCarTableAdapter.Fill(this.sTO_DBDataSet.AddCar, new System.Nullable<int>(((int)(System.Convert.ChangeType(f.id, typeof(int))))), markTextBox.Text, modelTextBox.Text, reg_numberTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(yearTextBox.Text, typeof(int))))), body_numberTextBox.Text, engine_capacityTextBox.Text);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            AddDateInDB();
            PrintDoc();
            this.Form1_Load(sender, e);
            MessageBox.Show("Данные сохранены и отправлены на печать");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new Form2().ShowDialog();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            carBindingSource.Filter = string.Format("reg_number like '%{0}%'", textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Car = sTO_DBDataSet.Car.First(x => x.id == Convert.ToInt32(listBox1.SelectedValue));
            markTextBox.Text = Car.mark;
            modelTextBox.Text = Car.model;
            yearTextBox.Text = Car.year.ToString();
            reg_numberTextBox.Text = Car.reg_number;
            body_numberTextBox.Text = Car.body_number;
            engine_capacityTextBox.Text = Car.engine_capacity;

            var Customer = sTO_DBDataSet.Customers.First(x => x.id == Convert.ToInt32(Car.id_Customer));
            customerTextBox.Text = Customer.customer;
            ownerTextBox.Text = Customer.owner;
            telephoneTextBox.Text = Customer.telephone;
            addressTextBox.Text = Customer.address; 
        }

        private void Clear()
        {
            customerTextBox.Text = "";
            ownerTextBox.Text = "";
            addressTextBox.Text = "";
            telephoneTextBox.Text = "";
            markTextBox.Text = "";
            modelTextBox.Text = "";
            reg_numberTextBox.Text = "";
            yearTextBox.Text = "";
            engine_capacityTextBox.Text = "";
            body_numberTextBox.Text = "";
            richTextBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
