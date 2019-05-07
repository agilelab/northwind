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
using EAS.Services;
using Northwind.BLL;

namespace Northwind.WinUI
{
    [Module("C8AD266B-637A-4570-9FE5-483904309175", "采购入库", "")]
    public partial class ProductInAddIn : UserControl
    {
        [ModuleStart]
        public void StartEx()
        {
            this.NewBill();
        }        

        public ProductInAddIn()
        {
            InitializeComponent();
            this.controlAutoFocus1.NextKeys = new Keys[] { Keys.Enter};
        }

        private void NewBill()
        {
            this.ClearInput();
            this.tbBillCode.Text = new InBill().GetMaxID().ToString("D8");
            this.inBillDetailBindingSource.DataSource = new List<InBillDetail>();
        }

        private void ClearInput()
        {
            this.tbName.Text = string.Empty;
            this.tbSpec.Text = string.Empty;
            this.tbUnit.Text = string.Empty;
            this.tbPrice.Text = string.Empty;
            this.tbNumber.Text = string.Empty;
        }

        private void textBoxAutoComplete1_InputComplete(object sender, EAS.Windows.UI.Controls.TextBoxInputEventAgrs e)
        {
            if (e.TextBox == this.tbName)
            {
                var v = e.TextBox.GetSelectedItem() as Product;
                this.tbSpec.Text = v.Spec;
                this.tbUnit.Text = v.Unit;
                this.tbPrice.Text = v.UnitPrice.ToString("F2");
                this.tbNumber.Focus();
            }
        }

        private void tbNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.tbNumber.Text.IsInteger())
                {
                    var number = this.tbNumber.Text.ToInt();
                    var p = this.tbName.GetSelectedItem() as Product;
                    if (p == null)
                        return;

                    List<InBillDetail> vList = this.inBillDetailBindingSource.DataSource as List<InBillDetail>;
                    InBillDetail item = new InBillDetail();
                    item.ID = item.GetMaxID();
                    item.ProductID = p.ProductID;
                    item.UnitPrice = p.UnitPrice;
                    item.Number = number;

                    this.inBillDetailBindingSource.SuspendBinding();

                    try
                    {
                        vList.Add(item);
                    }
                    finally
                    {
                        this.inBillDetailBindingSource.ResetBindings(false);
                        this.inBillDetailBindingSource.ResumeBinding();
                    }

                    this.ClearInput();
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //界面那些没有。

            //界面判定

            InBill bill = new InBill();
            bill.OrderID = this.tbBillCode.Text;
            bill.EmployeeID = LoginInfo.Employee.EmployeeID;

            List<InBillDetail> vList = this.inBillDetailBindingSource.DataSource as List<InBillDetail>;
            bill.Details = vList;

            //调用入库嗠

            var vService = ServiceContainer.GetService<IInService>();

            try
            {
                vService.ProductIn(bill);
            }
            catch(System.Exception exc)
            {
                MessageBox.Show("入库时出错：" + exc.Message);
                return;
            }

            this.NewBill();
            MessageBox.Show("入库OK" );

        }
    }
}
