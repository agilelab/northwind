using System;
using System.Data;
using EAS.Data;
using EAS.Data.Access;
using EAS.Data.ORM;

namespace Northwind.Entities
{
   /// <summary>
   /// 实体对象 InBill(入库单据)。
   /// </summary>
   public partial class InBill: DataEntity<InBill>
   {
       public int GetMaxID()
       {
           ParameterCollection pc = new ParameterCollection();
           pc.Add("ITEMKEY", this.DbTableName);

           return (int)this.DataAccessor.Query("exec GetIdentityValue @itemkey=?", pc);
       }
   }
}
