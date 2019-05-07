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
    [Module("A4421229-72B4-4B33-8DBC-9026F5AB2282", "销售业务", "")]
    public partial class SaleAddIn : UserControl
    {
        [ModuleStart]
        public void StartEx()
        {
            this.NewBill();
        }

        public SaleAddIn()
        {
            InitializeComponent();
            this.controlAutoFocus1.NextKeys = new Keys[] { Keys.Enter};
        }

        private void NewBill()
        {
            this.ClearInput();
            this.tbBillCode.Text = new SaleOrder().GetMaxID().ToString("D8");
            this.tbCustomer.SetSelectedItem(null);
            this.tbAddress.Text = string.Empty;
            this.tbFax.Text = string.Empty;
            this.tbTel.Text = string.Empty;
            this.tbMail.Text = string.Empty;

            this.saleOrderDetailBindingSource.DataSource = new List<SaleOrderDetail>();
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
            if (e.TextBox == this.tbCustomer)
            {
                var v = e.TextBox.GetSelectedItem() as Customer;
                this.tbAddress.Text = v.Address;
                this.tbFax.Text = v.Fax;
                this.tbTel.Text = v.Phone;
                this.tbMail.Text = v.Mail;
                this.tbName.Focus();
            }
            else if (e.TextBox == this.tbName)
            {
                var v = e.TextBox.GetSelectedItem() as Stock;
                this.tbSpec.Text = v.Product.Spec;
                this.tbUnit.Text = v.Product.Unit;
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
                    var p = this.tbName.GetSelectedItem() as Stock;
                    if (p == null)
                        return;

                    List<SaleOrderDetail> vList = this.saleOrderDetailBindingSource.DataSource as List<SaleOrderDetail>;
                    SaleOrderDetail item = new SaleOrderDetail();
                    item.ID = item.GetMaxID();
                    item.ProductID = p.ProductID;
                    item.UnitPrice = p.UnitPrice;
                    item.Number = number;

                    this.saleOrderDetailBindingSource.SuspendBinding();

                    try
                    {
                        vList.Add(item);
                    }
                    finally
                    {
                        this.saleOrderDetailBindingSource.ResetBindings(false);
                        this.saleOrderDetailBindingSource.ResumeBinding();
                    }

                    this.ClearInput();
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //界面那些没有。

            //界面判定

            SaleOrder bill = new SaleOrder();
            bill.OrderID = this.tbBillCode.Text;
            bill.EmployeeID = LoginInfo.Employee.EmployeeID;

            var v = this.tbCustomer.GetSelectedItem() as Customer;
            bill.CustomerID = v.CustomerID;

            List<SaleOrderDetail> vList = this.saleOrderDetailBindingSource.DataSource as List<SaleOrderDetail>;
            bill.Details = vList;

            //调用入库嗠

            var vService = ServiceContainer.GetService<ISaleService>();

            try
            {
                vService.Sale(bill);
            }
            catch(System.Exception exc)
            {
                MessageBox.Show("销售时出错：" + exc.Message);
                return;
            }

            this.NewBill();
            MessageBox.Show("销售OK" );

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
