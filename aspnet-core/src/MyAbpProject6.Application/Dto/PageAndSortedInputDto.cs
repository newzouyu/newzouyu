using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpProject6.Dto
{
    public class PageAndSortedInputDto : IPagedResultRequest,ISortedResultRequest
    {
        [Range(0, 500)]
        public int SkipCount { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        [Range(0,int.MaxValue)]
        public int MaxResultCount { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }

      
        public string Sorting { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
}
