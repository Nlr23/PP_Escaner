using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Informes
    {
        public static void MostrarDistribuidos(Escaner e, out int extension, out int cantidad, out string resumen) 
        {
            
        }
        private static void MostrarDocumentosPorEstado(Escaner e, Paso estado, out int extension, out int cantidad, out string resumen) { }
        public static void MostrarEnEscaner(Escaner e, out int extension, out int cantidad, out string resumen) { }
        public static void MostrarEnRevision(Escaner e, out int extension, out int cantidad, out string resumen) { }
        public static void MostrarTerminados(Escaner e, out int extension, out int cantidad, out string resumen) { }

        /*
         *  Cada uno de los informes públicos devolverá, dado un escáner y un estado en el que deban
            encontrarse los documentos tenidos en cuenta, los siguientes datos:
            - extensión: el total de la extensión de lo procesado según el escáner y el estado. Es
            decir, el total de páginas en el caso de los libros y el total de cm2 en el caso de los
             mapas.
            - cantidad: el número total de ítems únicos procesados según el escáner y el estado.
            - resumen: se muestran los datos de cada uno de los ítems contenidos en una lista
            según el escáner y el estado.
        */
    }
}
