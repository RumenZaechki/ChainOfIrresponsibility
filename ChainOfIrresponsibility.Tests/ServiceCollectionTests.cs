using ChainOfIrresponsibility.Abstractions;
using ChainOfIrresponsibility.Tests.TestChain;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace ChainOfIrresponsibility.Tests
{
    public class ServiceCollectionTests
    {
        [Fact]
        public void IncludeChain_Should_Add_Correct_Services()
        {
            IServiceCollection services = new ServiceCollection();

            services.IncludeChain<TestRequest>()
                    .AddSuccessor<TestSuccessor>()
                    .AddSuccessor<AnotherTestSuccessor>();

            services.Should()
                    .ContainSingle(d => d.ServiceType == typeof(IChain<TestRequest>));

            services.Where(d => d.ServiceType.IsAssignableTo(typeof(ISuccessor<TestRequest>)))
                    .Should()
                    .HaveCount(2)
                    .And
                    .OnlyContain(d => d.Lifetime == ServiceLifetime.Transient);

            services.Should().ContainSingle(d => d.ImplementationType == typeof(TestSuccessor));
            services.Should().ContainSingle(d => d.ImplementationType == typeof(AnotherTestSuccessor));
        }
    }
}
