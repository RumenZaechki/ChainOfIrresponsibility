using ChainOfIrresponsibility;
using ChainOfIrresponsibility.Abstractions;
using Demo.Chain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Demo
{
    public class Program
    {
        private static readonly IServiceScopeFactory _scopeFactory;
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services
                            .AddHostedService<Worker>()
                            .IncludeChain<RandomRequest>()
                            .AddSuccessor<RandomHandler>()
                            .AddSuccessor<AnotherRandomHandler>()
                            .AddSuccessor<YetAnotherRandomHandler>();
                });
    }
}