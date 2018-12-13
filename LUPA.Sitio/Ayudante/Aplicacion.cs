using System.Configuration;

namespace LUPA.Sitio
{
    public static class Aplicacion
    {
        static string _version;
        static string _nombreAplicacion;

        public static void Initialize()
        {
            _version = ConfigurationManager.AppSettings["version"];
            _nombreAplicacion = ConfigurationManager.AppSettings["nombreaplicacion"];
        }

        public static string Version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }

        public static string Nombre
        {
            get
            {
                return _nombreAplicacion;
            }
            set
            {
                _nombreAplicacion = value;
            }
        }

    }
}