using System;
using System.Collections.Generic;
using System.Text;

namespace BaseBackend.Entities.Interfaces
{
    public interface IDeleteableEntity
    {
        public bool IsDeleted { get; set; } //خذف شده
        public DateTime DeletedAt { get; set; } //تاریخ حذف
        public int DeletedByUserId { get; set; } //شخص حذف کننده
    }
}
