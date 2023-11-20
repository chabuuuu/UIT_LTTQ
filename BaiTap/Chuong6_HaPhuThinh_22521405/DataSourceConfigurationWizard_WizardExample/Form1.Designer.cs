namespace DataSourceConfigurationWizard_WizardExample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label dCHILabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label nGSINHLabel;
            System.Windows.Forms.Label dOANHSOLabel;
            System.Windows.Forms.Label nGDKLabel;
            this.qLBHDataSet = new DataSourceConfigurationWizard_WizardExample.QLBHDataSet();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new DataSourceConfigurationWizard_WizardExample.QLBHDataSetTableAdapters.KHACHHANGTableAdapter();
            this.tableAdapterManager = new DataSourceConfigurationWizard_WizardExample.QLBHDataSetTableAdapters.TableAdapterManager();
            this.kHACHHANGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.kHACHHANGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kHACHHANGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHTextBox = new System.Windows.Forms.TextBox();
            this.hOTENTextBox = new System.Windows.Forms.TextBox();
            this.dCHITextBox = new System.Windows.Forms.TextBox();
            this.sODTTextBox = new System.Windows.Forms.TextBox();
            this.nGSINHDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dOANHSOTextBox = new System.Windows.Forms.TextBox();
            this.nGDKDateTimePicker = new System.Windows.Forms.DateTimePicker();
            mAKHLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            dCHILabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            nGSINHLabel = new System.Windows.Forms.Label();
            dOANHSOLabel = new System.Windows.Forms.Label();
            nGDKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingNavigator)).BeginInit();
            this.kHACHHANGBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qLBHDataSet;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = this.kHACHHANGTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataSourceConfigurationWizard_WizardExample.QLBHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kHACHHANGBindingNavigator
            // 
            this.kHACHHANGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kHACHHANGBindingNavigator.BindingSource = this.kHACHHANGBindingSource;
            this.kHACHHANGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kHACHHANGBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kHACHHANGBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kHACHHANGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kHACHHANGBindingNavigatorSaveItem});
            this.kHACHHANGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kHACHHANGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kHACHHANGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kHACHHANGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kHACHHANGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kHACHHANGBindingNavigator.Name = "kHACHHANGBindingNavigator";
            this.kHACHHANGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kHACHHANGBindingNavigator.Size = new System.Drawing.Size(865, 27);
            this.kHACHHANGBindingNavigator.TabIndex = 0;
            this.kHACHHANGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // kHACHHANGBindingNavigatorSaveItem
            // 
            this.kHACHHANGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kHACHHANGBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kHACHHANGBindingNavigatorSaveItem.Image")));
            this.kHACHHANGBindingNavigatorSaveItem.Name = "kHACHHANGBindingNavigatorSaveItem";
            this.kHACHHANGBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.kHACHHANGBindingNavigatorSaveItem.Text = "Save Data";
            this.kHACHHANGBindingNavigatorSaveItem.Click += new System.EventHandler(this.kHACHHANGBindingNavigatorSaveItem_Click);
            // 
            // kHACHHANGDataGridView
            // 
            this.kHACHHANGDataGridView.AutoGenerateColumns = false;
            this.kHACHHANGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kHACHHANGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.kHACHHANGDataGridView.DataSource = this.kHACHHANGBindingSource;
            this.kHACHHANGDataGridView.Location = new System.Drawing.Point(90, 249);
            this.kHACHHANGDataGridView.Name = "kHACHHANGDataGridView";
            this.kHACHHANGDataGridView.RowHeadersWidth = 51;
            this.kHACHHANGDataGridView.RowTemplate.Height = 24;
            this.kHACHHANGDataGridView.Size = new System.Drawing.Size(635, 145);
            this.kHACHHANGDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAKH";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HOTEN";
            this.dataGridViewTextBoxColumn2.HeaderText = "HOTEN";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DCHI";
            this.dataGridViewTextBoxColumn3.HeaderText = "DCHI";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SODT";
            this.dataGridViewTextBoxColumn4.HeaderText = "SODT";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NGSINH";
            this.dataGridViewTextBoxColumn5.HeaderText = "NGSINH";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DOANHSO";
            this.dataGridViewTextBoxColumn6.HeaderText = "DOANHSO";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NGDK";
            this.dataGridViewTextBoxColumn7.HeaderText = "NGDK";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(276, 28);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(48, 16);
            mAKHLabel.TabIndex = 2;
            mAKHLabel.Text = "MAKH:";
            // 
            // mAKHTextBox
            // 
            this.mAKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "MAKH", true));
            this.mAKHTextBox.Location = new System.Drawing.Point(360, 25);
            this.mAKHTextBox.Name = "mAKHTextBox";
            this.mAKHTextBox.Size = new System.Drawing.Size(200, 22);
            this.mAKHTextBox.TabIndex = 3;
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(276, 56);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(58, 16);
            hOTENLabel.TabIndex = 4;
            hOTENLabel.Text = "HOTEN:";
            // 
            // hOTENTextBox
            // 
            this.hOTENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "HOTEN", true));
            this.hOTENTextBox.Location = new System.Drawing.Point(360, 53);
            this.hOTENTextBox.Name = "hOTENTextBox";
            this.hOTENTextBox.Size = new System.Drawing.Size(200, 22);
            this.hOTENTextBox.TabIndex = 5;
            // 
            // dCHILabel
            // 
            dCHILabel.AutoSize = true;
            dCHILabel.Location = new System.Drawing.Point(276, 84);
            dCHILabel.Name = "dCHILabel";
            dCHILabel.Size = new System.Drawing.Size(42, 16);
            dCHILabel.TabIndex = 6;
            dCHILabel.Text = "DCHI:";
            // 
            // dCHITextBox
            // 
            this.dCHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "DCHI", true));
            this.dCHITextBox.Location = new System.Drawing.Point(360, 81);
            this.dCHITextBox.Name = "dCHITextBox";
            this.dCHITextBox.Size = new System.Drawing.Size(200, 22);
            this.dCHITextBox.TabIndex = 7;
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(276, 112);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(48, 16);
            sODTLabel.TabIndex = 8;
            sODTLabel.Text = "SODT:";
            // 
            // sODTTextBox
            // 
            this.sODTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "SODT", true));
            this.sODTTextBox.Location = new System.Drawing.Point(360, 109);
            this.sODTTextBox.Name = "sODTTextBox";
            this.sODTTextBox.Size = new System.Drawing.Size(200, 22);
            this.sODTTextBox.TabIndex = 9;
            // 
            // nGSINHLabel
            // 
            nGSINHLabel.AutoSize = true;
            nGSINHLabel.Location = new System.Drawing.Point(276, 141);
            nGSINHLabel.Name = "nGSINHLabel";
            nGSINHLabel.Size = new System.Drawing.Size(62, 16);
            nGSINHLabel.TabIndex = 10;
            nGSINHLabel.Text = "NGSINH:";
            // 
            // nGSINHDateTimePicker
            // 
            this.nGSINHDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kHACHHANGBindingSource, "NGSINH", true));
            this.nGSINHDateTimePicker.Location = new System.Drawing.Point(360, 137);
            this.nGSINHDateTimePicker.Name = "nGSINHDateTimePicker";
            this.nGSINHDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.nGSINHDateTimePicker.TabIndex = 11;
            // 
            // dOANHSOLabel
            // 
            dOANHSOLabel.AutoSize = true;
            dOANHSOLabel.Location = new System.Drawing.Point(276, 168);
            dOANHSOLabel.Name = "dOANHSOLabel";
            dOANHSOLabel.Size = new System.Drawing.Size(78, 16);
            dOANHSOLabel.TabIndex = 12;
            dOANHSOLabel.Text = "DOANHSO:";
            // 
            // dOANHSOTextBox
            // 
            this.dOANHSOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "DOANHSO", true));
            this.dOANHSOTextBox.Location = new System.Drawing.Point(360, 165);
            this.dOANHSOTextBox.Name = "dOANHSOTextBox";
            this.dOANHSOTextBox.Size = new System.Drawing.Size(200, 22);
            this.dOANHSOTextBox.TabIndex = 13;
            // 
            // nGDKLabel
            // 
            nGDKLabel.AutoSize = true;
            nGDKLabel.Location = new System.Drawing.Point(276, 197);
            nGDKLabel.Name = "nGDKLabel";
            nGDKLabel.Size = new System.Drawing.Size(48, 16);
            nGDKLabel.TabIndex = 14;
            nGDKLabel.Text = "NGDK:";
            // 
            // nGDKDateTimePicker
            // 
            this.nGDKDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kHACHHANGBindingSource, "NGDK", true));
            this.nGDKDateTimePicker.Location = new System.Drawing.Point(360, 193);
            this.nGDKDateTimePicker.Name = "nGDKDateTimePicker";
            this.nGDKDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.nGDKDateTimePicker.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 457);
            this.Controls.Add(mAKHLabel);
            this.Controls.Add(this.mAKHTextBox);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.hOTENTextBox);
            this.Controls.Add(dCHILabel);
            this.Controls.Add(this.dCHITextBox);
            this.Controls.Add(sODTLabel);
            this.Controls.Add(this.sODTTextBox);
            this.Controls.Add(nGSINHLabel);
            this.Controls.Add(this.nGSINHDateTimePicker);
            this.Controls.Add(dOANHSOLabel);
            this.Controls.Add(this.dOANHSOTextBox);
            this.Controls.Add(nGDKLabel);
            this.Controls.Add(this.nGDKDateTimePicker);
            this.Controls.Add(this.kHACHHANGDataGridView);
            this.Controls.Add(this.kHACHHANGBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingNavigator)).EndInit();
            this.kHACHHANGBindingNavigator.ResumeLayout(false);
            this.kHACHHANGBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLBHDataSet qLBHDataSet;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QLBHDataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kHACHHANGBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kHACHHANGBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kHACHHANGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox mAKHTextBox;
        private System.Windows.Forms.TextBox hOTENTextBox;
        private System.Windows.Forms.TextBox dCHITextBox;
        private System.Windows.Forms.TextBox sODTTextBox;
        private System.Windows.Forms.DateTimePicker nGSINHDateTimePicker;
        private System.Windows.Forms.TextBox dOANHSOTextBox;
        private System.Windows.Forms.DateTimePicker nGDKDateTimePicker;
    }
}

