using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Front.Sitio.Areas.Desa.Models
{
    public class Entidad
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public int edad { get; set; }

        public string email { get; set; }
    }
}