using ChainOfIrresponsibility.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace ChainOfIrresponsibility
{
    public class Configuration<TRequest>
    {
        private readonly IServiceCollection _services;
        private readonly SuccessorRegistry<TRequest> _successorsRegistry;

        public Configuration(IServiceCollection services, SuccessorRegistry<TRequest> successorsRegistry)
        {
            _services = services;
            _successorsRegistry = successorsRegistry;
        }

        public Configuration<TRequest> AddSuccessor<TSuccessor>() where TSuccessor : ISuccessor<TRequest>
        {
            _successorsRegistry.Add<TSuccessor>();
            _services.AddTransient(typeof(TSuccessor));
            return this;
        }
    }
}
