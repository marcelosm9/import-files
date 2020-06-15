using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Dtos;
using static Api.Domain.Dtos.UserFileDto;

namespace Api.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<UserEntity> Get(Guid id);
        Task<IEnumerable<UserEntity>> GetAll();
        Task<UserEntity> Post(UserEntity user);
        IEnumerable<UserFileDTO> ImportFile();
        Task<UserEntity> Put(UserEntity user);
        Task<bool> Delete(Guid id);
    }
}
