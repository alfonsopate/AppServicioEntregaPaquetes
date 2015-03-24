using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class TwoDayPackage: Packege
    {
        string cuotafija;

        public string Cuotafija
        {
            get { return cuotafija; }
            set { cuotafija = value; }
        }

         #region "Constructores"

        public TwoDayPackage ()
        {
            this.cuotafija = "00000";

        }

            public TwoDayPackage (string cuotafija, string codigopostalR, string codigopostalD, string peso_kg, string costoenviogramos)
            {
                this.cuotafija = cuotafija;
                this.;
            }
         #endregion
    }
}