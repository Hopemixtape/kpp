using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ReceiptInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ReceiptContext>
    {
        protected override void Seed(ReceiptContext context)
        {
            var receipts = new List<Receipt>
            {
            new Receipt{ Adress = "Kharkov", Date = DateTime.Now, Name = "Lysak Kolyan", Privilege = true, ScoreNumber = 1,
             ServiceName = "Remont", SnstrumentReadings = "A", SumPayment = 122}
            };
            receipts.ForEach(s => context.Receipts.Add(s));
            context.SaveChanges();
        }
    }
}
