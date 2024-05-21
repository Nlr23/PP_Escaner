using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mapa : Documento
    {
        private int alto;
        private int ancho;

        public int Alto { get => alto; }
        public int Ancho { get => ancho; }
        public int Superficie { get => (Ancho * Alto); }
        
        public Mapa(string titulo, string autor, int anio, string numNormalizado, string codebar, int ancho, int alto) : base(anio, autor, codebar, numNormalizado, titulo)
        {
            this.alto = alto;
            this.ancho = ancho;
        }

        public static bool operator ==(Mapa m1 , Mapa m2)
        {
            bool resultado = false;
            if( (m1.Barcode == m2.Barcode) || ( (m1.Titulo == m2.Titulo) && (m1.Autor == m2.Autor) && (m1.Anio == m2.Anio) && (m1.Superficie == m2.Superficie) ) )
            {
                resultado = true;
            }
            return resultado;
        }

        public static bool operator !=(Mapa m1, Mapa m2)
        {
            return !(m1 == m2);
        }

        public override string ToString()
        {
            StringBuilder infoMapa = new StringBuilder();
            infoMapa.AppendLine(base.ToString());
            infoMapa.AppendLine($"Cód de Barras: {this.Barcode}");
            infoMapa.AppendLine($"Superficie: {this.Alto} * {this.Ancho} = {this.Superficie} cm2");
            return infoMapa.ToString();
        }
    }
}
