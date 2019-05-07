using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Data.Linq;
using EAS.Data.ORM;
using Northwind.Entities;
using EAS.Services;

namespace Northwind.BLL
{
    [ServiceBind(typeof(ISaleService))]
    public class SaleService : ISaleService
    {
        #region IInService 成员

        public void Sale(SaleOrder bill)
        {
            using (DbEntities db = new DbEntities())
            {
                using (var t = db.CreateTransaction())
                {
                    //bill.Total = bill.Details.Sum(p => p.UnitPrice * p.Number);
                    bill.SaleTime = EAS.Environment.NowTime;
                    bill.Insert();
                    foreach (var item in bill.Details)
                    {
                        item.OrderID = bill.OrderID;
                        item.Insert();

                        var v = db.Stocks.Where(p => p.ProductID == item.ProductID).FirstOrDefault();
                        if (v == null)
                        {
                            throw new System.Exception(string.Format("{0}库存异常", item.Product.ProductName));
                        }
                        else
                        {
                            v.Number -= item.Number;
                            v.Update();
                        }
                    }
                    t.Commit();
                }
            }
        }

        #endregion
    }
}
