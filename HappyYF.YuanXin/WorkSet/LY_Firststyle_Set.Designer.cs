﻿namespace HappyYF.YuanXin.WorkSet
{
    partial class LY_Firststyle_Set
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LY_Firststyle_Set));
            this.lYMaterialMange = new HappyYF.YuanXin.Data.LYMaterialMange();
            this.tableAdapterManager = new HappyYF.YuanXin.Data.LYMaterialMangeTableAdapters.TableAdapterManager();
            this.ly_materrial_sortBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ly_materrial_sortBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ly_firststyle_setBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ly_firststyle_setTableAdapter = new HappyYF.YuanXin.Data.LYMaterialMangeTableAdapters.ly_firststyle_setTableAdapter();
            this.ly_firststyle_setDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lYMaterialMange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ly_materrial_sortBindingNavigator)).BeginInit();
            this.ly_materrial_sortBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ly_firststyle_setBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ly_firststyle_setDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lYMaterialMange
            // 
            this.lYMaterialMange.DataSetName = "LYMaterialMange";
            this.lYMaterialMange.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ly_bm0031TableAdapter = null;
            this.tableAdapterManager.ly_employe_warehouseTableAdapter = null;
            this.tableAdapterManager.ly_firststyle_setTableAdapter = null;
            this.tableAdapterManager.ly_inma0010addTableAdapter = null;
            this.tableAdapterManager.ly_inma0010cpTableAdapter = null;
            this.tableAdapterManager.ly_inma0010TableAdapter = null;
            this.tableAdapterManager.ly_inma0010ylTableAdapter = null;
            this.tableAdapterManager.ly_material_plan_detail_endProductTableAdapter = null;
            this.tableAdapterManager.ly_materialstatusTableAdapter = null;
            this.tableAdapterManager.ly_prod_deptTableAdapter = null;
            this.tableAdapterManager.ly_secondstyle_setTableAdapter = null;
            this.tableAdapterManager.ly_unitsetTableAdapter = null;
            this.tableAdapterManager.ly_warehouseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HappyYF.YuanXin.Data.LYMaterialMangeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ly_materrial_sortBindingNavigator
            // 
            this.ly_materrial_sortBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ly_materrial_sortBindingNavigator.BindingSource = this.ly_firststyle_setBindingSource;
            this.ly_materrial_sortBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ly_materrial_sortBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ly_materrial_sortBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ly_materrial_sortBindingNavigatorSaveItem});
            this.ly_materrial_sortBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ly_materrial_sortBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ly_materrial_sortBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ly_materrial_sortBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ly_materrial_sortBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ly_materrial_sortBindingNavigator.Name = "ly_materrial_sortBindingNavigator";
            this.ly_materrial_sortBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ly_materrial_sortBindingNavigator.Size = new System.Drawing.Size(415, 25);
            this.ly_materrial_sortBindingNavigator.TabIndex = 0;
            this.ly_materrial_sortBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
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
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ly_materrial_sortBindingNavigatorSaveItem
            // 
            this.ly_materrial_sortBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ly_materrial_sortBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ly_materrial_sortBindingNavigatorSaveItem.Image")));
            this.ly_materrial_sortBindingNavigatorSaveItem.Name = "ly_materrial_sortBindingNavigatorSaveItem";
            this.ly_materrial_sortBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ly_materrial_sortBindingNavigatorSaveItem.Text = "保存数据";
            this.ly_materrial_sortBindingNavigatorSaveItem.Click += new System.EventHandler(this.ly_materrial_sortBindingNavigatorSaveItem_Click);
            // 
            // ly_firststyle_setBindingSource
            // 
            this.ly_firststyle_setBindingSource.DataMember = "ly_firststyle_set";
            this.ly_firststyle_setBindingSource.DataSource = this.lYMaterialMange;
            // 
            // ly_firststyle_setTableAdapter
            // 
            this.ly_firststyle_setTableAdapter.ClearBeforeFill = true;
            // 
            // ly_firststyle_setDataGridView
            // 
            this.ly_firststyle_setDataGridView.AutoGenerateColumns = false;
            this.ly_firststyle_setDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ly_firststyle_setDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ly_firststyle_setDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.ly_firststyle_setDataGridView.DataSource = this.ly_firststyle_setBindingSource;
            this.ly_firststyle_setDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ly_firststyle_setDataGridView.Location = new System.Drawing.Point(0, 25);
            this.ly_firststyle_setDataGridView.Name = "ly_firststyle_setDataGridView";
            this.ly_firststyle_setDataGridView.RowHeadersWidth = 19;
            this.ly_firststyle_setDataGridView.RowTemplate.Height = 23;
            this.ly_firststyle_setDataGridView.Size = new System.Drawing.Size(415, 299);
            this.ly_firststyle_setDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "firststyleCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "成品一级分类编码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 126;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "firststyleName";
            this.dataGridViewTextBoxColumn2.HeaderText = "成品一级分类名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 126;
            // 
            // LY_Firststyle_Set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 324);
            this.Controls.Add(this.ly_firststyle_setDataGridView);
            this.Controls.Add(this.ly_materrial_sortBindingNavigator);
            this.Name = "LY_Firststyle_Set";
            this.Text = "成品一级分类设置";
            this.Load += new System.EventHandler(this.LY_MaterialSort_Set_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lYMaterialMange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ly_materrial_sortBindingNavigator)).EndInit();
            this.ly_materrial_sortBindingNavigator.ResumeLayout(false);
            this.ly_materrial_sortBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ly_firststyle_setBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ly_firststyle_setDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HappyYF.YuanXin.Data.LYMaterialMange lYMaterialMange;
        private HappyYF.YuanXin.Data.LYMaterialMangeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ly_materrial_sortBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ly_materrial_sortBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource ly_firststyle_setBindingSource;
        private HappyYF.YuanXin.Data.LYMaterialMangeTableAdapters.ly_firststyle_setTableAdapter ly_firststyle_setTableAdapter;
        private System.Windows.Forms.DataGridView ly_firststyle_setDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}