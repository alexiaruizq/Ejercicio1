using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Enemigo
    {
        public string PosicionX {get;set;}
        public string PosicionY { get; set; }
        public bool Moverse { get; set; }
        public bool Disparar { get; set; }
        public bool Explotar { get; set; }
        private string _puntos;
        public string Puntos
        {
            get
            {
                return _puntos;
            }
            set
            {
                if (value.Length > 100)
                {
                    _puntos = value;
                }
                else
                {
                    throw new Exception("Error");
                }

            }
        }
    }




}
