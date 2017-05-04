using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita:Producto
    {
        protected float _peso;

        public Galletita(int codigo, float precio, EMarcaProducto marca, float peso):base(codigo,marca,precio)
        {
            this._peso = peso;
        }

        public static string MostrarGalletita(Galletita galleta)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Peso: " + galleta._peso);

            return Producto.MostrarProducto(galleta) + sb.ToString();
        }





    }
}
