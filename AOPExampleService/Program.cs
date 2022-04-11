using AOPExampleService;
using AOPExampleService.Interceptors;
using AOPExampleService.Services;
using AOPExampleService.Services.Interfaces;
using Castle.DynamicProxy;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddSingleton(new ProxyGenerator());
        services.AddTransient<IInterceptor, PerformanceInterceptor>();
        services.AddTransient<IInterceptor, LoggingInterceptor>();
        services.AddTransient<IInterceptor, ExceptionInterceptor>();
        services.AddProxiedTransient<IMessageService, MessageService>();
    })
    .Build();

await host.RunAsync();

