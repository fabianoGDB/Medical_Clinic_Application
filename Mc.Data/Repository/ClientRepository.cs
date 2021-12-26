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

        // metodo para retorno de clientes
        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
            return await context.Clients.AsNoTracking().ToListAsync();
        }
        public async Task<Client> GetClientAsync(int id)
        {
            return await context.Clients.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
