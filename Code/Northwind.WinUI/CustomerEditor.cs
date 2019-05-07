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
     /// 客户。 
     /// </summary> 
     public partial class CustomerEditor : Form 
     { 
  
         public CustomerEditor() 
         { 
             InitializeComponent(); 
         } 
         
         #region  DataEntity
         
         public Customer DataEntity 
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

         Customer m_DataEntity; 
         
         #endregion
         
         void RefreshData() 
         { 
             if(this.DataEntity != null) 
             { 
                this.tbCustomerID.Text=this.m_DataEntity.CustomerID.ToString(); 
                this.tbName.Text=this.m_DataEntity.Name; 
                this.tbAddress.Text=this.m_DataEntity.Address; 
                this.tbMail.Text=this.m_DataEntity.Mail; 
                this.tbPhone.Text=this.m_DataEntity.Phone; 
                this.tbFax.Text=this.m_DataEntity.Fax; 
             } 
         } 
        
        bool ValidInput() 
        { 
            if ( this.tbCustomerID.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "CustomerID ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbCustomerID.Focus(); 
                return false; 
            } 
            if ( this.tbName.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "Name ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbName.Focus(); 
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
            if ( this.tbFax.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "传真 ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbFax.Focus(); 
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
                Customer dataEntity = null; 
 
                if (this.DataEntity == null) 
                { 
                    dataEntity = new Customer(); 
                } 
                else 
                { 
                    dataEntity = this.DataEntity; 
                } 
 
                //基本信息 
                dataEntity.CustomerID=this.tbCustomerID.Text!=""? Convert.ToInt32(this.tbCustomerID.Text) : 0; 
                dataEntity.Name=this.tbName.Text; 
                dataEntity.Address=this.tbAddress.Text; 
                dataEntity.Mail=this.tbMail.Text; 
                dataEntity.Phone=this.tbPhone.Text; 
                dataEntity.Fax=this.tbFax.Text; 
 
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
                MessageBox.Show(this, "在保存‘客户’数据的过程中发生了一个错误： " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
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
