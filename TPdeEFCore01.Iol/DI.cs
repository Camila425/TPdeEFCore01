using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TPdeEFCore01.Datos;
using TPdeEFCore01.Datos.Interfaces;
using TPdeEFCore01.Datos.Repositorios;
using TPdeEFCore01.Servicios.Interfaces;
using TPdeEFCore01.Servicios.Repositorios;
using TPdeEFCore01.Servicios.Servicios;

namespace TPdeEFCore01.Iol
{
    public class DI
    {
        public static IServiceProvider ConfiguracionServicios()
        {
            var Servicio = new ServiceCollection();

            Servicio.AddScoped<IBrandsRepositorio, BrandRepositorio>();
            Servicio.AddScoped<IBrandServicio, BrandServicio>();

            Servicio.AddScoped<IGenresRepositorio, GenreRepositorio>();
            Servicio.AddScoped<IGenreServicio, GenreServicio>();

            Servicio.AddScoped<ISportServicio, SportServicio>();
            Servicio.AddScoped<ISportsRepositorio, SportRepositorio>();

            Servicio.AddScoped<IColorServicio, ColorServicio>();
            Servicio.AddScoped<IColorsRepositorio, ColorRepositorio>();

            Servicio.AddScoped<IShoeServicio, ShoeServicio>();
            Servicio.AddScoped<IShoesRepositorio, ShoeRepositorio>();

            Servicio.AddScoped<IUnitOfWork, UnitOfWork>();
            Servicio.AddScoped<ISizeServicio, SizeServicio>();
            Servicio.AddScoped<ISizeRepositorio, SizeRepositorio>();

            Servicio.AddDbContext<ShoesDbContext>(opciones =>
            {
                opciones.UseSqlServer(@"Data Source=.;" +
            "Initial Catalog=TPEFCore01; Trusted_Connection=true;" +
            " TrustServerCertificate=True;");
            });
            return Servicio.BuildServiceProvider();

        }

    }
}
