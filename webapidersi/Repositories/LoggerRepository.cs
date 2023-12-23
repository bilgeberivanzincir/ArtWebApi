
using NLog;
using webapidersi.Interfaces;


namespace webapidersi.Repositories
{
	public class LoggerRepository : ILoggerService
	{
		private static NLog.ILogger logger = LogManager.GetCurrentClassLogger();

		public void LogDebug(string message, Exception exception) => logger.Debug(message);


		public void LogError(string message)=> logger.Error(message);


		public void LogInfo(string message) => logger.Info(message);

		public void LogWarning(string message)=> logger.Warn(message);
	}
}
