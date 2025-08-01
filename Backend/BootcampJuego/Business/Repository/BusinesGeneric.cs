using Data.Interfaces.IRepository;
using Entity.Domain.Models.Base;
using Mapster;
using MapsterMapper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Business.Repository
{
    public class BusinesGeneric<TDto, TSelect, TEntity> : ABusinessGeneric<TDto, TSelect> where TEntity : BaseModel
    {
        protected readonly IData<TEntity> _data;
        protected readonly IMapper _mapper;
        public BusinesGeneric(IData<TEntity> data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }
        public override async Task<IEnumerable<TSelect>> GetAllAsync()
        {
            try
            {
                var entities = await _data.GetAllAsync();
                //return _mapper.Map<IEnumerable<TSelect>>(entities);
                return entities.Adapt<IEnumerable<TSelect>>();
            } catch (Exception ex) 
            {
                throw new Exception("Error al listar", ex);
            }
        }
        public override async Task<TSelect?> GetByIdAsync(int id)
        {
            try
            {
                var entity = await _data.GetByIdAsync(id);
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }

                //return _mapper.Map<TSelect>(entity);
                return entity.Adapt<TSelect>();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar por id", ex);
            }
        }
        public override async Task<TDto> CreateAsync(TDto dto)
        {
            try
            {
                if (dto == null) 
                { 
                    throw new ArgumentNullException(nameof(dto));
                }

                var entity = dto.Adapt<TEntity>();
                var created = await _data.CreateAsync(entity);
                return created.Adapt<TDto>();

            }
            catch(Exception ex) 
            {
                throw new Exception("error al crear", ex);
            }
        }
        public override async Task<bool> UpdateAsync(TDto dto)
        {
            try
            {
                if (dto == null)
                {
                    throw new ArgumentNullException(nameof(dto));
                }
                var entity = dto.Adapt<TEntity>();

                bool updated = await _data.UpdateAsync(entity);
                if (updated!)
                {
                    throw new Exception("No se logro actualizar");
                }
                return updated;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar", ex);
            }
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            try
            {
                bool delete = await _data.DeleteAsync(id);
                if (delete!)
                {
                    throw new Exception("No se logro actualizar");
                }
                return delete;

            }
            catch (Exception ex) 
            {
                throw new Exception("Error al eliminar", ex);
            }
        }



    }
}
