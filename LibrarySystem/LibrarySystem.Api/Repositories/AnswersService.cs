using System.Net.Http;
using LibrarySystem.Api.Interfaces;

namespace LibrarySystem.Api.Repositories
{
    public class AnswersService: IAnswersService
    {
        private readonly IHttpClientFactory _clientFactory;

        public AnswersService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

    }
}
