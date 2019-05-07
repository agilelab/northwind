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
using EAS;

namespace Northwind.WinUI 
{ 
     /// <summary> 
     /// 产品字典。 
     /// </summary> 
     public partial class ProductEditor : Form 
     { 
         public ProductEditor() 
         { 
             InitializeComponent(); 
         } 
         
         #region  DataEntity
         
         public Product DataEntity 
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

         Product m_DataEntity; 
         
         #endregion
         
         void RefreshData() 
         { 
             if(this.DataEntity != null) 
             { 
                this.tbProductID.Text=this.m_DataEntity.ProductID.ToString(); 
                this.tbProductName.Text=this.m_DataEntity.ProductName; 
                this.tbCategoryID.Text=this.m_DataEntity.CategoryID.ToString(); 
                this.tbSpec.Text=this.m_DataEntity.Spec; 
                this.tbUnit.Text=this.m_DataEntity.Unit; 
                this.tbUnitPrice.Text=this.m_DataEntity.UnitPrice.ToString(); 
                this.tbInputCode.Text=this.m_DataEntity.InputCode;
             } 
         }

         protected override void OnLoad(EventArgs e)
         {
             if (this.DataEntity == null)
             {
                 this.tbProductID.Text = new Product().GetMaxID().ToString();
             }
         }
        
        bool ValidInput() 
        { 
            if ( this.tbProductID.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "产品ID ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbProductID.Focus(); 
                return false; 
            } 
            if ( this.tbProductName.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "产品名称 ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbProductName.Focus(); 
                return false; 
            } 
            if ( this.tbCategoryID.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "产品种类ID ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbCategoryID.Focus(); 
                return false; 
            } 
            if ( this.tbSpec.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "规格 ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbSpec.Focus(); 
                return false; 
            } 
            if ( this.tbUnit.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "单位 ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbUnit.Focus(); 
                return false; 
            } 
            if ( this.tbUnitPrice.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "价格 ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbUnitPrice.Focus(); 
                return false; 
            } 
            if ( this.tbInputCode.Text==string.Empty ) 
            { 
                MessageBox.Show(this, "输入码 ： 必填项,不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.tbInputCode.Focus(); 
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
                Product dataEntity = null; 
 
                if (this.DataEntity == null) 
                { 
                    dataEntity = new Product(); 
                } 
                else 
                { 
                    dataEntity = this.DataEntity; 
                } 
 
                //基本信息 
                dataEntity.ProductID=this.tbProductID.Text!=""? Convert.ToInt32(this.tbProductID.Text) : 0; 
                dataEntity.ProductName=this.tbProductName.Text;
                dataEntity.CategoryID = (this.tbCategoryID.GetSelectedItem() as Category).CategoryID;
                dataEntity.Spec=this.tbSpec.Text; 
                dataEntity.Unit=this.tbUnit.Text; 
                dataEntity.UnitPrice=this.tbUnitPrice.Text!=""? Convert.ToDecimal(this.tbUnitPrice.Text) : 0; 
                dataEntity.InputCode=this.tbInputCode.Text;
                dataEntity.LMTime = EAS.Environment.NowTime; 
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
                MessageBox.Show(this, "在保存‘产品字典’数据的过程中发生了一个错误： " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
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

        private void tbProductName_TextChanged(object sender, EventArgs e)
        {
            tbInputCode.Text = tbProductName.Text.ToPinYin();
        } 
        
   } 
} 
