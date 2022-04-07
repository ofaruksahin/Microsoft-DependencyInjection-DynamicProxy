using Castle.DynamicProxy;

namespace AOPExampleService.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public abstract class BaseInterceptor : Attribute, IInterceptor
    {
        public virtual void Intercept(IInvocation invocation)
        {
            throw new NotImplementedException();
        }
    }
}

