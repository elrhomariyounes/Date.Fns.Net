using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Markdig;

namespace BlazorServer.Data
{
    public class HomeService
    {
        private readonly HttpClient _httpClient;
        private readonly NavigationManager _navigationManager;

        public HomeService(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
            _httpClient.BaseAddress = new Uri(_navigationManager.BaseUri);
        }

        public async Task<string> GetReadMeAsStringAsync()
        {
            var markDownAsString = await _httpClient.GetStringAsync("README.MD");
            return Markdown.ToHtml(markDownAsString);
        }
    }
}
