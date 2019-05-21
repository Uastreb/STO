namespace СТО
{
    partial class ChangeCars
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
            System.Windows.Forms.Label markLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label reg_numberLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label body_numberLabel;
            System.Windows.Forms.Label engine_capacityLabel;
            this.sTO_DBDataSet = new СТО.STO_DBDataSet();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new СТО.STO_DBDataSetTableAdapters.CarTableAdapter();
            this.tableAdapterManager = new СТО.STO_DBDataSetTableAdapters.TableAdapterManager();
            this.markTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.reg_numberTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.body_numberTextBox = new System.Windows.Forms.TextBox();
            this.engine_capacityTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            markLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            reg_numberLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            body_numberLabel = new System.Windows.Forms.Label();
            engine_capacityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sTO_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sTO_DBDataSet
            // 
            this.sTO_DBDataSet.DataSetName = "STO_DBDataSet";
            this.sTO_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.sTO_DBDataSet;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarTableAdapter = this.carTableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СТО.STO_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.Location = new System.Drawing.Point(15, 15);
            markLabel.Name = "markLabel";
            markLabel.Size = new System.Drawing.Size(50, 17);
            markLabel.TabIndex = 5;
            markLabel.Text = "Марка";
            // 
            // markTextBox
            // 
            this.markTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "mark", true));
            this.markTextBox.Location = new System.Drawing.Point(71, 15);
            this.markTextBox.Name = "markTextBox";
            this.markTextBox.Size = new System.Drawing.Size(314, 22);
            this.markTextBox.TabIndex = 6;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(391, 15);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(58, 17);
            modelLabel.TabIndex = 7;
            modelLabel.Text = "Модель";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "model", true));
            this.modelTextBox.Location = new System.Drawing.Point(455, 12);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(295, 22);
            this.modelTextBox.TabIndex = 8;
            // 
            // reg_numberLabel
            // 
            reg_numberLabel.AutoSize = true;
            reg_numberLabel.Location = new System.Drawing.Point(15, 50);
            reg_numberLabel.Name = "reg_numberLabel";
            reg_numberLabel.Size = new System.Drawing.Size(160, 17);
            reg_numberLabel.TabIndex = 9;
            reg_numberLabel.Text = "Регистрационный знак";
            // 
            // reg_numberTextBox
            // 
            this.reg_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "reg_number", true));
            this.reg_numberTextBox.Location = new System.Drawing.Point(181, 50);
            this.reg_numberTextBox.Name = "reg_numberTextBox";
            this.reg_numberTextBox.Size = new System.Drawing.Size(117, 22);
            this.reg_numberTextBox.TabIndex = 10;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(307, 50);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(90, 17);
            yearLabel.TabIndex = 11;
            yearLabel.Text = "Год выпуска";
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "year", true));
            this.yearTextBox.Location = new System.Drawing.Point(403, 50);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 22);
            this.yearTextBox.TabIndex = 12;
            // 
            // body_numberLabel
            // 
            body_numberLabel.AutoSize = true;
            body_numberLabel.Location = new System.Drawing.Point(15, 89);
            body_numberLabel.Name = "body_numberLabel";
            body_numberLabel.Size = new System.Drawing.Size(194, 17);
            body_numberLabel.TabIndex = 13;
            body_numberLabel.Text = "Идентефикационный номер";
            // 
            // body_numberTextBox
            // 
            this.body_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "body_number", true));
            this.body_numberTextBox.Location = new System.Drawing.Point(215, 89);
            this.body_numberTextBox.Name = "body_numberTextBox";
            this.body_numberTextBox.Size = new System.Drawing.Size(535, 22);
            this.body_numberTextBox.TabIndex = 14;
            // 
            // engine_capacityLabel
            // 
            engine_capacityLabel.AutoSize = true;
            engine_capacityLabel.Location = new System.Drawing.Point(515, 50);
            engine_capacityLabel.Name = "engine_capacityLabel";
            engine_capacityLabel.Size = new System.Drawing.Size(124, 17);
            engine_capacityLabel.TabIndex = 15;
            engine_capacityLabel.Text = "Объем двигателя";
            // 
            // engine_capacityTextBox
            // 
            this.engine_capacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "engine_capacity", true));
            this.engine_capacityTextBox.Location = new System.Drawing.Point(645, 47);
            this.engine_capacityTextBox.Name = "engine_capacityTextBox";
            this.engine_capacityTextBox.Size = new System.Drawing.Size(105, 22);
            this.engine_capacityTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 174);
            this.Controls.Add(this.button1);
            this.Controls.Add(markLabel);
            this.Controls.Add(this.markTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(reg_numberLabel);
            this.Controls.Add(this.reg_numberTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(body_numberLabel);
            this.Controls.Add(this.body_numberTextBox);
            this.Controls.Add(engine_capacityLabel);
            this.Controls.Add(this.engine_capacityTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение данных о машине";
            this.Load += new System.EventHandler(this.ChangeCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTO_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private STO_DBDataSet sTO_DBDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private STO_DBDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private STO_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox markTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox reg_numberTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox body_numberTextBox;
        private System.Windows.Forms.TextBox engine_capacityTextBox;
        private System.Windows.Forms.Button button1;
    }
}