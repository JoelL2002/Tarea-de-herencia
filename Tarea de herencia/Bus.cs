using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_herencia
{
    internal class Bus : Carro
    {
        public int MAXVELOCIDADbus = 500; //porque asi los corren en mi pais
        private int puertatrasera = 0;
        private const int cantidadasientos = 12;
        private int pasajeros = 0;
        public Bus()
        {
            MAXVELOCIDAD = MAXVELOCIDADbus;
            Marca = "Rayo Mcqueen";
            Modelo = 2050;
            Color = "Rojo";
            Encendido = 0;
            this.velocidad_actual = 0;
        }

        public void acelerarplus()
        {

            if (Encendido == 1)
            {
                if (velocidad_actual < MAXVELOCIDAD)
                {
                    velocidad_actual += 50;
                    if (velocidad_actual > MAXVELOCIDAD)
                    {
                        velocidad_actual = velocidad_actual - (velocidad_actual - MAXVELOCIDAD);
                    }

                }
            }

        }

        public void abrirpuerta()
        {


            if (puertatrasera == 0)
            {
                puertatrasera = 1;
            }
        }

        public void cerrarpuerta()
        {

            if (puertatrasera == 1)
            {
                puertatrasera = 0;
            }

        }

        public string subirpasajeros()
        {
            string mensaje = "";

            if (pasajeros <= cantidadasientos)
            {
                pasajeros += 2;
                mensaje = $"Suban que aun hay asientos. Cantidad de pasajeros: {pasajeros}";

            }
            if (pasajeros > cantidadasientos)
            {
                pasajeros++;
                mensaje = $"En las llantas aun caben suban. Cantidad de pasajeros: {pasajeros}";

            }
            return mensaje;
        }
    }
}

