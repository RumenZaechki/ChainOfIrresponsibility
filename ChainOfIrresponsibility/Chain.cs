using ChainOfIrresponsibility.Abstractions;

namespace ChainOfIrresponsibility
{
    public class Chain<TRequest> : IChain<TRequest>
    {
        private readonly IEnumerable<ISuccessor<TRequest>> _successors;
        public Chain(IEnumerable<ISuccessor<TRequest>> successors)
        {
            _successors = successors;
        }
        public async Task RunAsync(TRequest request, CancellationToken token = default)
        {
            foreach (var successor in _successors)
            {
                await successor.HandleAsync(request, token);
            }
        }
    }
}
