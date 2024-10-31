using System;

namespace BaseBackend.Entities.Interfaces
{
    public interface ICreateableEntity
    {
        public DateTime CreatedAt { get; set; } //تاریخ ایجاد
        public int CreatedByUserId { get; set; } //شخص ایجاد کننده
    }

}
