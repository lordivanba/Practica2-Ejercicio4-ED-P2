using System;
using System.Collections;
using System.Collections.Generic;

namespace practica2_ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementos;
            var random = new Random();
            var pila = new Stack<int>();
            var pila2 = new Stack<int>();
            int opcion = 0;
            int valorNuevo;
            int valorViejo;


            void reemplazar(Stack<int> stack, int valorNuevo, int valorViejo){
                while(stack.Count != 0){
                    int valor = stack.Pop();
                    if(valor != valorViejo){
                        pila2.Push(valor);
                    } else {
                        pila.Push(valorNuevo);
                    }
                }
                while(pila2.Count != 0){
                    pila.Push(pila2.Pop());                   
                }
                System.Console.WriteLine($"\nValor: {valorViejo} reemplazado por: {valorNuevo}");
            }

    

            System.Console.WriteLine("Ingrese la cantidad de elementos que desea tener en la pila");
            elementos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < elementos; i++)
            {
                pila.Push(random.Next(10, 50));
            }

            while (opcion != 3)
            {
                System.Console.WriteLine("\nElija una opcion: \n1. Imprimir elementos de la pila\n2. Reemplazar elemento de la pila\n3. Salir del programa\n");
                opcion = Convert.ToInt32(Console.ReadLine());
                
                switch(opcion){
                    case 1:
                        foreach(var item in pila){
                            System.Console.WriteLine($"\n[ {item} ]");
                        }
                        break;
                    case 2:
                        System.Console.WriteLine("\nIngrese el valor nuevo");
                        valorNuevo = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("\nIngrese el valor viejo");
                        valorViejo = Convert.ToInt32(Console.ReadLine());

                        if(pila.Contains(valorViejo)){
                            reemplazar(pila, valorNuevo, valorViejo);
                        } else {
                            System.Console.WriteLine("\nEl valor viejo no existe en la pila.");
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
            
            Console.ReadKey();
        }

       
    }
}
