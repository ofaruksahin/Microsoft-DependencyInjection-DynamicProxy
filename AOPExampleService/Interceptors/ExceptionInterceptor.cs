using Castle.DynamicProxy;

namespace AOPExampleService.Interceptors
{
    public class ExceptionInterceptor : BaseInterceptor
    {
        public override void OnException(IInvocation invocation, Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}

