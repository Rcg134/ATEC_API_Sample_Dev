using ATEC_API_Sample.Data.Context;
using ATEC_API_Sample.Data.IRepository;
using ATEC_API_Sample.Data.MappingProfile;
using ATEC_API_Sample.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//------------------Service Registration-------------------

builder.Services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();

//---------------------------------------------------------

//------------------Context Connection---------------------
builder.Services.AddDbContext<SocialMediaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalConnection"));
});
//---------------------------------------------------------

builder.Services.AddAutoMapper(typeof(SocialMediaMappingProfile));

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
