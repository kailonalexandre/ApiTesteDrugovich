using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Models;
using Bogus;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<IEnumerable<UserEntity>> PostRandomUsers()
        {
            var userFake = new Faker<UserEntity>("pt_BR")
                .RuleFor(c => c.Name, f => f.Name.FullName())
                .RuleFor(c => c.Email, f => f.Internet.Email())
                .RuleFor(c => c.Level, f => (RoleLevel)f.PickRandom(new int[] {1, 2}))
                .RuleFor(c => c.CreatedAt, f => f.Date.Recent(100))
                .RuleFor(c => c.UpdateAt, f => f.Date.Recent(100));
            var users = userFake.Generate(10);

            foreach (var user in users)
            {
                await _repository.InsertAsync(user);
            }
            return users;
        }
    }


}
