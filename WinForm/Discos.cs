using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    class Disco
    {
        //public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public int CantCanciones { get; set; }
        public string UrlImagen { get; set; }
        public Estilo Estilo { get; set; }
        public Estilo TipoEdicion { get; set; }
    }
}
