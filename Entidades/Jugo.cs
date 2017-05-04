using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo:Producto
    {
        protected ESaborJugo _sabor;

        public Jugo(int codigo, EMarcaProducto marca, float precio, ESaborJugo sabor)
            : base(codigo,marca,precio)
        {
            this._sabor = sabor;
        }

        public string MostrarJugo()
        {
            StringBuilder sb = new StringBuilder();
            //sb.Append("" + base._codigoBarra);
            //sb.Append("" + base.Marca);
            //sb.Append("" + base.Precio);
            sb.Append("" + this._sabor); //AppendLine ??

            return Producto.MostrarProducto(this) + sb.ToString();
        }



    }
}
