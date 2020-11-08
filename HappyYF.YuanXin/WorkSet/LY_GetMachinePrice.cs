﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyYF.Infrastructure.Repositories;

namespace HappyYF.YuanXin.WorkSet
{
    public partial class LY_GetMachinePrice : Form
    {
        public string InStrId = "";
 
        public LY_GetMachinePrice()
        {
            InitializeComponent();
        }




        private void LY_Quality_Control_PurchaseRep_Load(object sender, EventArgs e)
        {

            this.ly_store_inTableAdapter.Connection.ConnectionString = SQLDatabase.Connectstring;
            this.getMachineFivePriceTableAdapter.Connection.ConnectionString = SQLDatabase.Connectstring;
            this.getMachineFivePrice_OutSourceTableAdapter.Connection.ConnectionString = SQLDatabase.Connectstring;
            if (!string.IsNullOrEmpty(InStrId)  )
            {


                this.ly_store_inTableAdapter.Fill(this.lYQualityInspector.ly_store_in, int.Parse(InStrId));
                this.getMachineFivePriceTableAdapter.Fill(this.lYQualityInspector.GetMachineFivePrice, int.Parse(InStrId));
                this.getMachineFivePrice_OutSourceTableAdapter.Fill(this.lYQualityInspector.GetMachineFivePrice_OutSource, int.Parse(InStrId));
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
             ExportDataGridviewTOExcellA.ExportDataGridview(this.ly_purchase_contract_inspectionRepDataGridView, true);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ExportDataGridviewTOExcellA.ExportDataGridview(this.dataGridView1, true);
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            ExportDataGridviewTOExcellA.ExportDataGridview(this.dataGridView2, true);
        }
    }
}