using Actio.Common.Commands;
using Actio.Common.Events;
using Actio.Common.RabbitMq;
using Actio.Common.Services;
using Actio.Services.Activities.Handlers;

var builder = WebApplication.CreateBuilder(args);

ServiceHost.Create<StartupBase>(args)
    .UseRabbitMq().SubscribeToCommand<CreateActivitiy>()
    .Build();

builder.Services.AddMvc();
builder.Services.AddRabbitMq(builder.Configuration);
builder.Services.AddScoped<ICommandHandler<CreateActivitiy>, CreateActivitiyHandler>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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


