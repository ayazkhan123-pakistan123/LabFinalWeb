using LabFinalWeb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabFinalWeb.Models
{
    public class DataInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<DBContext>
    {
        public DataInitializer()
        {
            this.Seed(new DBContext());
        }
        protected override void Seed(DBContext context)
        {
            base.Seed(context);
            Tyres tyre = new Tyres() {
                TyresId = 1,
                Brand = "Dunlop",
                Country = "Pakistan",
                Size = 11,
                Condition = "new",
                Quantity = 33,
                PurchasePrice = 300,
                SellingPrice = 400
               
            };
            Sales sales = new Sales()
            {
                SalesId = 1,
                TyresId = 1,
                Quantity = 33,
                CustomerName = "Ayaz",
                TransactionDateTime = "12-12-12",
                CashRecieved = 12000
            };
            context.SaveChanges();
        }
    }
}