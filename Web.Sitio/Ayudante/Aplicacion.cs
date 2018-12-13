using System.Configuration;

namespace Front.Sitio
{
    public static class Aplicacion
    {
        static string _version;
        static string _ambienteApp;
        static string _nombreAplicacion;
        
        public static void Initialize()
        {
            _version = ConfigurationManager.AppSettings["version"];
            _ambienteApp = ConfigurationManager.AppSettings["ambiente"];
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

        public static string Ambiente
        {
            get
            {
                return _ambienteApp;
            }
            set
            {
                _ambienteApp = value;
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