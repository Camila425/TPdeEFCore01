using ConsoleTables;
using Microsoft.Extensions.DependencyInjection;
using TPdeEFCore01.Entidades;
using TPdeEFCore01.Entidades.Dtos;
using TPdeEFCore01.Entidades.Enums;
using TPdeEFCore01.Iol;
using TPdeEFCore01.Servicios.Interfaces;
using TPdeEFCore01.Shared;
using Color = TPdeEFCore01.Entidades.Color;
using Size = TPdeEFCore01.Entidades.Size;

namespace TPdeEFCore01.Consola
{
    public class Program
    {
        private static IServiceProvider? serviceProvider;
        static int cantidadPorPagina = 5;

        static void Main(string[] args)
        {
            serviceProvider = DI.ConfiguracionServicios();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Menu principal:");
                Console.WriteLine("1. Listado de Brand");
                Console.WriteLine("2. Listado de Brand Paginado");
                Console.WriteLine("3. Ingresar Brand");
                Console.WriteLine("4. Borrar Brand");
                Console.WriteLine("5. Editar Brand");
                Console.WriteLine("===============================");
                Console.WriteLine("10. Listado de Genre");
                Console.WriteLine("11. Listado de Genre Paginado");
                Console.WriteLine("12. Ingresar Genre");
                Console.WriteLine("13. Borrar Genre");
                Console.WriteLine("14. Editar Genre");
                Console.WriteLine("===============================");
                Console.WriteLine("20. Listado de Sports");
                Console.WriteLine("21. Listado de Sports Paginado");
                Console.WriteLine("22. Ingresar Sports");
                Console.WriteLine("23. Borrar Sports");
                Console.WriteLine("24. Editar Sports");
                Console.WriteLine("===============================");
                Console.WriteLine("30. Listado de Color");
                Console.WriteLine("31. Listado de Color Paginado");
                Console.WriteLine("32. Ingresar Color");
                Console.WriteLine("33. Borrar Color");
                Console.WriteLine("34. Editar Color");
                Console.WriteLine("===============================");
                Console.WriteLine("40. Listado de zapatos");
                Console.WriteLine("41. Listado de zapatos Paginado");
                Console.WriteLine("42. Ingresar zapatos");
                Console.WriteLine("43. Borrar zapatos");
                Console.WriteLine("44. Editar zapatos");
                Console.WriteLine("45. MostrarShoeporMarca");
                Console.WriteLine("46. MostrarShoeporGenero");
                Console.WriteLine("47. MostrarShoeporDeporte");
                Console.WriteLine("48. Motrar Zapatos Por Marca entre dos Precios");
                Console.WriteLine("49. Motrar Zapatos Por Genero Y Deporte");
                Console.WriteLine("50. Agregar Zapato con Talle");
                Console.WriteLine("51. Asignar Talle a Zapato");
                Console.WriteLine("52. Ordenar por precio");
                Console.WriteLine("53. Ordenar por Talles");
                Console.WriteLine("54. Ingresar stock de cada Zapato ");



                Console.WriteLine("===============================");
                Console.WriteLine("60. Listado de Size");
                Console.WriteLine("61. Listado de Size Paginado");
                Console.WriteLine("62. Ingresar Size");
                Console.WriteLine("63. Borrar Size");
                Console.WriteLine("64. Editar Size");
                Console.WriteLine("65. Talles Por Zapatos");

                Console.WriteLine("x: Salir");

                Console.Write("seleccionar una opcion:");
                string? Input = Console.ReadLine();
                switch (Input)
                {
                    case "1":
                        ListaDeBrand();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "2":
                        ListadoDeBrand();
                        break;
                    case "3":
                        IngresarBrand();
                        break;
                    case "4":
                        BorrarBrand();
                        break;
                    case "5":
                        EditarBrand();
                        break;

                    case "10":
                        ListaDeGenre();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "11":
                        ListadoDeGenre();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "12":
                        IngresarGenre();
                        break;
                    case "13":
                        BorrarGenre();
                        break;
                    case "14":
                        EditarGenre();
                        break;

                    case "20":
                        ListaDeDeporte();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "21":
                        ListadoDeSport();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "22":
                        IngresarSport();
                        break;
                    case "23":
                        BorrarSport();
                        break;
                    case "24":
                        EditarSport();
                        break;



                    case "30":
                        ListaColor();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "31":
                        ListadoDeColor();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "32":
                        IngresarColor();
                        break;
                    case "33":
                        BorrarColor();
                        break;
                    case "34":
                        EditarColor();
                        break;

                    case "40":
                        ListaZapato();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "41":
                        ListadoDeZapatos();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "42":
                        IngresarZapatos();
                        break;
                    case "43":
                        BorrarZapatos();
                        break;
                    case "44":
                        EditarZapatos();
                        break;
                    case "45":
                        MostrarShoeporMarca();
                        break;
                    case "46":
                        MostrarShoeporGenero();
                        break;
                    case "47":
                        MostrarShoeporDeporte();
                        break;
                    case "48":
                        MotrarZapatosPorMarcaentredosPrecios();
                        break;
                    case "49":
                        MotrarZapatosPorGeneroYDeporte();
                        break;
                    case "50":
                        AgregarZapatoConTalle();
                        break;
                    case "51":
                        AsignarTalleAZapato();
                        break;
                    case "52":
                        ListadoOrdenadoPorPrecio();
                        break;
                    case "53":
                        ListaOrdenadoPorTalle();
                        break;
                    case "54":
                        IngresarStockZapato();
                        break;


                    case "60":
                        ListaDeSize();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "61":
                        ListadoDeSize();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "62":
                        IngresarSize();
                        break;
                    case "63":
                        BorrarSize();
                        break;
                    case "64":
                        EditarSize();
                        break;
                    case "65":
                        ListarShoesConSize();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "x":
                        exit = true;
                        Console.WriteLine("Salir del programa");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. seleccione una opcion valida");
                        break;
                }
                Console.WriteLine();
            }
        }

        private static void IngresarStockZapato()
        {
            Console.Clear();
            var servicioZapatos = serviceProvider?.GetService<IShoeServicio>();

            if (servicioZapatos != null)
            {
                var zapatoStock = ActualizarStock();
                if (zapatoStock != null)
                {
                    var zapatoStockExiste = servicioZapatos.GetShoeSizeId(zapatoStock.ShoeId, zapatoStock.SizeId);

                    if (zapatoStockExiste != null)
                    {
                        zapatoStock.ShoeSizeId = zapatoStockExiste.ShoeSizeId;
                        servicioZapatos.GuardarStock(zapatoStock);
                        Console.WriteLine("Stock Agregado!!!");
                    }
                    else
                    {
                        Console.WriteLine("el zapato no existe!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Error al ingresar stock del zapato");
                }
            }
            else
            {
                Console.WriteLine("El servicio de Zapato es nulo");
            }
            Thread.Sleep(2000);
        }
        private static ShoeSizes ActualizarStock()
        {
            var servicioshoe = serviceProvider?.GetService<IShoeServicio>();
            var servicioSize = serviceProvider?.GetService<ISizeServicio>();

            if (servicioshoe == null || servicioSize == null)
            {
                Console.WriteLine("Error: Servicios no disponibles");
            }

            Console.WriteLine("Agregar Stock al Talle");
            ListaDeSize();

            var listaSizes = servicioSize?.GetLista().Select(s => s.SizeId.ToString()).ToList();
            var selectSizeId = ConsoleExtensions.GetValidOptions("Seleccione el Id del  Talle para actualizar el stock:", listaSizes);
            var sizeId = Convert.ToInt32(selectSizeId);
            var size = servicioSize?.GetSizeId(sizeId);

            if (size == null)
            {
                Console.WriteLine("Talle no encontrado");
            }

            ListaZapato();

            var listaZapatos = servicioshoe?.GetLista().Select(s => s.ShoeId.ToString()).ToList();
            var selectShoeId = ConsoleExtensions.GetValidOptions("Seleccione el Id del Zapato para actualizar el Stock:", listaZapatos);
            var shoeId = Convert.ToInt32(selectShoeId);
            var shoe = servicioshoe?.GetShoeId(shoeId);

            if (shoe == null)
            {
                Console.WriteLine("Zapato no encontrado");
            }

            var quantityInStock = ConsoleExtensions.ReadInt("Ingrese el Stock:", 1, 10000);

            var shoeSize = new ShoeSizes
            {
                ShoeId = shoeId,
                shoe = shoe,
                SizeId = sizeId,
                size = size,
                QuantityInStock = quantityInStock
            };
            return shoeSize;
        }



        private static void ListaOrdenadoPorTalle()
        {
            Console.Clear();
            Console.WriteLine("Listado de Talles Ordenado");

            var orden = ConsoleExtensions.GetValidOptions("(A)scendente (D)escendente:", new List<string> { "A", "D" });
            var servicio = serviceProvider?.GetService<ISizeServicio>();

            cantidadPorPagina = ConsoleExtensions.ReadInt("Ingrese la cantidad por pagina:", 10, 20);
            var Cantregistros = servicio?.GetCantidad() ?? 0;
            var Paginas = CalcularCantidadPaginas(Cantregistros, cantidadPorPagina);

            for (int pagina = 0; pagina < Paginas; pagina++)
            {
                switch (orden)
                {
                    case "A":
                        MostrarListaTalles(servicio?.GetListaPaginada(pagina, cantidadPorPagina, Orden.MenorTalle));
                        break;
                    case "D":
                        MostrarListaTalles(servicio?.GetListaPaginada(pagina, cantidadPorPagina, Orden.MayorTalle));
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Mostrando en orden ascendente");
                        MostrarListaTalles(servicio?.GetListaPaginada(pagina, cantidadPorPagina, Orden.MenorTalle));
                        break;
                }
            }
            ConsoleExtensions.EsperaEnter();
        }

        private static void MostrarListaTalles(List<Size>? listasizes)
        {
            var tabla = new ConsoleTable("SizeId", "SizeNumber");
            if (listasizes != null)
            {
                foreach (var size in listasizes)
                {
                    tabla.AddRow(size.SizeId, size.SizeNumber);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();
            }
        }

        private static void ListadoOrdenadoPorPrecio()
        {
            Console.Clear();
            Console.WriteLine("Listado de Zapato Ordenado Por Precio");
            var orden = ConsoleExtensions.GetValidOptions("(A)Z (Z)A (1)2 (2)1:", new List<string> { "A", "Z", "1", "2" });
            var servicio = serviceProvider?.GetService<IShoeServicio>();

            cantidadPorPagina = ConsoleExtensions.ReadInt("Ingrese la cantidad por pagina:", 10, 20);
            var Cantregistros = servicio?.GetCantidad() ?? 0;
            var Paginas = CalcularCantidadPaginas(Cantregistros, cantidadPorPagina);

            for (int pagina = 0; pagina < Paginas; pagina++)
            {
                switch (orden)
                {
                    case "A":
                        MostrarListaZapatos(servicio?.GetListaPaginada(pagina, cantidadPorPagina, Orden.AZ));
                        break;
                    case "Z":
                        MostrarListaZapatos(servicio?.GetListaPaginada(pagina, cantidadPorPagina, Orden.ZA));
                        break;
                    case "1":
                        MostrarListaZapatos(servicio?.GetListaPaginada(pagina, cantidadPorPagina, Orden.MenorPrecio));
                        break;
                    default:
                        MostrarListaZapatos(servicio?.GetListaPaginada(pagina, cantidadPorPagina, Orden.MayorPrecio));
                        break;
                }

            }
            ConsoleExtensions.EsperaEnter();
        }

        private static void AsignarTalleAZapato()
        {
            var ZapatoService = serviceProvider?.GetService<IShoeServicio>();
            var TalleService = serviceProvider?.GetService<ISizeServicio>();

            if (ZapatoService == null || TalleService == null)
            {
                Console.WriteLine("Servicios no disponibles");
                return;
            }

            var ListZapatos = ZapatoService.GetListaDto();
            if (ListZapatos.Count > 0)
            {
                MostrarListaZapatos(ListZapatos);
                var opcionZapato = ConsoleExtensions.GetValidOptions("Seleccione el Id de un Zapato para Agregar Talle:",
                ListZapatos.Select(s => s.ShoeId.ToString()).ToList());

                var ZapatoSeleccionado = ZapatoService.GetShoePorId(Convert.ToInt32(opcionZapato));

                if (ZapatoSeleccionado != null)
                {
                    Console.WriteLine("Zapato encontrado:");
                    Console.WriteLine($"ID:{ZapatoSeleccionado.ShoeId}");
                    Console.WriteLine($"Descripcion:{ZapatoSeleccionado.Description}-{ZapatoSeleccionado.Model}");
                    Console.WriteLine();

                    var listaTalles = TalleService.GetLista();

                    Console.WriteLine("Lista de Talle:");
                    foreach (var talle in listaTalles)
                    {
                        Console.WriteLine($"SizeId:{talle.SizeId}, SizeNumber:{talle.SizeNumber}");
                    }
                    Console.WriteLine();

                    var opcion = ConsoleExtensions.GetValidOptions("Seleccione el Id de un Talle (N para nuevo):",
                     listaTalles.Select(s => s.SizeId.ToString()).Concat(new[] { "N" }).ToList());

                    if (opcion == "N")
                    {
                        var SizeNumber = ConsoleExtensions.ReadDecimal("Numero del nuevo talle:");

                        Size nuevoTalle = new Size
                        {
                            SizeNumber = SizeNumber,
                        };

                        ZapatoService.AsignarTallesAZapato(ZapatoSeleccionado, nuevoTalle);
                    }
                    else
                    {
                        var TalleSeleccionado = listaTalles.FirstOrDefault(s => s.SizeId.ToString() == opcion);

                        if (TalleSeleccionado is not null)
                        {
                            ZapatoService.AsignarTallesAZapato(ZapatoSeleccionado, TalleSeleccionado);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron zapatos");
                }
            }
            else
            {
                Console.WriteLine("No hay zapatos disponibles.");
            }
            ConsoleExtensions.EsperaEnter();
        }

        private static void MostrarListaZapatos(List<ShoeListDto>? ListazapatosSinTalle)
        {
            var tabla = new ConsoleTable("ID", "Descripcion", "BrandName", "GenreName", "SportName", "ColorName", "Model", "Price");
            if (ListazapatosSinTalle != null)
            {
                foreach (var shoe in ListazapatosSinTalle)
                {
                    tabla.AddRow(shoe.ShoeId, shoe.Descripcion, shoe.BrandName, shoe.GenreName,
                        shoe.SportName, shoe.ColorName,
                        shoe.Model, shoe.Price);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();
            }
        }

        private static void AgregarZapatoConTalle()
        {
            var servicioZapato = serviceProvider?.GetService<IShoeServicio>();
            var servicioTalle = serviceProvider?.GetService<ISizeServicio>();

            if (servicioZapato == null || servicioTalle == null)
            {
                Console.WriteLine("Servicios no disponibles");
                return;
            }

            Shoe Zapato = CrearZapato();

            ListaDeSize();
            var listaChar = servicioTalle.GetLista().Select(t => t.SizeId.ToString()).ToList();
            var TalleId = ConsoleExtensions.GetValidOptions("Ingrese un ID de Talle (N para nuevo):", listaChar);

            if (TalleId == "N")
            {
                var SizeNumber = ConsoleExtensions.ReadDecimal("SizeNumber:");

                Size nuevoTalle = new Size
                {
                    SizeNumber = SizeNumber,
                };

                var shoeSize = new ShoeSizes
                {
                    shoe = Zapato,
                    size = nuevoTalle
                };
                Zapato.shoeSizes.Add(shoeSize);
                servicioZapato.GuardarConTalle(Zapato, nuevoTalle);
                Console.WriteLine("Zapato agregado con nuevo Talle");
            }
            else
            {
                int TalleIdInt = Convert.ToInt32(TalleId);
                Size? TalleExistente = servicioTalle.GetSizeId(TalleIdInt, true);
                if (TalleExistente != null)
                {
                    var shoesize = new ShoeSizes
                    {
                        shoe = Zapato,
                        size = TalleExistente
                    };
                    Zapato.shoeSizes.Add(shoesize);

                    servicioZapato.GuardarConTalle(Zapato, TalleExistente);
                    Console.WriteLine("Zapato agregado con Talle existente!");
                }
                else
                {
                    Console.WriteLine("Talle no encontrado.");
                }
            }
        }

        private static void ListarShoesConSize()
        {
            var servicio = serviceProvider?.GetService<IShoeServicio>();
            Console.Clear();
            Console.WriteLine("Talles por Zapatos");
            ListaZapato();
            var listaChar = servicio?.GetLista().Select(s => s.ShoeId.ToString()).ToList();

            var ShoeId = ConsoleExtensions.GetValidOptions("Seleccione ID del Zapato:", listaChar);
            Shoe? shoe = servicio?.GetShoePorId(Convert.ToInt32(ShoeId), true);
            if (shoe is null)
            {
                Console.WriteLine("Zapato inexistente!");
                ConsoleExtensions.EsperaEnter();
                return;
            }
            Console.Clear();
            Console.WriteLine($"Zapato: {shoe.Description}-{shoe.Model}");

            var tabla = new ConsoleTable("SizeId", "SizeNumber", "Precio","Stock");
            if (shoe.shoeSizes != null)
            {
                foreach (var item in shoe.shoeSizes)
                {
                    tabla.AddRow(item.size.SizeId,
                        item.size.SizeNumber,
                        item.shoe.Price,
                        item.QuantityInStock);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();
            }
        }

        private static void EditarSize()
        {
            Console.Clear();
            var ServicioSize = serviceProvider?.GetService<ISizeServicio>();

            Console.WriteLine("Lista de Talles");
            ListaDeSize();
            var sizeId = ConsoleExtensions.ReadInt("Ingrese el ID del Talle a editar:");
            var Size = ServicioSize?.GetSizeId(sizeId);

            if (Size == null)
            {
                Console.WriteLine("Talle no encontrado");
                return;
            }

            Console.WriteLine($"id: {Size.SizeId}");
            Console.WriteLine($"talle: {Size.SizeNumber}");

            Size.SizeNumber = ConsoleExtensions.ReadDecimal("Ingrese El Nuevo talle:");
            try
            {

                ServicioSize?.Guardar(Size);
                Console.WriteLine("Talle actualizado exitosamente");
                ConsoleExtensions.EsperaEnter();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static void BorrarSize()
        {
            var servicio = serviceProvider?.GetService<ISizeServicio>();
            Console.Clear();
            Console.WriteLine("Ingreso Size a borrar");
            ListaDeSize();
            var listaChar = servicio?.GetLista().Select(s => s.SizeId.ToString()).ToList();
            var SizeId = ConsoleExtensions.GetValidOptions("Ingrese un ID de Size:", listaChar);

            try
            {
                var Size = servicio?.GetSizeId(Convert.ToInt32(SizeId));
                if (Size != null)
                {
                    if (servicio != null)
                    {
                        servicio.Borrar(Size);
                        Console.WriteLine("Registro borrado!");
                    }
                    else
                    {
                        throw new Exception("Servicio no disponible");
                    }
                }
                else
                {
                    Console.WriteLine("Size inexistente!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
            ConsoleExtensions.EsperaEnter();
        }

        private static void IngresarSize()
        {
            Console.Clear();
            Console.WriteLine("ingreso un Size:");
            var NuevoTalle = ConsoleExtensions.ReadDecimal("Ingresar Un Nuevo Talle:");
            var talle = new Size
            {
                SizeNumber = NuevoTalle
            };
            try
            {
                var servicio = serviceProvider?.GetService<ISizeServicio>();
                if (servicio != null)
                {
                    if (!servicio.Existe(talle))
                    {
                        servicio.Guardar(talle);
                        Console.WriteLine("Registro Agregado!");
                    }
                    else
                    {
                        Console.WriteLine("Registro Existe!");
                    }
                }
                else
                {
                    throw new Exception("Servicio no disponible");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            ConsoleExtensions.EsperaEnter();
        }

        private static void ListadoDeSize()
        {
            Console.Clear();
            var servicio = serviceProvider?.GetService<ISizeServicio>();
            cantidadPorPagina = ConsoleExtensions.ReadInt("Ingrese la cantidad por pagina:", 5, 10);
            var Cantregistros = servicio?.GetCantidad() ?? 0;
            var Paginas = CalcularCantidadPaginas(Cantregistros, cantidadPorPagina);

            for (int pagina = 0; pagina < Paginas; pagina++)
            {
                Console.Clear();
                Console.WriteLine("Listado Paginado");
                Console.WriteLine($"Pagina: {pagina + 1}");
                var listaPaginadaSize = servicio?.GetListaPaginada(pagina, cantidadPorPagina);
                MostrarSize(listaPaginadaSize);
            }
            Console.WriteLine("Fin del Listado");
        }

        private static void MostrarSize(List<Size>? listaPaginadaSize)
        {
            var tabla = new ConsoleTable("ID", "SizeNumber");
            if (listaPaginadaSize != null)
            {
                foreach (Size size in listaPaginadaSize)
                {
                    tabla.AddRow(size.SizeId, size.SizeNumber);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();
                ConsoleExtensions.EsperaEnter();
            }
        }

        private static void ListaDeSize()
        {
            var servicio = serviceProvider?.GetService<ISizeServicio>();
            var lista = servicio?.GetLista();
            Console.WriteLine("Listado de Size");

            var tabla = new ConsoleTable("ID", "SizeNumber");

            if (lista != null)
            {
                foreach (Size size in lista)
                {
                    tabla.AddRow(size.SizeId, size.SizeNumber);
                }
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
            Console.WriteLine($"Cantidad: {servicio?.GetCantidad()}");
        }

        private static void ListaColor()
        {
            var servicio = serviceProvider?.GetService<IColorServicio>();
            var lista = servicio?.GetLista();
            Console.WriteLine("Listado de Color");

            var tabla = new ConsoleTable("ID", "ColorName");

            if (lista != null)
            {
                foreach (Color Color in lista)
                {
                    tabla.AddRow(Color.ColorId, Color.ColorName);
                }
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
            Console.WriteLine($"Cantidad: {servicio?.GetCantidad()}");
        }

        private static void MotrarZapatosPorGeneroYDeporte()
        {
            Console.Clear();
            ListaDeGenre();
            var servicioGenre = serviceProvider?.GetService<IGenreServicio>();
            var servicioSport = serviceProvider?.GetService<ISportServicio>();

            Genre? genre;
            Sport? sport;

            var listaGenres = servicioGenre?.GetLista().Select(g => g.GenreId.ToString()).ToList();
            var genreId = ConsoleExtensions.GetValidOptions("Seleccione Un Genero:", listaGenres);
            genre = servicioGenre?.GetGenreId(Convert.ToInt32(genreId));
            ListaDeDeporte();

            var listaSports = servicioSport?.GetLista().Select(s => s.SportId.ToString()).ToList();
            var sportId = ConsoleExtensions.GetValidOptions("Seleccione Un Deporte:", listaSports);
            sport = servicioSport?.GetSportId(Convert.ToInt32(sportId));

            List<Shoe>? lista = servicioGenre?.GetGenreySport(genre, sport);

            Console.WriteLine("Listado de Zapatos por Genero y Deporte");
            var tabla = new ConsoleTable("ID", "Descripcion", "BrandName", "GenreName", "SportName",
                "ColorName", "Model", "Price");
            if (lista != null && lista.Count > 0)
            {
                foreach (var shoe in lista)
                {
                    tabla.AddRow(shoe.ShoeId,
                        shoe.Description,
                        shoe.brand?.BrandName,
                        shoe.genre?.GenreName,
                        shoe.sport?.SportName,
                        shoe.color?.ColorName,
                        shoe.Model,
                        shoe.Price);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();
            }
            else
            {
                Console.WriteLine("No hay zapatos disponibles para este Genero y Deporte.");
            }
            ConsoleExtensions.EsperaEnter();
        }

        private static void MotrarZapatosPorMarcaentredosPrecios()
        {
            Console.Clear();
            ListaDeBrand();
            var servicioBrand = serviceProvider?.GetService<IBrandServicio>();

            Brand? brand;

            var listaChar = servicioBrand?.GetLista().Select(b => b.BrandId.ToString()).ToList();

            var BranId = ConsoleExtensions.GetValidOptions("Seleccione la Marca:", listaChar);

            brand = servicioBrand?.GetBrandId(Convert.ToInt32(BranId));

            Console.Write("Ingrese el precio minimo:");
            var IngresoElprecioMinimo = Console.ReadLine();
            decimal precioMinimo;
            while (!decimal.TryParse(IngresoElprecioMinimo, out precioMinimo))
            {
                Console.Write("Error. Ingrese un numero valido para el precio minimo:");
                IngresoElprecioMinimo = Console.ReadLine();
            }

            Console.Write("Ingrese el precio maximo: ");
            var IngresoprecioMaximo = Console.ReadLine();
            decimal precioMaximo;
            while (!decimal.TryParse(IngresoprecioMaximo, out precioMaximo))
            {
                Console.Write("Error. Ingrese un numero valido para el precio maximo: ");
                IngresoprecioMaximo = Console.ReadLine();
            }

            List<Shoe>? lista = servicioBrand?.GetBrands(brand)
                ?.Where(s => s.Price >= precioMinimo && s.Price <= precioMaximo).ToList();

            Console.WriteLine("Listado de Zapatos");
            var tabla = new ConsoleTable("ID", "Descripcion", "BrandName", "GenreName", "SportName", "ColorName", "Model", "Price");
            if (lista != null && lista.Count > 0)
            {
                foreach (var item in lista)
                {
                    tabla.AddRow(item.ShoeId,
                        item.Description,
                        item.brand?.BrandName,
                        item.genre?.GenreName,
                        item.sport?.SportName,
                        item.color?.ColorName,
                        item.Model,
                        item.Price);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();
                ConsoleExtensions.EsperaEnter();
            }
            else
            {
                Console.WriteLine("No se encontraron zapatos dentro del rango");
                ConsoleExtensions.EsperaEnter();
            }
        }

        private static void MostrarShoeporDeporte()
        {
            Console.Clear();
            ListaDeDeporte();

            var servicioDeporte = serviceProvider?.GetService<ISportServicio>();

            Sport? sport;

            var listaChar = servicioDeporte?.GetLista().Select(s => s.SportId.ToString()).ToList();


            var SporId = ConsoleExtensions.GetValidOptions("Seleccione Un Deporte:", listaChar);

            sport = servicioDeporte?.GetSportId(Convert.ToInt32(SporId));

            List<Shoe>? listaSport = servicioDeporte?.GetSports(sport);
            Console.WriteLine("Listado de Deportes");


            var tabla = new ConsoleTable("ID", "Descripcion", "BrandName", "GenreName", "SportName",
                "ColorName", "Model", "Price");
            if (listaSport != null && listaSport.Count > 0)
            {
                foreach (var shoe in listaSport)
                {
                    tabla.AddRow(shoe.ShoeId,
                        shoe.Description,
                        shoe.brand?.BrandName,
                        shoe.genre?.GenreName,
                        shoe.sport?.SportName,
                        shoe.color?.ColorName,
                        shoe.Model,
                        shoe.Price);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();

            }
            else
            {
                Console.WriteLine("No hay zapatos disponibles para este Deporte.");
            }
            ConsoleExtensions.EsperaEnter();
        }

        private static void ListaDeDeporte()
        {
            var servicio = serviceProvider?.GetService<ISportServicio>();
            var listaSport = servicio?.GetLista();
            Console.WriteLine("Listado de Sport");

            var tabla = new ConsoleTable("ID", "SportName");

            if (listaSport != null)
            {
                foreach (Sport sport in listaSport)
                {
                    tabla.AddRow(sport.SportId, sport.SportName);
                }
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
            Console.WriteLine($"Cantidad: {servicio?.GetCantidad()}");
        }

        private static void MostrarShoeporGenero()
        {
            Console.Clear();
            ListaDeGenre();

            var serviciGenre = serviceProvider?.GetService<IGenreServicio>();

            Genre? Genre;

            var listaChar = serviciGenre?.GetLista().Select(g => g.GenreId.ToString()).ToList();


            var GenreId = ConsoleExtensions.GetValidOptions("Seleccione Un Genero:", listaChar);

            Genre = serviciGenre?.GetGenreId(Convert.ToInt32(GenreId));

            List<Shoe>? listaGenre = serviciGenre?.GetGenres(Genre);
            Console.WriteLine("Listado de Generos");


            var tabla = new ConsoleTable("ID", "Descripcion", "BrandName", "GenreName", "SportName", "ColorName", "Model", "Price");
            if (listaGenre != null && listaGenre.Count > 0)
            {
                foreach (var shoe in listaGenre)
                {
                    tabla.AddRow(shoe.ShoeId,
                        shoe.Description,
                        shoe.brand?.BrandName,
                        shoe.genre?.GenreName,
                        shoe.sport?.SportName,
                        shoe.color?.ColorName,
                        shoe.Model,
                        shoe.Price);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();

            }
            else
            {
                Console.WriteLine("No hay zapatos disponibles para este Genero.");
            }
            ConsoleExtensions.EsperaEnter();
        }

        private static void ListaDeGenre()
        {
            var servicio = serviceProvider?.GetService<IGenreServicio>();
            var listaGenre = servicio?.GetLista();
            Console.WriteLine("Listado de Genre");

            var tabla = new ConsoleTable("ID", "GenreName");

            if (listaGenre != null)
            {
                foreach (Genre genre in listaGenre)
                {
                    tabla.AddRow(genre.GenreId, genre.GenreName);
                }
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
            Console.WriteLine($"Cantidad: {servicio?.GetCantidad()}");
        }

        private static void MostrarShoeporMarca()
        {
            Console.Clear();
            ListaDeBrand();

            var servicioBrand = serviceProvider?.GetService<IBrandServicio>();

            Brand? brand;

            var listaChar = servicioBrand?.GetLista().Select(b => b.BrandId.ToString()).ToList();


            var BrandId = ConsoleExtensions.GetValidOptions("Seleccione Una Marca:", listaChar);

            brand = servicioBrand?.GetBrandId(Convert.ToInt32(BrandId));

            List<Shoe>? lista = servicioBrand?.GetBrands(brand);
            Console.WriteLine("Listado de Marcas");


            var tabla = new ConsoleTable("ID", "Descripcion", "BrandName", "GenreName", "SportName", "ColorName", "Model", "Price");
            if (lista != null && lista.Count > 0)
            {
                foreach (var shoe in lista)
                {
                    tabla.AddRow(shoe.ShoeId,
                        shoe.Description,
                        shoe.brand?.BrandName,
                        shoe.genre?.GenreName,
                        shoe.sport?.SportName,
                        shoe.color?.ColorName,
                        shoe.Model,
                        shoe.Price);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();

            }
            else
            {
                Console.WriteLine("No hay zapatos disponibles para esta marca.");
            }
            ConsoleExtensions.EsperaEnter();
        }

        private static void ListaDeBrand()
        {
            var servicio = serviceProvider?.GetService<IBrandServicio>();
            var lista = servicio?.GetLista();
            Console.WriteLine("Lista de Brand");

            var tabla = new ConsoleTable("ID", "BrandName");

            if (lista != null)
            {
                foreach (Brand brand in lista)
                {
                    tabla.AddRow(brand.BrandId, brand.BrandName);
                }
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
            Console.WriteLine($"Cantidad: {servicio?.GetCantidad()}");
        }

        private static void EditarZapatos()
        {
            Console.Clear();
            var servicioZapatos = serviceProvider?.GetService<IShoeServicio>();
            var servicioMarcas = serviceProvider?.GetService<IBrandServicio>();
            var servicioGeneros = serviceProvider?.GetService<IGenreServicio>();
            var servicioDeportes = serviceProvider?.GetService<ISportServicio>();
            var servicioColores = serviceProvider?.GetService<IColorServicio>();

            Console.WriteLine("Lista de zapato");
            ListaZapato();
            var shoeId = ConsoleExtensions.ReadInt("Ingrese el ID del Zapato a editar:");
            var shoe = servicioZapatos?.GetShoeId(shoeId);

            if (shoe == null)
            {
                Console.WriteLine("Zapato no encontrado.");
                return;
            }

            Console.WriteLine($"Zapato: {shoe.Description}");
            Console.WriteLine($"Marca: {shoe.brand?.BrandName}");
            Console.WriteLine($"Genero: {shoe.genre?.GenreName}");
            Console.WriteLine($"Deporte: {shoe.sport?.SportName}");
            Console.WriteLine($"Color: {shoe.color.ColorName}");
            Console.WriteLine($"Modelo: {shoe.Model}");
            Console.WriteLine($"Precio: {shoe.Price}");

            shoe.Description = ConsoleExtensions.ReadString("Ingrese la nueva descripcion:");
            shoe.Model = ConsoleExtensions.ReadString("Ingrese el nuevo modelo del zapato:");
            shoe.Price = ConsoleExtensions.ReadDecimal("Ingrese el nuevo precio de venta:");

            var listaMarcas = servicioMarcas?.GetLista();
            Console.WriteLine("Marcas disponibles:");
            if (listaMarcas is not null)
            {
                foreach (var brand in listaMarcas)
                {
                    Console.WriteLine($"ID: {brand.BrandId}, Nombre: {brand.BrandName}");
                }
            }

            var BrandId = ConsoleExtensions.ReadInt("Ingrese el ID de la Nueva Marca:");

            var listaGenero = servicioGeneros?.GetLista();
            Console.WriteLine("Generos disponibles:");
            if (listaGenero is not null)
            {
                foreach (var genre in listaGenero)
                {
                    Console.WriteLine($"ID: {genre.GenreId}, Nombre: {genre.GenreName}");
                }
            }

            var genreId = ConsoleExtensions.ReadInt("Ingrese el ID del genero:");

            var listaDeporte = servicioDeportes?.GetLista();
            Console.WriteLine("Deportes disponibles:");
            if (listaDeporte is not null)
            {
                foreach (var Sport in listaDeporte)
                {
                    Console.WriteLine($"ID: {Sport.SportId}, Nombre: {Sport.SportName}");
                }
            }

            var SportId = ConsoleExtensions.ReadInt("Ingrese el ID del Deporte:");

            var listacolores = servicioColores?.GetLista();
            Console.WriteLine("Colores disponibles:");
            if (listacolores is not null)
            {
                foreach (var Color in listacolores)
                {
                    Console.WriteLine($"ID: {Color.ColorId}, Nombre: {Color.ColorName}");
                }

            }
            var ColorId = ConsoleExtensions.ReadInt("Ingrese el ID del Color:");

            try
            {
                shoe.BrandId = BrandId;
                shoe.GenreId = genreId;
                shoe.SportId = SportId;
                shoe.ColorId = ColorId;

                servicioZapatos?.Guardar(shoe);
                Console.WriteLine("Zapato actualizado exitosamente");
                ConsoleExtensions.EsperaEnter();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        private static void BorrarZapatos()
        {
            var servicio = serviceProvider?.GetService<IShoeServicio>();
            Console.Clear();
            Console.WriteLine("Ingreso Zapato a borrar");
            ListaZapato();
            var listaChar = servicio?.GetLista().Select(s => s.ShoeId.ToString()).ToList();
            var ZapatoId = ConsoleExtensions.GetValidOptions("Ingrese un ID de Zapato:", listaChar);

            try
            {
                var shoe = servicio?.GetShoeId(Convert.ToInt32(ZapatoId));
                if (shoe != null)
                {
                    if (servicio != null)
                    {
                        servicio.Borrar(shoe);
                        Console.WriteLine("Registro borrado!");
                    }
                    else
                    {
                        throw new Exception("Servicio no disponible");
                    }
                }
                else
                {
                    Console.WriteLine("Zapato inexistente!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
            ConsoleExtensions.EsperaEnter();
        }

        private static void ListaZapato()
        {
            var servicio = serviceProvider?.GetService<IShoeServicio>();
            var listaZapato = servicio?.GetListaDto();
            Console.WriteLine("Listado de Zapato");

            var tabla = new ConsoleTable("ID", "Descripcion", "BrandName", "GenreName", "SportName", "ColorName", "Model", "Price");

            if (listaZapato != null)
            {
                foreach (ShoeListDto shoe in listaZapato)
                {
                    tabla.AddRow(shoe.ShoeId, shoe.Descripcion, shoe.BrandName, shoe.GenreName,
                        shoe.SportName, shoe.ColorName,
                        shoe.Model, shoe.Price);
                }
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
            Console.WriteLine($"Cantidad: {servicio?.GetCantidad()}");
        }

        private static void IngresarZapatos()
        {
            Console.Clear();
            var servicioZapatos = serviceProvider?.GetService<IShoeServicio>();
            var Zapato = CrearZapato();
            if (servicioZapatos != null)
            {
                if (!servicioZapatos.Existe(Zapato))
                {
                    servicioZapatos.Guardar(Zapato);
                    Console.WriteLine("Zapato Agregado!");
                }
                else
                {
                    Console.WriteLine("Registro Duplicado!");
                }
            }
            else
            {
                Console.WriteLine("El servicio de Zapato es nulo");
            }
            Thread.Sleep(2000);
        }

        private static Shoe CrearZapato()
        {
            var servicioBrand = serviceProvider?.GetService<IBrandServicio>();
            var servicioGenre = serviceProvider?.GetService<IGenreServicio>();
            var servicioSport = serviceProvider?.GetService<ISportServicio>();
            var servicioColor = serviceProvider?.GetService<IColorServicio>();

            Brand? brand;
            Genre? genre;
            Sport? sport;
            Color? color;

            Console.WriteLine("Agregar Nuevo Zapato");
            var descripcion = ConsoleExtensions.ReadString("Descripcion Zapato:");

            ListaDeBrand();
            var lista = servicioBrand?.GetLista()
             .Select(b => b.BrandId.ToString()).ToList();
            var BrandId = ConsoleExtensions.GetValidOptions("Seleccione una Marca (N para nueva):", lista);

            if (BrandId == "N")
            {
                BrandId = "0";
                Console.WriteLine("Ingreso de nueva Marca");
                var Descripcion = ConsoleExtensions.ReadString("Ingrese la Nueva Marca:");

                brand = new Brand()
                {
                    BrandId = 0,
                    BrandName = Descripcion
                };
            }
            else
            {
                brand = servicioBrand?.GetBrandId(Convert.ToInt32(BrandId));

            }

            ListaDeGenre();
            var listagenre = servicioGenre?.GetLista()
             .Select(g => g.GenreId.ToString()).ToList();
            var Genreid = ConsoleExtensions.GetValidOptions("Seleccione un Genero (N para nuevo):", listagenre);

            if (Genreid == "N")
            {
                Genreid = "0";
                Console.WriteLine("Ingreso de nuevo Genero");
                var DescripcionGenre = ConsoleExtensions.ReadString("Ingrese El Nuevo Genero:");

                genre = new Genre()
                {
                    GenreId = 0,
                    GenreName = DescripcionGenre
                };
            }
            else
            {
                genre = servicioGenre?.GetGenreId(Convert.ToInt32(Genreid));

            }

            ListaDeDeporte();
            var ListaSport = servicioSport?.GetLista()
             .Select(s => s.SportId.ToString()).ToList();

            var sportId = ConsoleExtensions.GetValidOptions("Seleccione un Deporte (N para nuevo):", ListaSport);

            if (sportId == "N")
            {
                sportId = "0";
                Console.WriteLine("Ingreso de nuevo Deporte");
                var DescripcionSport = ConsoleExtensions.ReadString("Ingrese El Nuevo Deporte:");

                sport = new Sport()
                {
                    SportId = 0,
                    SportName = DescripcionSport
                };
            }
            else
            {
                sport = servicioSport?.GetSportId(Convert.ToInt32(sportId));

            }


            ListaColor();
            var listaColor = servicioColor?.GetLista()
             .Select(c => c.ColorId.ToString()).ToList();

            var colorid = ConsoleExtensions.GetValidOptions("Seleccione un Color (N para nuevo):", lista);

            if (colorid == "N")
            {
                colorid = "0";
                Console.WriteLine("Ingreso de nuevo Color");
                var DescripcionColor = ConsoleExtensions.ReadString("Ingrese El Nuevo Color:");

                color = new Color()
                {
                    ColorId = 0,
                    ColorName = DescripcionColor
                };
            }
            else
            {
                color = servicioColor?.GetColorId(Convert.ToInt32(colorid));
            }
            var Modelo = ConsoleExtensions.ReadString("Ingrese un Modelo:");
            var precio = ConsoleExtensions.ReadDecimal("Ingrese el precio:", 10000, 100000);

            var Zapato = new Shoe()
            {
                Description = descripcion,
                BrandId = Convert.ToInt32(BrandId),
                GenreId = Convert.ToInt32(Genreid),
                SportId = Convert.ToInt32(sportId),
                ColorId = Convert.ToInt32(colorid),
                brand = brand,
                genre = genre,
                sport = sport,
                color = color,
                Model = Modelo,
                Price = precio,
            };
            return Zapato;

        }

        private static void ListadoDeZapatos()
        {
            Console.Clear();
            var servicio = serviceProvider?.GetService<IShoeServicio>();
            cantidadPorPagina = ConsoleExtensions.ReadInt("Ingrese la cantidad por pagina:", 5, 10);
            var Cantregistros = servicio?.GetCantidad() ?? 0;
            var Paginas = CalcularCantidadPaginas(Cantregistros, cantidadPorPagina);

            for (int pagina = 0; pagina < Paginas; pagina++)
            {
                Console.Clear();
                Console.WriteLine("Listado Paginado");
                Console.WriteLine($"Pagina: {pagina + 1}");
                var listaPaginadaShoe = servicio?.GetListaPaginada(pagina, cantidadPorPagina);
                mostrarShoe(listaPaginadaShoe);
            }
            Console.WriteLine("Fin del Listado");
        }

        private static void mostrarShoe(List<ShoeListDto>? listaPaginadaShoe)
        {
            var tabla = new ConsoleTable("ID", "Descripcion", "BrandName", "GenreName", "SportName", "ColorName", "Model", "Price");
            if (listaPaginadaShoe != null)
            {
                foreach (ShoeListDto shoe in listaPaginadaShoe)
                {
                    tabla.AddRow(shoe.ShoeId, shoe.Descripcion, shoe.BrandName, shoe.GenreName,
                        shoe.SportName, shoe.ColorName,
                        shoe.Model, shoe.Price);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();
                ConsoleExtensions.EsperaEnter();
            }
        }

        private static void EditarColor()
        {
            Console.Clear();
            Console.WriteLine("Ingreso Color a Editar");
            var TipoDescripcion = ConsoleExtensions.ReadString("Ingreso Nombre de Color:");

            try
            {
                var servicio = serviceProvider?.GetService<IColorServicio>();
                var Color = servicio?.GetColorPorNombre(TipoDescripcion);

                if (Color != null)
                {
                    Console.WriteLine($"Color:{Color.ColorName}");
                    var OtraDesc = ConsoleExtensions.ReadString("Ingrese el nuevo Nombre para el Color:");
                    Color.ColorName = OtraDesc;
                    if (servicio != null)
                    {
                        if (!servicio.Existe(Color))
                        {
                            servicio.Guardar(Color);
                            Console.WriteLine("Registro Modificado!!");
                        }
                        else
                        {
                            Console.WriteLine("Registro Duplicado");

                        }
                    }
                    else
                    {
                        throw new Exception("Servicio no disponible");

                    }
                }
                else
                {
                    Console.WriteLine("Registro Inexistente!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Thread.Sleep(5000);

        }

        private static void BorrarColor()
        {
            Console.Clear();
            Console.WriteLine("Ingreso de Color a Borrar");
            var TipoDescripcion = ConsoleExtensions.ReadString("Ingrese Descripcion del Color:");

            try
            {
                var servicio = serviceProvider?.GetService<IColorServicio>();

                var Color = servicio?.GetColorPorNombre(TipoDescripcion);
                if (Color != null)
                {
                    if (servicio != null)
                    {
                        if (!servicio.EstaRelacionado(Color))
                        {
                            servicio.Borrar(Color);
                            Console.WriteLine($"Color {Color.ColorName} borrado!");
                        }
                        else
                        {
                            Console.WriteLine("Registro Relacionado..Baja Denegada.");
                        }
                    }
                    else
                    {
                        throw new Exception("Servicio no disponible");
                    }
                }
                else
                {
                    Console.WriteLine("Color No Existe!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            Thread.Sleep(5000);

        }

        private static void IngresarColor()
        {
            Console.Clear();
            Console.WriteLine("ingreso un Color:");
            var NuevoColor = ConsoleExtensions.ReadString("Ingresar Un Nuevo Color:");
            var Color = new Color
            {
                ColorName = NuevoColor
            };
            try
            {
                var servicio = serviceProvider?.GetService<IColorServicio>();
                if (servicio != null)
                {
                    if (!servicio.Existe(Color))
                    {
                        servicio.Guardar(Color);
                        Console.WriteLine("Registro Agregado!");
                    }
                    else
                    {
                        Console.WriteLine("Registro Existe!");
                    }
                }
                else
                {
                    throw new Exception("Servicio no disponible");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Thread.Sleep(2000);
        }

        private static void ListadoDeColor()
        {
            Console.Clear();
            var servicio = serviceProvider?.GetService<IColorServicio>();
            cantidadPorPagina = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 5, 10);
            var Cantregistros = servicio?.GetCantidad() ?? 0;
            var Paginas = CalcularCantidadPaginas(Cantregistros, cantidadPorPagina);

            for (int pagina = 0; pagina < Paginas; pagina++)
            {
                Console.Clear();
                Console.WriteLine("Listado Paginado");
                Console.WriteLine($"Pagina: {pagina + 1}");
                var listaPaginadaColor = servicio?.GetListaPaginada(pagina, cantidadPorPagina);
                mostrarColor(listaPaginadaColor);
            }
            Console.WriteLine("Fin del Listado");
        }

        private static void mostrarColor(List<Color>? listaPaginadaColor)
        {
            var tabla = new ConsoleTable("ID", "ColorName");
            if (listaPaginadaColor != null)
            {
                foreach (Color color in listaPaginadaColor)
                {
                    tabla.AddRow(color.ColorId, color.ColorName);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();
                ConsoleExtensions.EsperaEnter();
            }
        }

        private static void EditarSport()
        {
            Console.Clear();
            Console.WriteLine("Ingreso Deporte a Editar");
            var TipoDescripcion = ConsoleExtensions.ReadString("Ingreso Nombre del Deporte:");

            try
            {
                var servicio = serviceProvider?.GetService<ISportServicio>();
                var Deporte = servicio?.GetSportPorNombre(TipoDescripcion);

                if (Deporte != null)
                {
                    Console.WriteLine($"Deporte:{Deporte.SportName}");
                    var OtraDesc = ConsoleExtensions.ReadString("Ingrese el nuevo Nombre para el Deporte:");
                    Deporte.SportName = OtraDesc;
                    if (servicio != null)
                    {
                        if (!servicio.Existe(Deporte))
                        {
                            servicio.Guardar(Deporte);
                            Console.WriteLine("Registro Modificado!");
                        }
                        else
                        {
                            Console.WriteLine("Registro Duplicado");

                        }
                    }
                    else
                    {
                        throw new Exception("Servicio no disponible");

                    }
                }
                else
                {
                    Console.WriteLine("Registro Inexistente!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Thread.Sleep(5000);

        }

        private static void BorrarSport()
        {
            Console.Clear();
            Console.WriteLine("Ingreso del Deporte a Borrar");
            var TipoDescripcion = ConsoleExtensions.ReadString("Ingrese Descripcion del Deporte:");

            try
            {
                var servicio = serviceProvider?.GetService<ISportServicio>();

                var Deporte = servicio?.GetSportPorNombre(TipoDescripcion);
                if (Deporte != null)
                {
                    if (servicio != null)
                    {
                        if (!servicio.EstaRelacionado(Deporte))
                        {
                            servicio.Borrar(Deporte);
                            Console.WriteLine($"Deporte {Deporte.SportName} borrado!");
                        }
                        else
                        {
                            Console.WriteLine("Registro Relacionado..Baja Denegada");
                        }
                    }
                    else
                    {
                        throw new Exception("Servicio no disponible");
                    }
                }
                else
                {
                    Console.WriteLine("Registro existente!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            Thread.Sleep(5000);
        }


        private static void IngresarSport()
        {
            Console.Clear();
            Console.WriteLine("ingreso un Deporte:");
            var NuevoDeporte = ConsoleExtensions.ReadString("Ingresar Un Nuevo Deporte:");
            var deporte = new Sport
            {
                SportName = NuevoDeporte
            };
            try
            {
                var servicio = serviceProvider?.GetService<ISportServicio>();
                if (servicio != null)
                {
                    if (!servicio.Existe(deporte))
                    {
                        servicio.Guardar(deporte);
                        Console.WriteLine("Registro Agregado!");
                    }
                    else
                    {
                        Console.WriteLine("Registro Existe!");
                    }
                }
                else
                {
                    throw new Exception("Servicio no disponible");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Thread.Sleep(2000);
        }

        private static void ListadoDeSport()
        {
            Console.Clear();
            var servicio = serviceProvider?.GetService<ISportServicio>();
            cantidadPorPagina = ConsoleExtensions.ReadInt("Ingrese la cantidad por pagina:", 5, 10);
            var Cantregistros = servicio?.GetCantidad() ?? 0;
            var Paginas = CalcularCantidadPaginas(Cantregistros, cantidadPorPagina);

            for (int pagina = 0; pagina < Paginas; pagina++)
            {
                Console.Clear();
                Console.WriteLine("Listado Paginado");
                Console.WriteLine($"Pagina: {pagina + 1}");
                var listaPaginadaSport = servicio?.GetListaPaginada(pagina, cantidadPorPagina);
                mostrarSport(listaPaginadaSport);
            }
            Console.WriteLine("Fin del Listado");
        }

        private static void mostrarSport(List<Sport>? listaPaginadaSport)
        {
            var tabla = new ConsoleTable("ID", "SportName");
            if (listaPaginadaSport != null)
            {
                foreach (Sport sport in listaPaginadaSport)
                {
                    tabla.AddRow(sport.SportId, sport.SportName);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();
                ConsoleExtensions.EsperaEnter();
            }
        }

        private static void EditarGenre()
        {
            Console.Clear();
            Console.WriteLine("Ingreso De Genero a Editar");
            var TipoDescripcion = ConsoleExtensions.ReadString("Ingreso Nombre del Genero:");

            try
            {
                var servicio = serviceProvider?.GetService<IGenreServicio>();
                var Genre = servicio?.GetGenrePorNombre(TipoDescripcion);

                if (Genre != null)
                {
                    Console.WriteLine($"Genre:{Genre.GenreName}");
                    var OtraDesc = ConsoleExtensions.ReadString("Ingrese el nuevo Nombre para el Genero:");
                    Genre.GenreName = OtraDesc;
                    if (servicio != null)
                    {
                        if (!servicio.Existe(Genre))
                        {
                            servicio.Guardar(Genre);
                            Console.WriteLine("Registro Modificado!");
                        }
                        else
                        {
                            Console.WriteLine("Registro Duplicado");

                        }
                    }
                    else
                    {
                        throw new Exception("Servicio no disponible");

                    }
                }
                else
                {
                    Console.WriteLine("Registro Inexistente!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Thread.Sleep(5000);

        }

        private static void BorrarGenre()
        {
            Console.Clear();
            Console.WriteLine("Ingreso de Genero a Borrar");
            var TipoDescripcion = ConsoleExtensions.ReadString("Ingrese Descripcion del Genero:");

            try
            {
                var servicio = serviceProvider?.GetService<IGenreServicio>();

                var Genre = servicio?.GetGenrePorNombre(TipoDescripcion);
                if (Genre != null)
                {
                    if (servicio != null)
                    {
                        if (!servicio.EstaRelacionado(Genre))
                        {
                            servicio.Borrar(Genre);
                            Console.WriteLine($"Genre {Genre.GenreName} borrado!");
                        }
                        else
                        {
                            Console.WriteLine("Registro Relacionado..Baja Denegada");
                        }
                    }
                    else
                    {
                        throw new Exception("Servicio no disponible");
                    }
                }
                else
                {
                    Console.WriteLine("Registro existente!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            Thread.Sleep(5000);

        }

        private static void IngresarGenre()
        {
            Console.Clear();
            Console.WriteLine("ingreso un Genero:");
            var NuevoGenre = ConsoleExtensions.ReadString("Ingresar Un Nuevo Genero:");
            var genre = new Genre
            {
                GenreName = NuevoGenre
            };
            try
            {
                var servicio = serviceProvider?.GetService<IGenreServicio>();
                if (servicio != null)
                {
                    if (!servicio.Existe(genre))
                    {
                        servicio.Guardar(genre);
                        Console.WriteLine("Registro Agregado!");
                    }
                    else
                    {
                        Console.WriteLine("Registro Existe!");
                    }
                }
                else
                {
                    throw new Exception("Servicio no disponible");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Thread.Sleep(2000);
        }

        private static void ListadoDeGenre()
        {
            Console.Clear();
            var servicio = serviceProvider?.GetService<IGenreServicio>();
            cantidadPorPagina = ConsoleExtensions.ReadInt("Ingrese la cantidad por pagina:", 5, 10);
            var Cantregistros = servicio?.GetCantidad() ?? 0;
            var Paginas = CalcularCantidadPaginas(Cantregistros, cantidadPorPagina);

            for (int pagina = 0; pagina < Paginas; pagina++)
            {
                Console.Clear();
                Console.WriteLine("Listado Paginado");
                Console.WriteLine($"Pagina: {pagina + 1}");
                var listaPaginadaGenre = servicio?.GetListaPaginada(pagina, cantidadPorPagina);
                mostrarGenre(listaPaginadaGenre);
            }
            Console.WriteLine("Fin del Listado");
        }

        private static void mostrarGenre(List<Genre>? listaPaginadaGenre)
        {
            var tabla = new ConsoleTable("ID", "GenreName");
            if (listaPaginadaGenre != null)
            {
                foreach (Genre genre in listaPaginadaGenre)
                {
                    tabla.AddRow(genre.GenreId, genre.GenreName);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();
                ConsoleExtensions.EsperaEnter();
            }
        }

        private static void BorrarBrand()
        {
            Console.Clear();
            Console.WriteLine("Borrar Marca");
            ListaDeBrand();
            var BrandId = ConsoleExtensions.ReadInt("Ingrese ID del Brand:");

            try
            {
                var servicio = serviceProvider?.GetService<IBrandServicio>();

                var Brand = servicio?.GetBrandId(BrandId);
                if (Brand != null)
                {
                    if (servicio != null)
                    {
                        if (!servicio.EstaRelacionado(Brand))
                        {
                            servicio.Borrar(Brand);
                            Console.WriteLine($"Brand {Brand.BrandName} borrado!");
                        }
                        else
                        {
                            Console.WriteLine("Registro Relacionado..Baja Denegada");
                        }
                    }
                    else
                    {
                        throw new Exception("Servicio no disponible");
                    }
                }
                else
                {
                    Console.WriteLine("Registro existente!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            Thread.Sleep(5000);
        }

        private static void EditarBrand()
        {
            Console.Clear();
            var servicio = serviceProvider?.GetService<IBrandServicio>();

            Console.WriteLine("Editar Marca");
            ListaDeBrand();
            var IdEditar = ConsoleExtensions.ReadInt("Ingrese Id a editar:");
            var BrandEnDb = servicio?.GetBrandId(IdEditar);
            if (BrandEnDb != null)
            {
                Console.WriteLine($"Descripcion anterior:{BrandEnDb.BrandName}");
                var NuevaDescripcion = ConsoleExtensions.ReadString("Ingrese el nuevo Nombre para la Marca:");
                BrandEnDb.BrandName = NuevaDescripcion;
                if (servicio != null)
                {
                    if (!servicio.Existe(BrandEnDb))
                    {
                        servicio.Guardar(BrandEnDb);
                        Console.WriteLine("Registro Modificado!");
                    }
                    else
                    {
                        Console.WriteLine("Registro Duplicado");

                    }
                }
                else
                {
                    throw new Exception("Servicio no disponible");

                }
            }
            else
            {
                Console.WriteLine("Registro Inexistente!");
            }

            Thread.Sleep(5000);
        }

        private static void IngresarBrand()
        {
            Console.Clear();
            Console.WriteLine("ingreso una marca:");
            var NuevaMarca = ConsoleExtensions.ReadString("Ingresar Una Nueva Marca:");
            var brand = new Brand
            {
                BrandName = NuevaMarca
            };
            try
            {
                var servicio = serviceProvider?.GetService<IBrandServicio>();
                if (servicio != null)
                {
                    if (!servicio.Existe(brand))
                    {
                        servicio.Guardar(brand);
                        Console.WriteLine("Registro Agregado!");
                    }
                    else
                    {
                        Console.WriteLine("Registro Existe!");
                    }
                }
                else
                {
                    throw new Exception("Servicio no disponible");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Thread.Sleep(2000);
        }

        private static void ListadoDeBrand()
        {
            Console.Clear();
            var servicio = serviceProvider?.GetService<IBrandServicio>();
            cantidadPorPagina = ConsoleExtensions.ReadInt("Ingrese la cantidad por pagina:", 5, 10);
            var Cantregistros = servicio?.GetCantidad() ?? 0;
            var Paginas = CalcularCantidadPaginas(Cantregistros, cantidadPorPagina);

            for (int pagina = 0; pagina < Paginas; pagina++)
            {
                Console.Clear();
                Console.WriteLine("Listado Paginado");
                Console.WriteLine($"Pagina: {pagina + 1}");
                var listaPaginada = servicio?.GetListaPaginada(pagina, cantidadPorPagina);
                MostrarBrand(listaPaginada);
            }
            Console.WriteLine("Fin del Listado");
        }

        private static void MostrarBrand(List<Brand>? listaPaginada)
        {
            var tabla = new ConsoleTable("ID", "BrandName");
            if (listaPaginada != null)
            {
                foreach (Brand brand in listaPaginada)
                {
                    tabla.AddRow(brand.BrandId, brand.BrandName);
                }
                tabla.Options.EnableCount = false;
                tabla.Write();
                ConsoleExtensions.EsperaEnter();
            }
        }

        private static int CalcularCantidadPaginas(int cantidadRegistros, int cantidadPorPagina)
        {
            if (cantidadRegistros < cantidadPorPagina)
            {
                return 1;
            }
            else if (cantidadRegistros % cantidadPorPagina == 0)
            {
                return cantidadRegistros / cantidadPorPagina;
            }
            else
            {
                return cantidadRegistros / cantidadPorPagina + 1;
            }
        }
    }

}
