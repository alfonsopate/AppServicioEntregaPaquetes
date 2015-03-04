using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Packege
    {
        private string codigo;
        private string nombre;
        private string direccion;
        private string ciudad;
        private string departamento;
        private string codigopostalR;
        private string codigopostalD;
        private string peso_kg;
        private string costoenviogramos;

        #region "Propiedades"
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

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
        public string Departemento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        public string CodigopostalR
        {
            get { return codigopostalR; }
            set { codigopostalR = value; }
        }
        public string CodigopostalD
        {
            get { return codigopostalD; }
            set { codigopostalD = value; }
        }
        public string Costoenviogramos
        {
            get { return costoenviogramos; }
            set { costoenviogramos = value; }
        }
        #endregion

        #region "Constructores"

        public Packege ()
        {
            this.codigo = "000000";
            this.nombre = "";
            this.direccion = "kr00b#00-00";
            this.ciudad = "";
            this.departamento = "";
            this.codigopostalR = "tt000t000";
            this.codigopostalD = "tt000t000";
            this.peso_kg = "000kg";
            this.costoenviogramos = "000";
        }

            public Packege(string codigo, string nombre, string direccion, string cuidad, string departemento,
                           string codigopostalR, string codigopostalD, string peso_kg, string costoenviogramos)
            {
                this.codigo = codigo;
                this.nombre = nombre;
                this.direccion = direccion;
                this.ciudad = cuidad;
                this.departamento = departemento;
                this.codigopostalR = codigopostalR;
                this.codigopostalD = codigopostalD;
                this.peso_kg = peso_kg;
                this.costoenviogramos = costoenviogramos;
            }
         #endregion

            public override string ToString()
            {
                return "\n=============================================\n" +
                         "Codigo:  " + this.codigo+ "\n" +
                         "Nombres:  " + this.nombre + "\n" +
                         "Direccion:  " + this.direccion + "\n" +
                         "Ciudad:" + this.ciudad + "\n" +
                         "Departemento:" + this.departamento+ "\n" +
                         " Codigo postalR:" + this.codigopostalR + "\n" +
                         "Codigo postal des:" + this.codigopostalD + "\n"+
                         "Peso kg" + this.peso_kg + "\n"+ 
                         "Costa envio aquetes" + this.costoenviogramos;
            }
    }
}