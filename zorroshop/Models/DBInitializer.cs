using System;
using System.Data.Entity;

namespace zorroshop.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<Zorro>
    {
        protected override void Seed(Zorro context)
        {
            context.customerModels.Add(new CustomerModel() { address = "Vice city", code = "6666 - 1666", discount = 66, name = "Su" });

            context.customerModels.Add(new CustomerModel() { address = "Novoselsk", code = "0001 - 1111", discount = 5, name = "Indy" });

            context.customerModels.Add(new CustomerModel() { address = "Vice city", code = "0002 - 2222", discount = 6, name = "Cheburek" });


            base.Seed(context);
        }
    }
}
