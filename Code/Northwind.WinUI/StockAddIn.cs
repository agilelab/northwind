using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Modularization;

using Northwind.Entities;

namespace Northwind.WinUI
{
    [Module("1899DCDF-0E13-4EA0-89B9-18E2F66DA208", "库存查询", "")]
    public partial class StockAddIn : UserControl
    {
        [ModuleStart]
        public void StartEx()
        {
            this.gDisplayViewer1.ReportID = new Guid("CA178D53-87AD-4EAE-888B-462423D57A82");
        }

        public StockAddIn()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            using (DbEntities db = new DbEntities())
            {
                var v = db.Stocks.Where(p => p.InputCode.StartsWith(this.tbKey.Text)).ToList();
                this.gDisplayViewer1.DataObject = v;
            }
        }
    }
}
