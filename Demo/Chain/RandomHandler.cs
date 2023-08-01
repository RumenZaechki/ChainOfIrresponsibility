using ChainOfIrresponsibility.Abstractions;

namespace Demo.Chain
{
    public class RandomHandler : ISuccessor<RandomRequest>
    {
        public async Task HandleAsync(RandomRequest request, CancellationToken token)
        {
            if (request.Id >= 0 && request.Id < 10)
            {
                Console.WriteLine("{0} handled request {1}",
                    this.GetType().Name, request.Id);
            }
        }
    }
}
