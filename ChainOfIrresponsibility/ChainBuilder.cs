namespace ChainOfIrresponsibility
{
    public static class ChainBuilder
    {
        public static ChainBuilder<TRequest> For<TRequest>()
        {
            return new ChainBuilder<TRequest>();
        }
    }
}
