using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInventoryRental
{
    public class Item
    {
        public string Name {  get; set; }
        public byte[] Photo { get; set; }
        public string Category { get; set; }
        public double PriceInHour { get; set; }


        public static ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>()
        {
            new Item() {Name="Коньки", Category="Каток", PriceInHour=100},
            new Item() {Name="Горные лыжи", Category="Снежный склон", PriceInHour=500},
            new Item() {Name="Клюшка", Category="Каток", PriceInHour=200}
        };

    }
}
