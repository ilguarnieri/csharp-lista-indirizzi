using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    public class Address
    {
        public string Name { get; set; }
        public string Surname { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string Province { get; private set; }
        public string ZipCode { get; private set; }

        public Address(string name, string surname, string street, string city, string province, string zipCode)
        {
            this.Name = name;
            this.Surname = surname;
            this.Street = street;
            this.City = city;
            this.Province = province;
            this.ZipCode = zipCode;
        }


        public void ToString()
        {
            Console.WriteLine($"Nome: {this.Name}");
            Console.WriteLine($"Cognome: {this.Surname}");
            Console.WriteLine($"Via: {this.Street}");
            Console.WriteLine($"Città: {this.City}");
            Console.WriteLine($"Provincia: {this.Province}\t ZIP: {this.ZipCode}\n");
        }
    }
}
