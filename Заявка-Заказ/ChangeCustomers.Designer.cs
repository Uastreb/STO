namespace СТО
{
    partial class ChangeCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label ownerLabel;
            System.Windows.Forms.Label n_bookLabel;
            this.sTO_DBDataSet = new СТО.STO_DBDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new СТО.STO_DBDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new СТО.STO_DBDataSetTableAdapters.TableAdapterManager();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.n_bookTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            customerLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ownerLabel = new System.Windows.Forms.Label();
            n_bookLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sTO_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Location = new System.Drawing.Point(12, 15);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new System.Drawing.Size(70, 17);
            customerLabel.TabIndex = 3;
            customerLabel.Text = "Заказчик";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(12, 50);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(121, 17);
            telephoneLabel.TabIndex = 5;
            telephoneLabel.Text = "Номер телефона";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 90);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 17);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Адрес";
            // 
            // ownerLabel
            // 
            ownerLabel.AutoSize = true;
            ownerLabel.Location = new System.Drawing.Point(12, 128);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new System.Drawing.Size(73, 17);
            ownerLabel.TabIndex = 9;
            ownerLabel.Text = "Владелец";
            // 
            // n_bookLabel
            // 
            n_bookLabel.AutoSize = true;
            n_bookLabel.Location = new System.Drawing.Point(12, 168);
            n_bookLabel.Name = "n_bookLabel";
            n_bookLabel.Size = new System.Drawing.Size(102, 17);
            n_bookLabel.TabIndex = 11;
            n_bookLabel.Text = "Номер книжки";
            // 
            // sTO_DBDataSet
            // 
            this.sTO_DBDataSet.DataSetName = "STO_DBDataSet";
            this.sTO_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.sTO_DBDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = СТО.STO_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerTextBox
            // 
            this.customerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "customer", true));
            this.customerTextBox.Location = new System.Drawing.Point(91, 12);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(365, 22);
            this.customerTextBox.TabIndex = 4;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(139, 50);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(317, 22);
            this.telephoneTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(66, 90);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(390, 22);
            this.addressTextBox.TabIndex = 8;
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "owner", true));
            this.ownerTextBox.Location = new System.Drawing.Point(91, 128);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(365, 22);
            this.ownerTextBox.TabIndex = 10;
            // 
            // n_bookTextBox
            // 
            this.n_bookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "N_book", true));
            this.n_bookTextBox.Location = new System.Drawing.Point(139, 165);
            this.n_bookTextBox.Name = "n_bookTextBox";
            this.n_bookTextBox.Size = new System.Drawing.Size(317, 22);
            this.n_bookTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(customerLabel);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(ownerLabel);
            this.Controls.Add(this.ownerTextBox);
            this.Controls.Add(n_bookLabel);
            this.Controls.Add(this.n_bookTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение данных о клиенте";
            this.Load += new System.EventHandler(this.ChangeCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTO_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private STO_DBDataSet sTO_DBDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private STO_DBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private STO_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.TextBox n_bookTextBox;
        private System.Windows.Forms.Button button1;
    }
}