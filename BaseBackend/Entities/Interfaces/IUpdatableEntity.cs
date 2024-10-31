using System;
using System.Collections.Generic;
using System.Text;

namespace BaseBackend.Entities.Interfaces
{
    public interface IUpdatableEntity
    {
        public DateTime updatedAt { get; set; } //تاریخ بروزرسانی
        public int UpdatedByUserId { get; set; } // شخص بروزرسانی کننده
    }
}
