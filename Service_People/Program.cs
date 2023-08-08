using MassTransit;
using Microsoft.Extensions.Hosting;
using Service_Person.Consumers;
using Shared;
using System.Transactions;
using static MassTransit.MessageHeaders;

public class Program
{

    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
            .ConfigureServices((host, ser) =>
            {

            });


}

