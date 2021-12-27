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
        Task<Client> InsertClientAsync(Client client);
        Task<Client> UpdateClientAsync(Client client);
        Task<Client> GetClientAsync(int id);
        Task DeleteClientAsync(int id);
    }
}
