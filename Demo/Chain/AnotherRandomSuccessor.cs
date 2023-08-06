using ChainOfIrresponsibility.Abstractions;

namespace Demo.Chain
{
    public class AnotherRandomSuccessor : ISuccessor<RandomRequest>
    {
        public async Task HandleAsync(RandomRequest request, CancellationToken token = default)
        {
            Guid id = Guid.NewGuid();
            await Console.Out.WriteLineAsync($"AnotherRandomSuccessor - {id}");
        }
    }
}
