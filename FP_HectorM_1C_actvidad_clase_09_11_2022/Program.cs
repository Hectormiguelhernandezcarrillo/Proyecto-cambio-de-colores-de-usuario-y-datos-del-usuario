using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FP_HectorM_1C_actvidad_clase_09_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables para la asignacion de datos
            string nameUser, name, matricula, seccion, grado, password, passwordConfirm;
            int colores=0;

            Console.WriteLine("ingresa tu Usuario");
            nameUser = Console.ReadLine();
            Console.WriteLine("ingresa tu contraseña ");
            password = Console.ReadLine();
            Console.WriteLine("vuelve a ingresar tu contraseña ");
            passwordConfirm = Console.ReadLine();
            //sino esta bien la contraseña te sacara del porgrama por tener la contraseña incorrecta
            if (password == passwordConfirm)
            {
                Console.WriteLine("ingresa tu nombre ");
                name = Console.ReadLine();
                Console.WriteLine("ingresa tu matricula ");
                matricula = Console.ReadLine();
                Console.WriteLine("ingresa tu seccion ");
                seccion = Console.ReadLine();
                Console.WriteLine("ingresa tu grado");
                grado = Console.ReadLine();


                Console.WriteLine(" Ingresa el numero de color que quieres que sea tu consola 1:azul 2:rosa 3:verde 4:naranja 5:morado 6:blanco");



                //aqui cambiara el color de laq consola mostrando los datos del usuario
                colores = Convert.ToByte(Console.ReadLine());
                if (colores == 1)
                {
                    Console.SetWindowSize(150, 50);
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.WriteLine("Tema 1 Color azul");
                    Console.WriteLine("Datos de usuario: \n\t Usuario: {0}. \n\t Nombre:{1}. \n\t  Matricula: {2}. \n\t  Seccion:{3}. \n\t. Grado: {4}.\n\t", nameUser, name, matricula, seccion, grado);
                    Console.ReadKey();

                    
                }
               // rosa = Convert.ToByte(Console.ReadLine());
                if (colores == 2)
                {
                    Console.SetWindowSize(120, 30);
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Tema 1 Color rosa");
                    Console.WriteLine("Datos de usuario: \n\t Usuario: {0}. \n\t Nombre:{1}. \n\t  Matricula: {2}. \n\t  Seccion:{3}. \n\t. Grado: {4}.\n\t", nameUser, name, matricula, seccion, grado);
                    Console.ReadKey();


                }
               // verde = Convert.ToByte(Console.ReadLine());
                if (colores == 3)
                {
                    Console.SetWindowSize(220, 50);
                    Console.SetWindowSize(180, 40);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Tema 1 Color Verde");
                    Console.WriteLine("Datos de usuario: \n\t Usuario: {0}. \n\t Nombre:{1}. \n\t  Matricula: {2}. \n\t  Seccion:{3}. \n\t. Grado: {4}.\n\t", nameUser, name, matricula, seccion, grado);
                    Console.ReadKey();


                }
               // naranja = Convert.ToByte(Console.ReadLine());
                if (colores == 4)
                {
                    Console.SetWindowSize(100, 20);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.WriteLine("Tema 1 Color Naranja");
                    Console.WriteLine("Datos de usuario: \n\t Usuario: {0}. \n\t Nombre:{1}. \n\t  Matricula: {2}. \n\t  Seccion:{3}. \n\t. Grado: {4}.\n\t", nameUser, name, matricula, seccion, grado);
                    Console.ReadKey();


                }
            //    morado = Convert.ToByte(Console.ReadLine());
                if (colores == 5)
                {
                    Console.SetWindowSize(250, 50);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                
                    Console.Clear();
                    Console.WriteLine("Tema 1 Color Morado");
                    Console.WriteLine("Datos de usuario: \n\t Usuario: {0}. \n\t Nombre:{1}. \n\t  Matricula: {2}. \n\t  Seccion:{3}. \n\t. Grado: {4}.\n\t", nameUser, name, matricula, seccion, grado);
                    Console.ReadKey();


                }
              //  blanco = Convert.ToByte(Console.ReadLine());
                if (colores == 6)
                {
                    Console.SetWindowSize(300, 70);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.WriteLine("Tema 1 Color Blanco");
                    Console.WriteLine("Datos de usuario: \n\t Usuario: {0}. \n\t Nombre:{1}. \n\t  Matricula: {2}. \n\t  Seccion:{3}. \n\t Grado: {4}.\n\t", nameUser, name, matricula, seccion, grado);
                    Console.ReadKey();


                }
                //sino escoges un  numero para el color dentro del menu te dira este mensaje y te sacara del sistema
                else
                {
                    Console.WriteLine("No esta en las opciones de los colores");

                    Console.WriteLine("saliendo del sistema.");
                    Thread.Sleep(1000);
                    Console.WriteLine("saliendo del sistema..");
                    Thread.Sleep(1000);
                    Console.WriteLine("saliendo del sistema...");
                    Thread.Sleep(1000);

                    Thread.Sleep(5000);

                }

            }
        }
    }
}
