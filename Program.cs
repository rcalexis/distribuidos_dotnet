using Distribuidos.Api.Services;  
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddSingleton<IPipedreamService, PipedreamService>();  
 

var app = builder.Build();

// app.UseHttpRedirection();
app.UseAuthorization();
app.MapControllers(); 
app.Run();