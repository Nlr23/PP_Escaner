using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Escaner
    {
        private List<Documento> listaDocumentos;
        private Departamento locacion;
        private string marca;
        private TipoDoc tipo;

        public enum Departamento
        {
            nulo,
            mapoteca,
            procesosTecnicos
        }

        public enum TipoDoc
        {
            libro,
            mapa
        }




        public List<Documento> ListaDocumentos { get => listaDocumentos; }
        public Departamento Locacion { get => locacion; }
        public string Marca { get => marca; }
        public TipoDoc Tipo { get => tipo; }

        public Escaner(string marca, TipoDoc tipo)
        {
           this.marca = marca;
           this.tipo = tipo;
            if(tipo == TipoDoc.libro)
            {
                this.locacion = Departamento.procesosTecnicos;
            }
            else if(tipo == TipoDoc.mapa)
            {
                this.locacion = Departamento.mapoteca;
            }
           listaDocumentos = new List<Documento>();
        }

        public bool CambiarEstadoDocumento(Documento d)
        {
            bool resultado = false;
            // El método “CambiarEstadoDocumento()” cámbiará el estado del documento de dentro de la lista de documentos
            if (listaDocumentos.Contains(d) && listaDocumentos != null)
            {
                resultado = d.AvanzarEstado();
            }
            return resultado;
        }

        public static bool operator +(Escaner e, Documento d)
        {
            bool resultado = false;
            //La sobrecarga del operador “+” añade el documento a la lista de documentos en el
            //caso de que no haya un documento igual ya en ella.También debe añadirlo solo si
            //está en estado “Inicio”. Antes de añadirlo a la lista debe cambiar el estado a “Distribuido”.
            //if(!e.ListaDocumentos.Contains(d) && d.Estado == Paso.Inicio)
            if(!(e==d) && d.Estado == Paso.Inicio)
            {
                resultado = d.AvanzarEstado();
                e.listaDocumentos.Add(d);
            }
            return resultado;
        }

        public static bool operator ==(Escaner e, Documento d)
        {
            bool resultado = false;
            //La sobrecarga del operador “==” comprueba si hay un documento igual en la lista. Devuelve true si encuentra, false si no
            if (e.listaDocumentos.Contains(d))
            {
                resultado = true;
            }
            return resultado;
        }

        public static bool operator !=(Escaner e, Documento d)
        {
            return !(e == d);
        }
    }
}
