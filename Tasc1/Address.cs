using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Address
    {   //поля
        private string country, city, street, house;
        private int index, apartment;
        //Свойства
        public string Country
        {
            set { this.country = value; }
            get { return country; }
        }
        public string City
        {
            set { this.city = value; }
            get { return city; }
        }
        public string Street
        {
            set { this.street = value; }
            get { return street; }
        }
        public string House
        {
            set { this.house = value; }
            get { return house; }
        }
        public int Index
        {
            set { this.index = value; }
            get { return index; }
        }
        public int Apartment
        {
            set { this.apartment = value; }
            get { return apartment; }
        }              
      
    }
}
