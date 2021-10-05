using Microsoft.Extensions.DependencyInjection;
using QueOndas_APP.Data.Servicios;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace QueOndas_APP.Config
{
    public static class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection services, string urlBase)
        {
            services.AddRefitClient<ILlamadasData>().ConfigureHttpClient(c =>
            {
                c.BaseAddress = new Uri(uriString: urlBase);
            }).ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, sslErrors) => true
            });

            services.AddRefitClient<IChatsData>().ConfigureHttpClient(c =>
            {
                c.BaseAddress = new Uri(uriString: urlBase);
            }).ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, sslErrors) => true
            });

            services.AddRefitClient<IEstadosData>().ConfigureHttpClient(c =>
            {
                c.BaseAddress = new Uri(uriString: urlBase);
            }).ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, sslErrors) => true
            });
        }
    }
}
