using AOPExampleService.Interceptors;
using AOPExampleService.Services.Interfaces;

namespace AOPExampleService.Services
{
    public class MessageService : IMessageService
    {
        [PerformanceInterceptor]
        [LoggingInterceptor]
        public void Send(string message)
        {
            Console.WriteLine(message);
            Thread.Sleep(1250);
        }
    }
}

