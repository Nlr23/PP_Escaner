using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro : Documento
    {
        private int numPaginas;



        public Libro(int anio, string autor, string barcode, string numNormalizado, string titulo, int numPaginas) : base(anio, autor, barcode, numNormalizado, titulo)
        {
            this.numPaginas = numPaginas;
        }

        public int NumPaginas { get => numPaginas;}
        public string ISBN { get => NumNormalizado; }

        public static bool operator ==(Libro l1, Libro l2)
        {
            bool resultado = false;
            if( (l1.Barcode == l2.Barcode) || (l1.ISBN == l2.ISBN) || ( (l1.Titulo == l2.Titulo) && (l1.Autor == l2.Autor) ) )
            {
                resultado = true;
            }
            return resultado;
        }

        public static bool operator !=(Libro l1, Libro l2)
        {
            return !(l1 == l2);
        }

        public override string ToString()
        {
            StringBuilder infoLibro = new StringBuilder();
            infoLibro.AppendLine(base.ToString());
            infoLibro.AppendLine($"ISBN: {this.ISBN}");
            infoLibro.AppendLine($"Cód. de barras: {this.Barcode}");
            infoLibro.AppendLine($"Número de páginas: {this.NumPaginas}");
            return infoLibro.ToString();
        }
    }
}
