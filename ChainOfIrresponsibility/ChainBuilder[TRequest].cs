using ChainOfIrresponsibility.Abstractions;

namespace ChainOfIrresponsibility
{
    public class ChainBuilder<TRequest>
    {
        private readonly List<ISuccessor<TRequest>> _successors = new();

        public ChainBuilder<TRequest> AddSuccessor<TSuccessor>() where TSuccessor : ISuccessor<TRequest>, new()
        {
            _successors.Add(new TSuccessor()); 
            return this;
        }

        public IChain<TRequest> BuildChain()
        {
            return new SimpleChain<TRequest>(_successors);
        }
    }
}
