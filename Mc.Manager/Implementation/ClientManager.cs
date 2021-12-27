using Mc.Core.Domain;
using Mc.Manager.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mc.Manager.Implementation
{
    public class ClientManager : IClientManager
    {
        private readonly IClientRepository clientRepository;
        public ClientManager(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
            return await clientRepository.GetClientsAsync();
        }
      

        public async Task<Client> InsertClientAsync(Client client)
        {
            return await clientRepository.InsertClientAsync(client);
        }

        public async Task<Client> UpdateClientAsync(Client client)
        {
            return await clientRepository.UpdateClientAsync(client);
        }
        public async Task<Client> GetClientAsync(int id)
        {
            return await clientRepository.GetClientAsync(id);
        }
        public async Task DeleteClientAsync(int id)
        {
            await clientRepository.DeletClientAsync(id);
        }
    }
}