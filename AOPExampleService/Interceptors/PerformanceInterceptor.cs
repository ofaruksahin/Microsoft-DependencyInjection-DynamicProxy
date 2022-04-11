using System.Diagnostics;
using Castle.DynamicProxy;

namespace AOPExampleService.Interceptors
{
    public class PerformanceInterceptor : BaseInterceptor
    {
        Stopwatch stopWatch;

        public PerformanceInterceptor()
        {
            stopWatch = new Stopwatch();
        }

        public override void OnBefore(IInvocation invocation)
        {
            stopWatch.Start();
        }

        public override void OnAfter(IInvocation invocation)
        {
            stopWatch.Stop();
            Console.WriteLine($"Elapsed: {stopWatch.ElapsedMilliseconds} ms");
        }
    }
}

