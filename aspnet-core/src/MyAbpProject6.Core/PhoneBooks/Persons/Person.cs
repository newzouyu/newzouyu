using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpProject6.PhoneBooks.Persons
{
    public class Person:FullAuditedEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [EmailAddress]
        [MaxLength(80)]
        public string Address { get; set; }

        [MaxLength(200)]
        public string EmailAddress { get; set; }
    }
}
