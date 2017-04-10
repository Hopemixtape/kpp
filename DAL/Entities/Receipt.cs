using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Receipt
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int ScoreNumber { get; set; }
        public string ServiceName { get; set; }
        public bool Privilege { get; set; }
        public string SnstrumentReadings { get; set; }
        public double SumPayment { get; set; }

    }
}
//a.заголовок сторінки;
//b.дата оплати;
//c.прізвище та ініціали платника;
//d.адреса платника;
//e.номер особового рахунку;
//f.найменування послуги;
//g.наявність пільги;
//h.показання приладів обліку;
//i.сума оплати.