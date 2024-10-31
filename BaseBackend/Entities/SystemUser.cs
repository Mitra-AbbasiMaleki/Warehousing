#nullable disable
using BaseBackend.Entities.Interfaces;
using BaseBackend.Enums;
using System;
namespace BaseBackend.Entities
{
    public class SystemUser : Person, IBaseEntity
    {
        public decimal Salary { get; set; }       // حقوق
        public string UserName { get; private set; }  //نام کاربری
        //private string Password { get; private set; }  // رمزعبور
        private string Password
        {
            set
            {
                if (value.Length >= 5)
                {
                    Password = value; // ذخیره رمز عبور
                }
                else
                {
                    throw new Exception("رمز عبور باید حداقل 5 کاراکتر باشد.");
                }
            }
        }
        //کلاس سازنده کارمند
        public SystemUser(UserRole role,string userName,string password, string firstName, string lastName, string nationalCode, string phoneNumber, Address address)
            : base(role, firstName, lastName, nationalCode, phoneNumber, address)//فراخوانی سازنده کلاس پایه
        {
            UserName = userName;
            Password = password;
        }
        public SystemUser(UserRole role, string firstName, string lastName, string nationalCode, string phoneNumber, Address address,Address otherAddress=null)
            : base(role, firstName, lastName, nationalCode, phoneNumber, address,otherAddress)//فراخوانی سازنده کلاس پایه
        {
        }
        public SystemUser(UserRole role, string firstName, string lastName, string nationalCode)
            : base()//فراخوانی سازنده کلاس پایه
        {
        }

        // ویرایش اطلاعات تماس کاربر
        public new void UpdateContactInfo(string newPhoneNumber, string newEmail, Address newAddress)
        {
            PhoneNumber = newPhoneNumber;
            Addresses.Add(newAddress);
        }

        // به‌روزرسانی حقوق
        public void UpdateSalary(decimal newSalary)
        {
            Salary = newSalary;
        }
        // به‌روزرسانی موقعیت شغلی
        public void UpdateRole(UserRole newRole)
        {
            // newRoleبررسی معتبر بودن 
            if (Enum.IsDefined(typeof(UserRole), newRole))
                Role = newRole;
        }
        
    }

}
