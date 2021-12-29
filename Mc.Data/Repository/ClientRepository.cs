using Mc.Core.Domain;
using Mc.Data.Context;
using Mc.Manager.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc.Data.Repository
{
    // resposavel pelo acesso aos dados
    public class ClientRepository : IClientRepository
    {
        // uso de injestao de dependecia para inversao de controles
        // (atribuir a criacao pelo construtor ao csharp por meio de uma abstracao)

        private readonly MCContext context;
        public ClientRepository(MCContext context)
        {
            this.context = context;
        }

        // SELECT
        // metodo para retorno de clientes
        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
            return await context.Clients.AsNoTracking().ToListAsync();
        }
        public async Task<Client> GetClientAsync(int id)
        {
            return await context.Clients.FindAsync(id);
        }
        
        
        // INSERT
        public async Task<Client> InsertClientAsync(Client client)
        {
            await context.Clients.AddAsync(client);
            await context.SaveChangesAsync();
            return client;
        }

        public async Task DeletClientAsync(int id)
        {
            var clientExistis = await context.Clients.FindAsync(id);
            if(clientExistis != null)
            {
                context.Clients.Remove(clientExistis);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Client> UpdateClientAsync(Client client)
        {
            var clientExistis = await context.Clients.FindAsync(client.Id);
            if (clientExistis == null)
            {
                return null;
            }
            //clientExistis.Name = client.Name;
            //clientExistis.BirthDate = client.BirthDate;

            context.Entry(clientExistis).CurrentValues.SetValues(client);
            context.Clients.Update(clientExistis);
            await context.SaveChangesAsync();
            return clientExistis;
        }
    }
}
