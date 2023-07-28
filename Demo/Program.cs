using ChainOfIrresponsibility;
using Demo.Chain;
using Microsoft.Extensions.Hosting;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.IncludeChain<RandomRequest>()
                            .WithHandler<RandomHandler>()
                            .WithHandler<AnotherRandomHandler>()
                            .WithHandler<YetAnotherRandomHandler>();
                });
    }
}