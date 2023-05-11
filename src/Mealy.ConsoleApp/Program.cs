using Mealy.Application.Products.Queries.GetProducts;
using Mealy.Application.Products.Repositories;
using Mealy.Persistence;
using Mealy.Persistence.Products.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;

var host = Host.CreateDefaultBuilder(args)
               .ConfigureServices((hostContext, services) =>
               {
                 services.AddMediatR(options =>
                 {
                   options.RegisterServicesFromAssembly(Mealy.Application.AssemblyReference.Assembly);
                 });

                 services.AddScoped<IProductRepository, ProductRepository>();

                 services.AddDbContext<MealyDbContext>(options =>
                 {
                   options.UseSqlServer(hostContext.Configuration.GetConnectionString("Mealy"));
                 });
               }).Build();

var mediator = host.Services.GetRequiredService<ISender>();

var stopwatch = Stopwatch.StartNew();
await mediator.Send(new GetProductsQuery());
stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);