using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using LibrarySystem.Api.Interfaces;
using LibrarySystem.Api.ViewModels;

namespace LibrarySystem.Api.Repositories
{
    public class AnswersService: IAnswersService
    {
        private readonly IHttpClientFactory _clientFactory;

        public AnswersService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<AnswersViewModel> GetAnswers()
        {

            var request = new HttpRequestMessage(HttpMethod.Get, "StackOveFlowClient");
            var client = _clientFactory.CreateClient("StackOveFlowClient");
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var answers = await response.Content.ReadFromJsonAsync<AnswersViewModel>();
                return answers;
            }
            else
            {
                return new AnswersViewModel();
            }


        }
    }
}
