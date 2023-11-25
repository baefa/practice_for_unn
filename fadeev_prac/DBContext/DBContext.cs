using System;
using System.Data.Entity;
using fadeev_prac.Model;

namespace fadeev_prac.DBContext
{
    public class DBContext : DbContext
    {
        /// <summary>
        /// Конструктор DbContext
        /// </summary>
        /// <param name="options">Свойства контекста</param>
        public DBContext() : base("name=")
        {
        }
        
        /** Производители */
        public System.Data.Entity.DbSet<Producer> Producers { get; set; }
        
        /** Товары */
        public System.Data.Entity.DbSet<Product> Products { get; set; }
        
        /** Поступления товаров */
        public System.Data.Entity.DbSet<ReceiveProduct> RecieveProducts { get; set; }
        
        /** Поставщики */
        public System.Data.Entity.DbSet<Supplier> Suppliers { get; set; }
        
        /** Склады */
        public System.Data.Entity.DbSet<Warehouse> Warehouses { get; set; }
        
        /// <summary>
        /// Настройка свойств модели
        /// </summary>
    }
}