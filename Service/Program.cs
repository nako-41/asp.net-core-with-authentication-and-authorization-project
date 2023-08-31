using Case_BusinessLayer.Abstract;
using Case_BusinessLayer.Concrete;
using Case_DataAccessLayer.Abstract;
using Case_DataAccessLayer.Concrete.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ---------------Service-------------------- /

builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
builder.Services.AddScoped<IRoleService, RoleManager>();


// ----------------DAL------------------ /

builder.Services.AddScoped(typeof(IRepositoryDal<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IRoleRepositoryDal, RoleRepository>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

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
