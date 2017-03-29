
using ProductModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    public class ProductDC:DbContext
    {
        public ProductDC() : base("name=default")
        {
        }

        public ProductDC(string cs)
            : base(cs)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //禁用表的复数形式
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        /// <summary>
        /// 商品
        /// </summary>
        public DbSet<Goods> Goods { get; set; }


    }
}
