using Api.Domain.Dtos;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Client;
using Api.Domain.Models;
using Api.Domain.Repository;
using AutoMapper;
using Domain.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Service.Services
{
    public class ClientService : IClientService
    {
        private IClientRepository _repository;
        private IUserService _userService;
        private readonly IMapper _mapper;
        public ClientService(IClientRepository repository, IUserService userService, IMapper mapper)
        {
            _repository = repository;
            _userService = userService;
            _mapper = mapper;
        }

        private async Task<bool> ValidateUser(string token, RoleLevel access)
        {
            var userId = _repository.GetUserIDFromToken(token);
            var user = await _userService.Get(userId);

            if (user == null)
                return false;
            if (user.Level == access)
                return true;

            return false;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ClientEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<ClientEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<ClientEntity> Post(ClientInsertDto user)
        {
            var userModel = _mapper.Map<ClientModel>(user);
            var userEntity = _mapper.Map<ClientEntity>(userModel);
            if (userEntity == null)
                return null;
            return await _repository.InsertAsync(userEntity);
        }

        public async Task<ClientEntity> Put(ClientEntity user, string token)
        {
            if (!await ValidateUser(token, RoleLevel.Two))
                return null;
            return await _repository.UpdateAsync(user);
        }

        public async Task<ClientEntity> UpsertGroup(Guid id, Guid groupId)
        {
            var user = await _repository.SelectAsync(id);
            if (user == null)
                return null;
            user.GroupId = groupId;
            return await _repository.UpdateAsync(user);
        }
        public async Task<ClientEntity> RemoveAsync(Guid id)
        {
            var user = await _repository.SelectAsync(id);
            if (user == null)
                return null;
            user.GroupId = null;
            return await _repository.UpdateAsync(user);

        }
        public async Task<IEnumerable<ClientEntity>> GetGroupClient(Guid idGroup)
        {
            if (idGroup == Guid.Empty)
                return null;
            return await _repository.GetAllByGroup(idGroup);
        }
    }
}
