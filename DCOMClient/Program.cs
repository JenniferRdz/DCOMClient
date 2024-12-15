using System;
using System.Runtime.InteropServices;

namespace DCOMClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Crear una instancia del servidor DCOM
                Type serverType = Type.GetTypeFromProgID("DCOMServer.ServerClass");

                if (serverType == null)
                {
                    Console.WriteLine("No se pudo encontrar el servidor DCOM.");
                    return;
                }

                dynamic serverInstance = Activator.CreateInstance(serverType);

                // Llamar a un método del servidor
                string message = serverInstance.GetMessage();
                Console.WriteLine("Mensaje desde el servidor DCOM: " + message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar con el servidor DCOM: " + ex.Message);
            }

            Console.ReadLine(); // Espera entrada del usuario
        }
    }
}
