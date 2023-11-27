using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book
    {
        public string Name { get; set; }
        public string Autor { get; set; }
        public byte[] Photo { get; set; }
        public double Price { get; set; }


        public static ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>()
        {
            new Book() {Name = "Чистый код", Autor = "Роберт Мартин", Price = 1200.00},
            new Book() {Name = "Hello World!", Autor = "У. Сэнд", Price = 1500.00},
            new Book() {Name = "Гарри Поттер", Autor = "Джоан Роулинг", Price = 1099.00}
        };
    }
}
