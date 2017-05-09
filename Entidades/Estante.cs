using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        
        //public float ValorEstanteTotal
        //{
        //    get { return myVar; }
        //    //set { myVar = value; }
        //}

        private Estante()
        {
            _productos = new List<Producto>();
        }

        public Estante(sbyte capacidad):this()
        {
            this._capacidad = capacidad;
        }

        public List<Producto> GetProductos()
        {
            return this._productos;
        }

        public static string MostrarEstante(Estante est)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("Capacidad: " + est._capacidad);
            builder.Append("Listado de Productos");

            foreach (Producto item in est._productos)
            {
                if (item is Galletita)
                {
                    builder.AppendLine(Galletita.MostrarGalletita( ((Galletita)item)) );
                }

                if (item is Jugo)
                {
                    builder.AppendLine( ((Jugo)item).MostrarJugo() );
                }

                if (item is Gaseosa)
                {
                    builder.AppendLine( ((Gaseosa)item).MostrarGaseosa() );
                }

            }

            return builder.ToString();
        }

        /////////// SOBRECARGA OPERADORES ///////////////

        public static bool operator ==(Estante est, Producto prod)
        {
            foreach (Producto item in est._productos)
            {
                if (item == prod)
                    return true;                
            }

            return false;
        }

       public static bool operator !=(Estante est, Producto prod)
        {
            return !(est == prod);
        }

        public static bool operator +(Estante est, Producto prod)
        {
            if (est._productos.Count < est._capacidad)
            {
                if (est != prod)
                    return true;      //est._productos.Add(prod) ?
            }

            return false;
        }

        public static Estante operator -(Estante est, Producto prod)
        {
            if (est == prod)
                est._productos.Remove(prod);

            return est;
        }

        public static Estante operator -(Estante est, ETipoProducto tipo)
        {

            switch (tipo)   
            {
                case ETipoProducto.Galletita:
                    
                    break;
                case ETipoProducto.Gaseosa:
                    break;
                case ETipoProducto.Jugo:
                    break;
                case ETipoProducto.Todos:
                    break;
                default:
                    break;
            }
        }

    }
}
