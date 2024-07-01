using Microsoft.Extensions.DependencyInjection;
using TPdeEFCore01.Entidades;
using TPdeEFCore01.Servicios.Interfaces;
using Color = TPdeEFCore01.Entidades.Color;
using Size = TPdeEFCore01.Entidades.Size;

namespace TPdeEFCore01.Windows.Helpers
{
    public static class CombosHelper
    {
        public static void CargarComboBrand(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IBrandServicio>();

            var lista = servicio?.GetLista();
            var defaultBrand = new Brand
            {
                BrandName = "Seleccione"
            };
            lista?.Insert(0, defaultBrand);
            cbo.DataSource = lista;
            cbo.DisplayMember = "BrandName";
            cbo.ValueMember = "BrandId";
            cbo.SelectedIndex = 0;
        }
        public static void CargarComboGenre(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IGenreServicio>();

            var lista = servicio?.GetLista();
            var defaultGenre = new Genre
            {
                GenreName = "Seleccione"

            };
            lista?.Insert(0, defaultGenre);
            cbo.DataSource = lista;
            cbo.DisplayMember = "GenreName";
            cbo.ValueMember = "GenreId";
            cbo.SelectedIndex = 0;
        }
        public static void CargarComboSport(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<ISportServicio>();

            var lista = servicio?.GetLista();
            var defaultSport = new Sport
            {
                SportName = "Seleccione"

            };
            lista?.Insert(0, defaultSport);
            cbo.DataSource = lista;
            cbo.DisplayMember = "SportName";
            cbo.ValueMember = "SportId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboColor(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IColorServicio>();

            var lista = servicio?.GetLista();
            var defaultColor = new Color
            {
                ColorName = "Seleccione"

            };
            lista?.Insert(0, defaultColor);
            cbo.DataSource = lista;
            cbo.DisplayMember = "ColorName";
            cbo.ValueMember = "ColorId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarCombosPaginas(int cantPagina, ref ComboBox paginascomboBox)
        {
            paginascomboBox.Items.Clear();
            for (int pagina = 1; pagina <= cantPagina; pagina++)
            {
                paginascomboBox.Items.Add(pagina.ToString());
            }
            paginascomboBox.SelectedIndex = 0;
        }

        public static void CargarComboMarca(IServiceProvider serviceProvider, ref ToolStripComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IBrandServicio>();

            var lista = servicio?.GetLista();
            var defaultBrand = new Brand
            {
                BrandName = "Seleccione"
            };

            cbo.Items.Clear();
            lista?.Insert(0, defaultBrand);
            if (lista is not null)
            {
                foreach (Brand brand in lista)
                {
                    cbo.Items.Add(brand.BrandName);
                } 
            }
            if (lista is not null)
            {

                if (lista.Count > 0)
                {
                    cbo.SelectedIndex = 0;
                } 
            }
        }
        public static void CargarComboGenre(IServiceProvider serviceProvider, ref ToolStripComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IGenreServicio>();

            var lista = servicio?.GetLista();
            var defaultGenre = new Genre
            {
                GenreName = "Seleccione"
            };

            cbo.Items.Clear();
            lista?.Insert(0, defaultGenre);
            if (lista is not null)
            {
                foreach (Genre genre in lista)
                {
                    cbo.Items.Add(genre.GenreName);
                }

            }
            if (lista is not null)
            {
                if (lista.Count > 0)
                {
                    cbo.SelectedIndex = 0;
                } 
            }
        }
        public static void CargarComboSport(IServiceProvider serviceProvider, ref ToolStripComboBox cbo)
        {
            var servicio = serviceProvider.GetService<ISportServicio>();

            var lista = servicio?.GetLista();
            var defaultSport = new Sport
            {
                SportName = "Seleccione"
            };

            cbo.Items.Clear();
            lista?.Insert(0, defaultSport);
            if (lista is not null)
            {
                foreach (Sport sport in lista)
                {
                    cbo.Items.Add(sport.SportName);
                } 
            }

            if (lista is not null)
            {
                if (lista.Count > 0)
                {
                    cbo.SelectedIndex = 0;
                } 
            }
        }
        public static void CargarComboMarca(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IBrandServicio>();

            var lista = servicio?.GetLista();
            var defaultBrand = new Brand
            {
                BrandName = "Seleccione"
            };

            cbo.Items.Clear();
            lista?.Insert(0, defaultBrand);
            if (lista is not null)
            {
                foreach (Brand brand in lista)
                {
                    cbo.Items.Add(brand.BrandName);
                } 
            }

            if (lista is not null)
            {
                if (lista.Count > 0)
                {
                    cbo.SelectedIndex = 0;
                } 
            }
        }
        public static void CargarComboDeporte(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<ISportServicio>();

            var lista = servicio?.GetLista();
            var defaultSport = new Sport
            {
                SportName = "Seleccione"
            };

            cbo.Items.Clear();
            lista.Insert(0, defaultSport);
            foreach (Sport sport in lista)
            {
                cbo.Items.Add(sport.SportName);
            }

            if (lista.Count > 0)
            {
                cbo.SelectedIndex = 0;
            }
        }

        public static void CargarComboMarcaYDeporte(IServiceProvider serviceProvider, ref ComboBox cbo, Brand? brand)
        {
            var servicio = serviceProvider.GetService<IShoeServicio>();
            var lista = servicio?.GetDeportesPorMarca(brand.BrandId) ?? new List<Sport>();

            var defaultSport = new Sport
            {
                SportName = "Seleccione"
            };
            lista.Insert(0, defaultSport);

            cbo.DataSource = lista;
            cbo.DisplayMember = "SportName";
            cbo.ValueMember = "SportId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboGeneroYDeporte(IServiceProvider serviceProvider, ref ComboBox cbo, Genre? genre)
        {
            var servicio = serviceProvider.GetService<IShoeServicio>();
            var lista = servicio?.GetDeportesPorGenero(genre.GenreId) ?? new List<Sport>();

            var defaultSport = new Sport
            {
                SportName = "Seleccione"
            };
            lista.Insert(0, defaultSport);

            cbo.DataSource = lista;
            cbo.DisplayMember = "SportName";
            cbo.ValueMember = "SportId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboTalles(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<ISizeServicio>();

            var lista = servicio?.GetLista();
            var defaultTalle = new Size
            {
                SizeNumber = 0.0m
            };
            lista?.Insert(0, defaultTalle);
            cbo.DataSource = lista;
            cbo.DisplayMember = "SizeNumber";
            cbo.ValueMember = "SizeId";
            cbo.SelectedIndex = 0;
        }
    }
}
