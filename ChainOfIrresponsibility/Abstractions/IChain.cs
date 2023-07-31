namespace ChainOfIrresponsibility.Abstractions
{
    public interface IChain<in TRequest>
    {
        Task RunAsync(TRequest request, CancellationToken token = default);
    }
}
