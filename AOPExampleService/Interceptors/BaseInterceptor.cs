using Castle.DynamicProxy;

namespace AOPExampleService.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public abstract class BaseInterceptor : Attribute, IInterceptor
    {
        public virtual void OnBefore(IInvocation invocation)
        {

        }

        public void Intercept(IInvocation invocation)
        {
            try
            {
                OnBefore(invocation);
                invocation.Proceed();
                OnAfter(invocation);
            }
            catch (Exception ex)
            {
                OnException(invocation, ex);
            }
        }

        public virtual void OnAfter(IInvocation invocation)
        {

        }

        public virtual void OnException(IInvocation invocation, Exception exception)
        {

        }
    }
}

