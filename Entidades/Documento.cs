using System.Text;

namespace Entidades
{

    public enum Paso
    {
        Inicio,
        Distribuido,
        EnEscaner,
        EnRevision,
        Terminado
    }

    public abstract class Documento
    {
        private int anio;
        private string autor;
        private string barcode;
        private string numNormalizado;
        private string titulo;
        private Paso estado;

        public Documento(int anio, string autor, string barcode, string numNormalizado, string titulo)
        {
            this.anio = anio;
            this.autor = autor;
            this.barcode = barcode;
            this.numNormalizado = numNormalizado;
            this.titulo = titulo;
            this.estado = Paso.Inicio;
        }

        public int Anio { get => anio; }
        public string Autor { get => autor; }
        public string Barcode { get => barcode; }
        public Paso Estado { get => estado; }
        public string Titulo { get => titulo;}
        protected string NumNormalizado { get => numNormalizado; }

        public bool AvanzarEstado()
        {
            bool resultado = false;
            if( this.Estado != Paso.Terminado )
            {
                switch( this.Estado )
                {
                    case Paso.Inicio:
                        this.estado = Paso.Distribuido;
                        resultado = true; break;
                    case Paso.Distribuido:
                        this.estado = Paso.EnEscaner;
                        resultado = true; break;
                    case Paso.EnEscaner:
                        this.estado = Paso.EnRevision;
                        resultado = true; break;
                    case Paso.EnRevision:
                        this.estado = Paso.Terminado;
                        resultado = true; break;
                }
            }
            return resultado;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine($"Titulo: {Titulo}");
            info.AppendLine($"Autor: {Autor}");
            info.AppendLine($"Año: {Anio}");
            return info.ToString();
        }

    }
}
