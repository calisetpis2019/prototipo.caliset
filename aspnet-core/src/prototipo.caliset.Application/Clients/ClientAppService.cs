using Abp.Application.Services;
using prototipo.caliset.Clients.Dto;
using prototipo.caliset.Models.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipo.caliset.Clients
{
    public class ClientAppService : ApplicationService, IClientAppService
    {

        private readonly IClientManager _clientManager;
        public ClientAppService(IClientManager clientManager)
        {
            _clientManager = clientManager;
        }


        public async Task Create(CreateClientInput input)
        {
            var client = ObjectMapper.Map<Client>(input);
            await _clientManager.Create(client);
        }

        public void Delete(DeleteClientInput input)
        {
            _clientManager.Delete(input.Id);
        }

        public IEnumerable<GetClientOutput> GetAll()
        {
            var getAll = _clientManager.GetAll().ToList();
            List<GetClientOutput> output = ObjectMapper.Map<List<GetClientOutput>>(getAll);
            return output;
        }

        public GetClientOutput GetClientById(GetClientInput input)
        {
            var getClient = _clientManager.GetClientById(input.Id);
            GetClientOutput output = ObjectMapper.Map<GetClientOutput>(getClient);
            return output;
        }

        public void Update(UpdateClientInput input)
        {
            var client = _clientManager.GetClientById(input.Id);
            _clientManager.Update(client);
        }
    }
}
