using ChainOfIrresponsibility.Abstractions;

namespace Demo.Chain
{
    public class AnotherRandomHandler : ISuccessor<RandomRequest>
    {
        public Task HandleAsync(RandomRequest request, CancellationToken token)
        {
            if (request.Id >= 10 && request.Id < 20)
            {
                Console.WriteLine("{0} handled request {1}",
                    this.GetType().Name, request.Id);
            }
            return Task.CompletedTask;
        }
    }
}
