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
     /// <summary> 
     /// 员工。 
     /// </summary> 
     public partial class EmployeeEditor : Form 
     { 
  
         public EmployeeEditor() 
         { 
             InitializeComponent(); 
         } 
         
         #region  DataEntity
         
         public Employee DataEntity 
         { 
             get 
             { 
                return this.m_DataEntity; 
             } 
             set 
             { 
                if(value == null) 
                    return; 
                this.m_DataEntity = value; 
                this.RefreshData(); 
             } 
         } 

         Employee m_DataEntity; 
         
         #endregion
         
         void RefreshData() 
         { 
             if(this.DataEntity != null) 
             { 
                this.tbEmployeeID.Text=this.m_DataEntity.EmployeeID.ToString(); 
                this.tbName.Text=this.m_DataEntity.Name; 
                this.tbTitle.Text=this.m_DataEntity.Title; 
                this.tbBirthDate.Text=this.m_DataEntity.BirthDate.ToString(); 
                this.tbHireDate.Text=this.m_DataEntity.HireDate.ToString(); 
                this.tbAddress.Text=this.m_DataEntity.Address; 
                this.tbMail.Text=this.m_DataEntity.Mail; 
                this.tbPhone.Text=this.m_DataEntity.Phone; 
                this.tbLMTime.Text=this.m_DataEntity.LMTime.ToString(); 
             } 
         } 
        
        bool ValidInput() 
        { 
            if ( this.tbEmployeeID.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "员工ID ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbEmployeeID.Focus(); 
                return false; 
            } 
            if ( this.tbName.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "姓名 ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbName.Focus(); 
                return false; 
            } 
            if ( this.tbTitle.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "头衔 ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbTitle.Focus(); 
                return false; 
            } 
            if ( this.tbBirthDate.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "生日 ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbBirthDate.Focus(); 
                return false; 
            } 
            if ( this.tbHireDate.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "雇佣日期 ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbHireDate.Focus(); 
                return false; 
            } 
            if ( this.tbAddress.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "地址 ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbAddress.Focus(); 
                return false; 
            } 
            if ( this.tbMail.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "邮件 ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbMail.Focus(); 
                return false; 
            } 
            if ( this.tbPhone.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "电话 ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbPhone.Focus(); 
                return false; 
            } 
            if ( this.tbLMTime.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "最后更新时间 ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbLMTime.Focus(); 
                return false; 
            } 
            return true; 
        } 
        private void btnSave_Click(object sender, EventArgs e) 
        { 
            if (!this.ValidInput()) 
            { 
                return; 
            } 
 
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor; 
 
            try 
            { 
                Employee dataEntity = null; 
 
                if (this.DataEntity == null) 
                { 
                    dataEntity = new Employee(); 
                } 
                else 
                { 
                    dataEntity = this.DataEntity; 
                } 
 
                //基本信息 
                dataEntity.EmployeeID=this.tbEmployeeID.Text!=""? Convert.ToInt32(this.tbEmployeeID.Text) : 0; 
                dataEntity.Name=this.tbName.Text; 
                dataEntity.Title=this.tbTitle.Text; 
                dataEntity.BirthDate=this.tbBirthDate.Text!=null? Convert.ToDateTime(this.tbBirthDate.Text) : DateTime.Now; 
                dataEntity.HireDate=this.tbHireDate.Text!=null? Convert.ToDateTime(this.tbHireDate.Text) : DateTime.Now; 
                dataEntity.Address=this.tbAddress.Text; 
                dataEntity.Mail=this.tbMail.Text; 
                dataEntity.Phone=this.tbPhone.Text; 
                dataEntity.LMTime=this.tbLMTime.Text!=null? Convert.ToDateTime(this.tbLMTime.Text) : DateTime.Now; 
 
                if (this.DataEntity == null) 
                { 
                    dataEntity.Insert(); 
                } 
                else 
                { 
                    dataEntity.Update(); 
                } 
 
                this.m_DataEntity = dataEntity; 
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            } 
            catch (System.Exception ex) 
            { 
                MessageBox.Show(this, "在保存‘员工’数据的过程中发生了一个错误： " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            } 
            finally 
            { 
                this.Cursor = System.Windows.Forms.Cursors.Default; 
            } 
        } 
        
        private void btnClose_Click(object sender, EventArgs e) 
        { 
             this.Close();  
        } 
        
   } 
} 
