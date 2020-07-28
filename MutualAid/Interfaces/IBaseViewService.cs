using MutualAid.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.Interfaces
{
    public interface IBaseViewService
    {
        Task<IEnumerable<DropdownViewModel>> GetDropdownViewModelsAsync();
    }
}
