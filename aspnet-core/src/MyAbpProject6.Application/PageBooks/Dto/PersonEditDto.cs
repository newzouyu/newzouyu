﻿using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpProject6.PageBooks.Dto
{
    public class PersonEditDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public string EmailAddress { get; set; }
    }
}
