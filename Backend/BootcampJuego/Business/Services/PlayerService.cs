using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces.Implements;
using Business.Repository;
using Data.Interfaces.Implements;
using Data.Interfaces.IRepository;
using Entity.Domain.Models.Implements;
using Entity.DTOs.Implements.Create;
using Entity.DTOs.Implements.Select;
using Mapster;
using MapsterMapper;

namespace Business.Services
{
    public class PlayerService : BusinesGeneric<PlayerCreateDto, PlayerSelectDto, Player>, IPlayerService
    {

        private readonly IPlayerRepository _playerRepository;
        public PlayerService(IData<Player> data, IMapper mapper, IPlayerRepository playerRepository) : base(data, mapper)
        {
            _playerRepository = playerRepository;
        }


        public override async Task<PlayerCreateDto> CreateAsync(PlayerCreateDto dto)
        {
            try
            {
                if (dto == null)
                {
                    throw new ArgumentNullException(nameof(dto));
                }

                var entity = dto.Adapt<Player>();
                var created = await _playerRepository.CreateAsync(entity);
                return created.Adapt<PlayerCreateDto>();

            }
            catch (Exception ex)
            {
                throw new Exception("error al crear", ex);
            }
        }

        public override async Task<IEnumerable<PlayerSelectDto>> GetAllAsync()
        {
            try
            {
                var entities = await _playerRepository.GetAllAsync();
                return entities.Adapt<IEnumerable<PlayerSelectDto>>();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar", ex);
            }
        }

        public async Task<int?> DeleteLogic(int id)
        {
            try
            {
                var rowsAffected = await _playerRepository.DeleteLogic(id);
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo desactivar player",ex);
            }
        }

        public async Task<IEnumerable<Player>> GetAllDeletes()
        {
            try
            {
                var entities = await _playerRepository.GetAllDeletes();
                return (IEnumerable<Player>)entities.Adapt<IEnumerable<PlayerSelectDto>>();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar", ex);
            }
        }

        public async Task<int?> RestoreLogic(int id)
        {
            try
            {
                var rowsAffected = await _playerRepository.RestoreLogic(id);
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo activar player", ex);
            }
        }
    }
}
