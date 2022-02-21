using Microsoft.EntityFrameworkCore;
using APIAssignment1.DB;
using APIAssignment1.Interface;
using APIAssignment1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(IPersonService, PersonService);
builder.Services.AddDbContext<TaskContext>(options => options.UseInMemoryDatabase("PersonDTO"));
builder.Services.AddTransient<IToDoTaskService, ToDoTaskService>();

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
