using ChainOfIrresponsibility.Abstractions;

namespace Demo.Chain
{
    public class YetAnotherRandomHandler : ISuccessor<RandomRequest>
    {
        public async Task HandleAsync(RandomRequest request, CancellationToken token)
        {
            if (request.Id >= 20 && request.Id < 30)
            {
                Console.WriteLine("{0} handled request {1}",
                    this.GetType().Name, request.Id);
            }
        }
    }
}
