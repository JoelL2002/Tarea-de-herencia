using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_herencia
{
    internal class Grua : Carro
    {
        private int gancho = 0;
        private int MAXVELOCIDADgrua = 60;
        private int objetotomado = 0;

        public Grua()
        {
            MAXVELOCIDAD = MAXVELOCIDADgrua;
            Marca = "CAT";
            Modelo = 2018;
            Color = "Amarillo";
            Encendido = 0;
            this.velocidad_actual = 0;
        }

        public void activargrua()
        {

            if (Encendido == 1 && gancho == 0)
            {
                gancho = 1;
            }

        }

        public void desactivargrua()
        {

            if (Encendido == 1 && gancho == 1)
            {
                gancho = 0;

            }

        }

        public void tomaralgo()
        {

            if (Encendido == 1 && gancho == 1 && objetotomado == 0)
            {
                objetotomado = 1;
            }

        }

        public void soltar()
        {

            if (Encendido == 1 && gancho == 1 && objetotomado == 1)
            {
                objetotomado = 0;

            }

        }

    }
}
