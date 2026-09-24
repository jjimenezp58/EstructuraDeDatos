using System.Diagnostics;

namespace ejerciciosEstructuras
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EJERCICIO 1

            /* List<string> canciones = new List<string>
             {
                 "Espresso",
                 "APT.",
                 "Blinding Lights"
             };

             canciones.Add("Water");
             canciones.Insert(1, "Birds of a Feather");
             canciones[2] = "APT";
             canciones.Remove("Espresso");

             int numero = 1;

             Console.WriteLine("=== MI PLAYLIST ===");
             foreach (string cancion in canciones) 
             {
                 Console.WriteLine(numero + " " + cancion);
                 numero++;
             }

             Console.WriteLine($"Total de canciones: {canciones.Count()}\n");


             //EJERCICIO 2

             Console.WriteLine("=== LISTA DE LA COMPRA ===");

             List<string> listaDeCompra = new List<string>
             {
                 "Leche",
                  "Pan",
                  "Huevos",
                  "Pasta",
                  "Arroz",
             };

             Console.WriteLine("Productos:");

             foreach (string Productos in listaDeCompra)
             {
                 Console.WriteLine("- "+Productos);
             }

             Console.Write("Que producto quieres añadir: ");
             string productoyadido = Console.ReadLine() ?? "";

             listaDeCompra.Add(productoyadido);

             Console.Write("Que producto quieres eliminar: ");
             string productoEliminado = Console.ReadLine() ?? "";

             listaDeCompra.Remove(productoEliminado);

             Console.WriteLine("=== LISTA FINAL ===\n");

             foreach (string productos in listaDeCompra) 
             {
                 Console.WriteLine("- " + productos);
             }

             Console.WriteLine("\nProductos restantes: " + 
                 listaDeCompra.Count);



            //EJERCICIO 3



             List<string> GestorTareas = new List<string>
             {
                 "Estudiar c#",
                 "Hacer Ejercicio",
                 "Comprar Comida",
                 "Ver una pelicula"
             };

             int opcionUsuario = 0;

             while (opcionUsuario != 6)
             {

                 Console.WriteLine("=== MIS TAREAS ===");
                 Console.WriteLine("1. Mostrar Tareas: ");
                 Console.WriteLine("2. Añadir Tareas: ");
                 Console.WriteLine("3. Completar Tarea: ");
                 Console.WriteLine("4. Buscar Tarea: ");
                 Console.WriteLine("5. Ordenar Tarea: ");
                 Console.WriteLine("6. Salir: ");
                 Console.Write("Opción:");
                 opcionUsuario = int.Parse(Console.ReadLine() ?? "");


                 switch (opcionUsuario)
                 {
                     case 1:
                         foreach (string tarea in GestorTareas)
                         {
                             Console.WriteLine($"{tarea}");
                         }
                         break;
                     case 2:
                         Console.WriteLine("Caso 2");
                         break;
                     case 3:
                         Console.WriteLine("Caso 3");
                         break;
                     case 4:
                         Console.WriteLine("Caso 4");
                         break;
                     case 5:
                         Console.WriteLine("Caso 5");
                         break;
                     case 6:
                         Console.WriteLine("Caso 6");
                         break;
                     default:
                         Console.WriteLine("¡Opción no válida!");
                         break;} 
                  




                        // PILAS : EJECICIO 4

                Stack<string> pila = new Stack<string>();

                pila.Push("Escribir texto");
                pila.Push("Cambiar color");
                pila.Push("Insertar imagen");
                pila.Push("Eliminar imagen");

                  Console.WriteLine("===  HISTORIAL  ===");

                  Console.WriteLine("Última acción: " + pila.Peek());
                  Console.WriteLine( "Desacer: " + pila.Pop());
                  Console.WriteLine("Nueva última acción: " + pila.Peek());

                 pila.Push("cabiar tamaño");
                  Console.WriteLine("Nueva acción: " + pila.Peek()); */


            // EJERCICIO 5 — NAVEGADOR WEB 




            Stack<string> pila = new Stack<string>();

            pila.Push("Goggle.com");
            pila.Push("Youtube.com");
            pila.Push("Instagram.com");
            pila.Push("Github.com");

            Console.WriteLine("=== NAVEGADOR === \n");

            Console.WriteLine("PAGINA ACTUAL:\n" + pila.Peek());
            Console.WriteLine();

            Console.WriteLine("pulsando ATRAS...\n");
            Console.WriteLine();

             pila.Pop();
            Console.WriteLine("PAGINA ACTUAL: \n" + pila.Peek());
            Console.WriteLine(); 
            Console.WriteLine("pulsando ATRAS...\n");

            pila.Pop();
            Console.WriteLine("PAGINA ACTUAL: \n" + pila.Peek());
            Console.WriteLine();

            Console.WriteLine("pulsando ATRAS...\n");

            pila.Push("Tiktok.com");
            Console.WriteLine("Nueva visita:\n" + pila.Peek());
            Console.WriteLine();

           
            Console.WriteLine("PAGINA ACTUAL:\n" + pila.Peek());
            Console.WriteLine();
            
            
            
            Console.WriteLine("---- historial restante ---");

            foreach (string historial in pila)
            {
                {
                    
                    Console.WriteLine(historial); 
                }
            }    
        }   



    }
}