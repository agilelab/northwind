using System; 
using System.Collections; 
using System.Collections.Generic; 
using System.Drawing; 
using System.ComponentModel; 
using System.Data; 
using System.Windows.Forms; 
using System.IO; 
using System.Linq; 
using System.Globalization; 
using System.Runtime.Serialization.Formatters.Binary; 
using System.Text; 

using EAS.Data; 
using EAS.Data.ORM; 
using EAS.Data.Access; 
using EAS.Modularization; 

using EAS.Services; 
using EAS.Data.Linq; 

using Northwind.Entities; 

namespace Northwind.WinUI 
{ 
  [Module("0a41fdc9-c66e-4a96-abbf-14aa31e380a1", "产品管理", "ProductList")]  
  public partial class ProductList : UserControl 
  { 
        IQueryable<Product> vList = null; 
    
        public ProductList() 
        { 
            InitializeComponent(); 
            this.dataGridView1.AutoGenerateColumns = false; 
            this.dataGridView1.DataSource = this.datasourcedataGridView1;
            this.datasourcedataGridView1.DataSource = new List<Product>();
        } 
        
        [ModuleStart] 
        public void StartEx() 
        { 
        } 
        
        /// <summary>
        /// 显示记录。
        /// </summary>
        IList<Product> DisplayList
        {
            get
            {
                return this.datasourcedataGridView1.DataSource as IList<Product>;
            }
        }

  
        public void GetDataList(string productname ) 
        { 
            DataEntityQuery<Product> query = DataEntityQuery<Product>.Create(); 
  
            var v = (from item in query
                     where item.ProductName.StartsWith(productname) || item.InputCode.StartsWith(productname)
              select item); 
  
          this.vList = v as IQueryable<Product>; 
        } 
  
 
        private void dataPager_PageChanged(object sender, EventArgs e) 
        { 
            this.datasourcedataGridView1.DataSource = this.vList.Skip(this.dataPager.Skip).Take(this.dataPager.Take).ToList(); 
        } 
        
        private void btnAdd_Click(object sender, EventArgs e) 
        { 
             ProductEditor editor=new ProductEditor();
             if (editor.ShowDialog() == DialogResult.OK)
             {
                 btnQuery_Click(this.btnQuery, e);
                 //this.DisplayList.Add(editor.DataEntity);
             }
        } 
        
        private void btnEdit_Click(object sender, EventArgs e) 
        { 
             ProductEditor editor=new ProductEditor(); 
             editor.DataEntity = this.dataGridView1.CurrentRow.DataBoundItem as Product; 
             if (editor.ShowDialog() == DialogResult.OK) 
             {
              this.datasourcedataGridView1.ResetCurrentItem();
             }
        } 
        
        private void btnDelete_Click(object sender, EventArgs e) 
        { 
            Product selectEntity= this.dataGridView1.CurrentCell.OwningRow.DataBoundItem as Product; 
            if(selectEntity==null)  return;
            
            try
            {
              this.dataGridView1.Rows.Remove(this.dataGridView1.CurrentCell.OwningRow)  ;
              if (this.DisplayList.Contains(selectEntity)) 
                  this.DisplayList.Remove(selectEntity);  
                selectEntity.Delete();  
            }
            catch (System.Exception exc)
            {
               MessageBox.Show("删除数据时发生错误：\r\n" + exc.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 
        
        private void btnQuery_Click(object sender, EventArgs e) 
        { 
            this.GetDataList(this.tbProductName.Text.Trim() ); 
            this.dataPager.RecordCount = this.vList.Count(); 
        } 
        
        private void btnPrint_Click(object sender, EventArgs e) 
        { 
            this.Report.Name = ""; //在此处修改报表名称 
            this.Report.Refresh(); 
            if (!this.Report.Exists) 
            { 
                 MessageBox.Show("没有找到'" + this.Report.Name +"' 报表的定义。请联系系统管理员，确认该报表的创建。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                 return; 
            } 
            
            this.PrintForm.Report = this.Report; 
            this.PrintForm.DataObject = this.vList.ToList(); 
            this.PrintForm.PrintPreview(); 
        } 
        
        private void btnClose_Click(object sender, EventArgs e) 
        { 
             EAS.Application.Instance.CloseModule();  
        } 
        
 
        #region 报表相关 
        
        /// <summary> 
        /// 报表。 
        /// </summary> 
        protected EAS.Explorer.Entities.Report Report 
        { 
            get 
            { 
                if (this.m_Report == null) 
                { 
                    this.m_Report = new EAS.Explorer.Entities.Report(); 
                    this.m_Report.Name = string.Empty; 
                } 
                return this.m_Report; 
            } 
        } 
        EAS.Explorer.Entities.Report m_Report; 
         
        /// <summary> 
        /// 打印窗体。 
        /// </summary> 
        protected EAS.Report.Controls.PrintViewDialog PrintForm 
        { 
            get 
            { 
                if (this.m_PrintForm == null) 
                { 
                    this.m_PrintForm = new EAS.Report.Controls.PrintViewDialog(); 
                } 
                return this.m_PrintForm; 
            } 
        } 
        EAS.Report.Controls.PrintViewDialog m_PrintForm; 
         
        #endregion 
  } 
} 
