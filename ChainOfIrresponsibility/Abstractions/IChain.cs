namespace ChainOfIrresponsibility.Abstractions
{
    /// <summary>
    /// Represents the chain of responsibility
    /// </summary>
    /// <typeparam name="TRequest">The request the chain should handle</typeparam>
    public interface IChain<in TRequest>
    {
        /// <summary>
        /// Runs the chain, along with all its successors
        /// </summary>
        /// <param name="request">The request the chain handles</param>
        /// <param name="token">Cancellation token</param>
        /// <returns></returns>
        Task RunAsync(TRequest request, CancellationToken token = default);
    }
}
