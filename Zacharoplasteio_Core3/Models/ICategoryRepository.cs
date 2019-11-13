using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zacharoplasteio_Core3.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
