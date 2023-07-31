using ChainOfIrresponsibility.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace ChainOfIrresponsibility
{
    public static class ServiceCollectionExtensions
    {
        public static Configuration<TRequest> IncludeChain<TRequest>(this IServiceCollection services)
        {
            IEnumerable<ISuccessor<TRequest>> successors = new List<ISuccessor<TRequest>>();
            SuccessorRegistry<TRequest> registry = new ();
            services.AddSingleton<IChain<TRequest>>(s => new Chain<TRequest>(successors));
            return new Configuration<TRequest>(services, registry);
        }
    }
}
