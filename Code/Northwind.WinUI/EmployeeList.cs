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
  [Module("d72cca8d-2a67-4dcd-b905-31d4380aebb5", "员工管理", "EmployeeList")]  
  public partial class EmployeeList : UserControl 
  { 
        IQueryable<Employee> vList = null; 
    
        public EmployeeList() 
        { 
            InitializeComponent(); 
            this.dataGridView1.AutoGenerateColumns = false; 
            this.dataGridView1.DataSource = this.datasourcedataGridView1;
            this.datasourcedataGridView1.DataSource = new List<Employee>();
        } 
        
        [ModuleStart] 
        public void StartEx() 
        { 
        } 
        
        /// <summary>
        /// 显示记录。
        /// </summary>
        IList<Employee> DisplayList
        {
            get
            {
                return this.datasourcedataGridView1.DataSource as IList<Employee>;
            }
        }

  
        public void GetDataList(string name ) 
        { 
            DataEntityQuery<Employee> query = DataEntityQuery<Employee>.Create(); 
  
            var v = (from item in query 
                     where    (name.Trim().Length==0 || item.Name==name) 
              select item); 
  
          this.vList = v as IQueryable<Employee>; 
        } 
  
 
        private void dataPager_PageChanged(object sender, EventArgs e) 
        { 
            this.datasourcedataGridView1.DataSource = this.vList.Skip(this.dataPager.Skip).Take(this.dataPager.Take).ToList(); 
        } 
        
        private void btnAdd_Click(object sender, EventArgs e) 
        { 
             EmployeeEditor editor=new EmployeeEditor(); 
             if (editor.ShowDialog() == DialogResult.OK) 
             { 
              this.DisplayList.Add(editor.DataEntity); 
             } 
        } 
        
        private void btnEdit_Click(object sender, EventArgs e) 
        { 
             EmployeeEditor editor=new EmployeeEditor(); 
             editor.DataEntity = this.dataGridView1.CurrentRow.DataBoundItem as Employee; 
             if (editor.ShowDialog() == DialogResult.OK) 
             {
              this.datasourcedataGridView1.ResetCurrentItem();
             }
        } 
        
        private void btnDelete_Click(object sender, EventArgs e) 
        { 
            Employee selectEntity= this.dataGridView1.CurrentCell.OwningRow.DataBoundItem as Employee; 
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
            this.GetDataList(this.tbName.Text.Trim() ); 
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
