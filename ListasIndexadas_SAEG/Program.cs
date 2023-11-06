using System;

namespace ListasIndexadas_SAEG
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Listas Indexadas";
            
            Lista lista = new Lista();
            for (int i = 0; i < 5; i++)
            {
                lista.InsertarNodo();
            }
            lista.DesplegarLista();
            lista.InsertarEnLaMitad();
            lista.DesplegarLista();
            lista.EliminarUltimoNodo();
            lista.DesplegarLista();
    }
}