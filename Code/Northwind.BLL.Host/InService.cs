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
    [ServiceBind(typeof(IInService))]
    public class InService : IInService
    {
        #region IInService 成员

        public void ProductIn(Entities.InBill bill)
        {
            using (DbEntities db = new DbEntities())
            {
                using (var t = db.CreateTransaction())
                {
                    bill.Total = bill.Details.Sum(p => p.UnitPrice * p.Number);
                    bill.InTime = EAS.Environment.NowTime;
                    bill.Insert();
                    foreach (var item in bill.Details)
                    {
                        item.OrderID = bill.OrderID;
                        item.Insert();

                        var v = db.Stocks.Where(p => p.ProductID == item.ProductID).FirstOrDefault();
                        if (v == null)
                        {
                            v = new Stock();
                            v.ProductID = item.ProductID;
                            v.UnitPrice = item.UnitPrice;
                            v.Number = item.Number;
                            v.InputCode = item.Product.InputCode;
                            v.Insert();
                        }
                        else
                        {
                            v.Number += item.Number;
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
