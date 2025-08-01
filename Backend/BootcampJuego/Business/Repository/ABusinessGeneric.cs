using Business.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public abstract class ABusinessGeneric<TDto, TSelect> : IBusinessGeneric<TDto, TSelect>
    {
        public abstract Task<TDto> CreateAsync(TDto dto);
        public abstract Task<bool> DeleteAsync(int id);
        public abstract Task<IEnumerable<TSelect>> GetAllAsync();
        public abstract Task<TSelect?> GetByIdAsync(int id);
        public abstract Task<bool> UpdateAsync(TDto dto);
    }
}
