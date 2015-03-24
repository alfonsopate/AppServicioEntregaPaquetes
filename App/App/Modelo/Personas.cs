using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Personas
    {
        private string nombre;
        private string direccion;
        private string ciudad;
        private string departamento;
        private string codigopostal;



        #region "Propiedades"
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public string Departemento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        public string Codigopostal
        {
            get { return codigopostal; }
            set { codigopostal = value; }
        }
        
        #endregion

         #region "Constructores"

        public Personas ()
        {
            
            this.nombre = "";
            this.direccion = "kr00b#00-00";
            this.ciudad = "";
            this.departamento = "";
            this.codigopostal = "tt000t000";
            
        }

            public Personas(string nombre, string direccion, string cuidad, string departemento,
                           string codigopostal)
            {
              
                this.nombre = nombre;
                this.direccion = direccion;
                this.ciudad = cuidad;
                this.departamento = departemento;
                this.codigopostal = codigopostal;
               
            }
         #endregion

            #region "Constructores"

            public Personas()
            {

                this.nombre = "";
                this.direccion = "kr00b#00-00";
                this.ciudad = "";
                this.departamento = "";
                this.codigopostal = "tt000t000";

            }

            public Personas(string nombre, string direccion, string cuidad, string departemento,
                           string codigopostal)
            {

                this.nombre = nombre;
                this.direccion = direccion;
                this.ciudad = cuidad;
                this.departamento = departemento;
                this.codigopostal = codigopostal;

            }
            #endregion
        
    }
}