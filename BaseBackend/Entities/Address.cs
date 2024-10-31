using BaseBackend.Entities.Interfaces;
using BaseBackend.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseBackend.Entities
{
    public class Address : IBaseEntity
    {
        int nextid = 0;
        public int Id { get; set; }                    // شناسه آدرس
        public AddressTitle Name { get; set; }                  //عنوان محل آدرس
        public int PersonId { get; set; }              // شناسه شخص
        public string PostalCode { get; set; }         // کد پستی
        public string Province { get; set; }           // استان
        public string City { get; set; }               // شهر 
        public string Street { get; set; }             // خیابان
        public string Number { get; set; }             // پلاک 
       
        //سازنده کلاس
        public Address()
        {
            Id = nextid;
            nextid++;
        }
        public Address(AddressTitle name,string city, string street):this()
        {
            Name = name;
            City = city;
            Street = street;
        }
        public Address(AddressTitle name,string province,string city,string street,string number):this(name,city,street)
        {
            Province = province;
            Number = number;
        }
        public string ShortAddress
        {
            get
            {
               return City + "-" + Street;
            }
        }
    }
}
