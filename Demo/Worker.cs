using ChainOfIrresponsibility.Abstractions;
using Demo.Chain;
using Microsoft.Extensions.Hosting;
using System.Xml;

namespace Demo
{
    public class Worker : BackgroundService
    {
        private readonly IChain<RandomRequest> _chain;
        public Worker(IChain<RandomRequest> chain)
        {
            _chain = chain;
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            RandomRequest[] requests = new RandomRequest[]
            {
                new RandomRequest (2),
                new RandomRequest (5),
                new RandomRequest (14),
                new RandomRequest (22),
                new RandomRequest (18),
                new RandomRequest (3),
                new RandomRequest (27),
                new RandomRequest (20)
            };

            foreach (RandomRequest request in requests)
            {
                _chain.RunAsync(request);
                Console.WriteLine("---------------------------------------------------------");
            }
            return Task.CompletedTask;
        }
    }
}
