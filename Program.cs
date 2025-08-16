//usings do dotnet
using System;
using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

//meus usings
using aula4_exercicio.Data;
using Microsoft.Extensions.Logging;



internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<Aula4DbContext>(options =>
        {
            //var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            
            //options.UseSqlite($"Data Source={localAppData}/Aula4-exercicio/Data/database.db")
            options.UseSqlite($"Data Source=database.db")
                .EnableSensitiveDataLogging() // EnableSensitiveDataLogging é usado para logar os dados sensíveis no console
                .LogTo(Console.WriteLine, LogLevel.Information); // LogTo é usado para logar as informações de SQL no console       
        });

        // Add services to the container.
        

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseAuthorization();

        app.MapStaticAssets();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Agencia}/{action=Index}/{id?}")
            .WithStaticAssets();
        //RotasGet:
        //http://localhost:porta/Agencia/Index
        //http://localhost:porta/Cliente/Index
        //http://localhost:porta/ContaCorrente/Index

        //RotasPost:
        //http://localhost:porta/Agencia/Adicionar/?CGC=8579&Nome=xyzfsdf&Endereco=rua%20x&Telefone=123456
        //http://localhost:porta/Agencia/Deletar/?cgc=12345 
        //http://localhost:porta/Cliente/Adicionar/Nome=tttt&Email=ttt%40ttt&Telefone=99999
        //http://localhost:porta/Cliente/Deletar/?id=1
        //http://localhost:porta/ContaCorrente/AbrirConta/?Numero=1&ClienteId=1&AgenciaCGC=4568


        app.Run();
    }
}