using ChainOfIrresponsibility.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace ChainOfIrresponsibility
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers the specified <see cref="IChain{TRequest}"/>
        /// </summary>
        /// <typeparam name="TRequest">The request the chain handles</typeparam>
        /// <param name="services">the service collection</param>
        /// <returns>the chain configuration</returns>
        public static Configuration<TRequest> IncludeChain<TRequest>(this IServiceCollection services)
        {
            SuccessorRegistry<TRequest> registry = new ();
            services.AddSingleton<IChain<TRequest>>(s => new Chain<TRequest>(s, registry));
            return new Configuration<TRequest>(services, registry);
        }
    }
}
