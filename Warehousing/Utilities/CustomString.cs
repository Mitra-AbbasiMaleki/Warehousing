#nullable disable
using BaseBackend.Entities;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Warehousing.Utilities
{
    public static class CustomString
    {
        /// <summary>
        /// Check MobileNumber Format
        /// </summary>
        /// <param name="phoneNumber">phoneNumber from ..</param>
        /// <returns>return clean phoneNumber</returns>
        public static string CleanPhoneNumber(this string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return string.Empty;

            phoneNumber = phoneNumber.Trim().Replace("+98", "0").Replace("0098", "0");
            phoneNumber = phoneNumber.Length == 10 ? "0" + phoneNumber : phoneNumber;
            if (phoneNumber.Length == 10 && phoneNumber.StartsWith("0"))
            {
                return string.Empty;
            }
            return phoneNumber;
        }

        /// <summary>
        /// clean string
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Return Correct string</returns>
        public static string CleanName(this string name)
        {
            //تمامی حروف رشته را به حروف کوچک تبدیل میکند
            return name.Trim().ToLower();
        }


        /// <summary>
        /// Convert String To DateTime 
        /// </summary>
        /// <param name="expirationDate"></param>
        /// <returns>Date Time Format</returns>
        public static DateTime ToExpirationDate(this string expirationDate)
        {
            string format = "dd/mm/yyyy";
            // تلاش برای تبدیل رشته به فرمت تاریخ
            if (DateTime.TryParseExact(expirationDate, format, null, System.Globalization.DateTimeStyles.None, out DateTime expDate))
            {
                // اگر تبدیل موفق بود، تاریخ را بازگرداند
                return expDate;
            }
            else
            {
                // اگر تبدیل موفق نبود، null برگرداند
                return new DateTime();
            }
        }

        /// <summary>
        /// convert address to string
        /// </summary>
        /// <param name="address"></param>
        /// <returns> string form of address</returns>
        public static string ToAddress(this Address address)
        {
            return address.Province + "-" + address.City + "-" + address.Street + "-" + address.Number;
        }
    }
}
