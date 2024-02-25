
namespace WindowsFormsApp1
{
    partial class Form5
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
            System.Windows.Forms.Label код_заказаLabel;
            System.Windows.Forms.Label столикLabel;
            System.Windows.Forms.Label количество_клиентовLabel;
            System.Windows.Forms.Label код_сменыLabel;
            System.Windows.Forms.Label статусLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label блюдоLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dbDataSet = new WindowsFormsApp1.dbDataSet();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new WindowsFormsApp1.dbDataSetTableAdapters.ЗаказTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.dbDataSetTableAdapters.TableAdapterManager();
            this.заказBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.заказBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_заказаTextBox = new System.Windows.Forms.TextBox();
            this.столикTextBox = new System.Windows.Forms.TextBox();
            this.количество_клиентовTextBox = new System.Windows.Forms.TextBox();
            this.код_сменыTextBox = new System.Windows.Forms.TextBox();
            this.статусTextBox = new System.Windows.Forms.TextBox();
            this.позицииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.позицииTableAdapter = new WindowsFormsApp1.dbDataSetTableAdapters.ПозицииTableAdapter();
            this.позицииDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказПозицииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.блюдоComboBox = new System.Windows.Forms.ComboBox();
            this.менюBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.менюTableAdapter = new WindowsFormsApp1.dbDataSetTableAdapters.МенюTableAdapter();
            код_заказаLabel = new System.Windows.Forms.Label();
            столикLabel = new System.Windows.Forms.Label();
            количество_клиентовLabel = new System.Windows.Forms.Label();
            код_сменыLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            блюдоLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingNavigator)).BeginInit();
            this.заказBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.позицииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.позицииDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказПозицииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_заказаLabel
            // 
            код_заказаLabel.AutoSize = true;
            код_заказаLabel.Location = new System.Drawing.Point(25, 73);
            код_заказаLabel.Name = "код_заказаLabel";
            код_заказаLabel.Size = new System.Drawing.Size(68, 13);
            код_заказаLabel.TabIndex = 1;
            код_заказаLabel.Text = "Код заказа:";
            // 
            // столикLabel
            // 
            столикLabel.AutoSize = true;
            столикLabel.Location = new System.Drawing.Point(25, 99);
            столикLabel.Name = "столикLabel";
            столикLabel.Size = new System.Drawing.Size(46, 13);
            столикLabel.TabIndex = 3;
            столикLabel.Text = "Столик:";
            // 
            // количество_клиентовLabel
            // 
            количество_клиентовLabel.AutoSize = true;
            количество_клиентовLabel.Location = new System.Drawing.Point(25, 125);
            количество_клиентовLabel.Name = "количество_клиентовLabel";
            количество_клиентовLabel.Size = new System.Drawing.Size(119, 13);
            количество_клиентовLabel.TabIndex = 5;
            количество_клиентовLabel.Text = "Количество-клиентов:";
            // 
            // код_сменыLabel
            // 
            код_сменыLabel.AutoSize = true;
            код_сменыLabel.Location = new System.Drawing.Point(25, 151);
            код_сменыLabel.Name = "код_сменыLabel";
            код_сменыLabel.Size = new System.Drawing.Size(66, 13);
            код_сменыLabel.TabIndex = 7;
            код_сменыLabel.Text = "Код смены:";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(25, 177);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(44, 13);
            статусLabel.TabIndex = 9;
            статусLabel.Text = "Статус:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Location = new System.Drawing.Point(720, 39);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(69, 13);
            количествоLabel.TabIndex = 58;
            количествоLabel.Text = "Количество:";
            // 
            // блюдоLabel1
            // 
            блюдоLabel1.AutoSize = true;
            блюдоLabel1.Location = new System.Drawing.Point(720, 76);
            блюдоLabel1.Name = "блюдоLabel1";
            блюдоLabel1.Size = new System.Drawing.Size(43, 13);
            блюдоLabel1.TabIndex = 62;
            блюдоLabel1.Text = "Блюдо:";
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.dbDataSet;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = this.заказTableAdapter;
            this.tableAdapterManager.МенюTableAdapter = null;
            this.tableAdapterManager.ПозицииTableAdapter = null;
            this.tableAdapterManager.СменыTableAdapter = null;
            this.tableAdapterManager.СоставTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // заказBindingNavigator
            // 
            this.заказBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заказBindingNavigator.BindingSource = this.заказBindingSource;
            this.заказBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заказBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заказBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.заказBindingNavigatorSaveItem});
            this.заказBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заказBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заказBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заказBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заказBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заказBindingNavigator.Name = "заказBindingNavigator";
            this.заказBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заказBindingNavigator.Size = new System.Drawing.Size(918, 25);
            this.заказBindingNavigator.TabIndex = 0;
            this.заказBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // заказBindingNavigatorSaveItem
            // 
            this.заказBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заказBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказBindingNavigatorSaveItem.Image")));
            this.заказBindingNavigatorSaveItem.Name = "заказBindingNavigatorSaveItem";
            this.заказBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заказBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заказBindingNavigatorSaveItem.Click += new System.EventHandler(this.заказBindingNavigatorSaveItem_Click);
            // 
            // код_заказаTextBox
            // 
            this.код_заказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Код_заказа", true));
            this.код_заказаTextBox.Location = new System.Drawing.Point(150, 70);
            this.код_заказаTextBox.Name = "код_заказаTextBox";
            this.код_заказаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_заказаTextBox.TabIndex = 2;
            // 
            // столикTextBox
            // 
            this.столикTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Столик", true));
            this.столикTextBox.Location = new System.Drawing.Point(150, 96);
            this.столикTextBox.Name = "столикTextBox";
            this.столикTextBox.Size = new System.Drawing.Size(100, 20);
            this.столикTextBox.TabIndex = 4;
            // 
            // количество_клиентовTextBox
            // 
            this.количество_клиентовTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Количество-клиентов", true));
            this.количество_клиентовTextBox.Location = new System.Drawing.Point(150, 122);
            this.количество_клиентовTextBox.Name = "количество_клиентовTextBox";
            this.количество_клиентовTextBox.Size = new System.Drawing.Size(100, 20);
            this.количество_клиентовTextBox.TabIndex = 6;
            // 
            // код_сменыTextBox
            // 
            this.код_сменыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Код_смены", true));
            this.код_сменыTextBox.Location = new System.Drawing.Point(150, 148);
            this.код_сменыTextBox.Name = "код_сменыTextBox";
            this.код_сменыTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_сменыTextBox.TabIndex = 8;
            // 
            // статусTextBox
            // 
            this.статусTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Статус", true));
            this.статусTextBox.Location = new System.Drawing.Point(150, 174);
            this.статусTextBox.Name = "статусTextBox";
            this.статусTextBox.Size = new System.Drawing.Size(100, 20);
            this.статусTextBox.TabIndex = 10;
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
            // позицииDataGridView
            // 
            this.позицииDataGridView.AutoGenerateColumns = false;
            this.позицииDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.позицииDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.позицииDataGridView.DataSource = this.заказПозицииBindingSource;
            this.позицииDataGridView.Location = new System.Drawing.Point(345, 148);
            this.позицииDataGridView.Name = "позицииDataGridView";
            this.позицииDataGridView.Size = new System.Drawing.Size(545, 220);
            this.позицииDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код_заказа";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код_заказа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Блюдо";
            this.dataGridViewTextBoxColumn5.HeaderText = "Блюдо";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // заказПозицииBindingSource
            // 
            this.заказПозицииBindingSource.DataMember = "ЗаказПозиции";
            this.заказПозицииBindingSource.DataSource = this.заказBindingSource;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(345, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 45);
            this.button3.TabIndex = 54;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(28, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 45);
            this.button1.TabIndex = 52;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказПозицииBindingSource, "Количество", true));
            this.количествоTextBox.Location = new System.Drawing.Point(800, 36);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(100, 20);
            this.количествоTextBox.TabIndex = 59;
            // 
            // блюдоComboBox
            // 
            this.блюдоComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказПозицииBindingSource, "Блюдо", true));
            this.блюдоComboBox.DataSource = this.менюBindingSource;
            this.блюдоComboBox.DisplayMember = "Название";
            this.блюдоComboBox.FormattingEnabled = true;
            this.блюдоComboBox.Location = new System.Drawing.Point(769, 73);
            this.блюдоComboBox.Name = "блюдоComboBox";
            this.блюдоComboBox.Size = new System.Drawing.Size(121, 21);
            this.блюдоComboBox.TabIndex = 63;
            this.блюдоComboBox.ValueMember = "Название";
            // 
            // менюBindingSource
            // 
            this.менюBindingSource.DataMember = "Меню";
            this.менюBindingSource.DataSource = this.dbDataSet;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.заказПозицииBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(345, 120);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(263, 25);
            this.bindingNavigator1.TabIndex = 64;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // менюTableAdapter
            // 
            this.менюTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 458);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(блюдоLabel1);
            this.Controls.Add(this.блюдоComboBox);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(this.количествоTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.позицииDataGridView);
            this.Controls.Add(код_заказаLabel);
            this.Controls.Add(this.код_заказаTextBox);
            this.Controls.Add(столикLabel);
            this.Controls.Add(this.столикTextBox);
            this.Controls.Add(количество_клиентовLabel);
            this.Controls.Add(this.количество_клиентовTextBox);
            this.Controls.Add(код_сменыLabel);
            this.Controls.Add(this.код_сменыTextBox);
            this.Controls.Add(статусLabel);
            this.Controls.Add(this.статусTextBox);
            this.Controls.Add(this.заказBindingNavigator);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingNavigator)).EndInit();
            this.заказBindingNavigator.ResumeLayout(false);
            this.заказBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.позицииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.позицииDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказПозицииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private dbDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заказBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton заказBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_заказаTextBox;
        private System.Windows.Forms.TextBox столикTextBox;
        private System.Windows.Forms.TextBox количество_клиентовTextBox;
        private System.Windows.Forms.TextBox код_сменыTextBox;
        private System.Windows.Forms.TextBox статусTextBox;
        private System.Windows.Forms.BindingSource позицииBindingSource;
        private dbDataSetTableAdapters.ПозицииTableAdapter позицииTableAdapter;
        private System.Windows.Forms.DataGridView позицииDataGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.BindingSource заказПозицииBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox блюдоComboBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingSource менюBindingSource;
        private dbDataSetTableAdapters.МенюTableAdapter менюTableAdapter;
    }
}