
using UserStore.Core;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.Configure<MyDBConfig>(builder.Configuration);
builder.Services.AddScoped<IDBClient, DBClient>();
builder.Services.AddScoped<IUserService, UserServices>();
builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
