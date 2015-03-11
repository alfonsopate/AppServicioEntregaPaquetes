using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Packege
    {
        #region "Atributos"
        private string codigo;
        private string datosremitente = Personas;
        private string datosdestinaterio = Personas;
        private string peso_kg;
        private string costoenviogramos;

        #endregion
        #region "Propiedades"
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Datosremitente
        {
            get { return datosremitente; }
            set { datosremitente = value; }
        }

        public string Datosdestinaterio
        {
            get { return datosdestinaterio; }
            set { datosdestinaterio = value; }
        }

        public string Peso_kg
        {
            get { return peso_kg; }
            set { peso_kg = value; }
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
            this.datosremitente = "";
            this.datosdestinaterio = "";
            this.peso_kg = "000kg";
            this.costoenviogramos = "000";
        }

            public Packege(string codigo, string datosremitente, string datosdestinatario,  string peso_kg, string costoenviogramos)
            {
                this.codigo = codigo;
                this.datosremitente = datosremitente;
                this.datosdestinaterio = datosdestinaterio;      
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