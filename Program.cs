using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;
using PMS_API;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>(options =>{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IUserServices,UserServices>();
builder.Services.AddScoped<IPersonalService,PersonalService>();
builder.Services.AddScoped<ICollegeServices,CollegeServices>();
builder.Services.AddScoped<IDesignationServices,DesignationServices>();
builder.Services.AddScoped<IDomainServices,DomainServices>();
builder.Services.AddScoped<IProfileStatusServices,ProfileStatusServices>();
builder.Services.AddScoped<ITechnologyServices,TechnologyServices>();
builder.Services.AddControllersWithViews().AddNewtonsoftJson(options =>
options.SerializerSettings.ReferenceLoopHandling=Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
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
