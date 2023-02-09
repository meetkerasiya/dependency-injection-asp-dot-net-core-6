namespace ServiceLifetimeDemonstration
{
	public class DisposableService : IDisposable ,IAsyncDisposable
	{
		private readonly ILogger<DisposableService> _logger;

		public DisposableService(ILogger<DisposableService> logger)
		{
			_logger = logger;
		}
		public void Dispose()
		{
			_logger.LogInformation("DISPOSING SERVICE");
		}

		public ValueTask DisposeAsync()
		{
			_logger.LogInformation("DISPOSING SERVICE (Async)");
			return ValueTask.CompletedTask;
		}
	}
}
