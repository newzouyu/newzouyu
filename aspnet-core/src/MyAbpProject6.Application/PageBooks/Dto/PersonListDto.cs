using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using MyAbpProject6.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpProject6.PageBooks.Dto
{
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto: FullAuditedEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string EmailAddress { get; set; }
    }
}
