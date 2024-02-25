
namespace WindowsFormsApp1
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbDataSet = new WindowsFormsApp1.dbDataSet();
            this.позицииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.позицииTableAdapter = new WindowsFormsApp1.dbDataSetTableAdapters.ПозицииTableAdapter();
            this.кодпозицииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.блюдоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.позицииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодпозицииDataGridViewTextBoxColumn,
            this.кодзаказаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.блюдоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.позицииBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // позицииBindingSource
            // 
            this.позицииBindingSource.DataMember = "Позиции";
            this.позицииBindingSource.DataSource = this.dbDataSet;
            // 
            // позицииTableAdapter
            // 
            this.позицииTableAdapter.ClearBeforeFill = true;
            // 
            // кодпозицииDataGridViewTextBoxColumn
            // 
            this.кодпозицииDataGridViewTextBoxColumn.DataPropertyName = "Код_позиции";
            this.кодпозицииDataGridViewTextBoxColumn.HeaderText = "Код_позиции";
            this.кодпозицииDataGridViewTextBoxColumn.Name = "кодпозицииDataGridViewTextBoxColumn";
            this.кодпозицииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодзаказаDataGridViewTextBoxColumn
            // 
            this.кодзаказаDataGridViewTextBoxColumn.DataPropertyName = "Код_заказа";
            this.кодзаказаDataGridViewTextBoxColumn.HeaderText = "Код_заказа";
            this.кодзаказаDataGridViewTextBoxColumn.Name = "кодзаказаDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            // 
            // блюдоDataGridViewTextBoxColumn
            // 
            this.блюдоDataGridViewTextBoxColumn.DataPropertyName = "Блюдо";
            this.блюдоDataGridViewTextBoxColumn.HeaderText = "Блюдо";
            this.блюдоDataGridViewTextBoxColumn.Name = "блюдоDataGridViewTextBoxColumn";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.позицииBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource позицииBindingSource;
        private dbDataSetTableAdapters.ПозицииTableAdapter позицииTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпозицииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодзаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn блюдоDataGridViewTextBoxColumn;
    }
}