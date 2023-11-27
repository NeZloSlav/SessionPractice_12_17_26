using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorCellularNetwork
{
    public class Tariff
    {
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }


        public static ObservableCollection<Tariff> tariffs = new ObservableCollection<Tariff>()
        {
            new Tariff() {Name = "Эгосит", Description = "40 ГБ интернета + 100 мин. общения только для Вас.", Price=399.00},
            new Tariff() {Name = "Семейный", Description = "Безлимитный интернет + 400 мин. общения для всех близких.", Price=1099.00},
            new Tariff() {Name = "На двоих", Description = "80 ГБ интернета + 200 мин. общения для Вас и Вашей любимки.", Price=699.00}
        };


    }
}
