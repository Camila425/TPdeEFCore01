namespace TPdeEFCore01.Windows.Helpers
{
    public static class FormHelper
    {
        public static int CalcularPaginas(int registros, int cantidadPorPagina)
        {
            if (registros < cantidadPorPagina)
            {
                return 1;
            }
            if (registros % cantidadPorPagina == 0)
            {

                return registros / cantidadPorPagina;
            }
            return registros / cantidadPorPagina + 1;
        }
    }
}
