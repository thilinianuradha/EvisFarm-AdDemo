using AdDemo.Services.Advertisements;
using AdDemo.Services.Buyers;
using AdDemo.Services.Crops;
using AdDemo.Services.Vendors;
using AdDemo.Services.AcceptedRequests;
using AdDemo.Services.PendingRequests;
using AdDemo.Services.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IAdvetisementRepository, AdvertisementSqlServerService>();
builder.Services.AddScoped<ICropRepository, CropSqlServerService>();
builder.Services.AddScoped<IVendorRepository, VendorSqlServerService>();
builder.Services.AddScoped<IBuyerRepository, BuyerSqlServerService>();
builder.Services.AddScoped<IAcceptedRequestRepository, AcceptedRequestSqlServerService>();
builder.Services.AddScoped<IPendingRequestRepository, PendingRequestSqlServerService>();
builder.Services.AddScoped<IUserRepository, UserSqlServerService>();

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
