#nullable disable
using BaseBackend.Entities;
using BaseBackend.Enums;

namespace Warehousing.DTOs
{
   public sealed class AddPerson
    {
        public UserRole Role { get; set; }    //کد نقش 
        public string FirstName { get; set; }      // نام
        public string LastName { get; set; }       // نام خانوادگی
        public string NationalCode { get; set; }   //کد ملی
        public string PhoneNumber { get; set; }    // شماره تماس
        public Address Address { get; set; }  // آدرس
        public string CompanyName { get; set;} // نام شرکت
    }
}
