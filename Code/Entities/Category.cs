using System;
using System.Data;
using EAS.Data;
using EAS.Data.Access;
using EAS.Data.ORM;

namespace Northwind.Entities
{
   /// <summary>
   /// 实体对象 Category(产品分类)。
   /// </summary>
   public partial class Category: DataEntity<Category>
   {
       public int GetMaxID()
       {
           ParameterCollection pc = new ParameterCollection();
           pc.Add("ITEMKEY", this.DbTableName);

           return (int)this.DataAccessor.Query("exec GetIdentityValue @itemkey=?", pc);
       }

       public override string ToString()
       {
        return this.CategoryName;
       }
   }
}
