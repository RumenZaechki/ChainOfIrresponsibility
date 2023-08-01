using ChainOfIrresponsibility.Abstractions;

namespace ChainOfIrresponsibility
{
    public class Chain<TRequest> : IChain<TRequest>
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IEnumerable<Type> _successorTypes;

        public Chain(IServiceProvider serviceProvider, IEnumerable<Type> successorTypes)
        {
            _serviceProvider = serviceProvider;
            _successorTypes = successorTypes;
        }

        public async Task RunAsync(TRequest request, CancellationToken token = default)
        {
            foreach (var successorType in _successorTypes)
            {
                var successor = _serviceProvider.GetService(successorType) as ISuccessor<TRequest>;
                if (successor == null)
                {
                    throw new ArgumentNullException($"successor of type '{successorType}' is not registered,");
                }
                await successor.HandleAsync(request, token);
            }
        }
    }
}
