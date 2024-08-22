using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LibraryManagementWEBAPI.Data;
using LibraryManagementWEBAPI.Repository;
using LibraryManagementWEBAPI.Service;

namespace LibraryManagementWEBAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<LMSWEBAPIContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("LMSWEBAPIContext")));
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //string connectionString = builder.Configuration.GetConnectionString("testConnection");
            //builder.Services.AddDbContext<LMSWEBAPIContext>(
            //    options =>
            //    {
            //        options.UseMySql(connectionString, ServerVersion.Parse("8.0.39-mysql"));
            //        options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            //    }

            //    );

            builder.Services.AddScoped<IBookRepository, BookRepository>();
            builder.Services.AddScoped<IBookService, BookService>();
            builder.Services.AddScoped<IMemberRepository, MemberRepository>();
            builder.Services.AddScoped<IMemberService, MemberService>();
            builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
            builder.Services.AddScoped<ITransactionService, TransactionService>();


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


        }
    }
}
