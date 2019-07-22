using System;
using System.Data.Entity;


namespace zorroshop.Models
{
    public class Zorro : DbContext
    {
        public DbSet <CustomerModel> customerModels { get; set; }

        public DbSet <ItemModel> itemModels { get; set; }

        public DbSet <OrderElemModel> orderElemModels { get; set; }

        public DbSet <OrderModel> orderModels { get; set; }


    }
}
