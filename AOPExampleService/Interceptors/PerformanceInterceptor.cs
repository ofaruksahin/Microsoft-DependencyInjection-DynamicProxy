using System.Diagnostics;
using Castle.DynamicProxy;

namespace AOPExampleService.Interceptors
{
    public class PerformanceInterceptor : BaseInterceptor
    {
        public override void Intercept(IInvocation invocation)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            invocation.Proceed();
            stopwatch.Stop();
            Console.WriteLine($"Elapsed: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}

