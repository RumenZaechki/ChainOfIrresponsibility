using ChainOfIrresponsibility.Abstractions;
using Demo.Chain;
using Demo.Chain2;
using Microsoft.Extensions.Hosting;
using System.Xml;

namespace Demo
{
    public class Worker : BackgroundService
    {
        //private readonly IChain<RandomRequest> _chain;
        private readonly IChain<AnotherRandomRequest> _anotherChain;
        public Worker(/*IChain<RandomRequest> chain, */IChain<AnotherRandomRequest> anotherChain)
        {
            //_chain = chain;
            _anotherChain = anotherChain;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await _anotherChain.RunAsync(new AnotherRandomRequest());
            //RandomRequest[] requests = new RandomRequest[]
            //{
            //    new RandomRequest (2),
            //    new RandomRequest (5),
            //    new RandomRequest (14),
            //    new RandomRequest (22),
            //    new RandomRequest (18),
            //    new RandomRequest (3),
            //    new RandomRequest (27),
            //    new RandomRequest (20)
            //};

            //foreach (RandomRequest request in requests)
            //{
            //    await _chain.RunAsync(request);
            //    Console.WriteLine("---------------------------------------------------------");
            //}
        }
    }
}
