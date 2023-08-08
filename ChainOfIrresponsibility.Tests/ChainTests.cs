using ChainOfIrresponsibility.Tests.TestChain;
using FluentAssertions;

namespace ChainOfIrresponsibility.Tests
{
    public class ChainTests
    {
        private TestRequest _request = new TestRequest();
        [Fact]
        public async void Chain_Calls_Successors_In_Correct_Order()
        {
            ChainBuilder<TestRequest> builder = ChainBuilder.For<TestRequest>()
                                                            .AddSuccessor<TestSuccessor>()
                                                            .AddSuccessor<AnotherTestSuccessor>();
            var chain = builder.BuildChain();

            await chain.RunAsync(_request);

            _request.Logs.Should().HaveElementAt(0, "logging from TestSuccessor");
            _request.Logs.Should().HaveElementAt(1, "logging from AnotherTestSuccessor");
        }
    }
}