using Mc.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mc.Manager.Interfaces
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetClientsAsync();
        Task<Client> GetClientAsync(int id);
        Task<Client> InsertClientAsync(Client client);
        Task DeletClientAsync(int id);
        Task<Client> UpdateClientAsync(Client client);
    }
}
