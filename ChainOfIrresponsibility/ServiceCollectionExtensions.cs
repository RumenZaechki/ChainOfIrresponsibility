using Microsoft.Extensions.DependencyInjection;

namespace ChainOfIrresponsibility
{
    public static class ServiceCollectionExtensions
    {
        public static Configuration<TRequest> IncludeChain<TRequest>(this IServiceCollection services)
        {
            return null;
        }
    }
}
