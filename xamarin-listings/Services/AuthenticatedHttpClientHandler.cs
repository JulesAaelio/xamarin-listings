using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace xamarin-listings.Services
{
    public class AuthenticatedHttpClientHandler: HttpClientHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var auth = request.Headers.Authorization;
            if (auth != null)
            {
                if (SettingsService.TokenAPI != null)
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue(auth.Scheme, SettingsService.TokenAPI);

                }
            }
            
            return base.SendAsync(request, cancellationToken);
        }
    }
}