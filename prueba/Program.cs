using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Dato;
namespace prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OracleDBConnection.TestConnection() ? "Conexión exitosa." : "Fallo en la conexión.");
            //Propietario prop = new Propietario()
            //{
            //    Cedula = 1234567890,
            //    Nombres = "Juan",
            //    ApellidoPaterno = "Pérez",
            //    ApellidoMaterno = "Gómez",
            //    Sexo = "M",
            //    Telefono = "0987654321",
            //    Email = "juan@gmail.com"
            //};

            Console.WriteLine(new DatoPropietario().Eliminar(1234567890));

            foreach (var propietario in new DatoPropietario().Consultar())
            {
                Console.WriteLine(propietario.ToString());
            }

            Console.ReadKey();
        }
    }
}
