using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void сменыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сменыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.dbDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Состав". При необходимости она может быть перемещена или удалена.
            this.составTableAdapter.Fill(this.dbDataSet.Состав);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Смены". При необходимости она может быть перемещена или удалена.
            this.сменыTableAdapter.Fill(this.dbDataSet.Смены);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.сменыBindingSource.EndEdit();
            this.сменыTableAdapter.Update(this.dbDataSet.Смены);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.составBindingSource.EndEdit();
            this.составTableAdapter.Update(this.dbDataSet.Состав);
        }

        private void сменыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.составTableAdapter.Update(this.dbDataSet.Состав);
        }
    }
}
