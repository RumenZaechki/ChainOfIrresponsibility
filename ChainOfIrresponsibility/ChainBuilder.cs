namespace ChainOfIrresponsibility
{
    /// <summary>
    /// Allows building chains on demand
    /// </summary>
    public static class ChainBuilder
    {
        public static ChainBuilder<TRequest> For<TRequest>()
        {
            return new ChainBuilder<TRequest>();
        }
    }
}
