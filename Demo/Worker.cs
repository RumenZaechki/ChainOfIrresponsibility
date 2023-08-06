using ChainOfIrresponsibility.Abstractions;
using Demo.Chain;
using Microsoft.Extensions.Hosting;

namespace Demo
{
    public class Worker : BackgroundService
    {
        private readonly IChain<RandomRequest> _anotherChain;
        public Worker(IChain<RandomRequest> anotherChain)
        {
            _anotherChain = anotherChain;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await _anotherChain.RunAsync(new RandomRequest());
        }
    }
}
