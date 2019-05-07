using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.Entities;

namespace Northwind.BLL
{
    public interface ISaleService
    {
        void Sale(SaleOrder bill);
    }
}
