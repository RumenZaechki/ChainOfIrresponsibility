using ChainOfIrresponsibility.Abstractions;

namespace Demo.Chain2
{
    public class AnotherRandomSuccessor : ISuccessor<AnotherRandomRequest>
    {
        public async Task HandleAsync(AnotherRandomRequest request, CancellationToken token = default)
        {
            Guid id = Guid.NewGuid();
            await Console.Out.WriteLineAsync($"AnotherRandomSuccessor - {id}");
        }
    }
}
