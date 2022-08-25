using Estacionamiento_C.Models;

namespace Estacionamiento_C.TestsEnClase
{
    public static class MainTest
    {
        //int numero = 4;
        //Direccion direccion = new Direccion() { Calle = "Cordoba", Numero = 2222 };

        //Console.WriteLine(numero);
        //    Console.WriteLine(direccion.Calle);


        //    ModificarDireccion(direccion);
        //ModificarNumero(numero);

        //Console.WriteLine(numero);
        //    Console.WriteLine(direccion.Calle);

        //            private static void ModificarDireccion(Direccion direccion)
        //{
        //    direccion.Calle = "Corrientes";
        //}

        //private static void ModificarNumero(int numero)
        //{
        //    numero = 6;
        //}


        public static void TestHerencia()
        {
            Persona persona = new Persona();    
            Cliente cliente = new Cliente();
            Empleado empleado = new Empleado();

            cliente.Nombre = "Pedro";

            cliente.Direccion.Calle = "Cordoba";


        }

    }



}
