using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Modularization;
using EAS.Data.Access;
using EAS.Data.ORM;
using EAS.Data.Linq;
using Northwind.Entities;
using EAS;

namespace Northwind.WinUI
{
    [Module("18FE455D-B818-4082-931B-153F3EE31792", "商品目录", "")]
    public partial class CategoryAddIn : UserControl
    {
        [ModuleStart]
        public void StartEx()
        {
            this.LoadData();
        }

        public CategoryAddIn()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        void LoadData()
        {
            string key = this.tbKey.Text.ToPinYin();

            using (DbEntities db = new DbEntities())
            {
                var vList = db.Categorys.ToList();

                this.categoryBindingSource.DataSource = vList
                    .Where(p => p.CategoryName.ToPinYin().StartsWith(key)).ToList().ToSortable();
            }
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex > -1 && dataGridView1.Rows.Count > e.RowIndex-1)
            {
                var v = dataGridView1.Rows[e.RowIndex];

                if (v != null)
                {
                    Category item = v.DataBoundItem as Category;
                    if (item != null)
                    {
                        if (item.CategoryID == 0)
                            item.CategoryID = item.GetMaxID();
                        item.LMTime = EAS.Environment.NowTime;
                    }
                }
            }
        }
    }
}
