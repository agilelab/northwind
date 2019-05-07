using System;
using System.Data;
using EAS.Data;
using EAS.Data.Access;
using EAS.Data.ORM;

namespace Northwind.Entities
{
   /// <summary>
   /// 实体对象 Stock(产品库存)。
   /// </summary>
   public partial class Stock: DataEntity<Stock>
   {
       public int GetMaxID()
       {
           ParameterCollection pc = new ParameterCollection();
           pc.Add("ITEMKEY", this.DbTableName);

           return (int)this.DataAccessor.Query("exec GetIdentityValue @itemkey=?", pc);
       }

       /// <summary>
       /// 产品名称 。
       /// </summary>
       [Column("ProductName", "产品名称"), Virtual]
       public string ProductName
       {
           get
           {
               return this.Product.ProductName;
           }
           set
           {

           }
       }
   }
}
