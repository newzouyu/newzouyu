﻿using Abp.Application.Services.Dto;

namespace MyAbpProject6.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

