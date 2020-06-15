using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services;
using static Api.Domain.Dtos.UserFileDto;

namespace Api.Service.Services
{
    public class UserService : IUserService
    {
        private IRepository<UserEntity> _repository;

        public UserService(IRepository<UserEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UserEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<UserEntity> Post(UserEntity user)
        {
            return await _repository.InsertAsync(user);
        }

        public async Task<UserEntity> Put(UserEntity user)
        {
            return await _repository.UpdateAsync(user);
        }

        public IEnumerable<UserFileDTO> ImportFile()
        {
            var userList = File.ReadAllLines(@"C:\Users\marce\Desktop\Cadastro.csv")
                .Select(a => a.Split(';'))
                .Select(c => new UserFileDTO()
                {
                    Name = c[0],
                    Email = c[1],
                    Birthday = Convert.ToDateTime(c[2]),
                    Gender = c[3]
                }).ToList();

            return userList;
        }
    }
}
