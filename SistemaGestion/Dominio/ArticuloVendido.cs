using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ArticuloVendido
    {
        public int CodArt { get; set; }
        public string Marca { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public float PU { get; set; }
    }
}
