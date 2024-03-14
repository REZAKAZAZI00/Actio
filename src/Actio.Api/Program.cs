using Actio.Api.Handlers;
using Actio.Common.Events;
using Actio.Common.RabbitMq;
using Actio.Common.Services;
using Microsoft.AspNetCore.Hosting;


 


var builder = WebApplication.CreateBuilder(args);
ServiceHost.Create<StartupBase>(args)
    .UseRabbitMq().SubscribeToEvent<ActivitiyCreated>()
    .Build();

builder.Services.AddRabbitMq(builder.Configuration);
builder.Services.AddScoped<IEventHandler<ActivitiyCreated>,ActivitiyCreateHandler>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.Run();

