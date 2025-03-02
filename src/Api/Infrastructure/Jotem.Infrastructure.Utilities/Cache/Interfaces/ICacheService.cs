using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotem.Infrastructure.Utilities.Cache.Interfaces
{
    public interface ICacheService
    {
        Task SetAsync(string key, string value, TimeSpan? expiresIn = null);

        Task<string?> GetAsync(string key);

        Task RemoveAsync(string key);

    }
}
