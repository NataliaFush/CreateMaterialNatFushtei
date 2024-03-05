using Microsoft.EntityFrameworkCore;
using DataBase;
using DataBase.Repositories;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Services;

namespace CreateMaterialNatFushtei
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<MyDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPagesConnection") ?? throw new InvalidOperationException("Connection string 'RazorPagesContext' not found.")));
            builder.Services.AddTransient<IItemRepository, ItemRepository>();
            builder.Services.AddTransient<IItemService, ItemService>();
            builder.Services.AddTransient<ITaxRepository, TaxRepository>();
            builder.Services.AddTransient<ITaxService, TaxService>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}