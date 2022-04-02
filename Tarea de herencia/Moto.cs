using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_herencia
{
    internal class Moto : Carro
    {
        public int MAXVELOCIDADmoto = 180;

        //jaja solo le puse modo diablo porque no sabia que agregarle jaja :(
        public int mododiablo = 0;

        public Moto()
        {
            MAXVELOCIDAD = MAXVELOCIDADmoto;
            Marca = "Honda";
            Modelo = 2023;
            Color = "Rojo";
            Encendido = 0;
            this.velocidad_actual = 0;
        }

        public void frenaradelante()
        {
            if (Encendido == 1)
            {
                velocidad_actual = 0;

            }
        }

        public void frenaratras()
        {

            if (Encendido == 1)
            {
                velocidad_actual = 0;
            }

        }

        public void modosatanas()
        {

            if (Encendido == 1 && mododiablo == 0)
            {
                mododiablo = 1;
                MAXVELOCIDAD = MAXVELOCIDADmoto *= 2;
            }

        }

        public void modonormal()
        {

            if (Encendido == 1 && mododiablo == 1)
            {

                mododiablo = 0;
                MAXVELOCIDAD = MAXVELOCIDADmoto = 180;
                velocidad_actual = 180;

            }

        }
    }
}


