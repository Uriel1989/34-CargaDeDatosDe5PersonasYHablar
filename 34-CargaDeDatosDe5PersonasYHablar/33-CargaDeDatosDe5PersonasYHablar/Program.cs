using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _33_CargaDeDatosDe5PersonasYHablar
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();

            p1.Nombre = "Uriel";
            p1.Apellido = "Santarelli";
            p1.DNI = 34498088;
            p1.Nacionalidad = "España";
            p1.FechaNac = 1989;
            p1.Sexo = "Masculino";

            int edad1 = 2018 - p1.FechaNac;

            Persona p2 = new Persona();
            p2.Nombre = "Horacio";
            p2.Apellido = "Santarelli";
            p2.DNI = 4412003;
            p2.Nacionalidad = "Brazil";
            p2.FechaNac = 1943;
            p2.Sexo = "Masculino";

            int edad2 = 2018 - p2.FechaNac;

            Persona p3 = new Persona();
            p3.Nombre = "Cristina";
            p3.Apellido = "Solano";
            p3.Nacionalidad = "E.E.U.U";
            p3.DNI = 4433002;
            p3.FechaNac = 1950;
            p3.Sexo = "Femenino";

            int edad3 = 2018 - p3.FechaNac;

            Persona p4 = new Persona();
            p4.Nombre = "Gaston";
            p4.Apellido = "Santarelli";
            p4.DNI = 30325002;
            p4.FechaNac = 1980;
            p4.Sexo = "Masculino";

            int edad4 = 2018 - p4.FechaNac;

            Persona p5 = new Persona();
            p5.Nombre = "Mariel";
            p5.Apellido = "Santarelli";
            p5.DNI = 27418932;
            p5.FechaNac = 1978;
            p5.Sexo = "Femenino";

            int edad5 = 2018 - p5.FechaNac;

            Console.WriteLine("Hola mi nombre es: " + p1.Nombre + " y mi tengo " + edad1 + "años y soy de España.");
            Console.WriteLine("Olá meu nome é: " + p2.Nombre + " tenho " + edad2 + "anos e sou do Brasil.");
            Console.WriteLine("Hello my name is: " + p3.Nombre + " and I have " + edad3 + "years old and I am USA.");
            Console.WriteLine("Hola mi nombre es: " + p4.Nombre + " y mi tengo " + edad4 + "años.");
            Console.WriteLine("Hola mi nombre es: " + p5.Nombre + " y mi tengo " + edad5 + "años.");


            Console.ReadKey();

        }
    }
}
