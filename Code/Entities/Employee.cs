using System;
using System.Data;
using EAS.Data;
using EAS.Data.Access;
using EAS.Data.ORM;

namespace Northwind.Entities
{
   /// <summary>
   /// 实体对象 Employee(员工)。
   /// </summary>
   public partial class Employee: DataEntity<Employee>
   {
       public int GetMaxID()
       {
           ParameterCollection pc = new ParameterCollection();
           pc.Add("ITEMKEY", this.DbTableName);

           return (int)this.DataAccessor.Query("exec GetIdentityValue @itemkey=?", pc);
       }

       public override string ToString()
       {
           return this.Name;
       }
   }
}
