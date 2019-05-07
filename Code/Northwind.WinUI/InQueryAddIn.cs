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
using EAS;

namespace Northwind.WinUI
{
    [Module("033E2C1E-BEE4-4EB6-B4D7-4AD48E89BE25", "入库查询", "")]
    public partial class InQueryAddIn : UserControl
    {
        [ModuleStart]
        public void StartEx()
        {
            this.dtpStart.Value = EAS.Environment.NowTime.Date;
            this.dtpEnd.Value = EAS.Environment.NowTime.Date;
        }

        public InQueryAddIn()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            using (DbEntities db = new DbEntities())
            {
                var v = db.InBills
                    .Where(p => p.InTime >= this.dtpStart.Value && p.InTime <= this.dtpEnd.Value.AddDays(1))
                    .ToList().ToSortable();

                inBillBindingSource.DataSource = v;
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           var hit = this.dataGridView1.HitTest(e.X,e.Y);
           if (hit.Type == DataGridViewHitTestType.Cell || hit.Type == DataGridViewHitTestType.RowHeader)
           {
               var v = dataGridView1.Rows[hit.RowIndex].DataBoundItem as InBill;
               inBillDetailBindingSource.DataSource = v.Details;
           }
        }
    }
}
