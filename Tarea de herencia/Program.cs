using Tarea_herencia;


static void ejecutarcarro()
{
    Console.Clear();
    Carro carro = new Carro();

    Console.WriteLine($"Marca: {carro.Marca}  Modelo: {carro.Modelo}  Color: {carro.Color} \n\n");

    int opcion;
    Console.WriteLine("Seleccione que es lo que desea hacer\n");
    Console.WriteLine("1. Encender el motor\n" + "2. Apagar el motor\n" + "3. Acelerar\n" + "4. Desacelerar\n" + "5. Frenar\n" + "6. Bocinar\n");
    Console.WriteLine("Si desea acelerar, primero debera encender el motor y si desea desacelerar debera haber acelerado primero");
    do
    {
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                {
                    carro.EncenderMotor();
                    Console.WriteLine($"El carro esta encendido velocidad actual: {carro.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 2:
                {
                    carro.Apagarmotor();

                    Console.WriteLine("El carro se ha apagado");
                    elcomienzo();
                }
                break;

            case 3:
                {
                    carro.acelerar();
                    Console.WriteLine($"Velocidad actual: {carro.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 4:
                {
                    carro.desacelerar();
                    Console.WriteLine($"Velocidad actual: {carro.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 5:
                {
                    carro.Frenar();
                    Console.WriteLine($"Velocidad actual: {carro.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 6:
                {
                    Console.WriteLine(carro.Bocinar());
                    opcion = 0;
                }
                break;
        }

    } while (opcion < 6);
    if (opcion >= 6)
    {
        Console.WriteLine("La opcion esta fuera de rango");
        opcion = 0;
    }
}
static void ejecutarmoto()
{
    Console.Clear();
    Moto moto = new Moto();

    Console.WriteLine($"Marca: {moto.Marca}  Modelo: {moto.Modelo}  Color: {moto.Color} \n\n");

    int opcion;
    Console.WriteLine("Seleccione que es lo que desea hacer\n");
    Console.WriteLine("1. Encender el motor\n" + "2. Apagar el motor\n" + "3. Acelerar\n" + "4. Desacelerar\n" + "5. Freno delantero\n"
                    + "6. Freno traero\n" + "7. Bocinar\n" + "8. Modo diablo >:)\n" + "9. Modo normal\n");
    Console.WriteLine("Si desea realizar alguna funcion primero debera encender el motor");
    do
    {
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                {
                    moto.EncenderMotor();
                    Console.WriteLine($"La moto esta encendida velocidad actual: {moto.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 2:
                {
                    moto.Apagarmotor();

                    Console.WriteLine("La moto se ha apagado\n");
                    elcomienzo();
                }
                break;

            case 3:
                {
                    moto.acelerar();
                    Console.WriteLine($"Velocidad actual: {moto.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 4:
                {
                    moto.desacelerar();
                    Console.WriteLine($"Velocidad actual: {moto.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 5:
                {
                    moto.frenaradelante();
                    Console.WriteLine("Ha frenado con el freno delantero, mas cuidado que se puede ir de frente\n" + $"Velocidad actual: {moto.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 6:
                {
                    moto.frenaratras();
                    Console.WriteLine($"Ha frenado con el freno trasero. Velocidad actual: {moto.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 7:
                {
                    Console.WriteLine(moto.Bocinar());
                    opcion = 0;
                }
                break;

            case 8:
                {
                    moto.modosatanas();
                    Console.WriteLine($"Ha duplicado su limite de velocidad Limite e velocidad actual = {moto.MAXVELOCIDADmoto}");
                    opcion = 0;
                }
                break;

            case 9:
                {
                    moto.modonormal();
                    Console.WriteLine($"Ha cambiado al modo normal su velocidad de ha reducido a: {moto.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;
        }

    } while (opcion < 10);
    if (opcion >= 10)
    {
        Console.WriteLine("La opcion esta fuera de rango");
        opcion = 0;
    }
}
static void ejecutarbus()
{
    Console.Clear();
    Bus bus = new Bus();

    Console.WriteLine($"Marca: {bus.Marca}  Modelo: {bus.Modelo}  Color: {bus.Color} \n\n");

    int opcion;
    Console.WriteLine("Seleccione que es lo que desea hacer\n");
    Console.WriteLine("1. Encender el motor\n" + "2. Apagar el motor\n" + "3. Acelerar\n" + "4. Desacelerar\n" + "5. Frenar\n"
                    + "6. Acelerar plus\n" + "7. Bocinar\n" + "8. Abrir puerta trasera\n" + "9. Cerrar puerta trasera\n" + "10. Subir pasajeros\n");
    Console.WriteLine("Si desea realizar alguna funcion primero debera encender el motor, excepto subir pasajeros o abrir/cerrar la puerta trasera");
    do
    {
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                {
                    bus.EncenderMotor();
                    Console.WriteLine($"El bus esta encendida velocidad actual: {bus.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 2:
                {
                    bus.Apagarmotor();

                    Console.WriteLine("El bus se ha apagado\n");
                    elcomienzo();
                }
                break;

            case 3:
                {
                    bus.acelerar();
                    Console.WriteLine($"Velocidad actual: {bus.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 4:
                {
                    bus.desacelerar();
                    Console.WriteLine($"Velocidad actual: {bus.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 5:
                {
                    bus.Frenar();
                    Console.WriteLine($"Velocidad actual: {bus.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 6:
                {

                    bus.acelerarplus();
                    Console.WriteLine($"Velocidad actual: {bus.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 7:
                {
                    Console.WriteLine(bus.Bocinar());
                    opcion = 0;
                }
                break;

            case 8:
                {
                    bus.abrirpuerta();
                    Console.WriteLine("La puerta se ha abierto");

                    opcion = 0;
                }
                break;

            case 9:
                {
                    bus.cerrarpuerta();
                    Console.WriteLine("La puerta se ha cerrado");
                    opcion = 0;
                }
                break;
            case 10:
                {
                    bus.subirpasajeros();
                    Console.WriteLine(bus.subirpasajeros());
                    opcion = 0;
                }
                break;
        }

    } while (opcion < 11);
    if (opcion >= 11)
    {
        Console.WriteLine("La opcion esta fuera de rango");
        opcion = 0;
    }
}
static void ejecutargrua()
{
    Console.Clear();
    Grua grua = new Grua();

    Console.WriteLine($"Marca: {grua.Marca}  Modelo: {grua.Modelo}  Color: {grua.Color} \n\n");

    int opcion;
    Console.WriteLine("Seleccione que es lo que desea hacer\n");
    Console.WriteLine("1. Encender el motor\n" + "2. Apagar el motor\n" + "3. Acelerar\n" + "4. Desacelerar\n" + "5. Frenar\n"
                    + "6. Activar grua\n" + "7. Bocinar\n" + "8. Desactivar grua\n" + "9. Tomar un objeto con la grua\n" + "10. Soltar el objeto\n");
    Console.WriteLine("Si desea realizar alguna funcion primero debera encender el motor");
    do
    {
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                {
                    grua.EncenderMotor();
                    Console.WriteLine($"La maquina de grua esta encendida velocidad actual: {grua.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 2:
                {
                    grua.Apagarmotor();

                    Console.WriteLine("La maquina de grua se ha apagado\n");
                    elcomienzo();
                }
                break;

            case 3:
                {
                    grua.acelerar();
                    Console.WriteLine($"Velocidad actual: {grua.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 4:
                {
                    grua.desacelerar();
                    Console.WriteLine($"Velocidad actual: {grua.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 5:
                {
                    grua.Frenar();
                    Console.WriteLine($"Velocidad actual: {grua.GetVelocidadActual()}KPH");
                    opcion = 0;
                }
                break;

            case 6:
                {
                    grua.activargrua();
                    Console.WriteLine("La grua se ha activado");
                    opcion = 0;
                }
                break;

            case 7:
                {
                    Console.WriteLine(grua.Bocinar());
                    opcion = 0;
                }
                break;

            case 8:
                {
                    grua.desactivargrua();
                    Console.WriteLine("La grua se ha desactivado");
                    opcion = 0;
                }
                break;

            case 9:
                {
                    grua.tomaralgo();
                    Console.WriteLine("La grua ha tomado un objeto");
                    opcion = 0;
                }
                break;

            case 10:
                {
                    grua.soltar();
                    Console.WriteLine("La grua ha soltado lo que habia tomado");
                    opcion = 0;
                }
                break;
        }

    } while (opcion < 11);
    if (opcion >= 11)
    {
        Console.WriteLine("La opcion esta fuera de rango");
        opcion = 0;
    }
}


static void elcomienzo()
{
    int tipovehiculo;
    Console.WriteLine("Que vehiculo desea utilizar?\n");
    Console.WriteLine("1. Carro\n" + "2. Moto\n" + "3. Bus\n" + "4. Grua\n");
    tipovehiculo = int.Parse(Console.ReadLine());

    switch (tipovehiculo)
    {
        case 1:
            {
                ejecutarcarro();
            }
            break;
        case 2:
            {
                ejecutarmoto();
            }
            break;
        case 3:
            {
                ejecutarbus();
            }
            break;
        case 4:
            {
                ejecutargrua();
            }
            break;

    }
}

elcomienzo();
