using Abp.Domain.Entities.Auditing;
using MyAbpProject6.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpProject6.PhoneBooks.PhoneNumbers
{
    public class PhoneNumber : FullAuditedEntity
    {
        public string Number { get; set; }

        public PhoneType PhoneType { get; set; }

        public int PersonId { get; set; }

        public Person Person
        {
            get;set;
        }
        public DateTime CreationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
