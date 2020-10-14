using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleWebAPI.Data
{
    public class BaseDomain
    {
        public int Id { get; private set; }
        public DateTime CreatedDate { get; private set; }
        [MaxLength(256)]
        public string CreatedBy { get; private set; }
        public DateTime LastModifiedDate { get; private set; }
        [MaxLength(256)]
        public string LastModifiedBy { get; private set; }
        public bool IsDeleted { get; private set; }

        public void FlagForCreate(string user)
        {
            CreatedDate = DateTime.Now;
            CreatedBy = user;
            LastModifiedDate = DateTime.Now;
            LastModifiedBy = user;
        }

        public void FlagForUpdate(string user)
        {
            LastModifiedDate = DateTime.Now;
            LastModifiedBy = user;
        }

        public void FlagForDelete(string user)
        {
            LastModifiedDate = DateTime.Now;
            LastModifiedBy = user;
            IsDeleted = true;
        }
    }
}
