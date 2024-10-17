using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInscripcionS9.Datos.Entidades
{
    internal class E_Postulante
    {
        public int NPostu {  get; set; }
        public String? NombreP { get; set; }
        public String? ApellidoP { get; set;}
        public String? TDocP { get; set; }
        public int DocP { get; set; }
    }
}
