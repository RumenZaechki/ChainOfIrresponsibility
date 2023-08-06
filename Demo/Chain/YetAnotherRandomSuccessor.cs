using ChainOfIrresponsibility.Abstractions;

namespace Demo.Chain
{
    public class YetAnotherRandomSuccessor : ISuccessor<RandomRequest>
    {
        public async Task HandleAsync(RandomRequest request, CancellationToken token = default)
        {
            Guid id = Guid.NewGuid();
            await Console.Out.WriteLineAsync($"YetAnotherRandomSuccessor - {id}");
        }
    }
}
