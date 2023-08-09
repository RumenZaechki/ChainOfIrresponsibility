namespace ChainOfIrresponsibility.Abstractions
{
    /// <summary>
    /// Represents a successor, a unit in the chain of responsibility
    /// </summary>
    /// <typeparam name="TRequest">The request the successor handles</typeparam>
    public interface ISuccessor<in TRequest>
    {
        /// <summary>
        /// Represents the handling of the given request by the given successor
        /// </summary>
        /// <param name="request">The request the successor handles</param>
        /// <param name="token">Cancellation token</param>
        /// <returns></returns>
        Task HandleAsync(TRequest request, CancellationToken token = default);
    }
}
