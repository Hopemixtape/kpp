using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReceiptContext : DbContext
    { 
        public ReceiptContext():base("ReceiptContext")
    { 
    }
        public DbSet<Receipt> Receipts { get; set; }
    }
}
