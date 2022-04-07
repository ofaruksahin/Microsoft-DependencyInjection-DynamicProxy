using AOPExampleService.Services.Interfaces;

namespace AOPExampleService;

public class Worker : BackgroundService
{
    private readonly IMessageService _messageService;

    public Worker(IMessageService messageService)
    {
        _messageService = messageService ?? throw new ArgumentNullException(nameof(messageService));
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _messageService.Send("Hello World");
    }
}

