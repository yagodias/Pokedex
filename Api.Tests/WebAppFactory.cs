using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;

namespace Api.Tests
{
    internal class WebAppFactory : WebApplicationFactory<Program>
    {
        private readonly string _enviroment;
        public WebAppFactory(string enviroment = "Development")
        {
            _enviroment = enviroment;
        }

        protected override IHost CreateHost(IHostBuilder builder)
        {
            builder.UseEnvironment(_enviroment);
            return base.CreateHost(builder);
        }
    }
}
