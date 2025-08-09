
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR;


namespace MyFarmWeb.Repository
{
    public class ServerTimeNotifier : BackgroundService
    {

        NavigationManager nv;
        private static readonly TimeSpan period = TimeSpan.FromSeconds(5);
        private readonly ILogger<ServerTimeNotifier> _logger;
        //private readonly IHubContext<NotificationHub, INotificationClient> _context;

        //public ServerTimeNotifier(ILogger<ServerTimeNotifier> logger, IHubContext<NotificationHub, INotificationClient> context)
        //{
        //    _logger = logger;
        //    _context = context;
           
        //}

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using var Timer = new PeriodicTimer(period);
            while (!stoppingToken.IsCancellationRequested && await Timer.WaitForNextTickAsync(stoppingToken))
            {
                var datetime = DateTime.Now;
                _logger.LogInformation("Excuting {Service} {Time}", nameof(ServerTimeNotifier), datetime);
                //await _context.Clients.All.ReceiveNotification($"Server Time {datetime} hello mohamed alhady{random()} ");

            }
        }

        int random()
        {
            Random random = new Random();
           var i = random.Next();
            return i;
        }
    }
}
