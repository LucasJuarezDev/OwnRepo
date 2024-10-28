using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
        public List<Articulo> ArticulosVendidos { get; set; }
        public bool MetodoDePago { get; set; }
        public string DescripcionDePago { get; set; }
        public Articulo VentaArticulo { get; set; }
        public int IDGlobalVentas { get; set; }
        public DateTime FechaVenta
        {
            get { return DateTime.Now; }
        }
        public DateTime FechaReporte { get; set; }

        public Venta()
        {
            ArticulosVendidos = new List<Articulo>();
        }


    }
}
