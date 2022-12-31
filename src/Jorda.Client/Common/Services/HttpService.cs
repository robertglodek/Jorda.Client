using Microsoft.AspNetCore.Components;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using Blazored.LocalStorage;
using Jorda.Client.Common.Services;
using Jorda.Client.Common.Constants;
using Jorda.Client.Common.Exceptions;

namespace Jorda.Client.Services
{
    public class HttpService: IHttpService
    {
        private HttpClient _httpClient;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;

        public HttpService(HttpClient httpClient, NavigationManager navigationManager, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task<T> Get<T>(string uri)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            return await SendRequest<T>(request);
        }

        public Task<T> Post<T>(string uri, object value)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, uri);
            request.Content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            return SendRequest<T>(request);
        }

        public Task<T> Put<T>(string uri, object value)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, uri);
            request.Content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            return SendRequest<T>(request);
        }

        public Task Put(string uri, object value)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, uri);
            request.Content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            return SendRequest(request);
        }

        public Task Delete(string uri)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, uri);
            return SendRequest<int>(request);
        }

        private async Task<T> SendRequest<T>(HttpRequestMessage request)
        {
            var token = await _localStorageService.GetItemAsync<string>(StorageConstants.AuthToken);

            var isApiUrl = request.RequestUri!.IsAbsoluteUri;
            if (token != null && isApiUrl)
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            var response = await _httpClient.SendAsync(request);

            // throw exception on error response
            if (!response.IsSuccessStatusCode)
            {
                ServerError error = (await response.Content.ReadFromJsonAsync<ServerError>())!;
                DetermineActionWhenError(error);
            }

            var result = await response.Content.ReadFromJsonAsync<Reponse<T>>();
            return result!.Data!;
        }

        private async Task SendRequest(HttpRequestMessage request)
        {
            var token = await _localStorageService.GetItemAsync<string>("token");

            var isApiUrl = request.RequestUri!.IsAbsoluteUri;
            if (token != null && isApiUrl)
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Basic", token);
            }

            var response = await _httpClient.SendAsync(request);

            // throw exception on error response
            if (!response.IsSuccessStatusCode)
            {
                ServerError error = (await response.Content.ReadFromJsonAsync<ServerError>())!;
                DetermineActionWhenError(error);
            }
        }

        public void DetermineActionWhenError(ServerError error)
        {
            switch (error!.Title)
            {

                case ErrorResponseTypeConstants.Forbidden:
                    _navigationManager.NavigateTo("/forbidden");
                    break;
                case ErrorResponseTypeConstants.InternalServerError:
                    _navigationManager.NavigateTo("/error");
                    break;
                case ErrorResponseTypeConstants.Unauthorized:
                    _navigationManager.NavigateTo("/login");
                    break;
                case ErrorResponseTypeConstants.NotFound:
                    _navigationManager.NavigateTo("/notFound");
                    break;
                case ErrorResponseTypeConstants.InvalidModelState:
                    _navigationManager.NavigateTo("/error");
                    break;
                case ErrorResponseTypeConstants.Limitation:
                    throw new LimitationException(error.Details!);
                case ErrorResponseTypeConstants.UnsupportedColor:
                    throw new UnsupportedColourException();
                case ErrorResponseTypeConstants.ValidationIssues:
                    throw new ValidationException(error.Errors!);
                case ErrorResponseTypeConstants.IdentityError:
                    throw new IdentityErrorException(error.FailureMessages!);
                case ErrorResponseTypeConstants.SmtpError:
                    _navigationManager.NavigateTo("/error");
                    break;
                default:
                    _navigationManager.NavigateTo("/error");
                    break;

            }
        }

        
    }
}
