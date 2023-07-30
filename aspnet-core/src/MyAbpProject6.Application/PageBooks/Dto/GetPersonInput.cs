using Abp;
using Abp.Runtime.Validation;
using MyAbpProject6.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpProject6.PageBooks.Dto
{
    public class GetPersonInput : PageAndSortedInputDto, IShouldNormalize
    {
        public string FilterText { get; set; }
        public void Normalize()
        {
            if(string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
}
