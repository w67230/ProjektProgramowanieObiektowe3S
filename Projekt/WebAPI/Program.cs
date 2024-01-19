using BibliotekaKlas;
using BibliotekaKlas.Lekarze;
using BibliotekaKlas.Pacjenci;
using BibliotekaKlas.Wizyty;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddTransient<Dzialania<Lekarz, int>, DzialaniaLekarz>();
            builder.Services.AddTransient<Dzialania<Pacjent, string>, DzialaniaPacjent>();
            builder.Services.AddTransient<Dzialania<Wizyta, DateTime>, DzialaniaWizyta>();

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
        }
    }
}