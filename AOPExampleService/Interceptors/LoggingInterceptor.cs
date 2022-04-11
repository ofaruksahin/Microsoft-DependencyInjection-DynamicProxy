using Castle.DynamicProxy;

namespace AOPExampleService.Interceptors
{
    public class LoggingInterceptor : BaseInterceptor
    {
        public override void OnBefore(IInvocation invocation)
        {
            Console.WriteLine("On Method Before");
        }

        public override void OnAfter(IInvocation invocation)
        {
            Console.WriteLine("On Method After");
        }
    }
}

