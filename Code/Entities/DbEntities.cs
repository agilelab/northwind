using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EAS.Data;
using EAS.Data.Access;
using EAS.Data.ORM;
using EAS.Data.Linq;

namespace Northwind.Entities
{
   /// <summary>
   /// 数据上下文。
   /// </summary>
   public class DbEntities:DataContext
   {
        #region 字段定义

        private DataEntityQuery<Category> m_Categorys;
        private DataEntityQuery<Product> m_Products;
        private DataEntityQuery<Stock> m_Stocks;
        private DataEntityQuery<InBill> m_InBills;
        private DataEntityQuery<InBillDetail> m_InBillDetails;
        private DataEntityQuery<Employee> m_Employees;
        private DataEntityQuery<Customer> m_Customers;
        private DataEntityQuery<SaleOrder> m_SaleOrders;
        private DataEntityQuery<SaleOrderDetail> m_SaleOrderDetails;
        #endregion

        #region 构造函数

        /// <summary>
        /// 初始化DbEntities对象实例。
        /// </summary>
        public DbEntities()
        {
        }

        /// <summary>
        /// 初始化DbEntities对象实例。
        /// </summary>
        /// <param name="dbProvider">数据库访问程序提供者。</param>
        public DbEntities(IDbProvider dbProvider)
            : base(dbProvider)
        {

        }

        /// <summary>
        /// 初始化DbEntities对象实例。
        /// </summary>
        /// <param name="dataAccessor">数据访问器。</param>
        public DbEntities(IDataAccessor dataAccessor)
            : base(dataAccessor)
        {

        }

        /// <summary>
        /// 初始化DbEntities对象实例。
        /// </summary>
        /// <param name="dataAccessor">数据访问器。</param>
        /// <param name="ormAccessor">Orm访问器。</param>
        public DbEntities(IDataAccessor dataAccessor, IOrmAccessor ormAccessor)
            : base(dataAccessor, ormAccessor)
        {

        }

        #endregion

        #region 查询定义

        /// <summary>
        /// 产品分类。
        /// </summary>
        public DataEntityQuery<Category> Categorys
        {
            get
            {
                if (this.m_Categorys == null)
                {
                    this.m_Categorys = base.CreateQuery<Category>();
                }
                return this.m_Categorys;
            }
        }

        /// <summary>
        /// 产品字典。
        /// </summary>
        public DataEntityQuery<Product> Products
        {
            get
            {
                if (this.m_Products == null)
                {
                    this.m_Products = base.CreateQuery<Product>();
                }
                return this.m_Products;
            }
        }

        /// <summary>
        /// 产品库存。
        /// </summary>
        public DataEntityQuery<Stock> Stocks
        {
            get
            {
                if (this.m_Stocks == null)
                {
                    this.m_Stocks = base.CreateQuery<Stock>();
                }
                return this.m_Stocks;
            }
        }

        /// <summary>
        /// 入库单据。
        /// </summary>
        public DataEntityQuery<InBill> InBills
        {
            get
            {
                if (this.m_InBills == null)
                {
                    this.m_InBills = base.CreateQuery<InBill>();
                }
                return this.m_InBills;
            }
        }

        /// <summary>
        /// 入库单据明细。
        /// </summary>
        public DataEntityQuery<InBillDetail> InBillDetails
        {
            get
            {
                if (this.m_InBillDetails == null)
                {
                    this.m_InBillDetails = base.CreateQuery<InBillDetail>();
                }
                return this.m_InBillDetails;
            }
        }

        /// <summary>
        /// 员工。
        /// </summary>
        public DataEntityQuery<Employee> Employees
        {
            get
            {
                if (this.m_Employees == null)
                {
                    this.m_Employees = base.CreateQuery<Employee>();
                }
                return this.m_Employees;
            }
        }

        /// <summary>
        /// 客户。
        /// </summary>
        public DataEntityQuery<Customer> Customers
        {
            get
            {
                if (this.m_Customers == null)
                {
                    this.m_Customers = base.CreateQuery<Customer>();
                }
                return this.m_Customers;
            }
        }

        /// <summary>
        /// 销售订单。
        /// </summary>
        public DataEntityQuery<SaleOrder> SaleOrders
        {
            get
            {
                if (this.m_SaleOrders == null)
                {
                    this.m_SaleOrders = base.CreateQuery<SaleOrder>();
                }
                return this.m_SaleOrders;
            }
        }

        /// <summary>
        /// 销售订单明细。
        /// </summary>
        public DataEntityQuery<SaleOrderDetail> SaleOrderDetails
        {
            get
            {
                if (this.m_SaleOrderDetails == null)
                {
                    this.m_SaleOrderDetails = base.CreateQuery<SaleOrderDetail>();
                }
                return this.m_SaleOrderDetails;
            }
        }


        #endregion

   }
}
