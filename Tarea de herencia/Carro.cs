﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_herencia
{
    internal class Carro
    {
        public string Marca { get; set; }
        public int Modelo { get; set; }
        public String Color { get; set; }

        public int MAXVELOCIDAD { get; set; }

        public int Encendido = 0;
        public int velocidad_actual = 0;




        public Carro()
        {
            Marca = "Toyota";
            Modelo = 2021;
            Color = "Negro";
            MAXVELOCIDAD = 160;
            Encendido = 0;
            this.velocidad_actual = 0;

        }


        public string acelerar()
        {
            string mensaje = "";
            if (Encendido == 1)
            {
                if (velocidad_actual < MAXVELOCIDAD)
                {
                    velocidad_actual += 20;
                    if (velocidad_actual > MAXVELOCIDAD)
                    {
                        velocidad_actual = velocidad_actual - (velocidad_actual - MAXVELOCIDAD);
                        mensaje = $"{velocidad_actual}KPH";
                    }
                    mensaje = $"{velocidad_actual}KPH";
                }
            }

            return mensaje;

        }

        public string desacelerar()
        {
            string mensaje = "";
            if (Encendido == 1)
            {
                if (velocidad_actual != 0)
                {
                    velocidad_actual -= 20;
                    mensaje = $"{velocidad_actual}KPH";
                }
            }
            return mensaje;
        }

        public string Frenar()
        {
            string mensaje = "";
            velocidad_actual = 0;
            mensaje = $"{velocidad_actual}KPH";
            return mensaje;
        }

        public string Bocinar()
        {
            //no sabia como hacer que bocine jajaja por eso le puse esto
            string mensaje = "Piiiii piiii\n";
            return mensaje;
        }
        public int GetVelocidadActual()
        {
            return velocidad_actual;
        }


        public void EncenderMotor()
        {
            if (Encendido == 0)
            {
                Encendido = 1;
                velocidad_actual = 0;
            }
        }
        public void Apagarmotor()
        {
            if (Encendido == 1)
            {
                Encendido = 0;
                velocidad_actual = 0;
            }
        }

    }
}



