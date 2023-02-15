using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DepartmentContext>(options =>
options.UseInMemoryDatabase("Department"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapGet("/", () => "Hello !");
app.MapGet("/Department/{Id}", async (int Id, DepartmentContext dc)=>
    await dc.DepartmentSet.FindAsync(Id));
app.MapPost("/department", async (Department d, DepartmentContext dc) =>
{
    dc.DepartmentSet.Add(d);
});
app.MapPut("/department/{Id}", async (int Id, Department d, DepartmentContext dc) =>
{
    var ids = await dc.DepartmentSet.FindAsync(Id);
    if(ids is null) return Results.NotFound();
    ids.Name = d.Name;
    ids.Location = d.Location;
    await dc.SaveChangesAsync();
    return Results.NoContent();
});
app.MapDelete("/department/{Id}", async (int Id, DepartmentContext dc) =>
{
    if(await dc.DepartmentSet.FindAsync(Id) is Department d)
    {
        dc.DepartmentSet.Remove(d);
        await dc.SaveChangesAsync();
        return;
    }
});




app.Run();

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }

}
class DepartmentContext : DbContext
{
    public DepartmentContext(DbContextOptions options) : base(options)
    { }
    public DbSet<Department> DepartmentSet { get; set; }
}