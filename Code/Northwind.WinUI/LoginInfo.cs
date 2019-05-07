using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.Entities;
using EAS.Explorer.Entities;
using EAS;
using EAS.Data.ORM;

namespace Northwind.WinUI
{
    class LoginInfo
    {
        public static Account Account
        {
            get
            {
                return EAS.Application.Instance.Session.Client as Account;
            }
        }

        private static Entities.Employee m_Employee;
        public static Employee Employee
        {
            get
            {
                if(m_Employee ==null)
                {
                    m_Employee = new Employee();
                }
                
                if(m_Employee.EmployeeID !=Account.OriginalID.ToInt())
                {
                    m_Employee.EmployeeID = Account.OriginalID.ToInt();
                    m_Employee.Read();
                }
                return m_Employee;
            }
        }
    }
}
