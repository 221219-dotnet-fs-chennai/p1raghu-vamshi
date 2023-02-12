using EntityApi.Entities;
using BusinessLogic;
using Microsoft.EntityFrameworkCore;
using Modules;
using EntityApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddMemoryCache();
builder.Services.AddControllers().AddXmlSerializerFormatters();
/*builder.Services.AddCors(options =>
   options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        }
        )
    );*/
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var config = builder.Configuration.GetConnectionString("ConnectionString");
builder.Services.AddDbContext<AssociatesDbContext>(options => options.UseSqlServer(config));
builder.Services.AddScoped<IRepo<EntityApi.Entities.UserDetail>, EntityApi.SqlRepo>();
builder.Services.AddScoped<ILogic, Logic>();
builder.Services.AddScoped<IEducationRepo<EntityApi.Entities.Education>, EntityApi.EducationSqlRepo>();
builder.Services.AddScoped<ILogic1, Logic1>();
builder.Services.AddScoped<IAddressRepo<EntityApi.Entities.Address>, EntityApi.AddressSqlRepo>();
builder.Services.AddScoped<ILogic2, Logic2>();
builder.Services.AddScoped<ICompanyRepo<EntityApi.Entities.Company>, EntityApi.CompanySqlRepo>();
builder.Services.AddScoped<ICompanyLogic, CompanyLogic>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();


app.UseAuthorization();

app.MapControllers();

app.Run();
