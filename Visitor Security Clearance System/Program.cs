using Visitor_Security_Clearance_System.CosmosDB;
using Visitor_Security_Clearance_System.Interfaces;
using Visitor_Security_Clearance_System.Services;
using static Visitor_Security_Clearance_System.CosmosDB.CosmosDBServices;
using static Visitor_Security_Clearance_System.CosmosDB.ICosmosDBServices;
using Visitor_Security_Clearance_System.Interfaces;
using Visitor_Security_Clearance_System.Services;
using Visitor_Security_Clearance_System.Interfaces;
using Visitor_Security_Clearance_System.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Dependensies injection
builder.Services.AddScoped<IManagerService, ManagerService>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IOfficeService, OfficeService>();
builder.Services.AddScoped<IVisitorService, VisitorService>();
builder.Services.AddScoped<ISecurityService, SecurityService>();
builder.Services.AddScoped<ICosmosDBServices, CosmosDBServices>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
