using MutualAid.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Application.Interfaces
{
    public interface IBaseService
    {
        Task<IEnumerable<DropdownDto>> GetDropdownDtosAsync();
    }
}
