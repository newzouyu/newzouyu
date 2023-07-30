using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyAbpProject6.PageBooks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpProject6.PageBooks
{
    /// <summary>
    /// 用户相关操作
    /// </summary>
    public interface IPersonAppService:IApplicationService
    {
        /// <summary>
        /// 分页获取用户信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<PersonListDto>> GetPagePersonAsync(GetPersonInput input);

        /// <summary>
        /// 根据ID获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<PersonListDto> GetPersonByIdAsync(NullableIdDto i);

        /// <summary>
        /// 新增或者更改联系人信息
        /// </summary>
        /// <returns></returns>
        Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input);

        /// <summary>
        /// 删除联系人信息
        /// </summary>
        /// <returns></returns>
        Task DeletePersonAsync(EntityDto info);

    }
}
