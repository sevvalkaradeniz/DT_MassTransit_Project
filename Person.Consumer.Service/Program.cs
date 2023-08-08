using Data_Access.Repository.Base;
using Data_Access.Repository;
using MassTransit;
using Person.Consumer.Service;
using Person.Consumer.Service.Consumers;
using Person.Model;
using Person.Application.Service;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddScoped<IPersonService, PersonService>();
        

        services.AddMassTransit(x =>
        {
            x.AddConsumer<PersonAddedCommandConsumer>();
            x.AddConsumer<PersonDeletedCommandConsumer>();
            x.AddConsumer<PersonUpdatedCommandConsumer>();  

            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.ReceiveEndpoint(RabbitMQSettings.PersonAddedCommandSendQueueName, e =>
                {
                    e.ConfigureConsumer<PersonAddedCommandConsumer>(context);
                });
                cfg.ReceiveEndpoint(RabbitMQSettings.PersonDeletedCommandQueueName, e =>
                {
                    e.ConfigureConsumer<PersonDeletedCommandConsumer>(context);
                });
                cfg.ReceiveEndpoint(RabbitMQSettings.PersonUpdatedCommandQueueName, e =>
                {
                    e.ConfigureConsumer<PersonUpdatedCommandConsumer>(context);
                });
                var ConnectionString = new Uri("amqps://idlijwgn:0_2qi3Q3S2-SxmN-p4ph-8Di6BuPqM0D@sparrow.rmq.cloudamqp.com/idlijwgn");
                cfg.Host(ConnectionString);
             
            });
        });
        
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
