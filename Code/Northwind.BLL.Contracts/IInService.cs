using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.Entities;

namespace Northwind.BLL
{
    public interface IInService
    {
        void ProductIn(InBill bill);
    }
}
