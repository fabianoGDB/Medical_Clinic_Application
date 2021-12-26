using Mc.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc.Manager.Interfaces
{
    public interface IClientManager
    {
        Task<IEnumerable<Client>> GetClientsAsync();
        Task<Client> GetClientAsync(int id);
    }
}
