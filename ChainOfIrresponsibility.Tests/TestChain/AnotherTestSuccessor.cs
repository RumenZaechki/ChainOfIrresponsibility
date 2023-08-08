using ChainOfIrresponsibility.Abstractions;

namespace ChainOfIrresponsibility.Tests.TestChain
{
    public class AnotherTestSuccessor : ISuccessor<TestRequest>
    {
        public async Task HandleAsync(TestRequest request, CancellationToken token = default)
        {
            request.Logs.Add("logging from AnotherTestSuccessor");
        }
    }
}
