using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;

        public Producto(int codigo, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigo;
            this._marca = marca;
            this._precio = precio;
        }

        /* Propiedades. */

        /// <summary>
        /// Retorna solo el valor contenido en el atributo marca.
        /// </summary>
        public EMarcaProducto Marca
        {
            get { return this._marca; }
            //set { myVar = value; }
        }

        /// <summary>
        /// Retorna el valor contenido en el atributo precio.
        /// </summary>
        public float Precio
        {
            get { return this._precio; }
            //set { myVar = value; }
        }
        
        /* Método de clase. */

        /// <summary>
        /// Retorna una cadena detallando los atributos de la clase.
        /// </summary>
        /// <param name="prod"></param>
        /// <returns></returns>
        protected static string MostrarProducto(Producto prod)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Codigo de Barra: " + prod._codigoBarra);
            sb.Append("Marca: " + prod._marca);
            sb.Append("Precio Unitario: " + prod._precio);

            return sb.ToString();
        }

        /* Operadores. */

         /* == */
        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1._codigoBarra == p2._codigoBarra && p1._marca == p2._marca;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }


        public static bool operator ==(Producto p1, EMarcaProducto marca)
        {
            return p1._marca == marca;
        }

        public static bool operator !=(Producto p1, EMarcaProducto marca)
        {
            return !(p1 == marca);
        }

        public static explicit operator int(Producto prod)
        {
            return prod._codigoBarra;
        }


    }
}
