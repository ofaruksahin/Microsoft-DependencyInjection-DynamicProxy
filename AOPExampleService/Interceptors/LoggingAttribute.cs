using Castle.DynamicProxy;

namespace AOPExampleService.Interceptors
{
    public class LoggingInterceptor : BaseInterceptor
    {
        public override void Intercept(IInvocation invocation)
        {
            Console.WriteLine("On Method Before");
            invocation.Proceed();
            Console.WriteLine("On Method After");
        }
    }
}

