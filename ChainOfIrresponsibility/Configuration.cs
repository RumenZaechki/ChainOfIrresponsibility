using Microsoft.Extensions.DependencyInjection;

namespace ChainOfIrresponsibility
{
    public class Configuration<TRequest>
    {
        private readonly IServiceCollection _services;

        public Configuration(IServiceCollection services)
        {
            _services = services;
        }

        public Configuration<TRequest> WithHandler<THandler>()
        {
            return null;
        }
    }
}
