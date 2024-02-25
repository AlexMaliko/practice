
namespace WindowsFormsApp1
{
    partial class Form4
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
            System.Windows.Forms.Label код_составLabel;
            System.Windows.Forms.Label код_сменыLabel;
            System.Windows.Forms.Label сотрудникLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dbDataSet = new WindowsFormsApp1.dbDataSet();
            this.сменыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сменыTableAdapter = new WindowsFormsApp1.dbDataSetTableAdapters.СменыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.dbDataSetTableAdapters.TableAdapterManager();
            this.составTableAdapter = new WindowsFormsApp1.dbDataSetTableAdapters.СоставTableAdapter();
            this.сотрудникиTableAdapter = new WindowsFormsApp1.dbDataSetTableAdapters.СотрудникиTableAdapter();
            this.сменыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.сменыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.сменыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.составBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.составDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.код_составTextBox = new System.Windows.Forms.TextBox();
            this.код_сменыTextBox = new System.Windows.Forms.TextBox();
            this.сотрудникComboBox = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сменыСоставBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            код_составLabel = new System.Windows.Forms.Label();
            код_сменыLabel = new System.Windows.Forms.Label();
            сотрудникLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сменыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сменыBindingNavigator)).BeginInit();
            this.сменыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сменыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.составBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.составDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сменыСоставBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_составLabel
            // 
            код_составLabel.AutoSize = true;
            код_составLabel.Location = new System.Drawing.Point(721, 165);
            код_составLabel.Name = "код_составLabel";
            код_составLabel.Size = new System.Drawing.Size(67, 13);
            код_составLabel.TabIndex = 3;
            код_составLabel.Text = "Код состав:";
            // 
            // код_сменыLabel
            // 
            код_сменыLabel.AutoSize = true;
            код_сменыLabel.Location = new System.Drawing.Point(721, 191);
            код_сменыLabel.Name = "код_сменыLabel";
            код_сменыLabel.Size = new System.Drawing.Size(66, 13);
            код_сменыLabel.TabIndex = 5;
            код_сменыLabel.Text = "Код смены:";
            // 
            // сотрудникLabel
            // 
            сотрудникLabel.AutoSize = true;
            сотрудникLabel.Location = new System.Drawing.Point(721, 217);
            сотрудникLabel.Name = "сотрудникLabel";
            сотрудникLabel.Size = new System.Drawing.Size(63, 13);
            сотрудникLabel.TabIndex = 7;
            сотрудникLabel.Text = "Сотрудник:";
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сменыBindingSource
            // 
            this.сменыBindingSource.DataMember = "Смены";
            this.сменыBindingSource.DataSource = this.dbDataSet;
            // 
            // сменыTableAdapter
            // 
            this.сменыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.МенюTableAdapter = null;
            this.tableAdapterManager.ПозицииTableAdapter = null;
            this.tableAdapterManager.СменыTableAdapter = this.сменыTableAdapter;
            this.tableAdapterManager.СоставTableAdapter = this.составTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            // 
            // составTableAdapter
            // 
            this.составTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // сменыBindingNavigator
            // 
            this.сменыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.сменыBindingNavigator.BindingSource = this.сменыBindingSource;
            this.сменыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.сменыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.сменыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.сменыBindingNavigatorSaveItem});
            this.сменыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.сменыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.сменыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.сменыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.сменыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.сменыBindingNavigator.Name = "сменыBindingNavigator";
            this.сменыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.сменыBindingNavigator.Size = new System.Drawing.Size(935, 25);
            this.сменыBindingNavigator.TabIndex = 0;
            this.сменыBindingNavigator.Text = "bindingNavigator1";
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
            // сменыBindingNavigatorSaveItem
            // 
            this.сменыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сменыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("сменыBindingNavigatorSaveItem.Image")));
            this.сменыBindingNavigatorSaveItem.Name = "сменыBindingNavigatorSaveItem";
            this.сменыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.сменыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.сменыBindingNavigatorSaveItem.Click += new System.EventHandler(this.сменыBindingNavigatorSaveItem_Click);
            // 
            // сменыDataGridView
            // 
            this.сменыDataGridView.AutoGenerateColumns = false;
            this.сменыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сменыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.сменыDataGridView.DataSource = this.сменыBindingSource;
            this.сменыDataGridView.Location = new System.Drawing.Point(12, 52);
            this.сменыDataGridView.Name = "сменыDataGridView";
            this.сменыDataGridView.Size = new System.Drawing.Size(300, 220);
            this.сменыDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_смены";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_смены";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // составBindingSource
            // 
            this.составBindingSource.DataMember = "Состав";
            this.составBindingSource.DataSource = this.dbDataSet;
            // 
            // составDataGridView
            // 
            this.составDataGridView.AutoGenerateColumns = false;
            this.составDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.составDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.составDataGridView.DataSource = this.сменыСоставBindingSource;
            this.составDataGridView.Location = new System.Drawing.Point(353, 52);
            this.составDataGridView.Name = "составDataGridView";
            this.составDataGridView.Size = new System.Drawing.Size(345, 220);
            this.составDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Код_состав";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код_состав";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Код_смены";
            this.dataGridViewTextBoxColumn4.HeaderText = "Код_смены";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Сотрудник";
            this.dataGridViewTextBoxColumn5.HeaderText = "Сотрудник";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // код_составTextBox
            // 
            this.код_составTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.составBindingSource, "Код_состав", true));
            this.код_составTextBox.Location = new System.Drawing.Point(794, 162);
            this.код_составTextBox.Name = "код_составTextBox";
            this.код_составTextBox.Size = new System.Drawing.Size(121, 20);
            this.код_составTextBox.TabIndex = 4;
            // 
            // код_сменыTextBox
            // 
            this.код_сменыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.составBindingSource, "Код_смены", true));
            this.код_сменыTextBox.Location = new System.Drawing.Point(794, 188);
            this.код_сменыTextBox.Name = "код_сменыTextBox";
            this.код_сменыTextBox.Size = new System.Drawing.Size(121, 20);
            this.код_сменыTextBox.TabIndex = 6;
            // 
            // сотрудникComboBox
            // 
            this.сотрудникComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.составBindingSource, "Сотрудник", true));
            this.сотрудникComboBox.DataSource = this.сотрудникиBindingSource;
            this.сотрудникComboBox.DisplayMember = "ФИО";
            this.сотрудникComboBox.FormattingEnabled = true;
            this.сотрудникComboBox.Location = new System.Drawing.Point(794, 214);
            this.сотрудникComboBox.Name = "сотрудникComboBox";
            this.сотрудникComboBox.Size = new System.Drawing.Size(121, 21);
            this.сотрудникComboBox.TabIndex = 8;
            this.сотрудникComboBox.ValueMember = "Код_Сотрудника";
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.dbDataSet;
            // 
            // сменыСоставBindingSource
            // 
            this.сменыСоставBindingSource.DataMember = "СменыСостав";
            this.сменыСоставBindingSource.DataSource = this.сменыBindingSource;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(669, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 45);
            this.button2.TabIndex = 50;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 45);
            this.button1.TabIndex = 49;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(353, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 45);
            this.button3.TabIndex = 51;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_составLabel);
            this.Controls.Add(this.код_составTextBox);
            this.Controls.Add(код_сменыLabel);
            this.Controls.Add(this.код_сменыTextBox);
            this.Controls.Add(сотрудникLabel);
            this.Controls.Add(this.сотрудникComboBox);
            this.Controls.Add(this.составDataGridView);
            this.Controls.Add(this.сменыDataGridView);
            this.Controls.Add(this.сменыBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сменыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сменыBindingNavigator)).EndInit();
            this.сменыBindingNavigator.ResumeLayout(false);
            this.сменыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сменыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.составBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.составDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сменыСоставBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource сменыBindingSource;
        private dbDataSetTableAdapters.СменыTableAdapter сменыTableAdapter;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator сменыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton сменыBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView сменыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private dbDataSetTableAdapters.СоставTableAdapter составTableAdapter;
        private System.Windows.Forms.BindingSource составBindingSource;
        private dbDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.DataGridView составDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox код_составTextBox;
        private System.Windows.Forms.TextBox код_сменыTextBox;
        private System.Windows.Forms.ComboBox сотрудникComboBox;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private System.Windows.Forms.BindingSource сменыСоставBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}