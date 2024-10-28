using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dominio
{
    public class Articulo
    {
        [DisplayName("Código")]
        public int CodigoArticulo { get; set; }
        [DisplayName("Articulo")]
        public string Articulos { get; set; }
        [DisplayName("Descripción")]
        public string TipoDeArticulo { get; set; }
        [DisplayName("Stock")]
        public int CantidadDeArticulos { get; set; }
        [DisplayName("Stock Minimo")]
        public int CantidadMinima { get; set; }
        [DisplayName("PU")]
        public float PrecioVenta { get; set; }
        [DisplayName("PU (De Lista)")]
        public float PrecioCompra { get; set; }
        public Marca Marcas { get; set; }

        public Categoria Categoria { get; set; }

        public int IDMarca { get; set; }
        public int IDCategoria { get; set; }
    }
}
