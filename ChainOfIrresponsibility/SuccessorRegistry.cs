using ChainOfIrresponsibility.Abstractions;
using System.Collections;

namespace ChainOfIrresponsibility
{
    public class SuccessorRegistry<TRequest> : IEnumerable<Type>
    {
        private readonly HashSet<Type> _successors = new ();

        public IEnumerator<Type> GetEnumerator() =>_successors.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Add<TSuccessor>() where TSuccessor : ISuccessor<TRequest> 
        {
            _successors.Add(typeof(TSuccessor));
        }
    }
}
