using SignalRWebUI.BusinessLayer;
using SignalRWebUI.DataAccessLayer.Contexts;
using SignalRWebUI.DataAccessLayer;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<SignalRContext>();

// business service registration
builder.Services.AddBusinessServices();

// data access service registration
builder.Services.AddDataAccessServices();

// about
//builder.Services.AddScoped<IAboutService, AboutManager>();
//builder.Services.AddScoped<IAboutDal, EfAboutDal>();


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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
