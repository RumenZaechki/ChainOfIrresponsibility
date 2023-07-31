namespace ChainOfIrresponsibility.Abstractions
{
    public interface ISuccessor<in TRequest>
    {
        Task HandleAsync(TRequest request, CancellationToken token = default);
    }
}
