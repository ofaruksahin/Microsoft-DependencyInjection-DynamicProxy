using Castle.DynamicProxy;

namespace AOPExampleService
{
    public static class ServiceExtensions
    {
        public static void AddProxiedTransient<TInterface, TImplementation>(this IServiceCollection services)
            where TInterface : class
            where TImplementation : class, TInterface
        {
            services.AddTransient<TImplementation>();
            services.AddTransient(typeof(TInterface), serviceProvider =>
             {
                 var proxyGenerator = serviceProvider.GetRequiredService<ProxyGenerator>();
                 var actual = serviceProvider.GetRequiredService<TImplementation>();
                 var interceptors = serviceProvider.GetServices<IInterceptor>().ToArray();
                 return proxyGenerator.CreateInterfaceProxyWithTarget(typeof(TInterface), actual, interceptors);
             });
        }
    }
}

