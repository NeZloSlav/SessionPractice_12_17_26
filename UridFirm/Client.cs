using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UridFirm
{
    public class Client
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public byte[] Photo { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }


        public static ObservableCollection<Client> Clients { get; set;} = new ObservableCollection<Client>()
        {
            new Client() {LastName = "Петров", FirstName = "Пётр", MiddleName = "Петрович", Age = 20, Phone = "+7(932)123-74-64"},
            new Client() {LastName = "Сидоров", FirstName = "Сидр", MiddleName = "Сидорович", Age = 40, Phone = "+7(123)432-62-82"},
            new Client() {LastName = "Иванов", FirstName = "Иван", MiddleName = "Иванович", Age = 30, Phone = "+7(032)234-75-00"}
        };

    }
}
