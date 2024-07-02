using Microsoft.EntityFrameworkCore;
using System;
using ToDoList.Model;

namespace WebApplication1;

public class Program {
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);
        // Add services to the container.

        builder.Services.AddControllers();


        builder.Services.AddDbContext<ToDoListTable>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("ToDoListTable")
            ?? throw new InvalidOperationException("Connection string 'ToDoListTable' not found.")));

        //AppDbContext is a key that has to be in the connection string 

        builder.Services.AddCors();

        var app = builder.Build();

        // Configure the HTTP request pipeline.

        app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod());

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
