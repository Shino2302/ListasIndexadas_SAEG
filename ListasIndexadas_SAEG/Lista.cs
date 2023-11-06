using System;

namespace ListasIndexadas_SAEG
{
    public class Lista
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        //Constructor que inicializa los valores como nulos
        public Lista()
        {
            Primero = null;
            Ultimo = null;
        }

        public void InsertarNodo()
        {
            Nodo Nuevo = new Nodo(); //Generamos un nuevo nodo
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("ingrese el dato que desee agregar a la lista:");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Nuevo.Dato = Convert.ToInt32(Console.ReadLine()); //Le pasamos información
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            if (Primero == null) // verificamos si la lista esta vacía
            {
                // Si se encuentra vacía iniciamos declarando el primer dato como el principio y el fin
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Nuevo;
            }
            else
            {
                //Si no se encuentra vacia
                Ultimo.Siguiente = Nuevo; //al ultimo nodo insertado le indicamos que tendra otro por delante
                Nuevo.Siguiente = null; //en el nuevo nodo apuntamos al final
                Ultimo = Nuevo; // convertimos al nuevo nodo en el ultimo ingresado
            }
            Console.WriteLine("Nodo Ingresado!");

        }

        public void DesplegarLista()
        {
            Nodo Actual = Primero;

            if(Primero != null)
            {
                Console.Clear();
                Console.WriteLine("La lista es: ");
                while (Actual != null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{Actual.Dato}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" -> ");
                    Actual = Actual.Siguiente;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("La lista se encuentra vacia");
            }
        }
        public void InsertarEnLaMitad()
        {
            if(Primero != null)
            {
                Nodo Actual = Primero; //Creamos un Nodo para recorrer la lista, iniciandolo en el primer nodo
                int contador = 0; //Generamos un contador para poder encontrar el centro de nuestra lista

                while (Actual != null) //Mientras que el nodo no llegue a una referencia nula seguira avanzando
                {
                    contador++;
                    Actual = Actual.Siguiente;
                }
                int medioDeLista = contador % 2 == 0 ? contador / 2 : (contador + 1) / 2; //Operador ternario en caso de que sea par o impar

                Actual = Primero; //Volvemos al principio de la lista
                
                for (int i = 0; i < medioDeLista-1; i++) //Ahora utilizamos un for, porque sabemos hasta donde necesitamos llegar
                {
                    Actual = Actual.Siguiente;
                } 
                Nodo Nuevo = new Nodo();
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Ingrese el dato que desee agregar a la lista:");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.White;
                Nuevo.Dato = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

                Nodo Auxiliar = new Nodo(); //Nodo Auxiliar para tomar la posicion siguiente de la lista
                Auxiliar = Actual; 
                Auxiliar = Auxiliar.Siguiente; // Le indicamos que se coloque una posicion por delante del centro para enlazarlo
                Nuevo.Siguiente = Auxiliar; //Le inidamos cuál sera el nodo que sigue
                Actual.Siguiente = Nuevo; //Le indicamos al anterior que tiene un nuevo siguiente
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La lista se encuentra vacia");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Desea insertar igualmente un dato? precione Enter para continuar:");
                ConsoleKeyInfo myKey = Console.ReadKey(true);
                if (myKey.Key == ConsoleKey.Enter) //Si no preciona enter es cancelado
                {
                    InsertarNodo();
                }
                else
                {
                    Console.WriteLine("OK");
                }
            }
        }
        public void EliminarUltimoNodo()
        {
            Nodo Actual = Primero;
            int contador = 0;

            if(Primero == null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("No se puede eliminar nada, porque la lista se encuentra vacía");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                while (Actual.Siguiente != null)
                {
                    contador++;
                    Actual = Actual.Siguiente;
                }
                Actual = Primero; //Reseteamos el nodo para poder dezplazar de vuelta
                for (int i = 0; i < contador; i++)
                {
                    if (i == contador - 1)
                    {
                        Actual.Siguiente = null; //Asignamos apuntamos a nulo para cortar el nodo 
                        Ultimo = Actual; //Y lo colocamos como ultimo
                    }
                    else
                    {
                        Actual = Actual.Siguiente;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
        }
        public void EliminarNodoEspecifico()
        {
            if(Primero == null)
            {
                Console.WriteLine("La lista se encuentra vacía");
            }
            else
            {
                Nodo Actual = Primero;
                DesplegarLista();
                Console.Write("\n¿Que elemento deseas ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Eliminar");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("?: \n");
                int nodoAEliminar = int.Parse(Console.ReadLine());
                while(Actual.Dato != nodoAEliminar)
                {
                    if(Actual.Siguiente == null && Actual.Dato != nodoAEliminar)
                    {
                        Console.WriteLine("El dato no se encuentra en la lista!");
                        break;
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
