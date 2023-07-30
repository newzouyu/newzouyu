using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using MyAbpProject6.PageBooks.Dto;
using MyAbpProject6.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpProject6.PageBooks
{
    /// <summary>
    /// 联系人服务类
    /// </summary>
    public class PersonAppService : MyAbpProject6AppServiceBase, IPersonAppService
    {
        private readonly IRepository<Person> _personRepository;
        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }
        /// <summary>
        /// 新增或修改联系人信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input)
        {
            if (input.PersonEditDto.Id.HasValue)
            {
               await UpdatePersonAsync(input.PersonEditDto);
            }
            else
            {
                await CreatePersonAsync(input.PersonEditDto);
            }
        }

        /// <summary>
        /// 根据ID获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeletePersonAsync(EntityDto info)
        {
            var person = await _personRepository.GetAsync(info.Id);
            if (person == null)
            {
                throw new UserFriendlyException("该联系人不存在");
            }
            await _personRepository.DeleteAsync(info.MapTo<Person>());
        }

        /// <summary>
        /// 分页获取用户信息
        /// </summary>
        /// <returns></returns>
        public async Task<PagedResultDto<PersonListDto>> GetPagePersonAsync(GetPersonInput input)
        {
            var query=_personRepository.GetAll();
            var personCount = await _personRepository.CountAsync();
            var persons = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();
            var list = persons.MapTo<List<PersonListDto>>();
            return new PagedResultDto<PersonListDto>(personCount, list);            
        }

        /// <summary>
        /// 删除联系人信息
        /// </summary>
        /// <returns></returns>
        public async Task<PersonListDto> GetPersonByIdAsync(NullableIdDto i)
        {
            int id = i.Id.Value;
            var person =await _personRepository.GetAsync(id);
            var dto = person.MapTo<PersonListDto>();
            return dto;
        }

        public async Task UpdatePersonAsync(PersonEditDto dto)
        {
            var person = await _personRepository.FirstOrDefaultAsync(dto.Id.Value);
            person = dto.MapTo<Person>();
            await _personRepository.UpdateAsync(person);
        }

        public async Task CreatePersonAsync(PersonEditDto dto)
        {
            var person = dto.MapTo<Person>();
            await _personRepository.InsertAsync(person);
        }
    }
}
