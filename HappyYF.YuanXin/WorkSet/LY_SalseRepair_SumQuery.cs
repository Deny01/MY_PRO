﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using HappyYF.Infrastructure.Repositories;
using DataGridFilter;

using HappyYF.YuanXin.Data;



 namespace HappyYF.YuanXin.WorkSet
{
    public partial class LY_SalseRepair_SumQuery : Form
    {
        private string nowfilterStr = "";
        private string nowusercode = "";
        private string nowfillstragecode = "";

        private string nowdatetype = "inspection";
        private string nowdatetypedetail = "inspection";



        public LY_SalseRepair_SumQuery()
        {
            InitializeComponent();
        }

        private void t_usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.t_usersBindingSource.EndEdit();
            ////this.tableAdapterManager.UpdateAll(this.yonghuDataSet);
            //this.t_usersTableAdapter.Update( this.yonghuDataSet.T_users);

            SetViewState("View");

        }

        private void SetViewState(string state)
        {
            if ("View" == state)
            {

                //this.yhbmTextBox.ReadOnly = true ;
                //this.yhmcTextBox.ReadOnly = true ;
                //this.pwdTextBox.ReadOnly = true ;
                //this.group_IdComboBox.Enabled = false;
                //this.month_salaryTextBox.ReadOnly = true;

                //this.bindingNavigatorAddNewItem.Enabled = true;
                //this.bindingNavigatorDeleteItem.Enabled = true;
                //this.toolStripButton1.Enabled = true;
                //this.t_usersBindingNavigatorSaveItem.Enabled = false;

                //this.bindingNavigatorMoveFirstItem.Enabled = true;
                //this.bindingNavigatorMoveLastItem.Enabled = true;
                //this.bindingNavigatorMovePreviousItem.Enabled = true;
                //this.bindingNavigatorMoveNextItem.Enabled = true;
                //this.bindingNavigatorPositionItem.Enabled = true;

                //this.genderComboBox.Enabled = false;
                //this.identityCardTextBox.ReadOnly = true;
                //this.phoneTextBox.ReadOnly = true;
                //this.addressTextBox.ReadOnly = true;
                //this.inwork_dayDateTimePicker.Enabled = false;
                //this.in_active_serviceCheckBox.Enabled = false;
                ////this.duty_classComboBox.Enabled = false;
                //this.onlineTextBox.ReadOnly = true;

                this.treeView1.Focus();


            }
            else
            {
                //this.yhbmTextBox.ReadOnly = false  ;
                //this.yhmcTextBox.ReadOnly = false  ;
                //this.pwdTextBox.ReadOnly = false  ;
                //this.group_IdComboBox.Enabled = true ;
                //this.month_salaryTextBox.ReadOnly = false ;

                //this.bindingNavigatorAddNewItem.Enabled = false;
                //this.bindingNavigatorDeleteItem.Enabled = false;
                //this.toolStripButton1.Enabled = false;
                //this.t_usersBindingNavigatorSaveItem.Enabled = true;

                //this.bindingNavigatorMoveFirstItem.Enabled = false;
                //this.bindingNavigatorMoveLastItem.Enabled = false;
                //this.bindingNavigatorMovePreviousItem.Enabled = false;
                //this.bindingNavigatorMoveNextItem.Enabled = false;
                //this.bindingNavigatorPositionItem.Enabled = false;

                //this.genderComboBox.Enabled = true ;
                //this.identityCardTextBox.ReadOnly = false ;
                //this.phoneTextBox.ReadOnly = false ;
                //this.addressTextBox.ReadOnly = false ;
                //this.inwork_dayDateTimePicker.Enabled = true ;
                //this.in_active_serviceCheckBox.Enabled = true ;
                ////this.duty_classComboBox.Enabled = true;
                //this.onlineTextBox.ReadOnly = false ;

            }

        }

        private void Yonghu_Load(object sender, EventArgs e)
        {

            

          
            this.nowusercode = SQLDatabase.NowUserID;

            
            this. ly_sales_repair_replacementTableAdapter.Connection.ConnectionString = SQLDatabase.Connectstring;

            this.ly_SalseRepair_SumQuery_ReportTableAdapter.Connection.ConnectionString = SQLDatabase.Connectstring;

             this.ly_SalseRepair_SumQuery_ReportAllTableAdapter.Connection.ConnectionString = SQLDatabase.Connectstring;

             this.ly_sales_receive_itemDetail_repairDetailTableAdapter.Connection.ConnectionString = SQLDatabase.Connectstring;


            
            

           

          



            this.dateTimePicker1.Text = DateTime.Today.AddMonths(-1).Date.ToString();
            this.dateTimePicker2.Text = DateTime.Today.AddDays(0).Date.ToString();

            this.dateTimePicker3.Text = DateTime.Today.AddMonths(-1).Date.ToString();
            this.dateTimePicker4.Text = DateTime.Today.AddDays(0).Date.ToString();

            this.dateTimePicker5.Text = DateTime.Today.AddMonths(-3).Date.ToString();
            this.dateTimePicker6.Text = DateTime.Today.AddDays(0).Date.ToString();


          
            string selAllString;

            if (SQLDatabase.CheckHaveRight(SQLDatabase.NowUserID, "营业维修综合信息"))
            {

                //selAllString = "SELECT  a.salesregion_code, a.salesregion_code+':'+a.salesregion_name as salesregion_name,b.yhbm,b.yhbm+':'+b.yhmc as yhmc FROM  ly_salesregion a left join T_users b on a.salesregion_code=b.salesregion_code ORDER BY  salesregion_code ";

                selAllString = " select distinct a.oper_dept as salesregion_code,a.oper_dept+':'+a.prodname as salesregion_name, b.yhbm ,b.yhbm+':'+b.yhmc as yhmc "
                    + " from ly_sales_repair_sum a left join "
                    + " (SELECT  yhmc , yhbm  FROM T_users WHERE (bumen = '000302')) b on a.workname=b.yhmc "
                    + "  where b.yhbm is not null order by a.oper_dept+':'+a.prodname,b.yhbm+':'+b.yhmc ";
            }
            else if (SQLDatabase.CheckHaveRight(SQLDatabase.NowUserID, "营业维修部门信息"))
            {

                selAllString = " select distinct a.oper_dept as salesregion_code,a.oper_dept+':'+a.prodname as salesregion_name, b.yhbm ,b.yhbm+':'+b.yhmc as yhmc "
                     + " from ly_sales_repair_sum a left join "
                     + " (SELECT  yhmc , yhbm  FROM T_users WHERE (bumen = '000302')) b on a.workname=b.yhmc "
                     + "  where b.yhbm is not null order by a.oper_dept+':'+a.prodname,b.yhbm+':'+b.yhmc ";
            }
            else
            {
                selAllString = " select distinct a.oper_dept as salesregion_code,a.oper_dept+':'+a.prodname as salesregion_name, b.yhbm ,b.yhbm+':'+b.yhmc as yhmc "
                     + " from ly_sales_repair_sum a left join "
                     + " (SELECT  yhmc , yhbm  FROM T_users WHERE (bumen = '000302')) b on a.workname=b.yhmc "
                     + "  where b.yhbm is not null and b.yhbm='"+SQLDatabase.NowUserID+"' order by a.oper_dept+':'+a.prodname,b.yhbm+':'+b.yhmc ";
            }


            SqlDataAdapter salesregionAdapter = new SqlDataAdapter(selAllString, SQLDatabase.Connectstring);

            DataSet salesregionData = new DataSet();
            salesregionAdapter.Fill(salesregionData);


            System.Windows.Forms.TreeNode TNode = new System.Windows.Forms.TreeNode();
            TNode.Text = "中原精密营业维修";

            if (SQLDatabase.CheckHaveRight(SQLDatabase.NowUserID, "营业维修综合信息"))
            {
                TNode.Tag = "";
            }
            else if (SQLDatabase.CheckHaveRight(SQLDatabase.NowUserID, "营业维修部门信息"))
            {
                TNode.Tag = "salesregion_code='" + SQLDatabase.nowSalesregioncode() + "'";
            }
            else
            {
                TNode.Tag = "salesperson_code='" + SQLDatabase.NowUserID + "'"; 
            
            }

            this.treeView1.Nodes.Add(TNode);

            MakeTreeView(salesregionData.Tables[0], null, TNode);
            
            this.treeView1.ExpandAll();

            if (SQLDatabase.CheckHaveRight(SQLDatabase.NowUserID, "营业维修综合信息"))
            {
                //this.treeView1.Visible = true;
                //this.splitContainer1.Panel1Collapsed = false;
            }
            else
            {
                //this.treeView1.Visible = false;
                //this.splitContainer1.Panel1Collapsed = true;
                this.nowfilterStr = "salesperson_code='" + SQLDatabase.NowUserID + "'";
              
                
            }

            //this.ly_sales_contract_main1DataGridView.SelectionChanged -= ly_sales_contract_main1DataGridView_SelectionChanged;
            //this.ly_sales_contract_main1TableAdapter.Fill(this.lYSalseMange.ly_sales_contract_main1,"","full" );
            //this.ly_sales_contract_main1DataGridView.SelectionChanged += ly_sales_contract_main1DataGridView_SelectionChanged;

            //SetViewState("View");

        }

      



        private void MakeTreeView(DataTable table, string salesregionCode, System.Windows.Forms.TreeNode PNode)
        {


            DataRow[] dr;
            string now_salesregion_code;
            string last_salesregion_code="___";

          

            dr = table.Select("salesregion_code is not  null");

            System.Windows.Forms.TreeNode TNode = null;
            System.Windows.Forms.TreeNode CNode = null;

            foreach (DataRow d in dr)
            {
                now_salesregion_code = d["salesregion_name"].ToString();

               

                if (last_salesregion_code != now_salesregion_code)
                {

                    TNode = new System.Windows.Forms.TreeNode();

                    TNode.Text = d["salesregion_name"].ToString();

                    if (SQLDatabase.CheckHaveRight(SQLDatabase.NowUserID, "营业维修综合信息"))
                    {
                        TNode.Tag = "salesregion_code='" + d["salesregion_code"].ToString() + "'";
                    }
                    else if (SQLDatabase.CheckHaveRight(SQLDatabase.NowUserID, "营业维修部门信息"))
                    {
                        TNode.Tag = "salesregion_code='" + d["salesregion_code"].ToString() + "'";
                    }
                    
                    else
                    {

                        TNode.Tag = "salesperson_code='" + SQLDatabase.NowUserID + "'";
                    }
                    if (PNode == null)
                    {
                        this.treeView1.Nodes.Add(TNode);
                    }
                    else
                    {
                        PNode.Nodes.Add(TNode);
                        CNode = new System.Windows.Forms.TreeNode();
                        CNode.Text = d["yhmc"].ToString();
                        CNode.Tag = "salesperson_code='" + d["yhbm"].ToString() + "'";
                        if (TNode == null)
                        {
                            this.treeView1.Nodes.Add(TNode);
                        }
                        else
                        {
                            TNode.Nodes.Add(CNode);
                        }
                    }
                }
                else
                {
                    CNode = new System.Windows.Forms.TreeNode();
                    CNode.Text = d["yhmc"].ToString();
                    CNode.Tag = "salesperson_code='" + d["yhbm"].ToString() + "'";
                    if (TNode == null)
                    {
                        this.treeView1.Nodes.Add(TNode);
                    }
                    else
                    {
                        TNode.Nodes.Add(CNode);
                    }


                }
                last_salesregion_code = now_salesregion_code;

            }

          
         
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //this.ly_sales_clientBindingSource.Filter = e.Node.Tag.ToString() ;
            this.nowfilterStr = e.Node.Tag.ToString();

            if (e.Node.Level == 2)
            {
                //this.ly_sales_clientDataGridView.Columns["yhbm"].Visible = false;
                //this.ly_sales_clientDataGridView.Columns["yhmc"].Visible = false;

                this.nowusercode = this.nowfilterStr.Substring(this.nowfilterStr.Length - 4, 3);
                this.nowfillstragecode = "single";

                
                //this.ly_sales_contract_main1DataGridView.SelectionChanged -= ly_sales_contract_main1DataGridView_SelectionChanged;
                //this.ly_sales_contract_main1TableAdapter.Fill(this.lYSalseMange.ly_sales_contract_main1, this.nowusercode,"single", this.dateTimePicker1.Value , this.dateTimePicker2.Value );
                //AddSummationRow_New(ly_sales_contract_main1BindingSource, ly_sales_contract_main1DataGridView);
                //this.ly_sales_contract_main1DataGridView.SelectionChanged += ly_sales_contract_main1DataGridView_SelectionChanged;
               
            }
            else if (e.Node.Level == 1)
            {
                //this.ly_sales_clientDataGridView.Columns["yhbm"].Visible = true ;
                //this.ly_sales_clientDataGridView.Columns["yhmc"].Visible = true ;

                this.nowusercode = this.nowfilterStr.Substring(this.nowfilterStr.Length - 3, 2);
                this.nowfillstragecode = "region";

                //this.ly_sales_contract_main1DataGridView.SelectionChanged -= ly_sales_contract_main1DataGridView_SelectionChanged;
                //this.ly_sales_contract_main1TableAdapter.Fill(this.lYSalseMange.ly_sales_contract_main1, this.nowusercode, "region", this.dateTimePicker1.Value, this.dateTimePicker2.Value);
                //AddSummationRow_New(ly_sales_contract_main1BindingSource, ly_sales_contract_main1DataGridView);
                //this.ly_sales_contract_main1DataGridView.SelectionChanged += ly_sales_contract_main1DataGridView_SelectionChanged;
            }
            else if (e.Node.Level == 0)
            {
                //this.ly_sales_clientDataGridView.Columns["yhbm"].Visible = true;
                //this.ly_sales_clientDataGridView.Columns["yhmc"].Visible = true;
                if (SQLDatabase.CheckHaveRight(SQLDatabase.NowUserID, "营业维修综合信息"))
                {
                    this.nowusercode = "";
                    this.nowfillstragecode = "full";
                }
                else
                {

                    this.nowusercode = SQLDatabase.NowUserID;
                    this.nowfillstragecode = "single";

                }

                //this.ly_sales_contract_main1DataGridView.SelectionChanged -= ly_sales_contract_main1DataGridView_SelectionChanged;
                //this.ly_sales_contract_main1TableAdapter.Fill(this.lYSalseMange.ly_sales_contract_main1, this.nowusercode, "full", this.dateTimePicker1.Value, this.dateTimePicker2.Value);
                //AddSummationRow_New(ly_sales_contract_main1BindingSource, ly_sales_contract_main1DataGridView);
                //this.ly_sales_contract_main1DataGridView.SelectionChanged += ly_sales_contract_main1DataGridView_SelectionChanged;
            }

            //this.ly_sales_standard_Report_giveTableAdapter.Fill(this.lYSalseMange.ly_sales_borrow_detail_all, this.nowusercode, this.nowfillstragecode, this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            //this.ly_sales_repairstandard_ReportTableAdapter.Fill(this.lYSalseMange2.ly_sales_repairstandard_Report, this.nowusercode, this.nowfillstragecode, this.dateTimePicker3.Value, this.dateTimePicker4.Value.AddDays(1));
            //AddSummationRow_New(ly_sales_repairstandard_ReportBindingSource, ly_sales_contract_standard_ReportDataGridView);

            //this.ly_sales_repair_replacementTableAdapter.Fill(this.lYSalseRepair.ly_sales_repair_replacement, this.nowusercode, this.nowfillstragecode, this.dateTimePicker1.Value, this.dateTimePicker2.Value.AddDays(1));
            this.ly_SalseRepair_SumQuery_ReportTableAdapter.Fill(this.lYSalseRepair.ly_SalseRepair_SumQuery_Report, this.nowusercode, this.nowfillstragecode, this.dateTimePicker3.Value, this.dateTimePicker4.Value.AddDays(1),this .nowdatetype);
            this.ly_SalseRepair_SumQuery_ReportAllTableAdapter.Fill(this.lYSalseRepair.ly_SalseRepair_SumQuery_ReportAll, this.nowusercode, this.nowfillstragecode, this.dateTimePicker3.Value, this.dateTimePicker4.Value.AddDays(1),this .nowdatetype);

            if (this.tabControl1.SelectedIndex == 1)
            {

                NewFrm.Show(this);
                this.ly_sales_receive_itemDetail_repairDetailTableAdapter.Fill(this.lYSalseRepair.ly_sales_receive_itemDetail_repairDetail, this.nowusercode, this.nowfillstragecode, this.dateTimePicker5.Value, this.dateTimePicker6.Value.AddDays(1),this .nowdatetypedetail);
                NewFrm.Hide(this);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void t_usersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.BindingSource bs = sender as BindingSource;

            //this.itemofserviceBindingSource.Filter = "Teacher = '" + ((DataRowView)bs.Current)["yhbm"] + "'";
            //this.duty_classComboBox.DataSource = null;
            //this.duty_classComboBox.DataSource = this.itemofserviceBindingSource;
            //this.duty_classComboBox.DisplayMember = "ItemofserviceName";
            //this.duty_classComboBox.ValueMember = "ItemofserviceNumber";
            if (null != (DataRowView)bs.Current)
            {
                //this.ly_employe_warehouseTableAdapter.Fill(this.yonghuDataSet.ly_employe_warehouse, ((DataRowView)bs.Current)["yhbm"].ToString());
                //this.itemofserviceTableAdapter.Fill(this.yonghuDataSet.Itemofservice, ((DataRowView)bs.Current)["yhbm"].ToString());
            }
           

        }

     

      

       

        private TreeNode FindNode( TreeNodeCollection tnParent, string strValue)
        {

            if (tnParent == null) return null;

            //if (tnParent.Text == strValue) return tnParent;



            TreeNode tnRet = null;

            foreach (TreeNode tn in tnParent)
            {



                if (tn.Text == strValue)
                {
                    tnRet = tn;
                }
                else
                {

                    tnRet = FindNode(tn.Nodes, strValue);
                }

                if (tnRet != null) break;

            }

            return tnRet;

        }


       

        private void ly_sales_contract_detailDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex > -1)
            {
                if ((dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.GetType() == typeof(decimal)
                      || dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.GetType() == typeof(double)
                      || dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.GetType() == typeof(int)))
                {
                    if (Convert.ToDecimal(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == 0)
                    {
                        e.Value = "";
                    }
                }
            }       
        }

        protected bool IsInteger(object o)
        {
            if (o is Int64)
                return true;
            if (o is Int32)
                return true;
            if (o is Int16)
                return true;
            return false;
        }
        protected bool IsDecimal(object o)
        {
            if (o is Decimal)
                return true;
            if (o is Single)
                return true;
            if (o is Double)
                return true;
            return false;
        }

        private void AddSummationRow_New(BindingSource bs, DataGridView dgv)
        {
            DataRow sumdr = (((DataSet)bs.DataSource).Tables[bs.DataMember]).NewRow();

            if (-1 != bs.Find("清单号", "合计"))
            {
                bs.RemoveAt(bs.Find("清单号", "合计"));
            }

            foreach (DataGridViewRow dgvRow in dgv.Rows)
            {
                foreach (DataGridViewCell dgvCell in dgvRow.Cells)
                {
                    //foreach (DataGridViewColumn dgvColumn in dgv.Columns)
                    //{
                    if (dgvCell.Value != null && !(dgvCell.Value is DBNull))
                    {
                        if (IsInteger(dgvCell.Value))
                        {
                            if ("年份" != dgvCell.OwningColumn.HeaderText && "月份" != dgvCell.OwningColumn.HeaderText)
                            {
                                if (sumdr[dgvCell.OwningColumn.DataPropertyName] == null || (sumdr[dgvCell.OwningColumn.DataPropertyName] is DBNull))
                                    sumdr[dgvCell.OwningColumn.DataPropertyName] = 0;


                                sumdr[dgvCell.OwningColumn.DataPropertyName] = Convert.ToInt64(sumdr[dgvCell.OwningColumn.DataPropertyName]) + Convert.ToInt64(dgvCell.Value);
                            }
                        }
                        else if (IsDecimal(dgvCell.Value))
                        {
                            if ("年份" != dgvCell.OwningColumn.HeaderText && "月份" != dgvCell.OwningColumn.HeaderText )
                            {
                                if (sumdr[dgvCell.OwningColumn.DataPropertyName] == null || (sumdr[dgvCell.OwningColumn.DataPropertyName] is DBNull))
                                    sumdr[dgvCell.OwningColumn.DataPropertyName] = 0;
                                //dgvCell .OwningColumn.Name  dgvCell.ColumnIndex

                                sumdr[dgvCell.OwningColumn.DataPropertyName] = Convert.ToDecimal(sumdr[dgvCell.OwningColumn.DataPropertyName]) + Convert.ToDecimal(dgvCell.Value);
                            }
                        }

                        //sumBox.Text = string.Format("{0}", sumBox.Tag);
                        //sumBox.Invalidate();

                    }
                    //}
                }

            }
            sumdr["清单号"] = "合计";
            sumdr["客户"] = "";
            sumdr["税务"] = "";
            ((DataSet)bs.DataSource).Tables[bs.DataMember].Rows.Add(sumdr);
            bs.ResetBindings(true);

        }

       

        private void toolStripButton16_Click_1(object sender, EventArgs e)
        {
            //ExportDataGridviewTOExcell.ExportDataGridview(this.ly_sales_contract_standard_ReportDataGridView, true);
        }

        private void toolStripButton21_Click_1(object sender, EventArgs e)
        {
            //this.ly_sales_repairstandard_ReportTableAdapter.Fill(this.lYSalseMange2.ly_sales_repairstandard_Report, this.nowusercode, this.nowfillstragecode, this.dateTimePicker1.Value, this.dateTimePicker2.Value.AddDays(1));
            //AddSummationRow_New(ly_sales_repairstandard_ReportBindingSource, ly_sales_contract_standard_ReportDataGridView);

        }

        //private void toolStripTextBox4_KeyUp(object sender, KeyEventArgs e)
        //{
        //    string filterString;


        //    filterString = GetDataGridviewMultiFilterString.DGVMultiFilterString(this.ly_sales_standard_Report_giveDataGridView, this.toolStripTextBox4.Text);


        //    this.ly_sales_standard_Report_giveBindingSource.Filter = filterString;
        //}

       

        //private void toolStripTextBox4_Enter(object sender, EventArgs e)
        //{
        //    toolStripTextBox4.Text = "";

        //    this.ly_sales_standard_Report_giveBindingSource.Filter = "";
        //}

        //private void toolStripButton5_Click(object sender, EventArgs e)
        //{
        //    ExportDataGridviewTOExcell.ExportDataGridview(this.ly_sales_contract_standard_ReportDataGridView, true);
        //}

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            //this.ly_sales_repairstandard_ReportTableAdapter.Fill(this.lYSalseMange2.ly_sales_repairstandard_Report, this.nowusercode, this.nowfillstragecode, this.dateTimePicker3.Value, this.dateTimePicker4.Value.AddDays(1));
            //AddSummationRow_New(ly_sales_repairstandard_ReportBindingSource, ly_sales_contract_standard_ReportDataGridView);

        }

        private void ly_sales_contract_standard_ReportDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //string isgood = "yes";

            //decimal nowmoney;

           

            //foreach (DataGridViewRow dgr in ly_sales_contract_standard_ReportDataGridView.Rows)
            //{


            //    if ("" != dgr.Cells["金额"].Value.ToString())
            //    {
            //        nowmoney = decimal.Parse(dgr.Cells["金额"].Value.ToString());
            //    }
            //    else
            //    {
            //        nowmoney = 0;
            //    }







            //    if (nowmoney <= 0)
            //        {
            //            foreach (DataGridViewCell dgc in dgr.Cells)
            //            {

            //                dgc.Style.BackColor = Color.White;
            //                dgc.Style.ForeColor = Color.Red;
            //            }
            //        }
              
            //    //else
            //    //{ 


            //    //}



            //}
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            //if (null == this.ly_sales_contract_standard_ReportDataGridView.CurrentRow)    return;

            //FilterForm filterForm = new FilterForm();

            ////SumQueryDataSet qds;
            ////qds = new SumQueryDataSet();

            //List<string> ls = new List<string>();
            //ls.Add("id");


            //filterForm.SetSourceColumns(this .lYSalseMange2.ly_sales_contract_standard_Report.Columns, ls);

            //filterForm.ShowDialog();

            //this.ly_sales_repairstandard_ReportBindingSource.Filter = filterForm.GetFilterString();
            //AddSummationRow_New(ly_sales_repairstandard_ReportBindingSource, ly_sales_contract_standard_ReportDataGridView);

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
        //    if (null == this.ly_sales_contract_standard_ReportDataGridView.CurrentRow) return;
        //    SortForm DataSort = new SortForm();

        //    List<string> ls = new List<string>();
        //    ls.Add("id");


        //    DataSort.SetSortColumns(this.lYSalseMange2.ly_sales_contract_standard_Report.Columns, ls);
        //    DataSort.ShowDialog();
            //this.ly_sales_contract_standard_ReportBindingSource.Sort ="(" +DataSort.GetSortString()+") or 清单号='合计'";
        }

        private void toolStripTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            //string filterString;


            //filterString = GetDataGridviewMultiFilterString.DGVMultiFilterString(this.ly_sales_contract_standard_ReportDataGridView, this.toolStripTextBox2.Text);


            //this.ly_sales_repairstandard_ReportBindingSource.Filter = "(" + filterString + ") or 清单号='合计'";
            //AddSummationRow_New(ly_sales_repairstandard_ReportBindingSource, ly_sales_contract_standard_ReportDataGridView);
        }

        private void toolStripTextBox2_Enter(object sender, EventArgs e)
        {
            //toolStripTextBox2.Text = "";

            //this.ly_sales_repairstandard_ReportBindingSource.Filter = "";
        }

        private void ly_sales_contract_standard_ReportDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (null == dgv.CurrentRow) return;

            string nowcontract_code = dgv.CurrentRow.Cells["收件单号"].Value.ToString();

            ///////////////////////////////////////////////////////////////

            if ("开票日期" == dgv.CurrentCell.OwningColumn.Name)
            {

                //if ("XS" != nowcontract_code.Substring(0, 2))
                //{

                //    MessageBox.Show("只能修改合同开票日期...", "注意");
                //    return;
                
                //}

                ChangeValue queryForm = new ChangeValue();

                queryForm.OldValue = dgv.CurrentCell.Value.ToString();
                queryForm.NewValue = "";
                queryForm.ChangeMode = "datetime";
                queryForm.ShowDialog();


                
                string updstr;

                if (queryForm.NewValue != "")
                {
                    dgv.CurrentRow.Cells["开票日期"].Value = queryForm.NewValue;
                    //dgv.CurrentRow.Cells["开票人"].Value = "宋美彰";
                    updstr = " update ly_sales_receive  " +
                                "  set invoice_date=  '" + queryForm.NewValue + "',invoice_people='宋美彰' where  receive_code='" + nowcontract_code + "'";



                }
                else
                {

                    dgv.CurrentRow.Cells["开票日期"].Value = DBNull.Value;
                    //dgv.CurrentRow.Cells["开票人"].Value = DBNull.Value;
                    updstr = " update ly_sales_receive  " +
                                "  set invoice_date= null, invoice_people=null where  receive_code='" + nowcontract_code + "'";


                }


                ///////////////////

               


                        SqlConnection sqlConnection1 = new SqlConnection(SQLDatabase.Connectstring);
                        SqlCommand cmd = new SqlCommand();

                        cmd.CommandText = updstr;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = sqlConnection1;

                        //sqlConnection1.Open();
                        //cmd.ExecuteNonQuery();
                        //sqlConnection1.Close();

                        int temp = 0;

                        using (TransactionScope scope = new TransactionScope())
                        {

                            sqlConnection1.Open();
                            try
                            {

                                cmd.ExecuteNonQuery();



                                scope.Complete();



                            }
                            catch (SqlException sqle)
                            {


                                MessageBox.Show(sqle.Message.Split('*')[0]);
                            }


                            finally
                            {
                                sqlConnection1.Close();


                            }
                        }



                        ////////////////////////////



                return;

            }
            ////////////////////////////////////////////////////////////////////////
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            //this.ly_sales_repairstandard_ReportBindingSource.Filter = " 公司='中原' or 清单号='合计'";
            //AddSummationRow_New(ly_sales_repairstandard_ReportBindingSource, ly_sales_contract_standard_ReportDataGridView);

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            //this.ly_sales_repairstandard_ReportBindingSource.Filter = " 公司='中成'or 清单号='合计'";
            //AddSummationRow_New(ly_sales_repairstandard_ReportBindingSource, ly_sales_contract_standard_ReportDataGridView);

        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            //this.ly_sales_repairstandard_ReportBindingSource.Filter = "";
            //AddSummationRow_New(ly_sales_repairstandard_ReportBindingSource, ly_sales_contract_standard_ReportDataGridView);

        }

        private void ly_sales_contract_standard_ReportDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            //this.ly_sales_repair_replacementTableAdapter.Fill(this.lYSalseRepair.ly_sales_repair_replacement, this.nowusercode, this.nowfillstragecode, this.dateTimePicker1.Value, this.dateTimePicker2.Value.AddDays(1));

        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            ExportDataGridviewTOExcell.ExportDataGridview(this.ly_sales_repair_replacementDataGridView, true);
        }

        private void toolStripButton27_Click(object sender, EventArgs e)
        {


            if (null == this.ly_sales_repair_replacementDataGridView.CurrentRow) return;
            
            NewFrm.Show(this); 

     

            BaseReportView queryForm = new BaseReportView();



            queryForm.setchackBoxCansee(false);

            queryForm.Printdata = this.lYSalseRepair;
            //queryForm.company = ly_sales_contract_mainDataGridView.CurrentRow.Cells["公司"].Value.ToString();


                queryForm.Text = "退料明细表";
                queryForm.PrintCrystalReport = new LY_sales_repair_Replc();
          


            //string selectFormula;

            //selectFormula = "not {ly_sales_receive_repairfee.免费} and {ly_sales_receive_repairfee.金额}>0 ";
            //queryForm.PrintCrystalReport.DataDefinition.RecordSelectionFormula = selectFormula;



            NewFrm.Hide(this);

            queryForm.ShowDialog();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            //this.ly_sales_repair_replacementTableAdapter.Fill(this.lYSalseRepair.ly_sales_repair_replacement, this.nowusercode, this.nowfillstragecode, this.dateTimePicker1.Value, this.dateTimePicker2.Value.AddDays(1));
            this.ly_SalseRepair_SumQuery_ReportTableAdapter.Fill(this.lYSalseRepair.ly_SalseRepair_SumQuery_Report, this.nowusercode, this.nowfillstragecode, this.dateTimePicker3.Value, this.dateTimePicker4.Value.AddDays(1), this.nowdatetype);
            this.ly_SalseRepair_SumQuery_ReportAllTableAdapter.Fill(this.lYSalseRepair.ly_SalseRepair_SumQuery_ReportAll, this.nowusercode, this.nowfillstragecode, this.dateTimePicker3.Value, this.dateTimePicker4.Value.AddDays(1), this.nowdatetype);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            NewFrm.Show(this);
            this.ly_sales_receive_itemDetail_repairDetailTableAdapter.Fill(this.lYSalseRepair.ly_sales_receive_itemDetail_repairDetail, this.nowusercode, this.nowfillstragecode, this.dateTimePicker5.Value, this.dateTimePicker6.Value.AddDays(1),this .nowdatetypedetail );
            NewFrm.Hide(this);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;

            if ("质检" == rdb.Text)
            {
                this.nowdatetype = "inspection";
            }
            else if ("完成" == rdb.Text)
            {
                this.nowdatetype = "finish";
            }
            else
            {
                this.nowdatetype = "accept";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;

            if ("质检" == rdb.Text)
            {
                this.nowdatetypedetail = "inspection";
            }
            else if ("完成" == rdb.Text)
            {
                this.nowdatetypedetail = "finish";
            }
            else
            {
                this.nowdatetypedetail = "accept";
            }

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ExportDataGridviewTOExcell.ExportDataGridview(ly_sales_receive_itemDetail_repairDetailDataGridView, true);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            ExportDataGridviewTOExcell.ExportDataGridview(ly_SalseRepair_SumQuery_ReportDataGridView, true);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {


            ExportDataGridviewTOExcell.ExportDataGridview(ly_SalseRepair_SumQuery_ReportAllDataGridView, true);
        }

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.ly_sales_receive_itemDetail_repairDetailTableAdapter.Fill(this.lYSalseRepair.ly_sales_receive_itemDetail_repairDetail, worker_codeToolStripTextBox.Text, procodeToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(begindateToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(enddateToolStripTextBox.Text, typeof(System.DateTime))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.ly_SalseRepair_SumQuery_ReportAllTableAdapter.Fill(this.lYSalseRepair.ly_SalseRepair_SumQuery_ReportAll, salesperson_codeToolStripTextBox.Text, selcodeToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(begindateToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(enddateToolStripTextBox.Text, typeof(System.DateTime))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.ly_SalseRepair_SumQuery_ReportTableAdapter.Fill(this.lYSalseRepair.ly_SalseRepair_SumQuery_Report, salesperson_codeToolStripTextBox.Text, selcodeToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(begindateToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(enddateToolStripTextBox.Text, typeof(System.DateTime))))));
       
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.ly_sales_repair_replacementTableAdapter.Fill(this.lYSalseRepair.ly_sales_repair_replacement, salesperson_codeToolStripTextBox.Text, selcodeToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(begindateToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(enddateToolStripTextBox.Text, typeof(System.DateTime))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.ly_sales_repairstandard_ReportTableAdapter.Fill(this.lYSalseMange2.ly_sales_repairstandard_Report, salesperson_codeToolStripTextBox.Text, selcodeToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(begindateToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(enddateToolStripTextBox.Text, typeof(System.DateTime))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.ly_sales_standard_Report_giveTableAdapter.Fill(this.lYSalseMange2.ly_sales_standard_Report_give, salesperson_codeToolStripTextBox.Text, selcodeToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(begindateToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(enddateToolStripTextBox.Text, typeof(System.DateTime))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

       
       
       

       
    }
}
