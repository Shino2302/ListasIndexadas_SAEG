using System;

namespace ListasIndexadas_SAEG
{
    public class MenuInteractivo
    {
        private string[] arrayDeOpciones = new string[] { "LISTAS", "PILAS Y COLAS", "ARBOLES", "SALIR" };
        public void Menu()
        {
            int control = 0;
            while (true)
            {
                Console.CursorVisible = false;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("°-------------------------------------------------------------------------°\n");
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("  _   _   _   _   _   _   _   _   _   _     _   _     _   _   _   _   _  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("|\n");
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(@" / \ / \ / \ / \ / \ / \ / \ / \ / \ / \   / \ / \   / \ / \ / \ / \ / \ ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("|");
                Console.Write("\n|");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("( E ( S ( T ( R ( U ( C ( T ( U ( R ( A ) ( D ( E ) ( D ( A ( T ( O ( S )");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("|\n");
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(@" \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/   \_/ \_/   \_/ \_/ \_/ \_/ \_/ ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("|");
                //ConsoleKeyInfo myKey = Console.ReadKey(true);
                Console.Write("\n°-------------------------------------------------------------------------°\n");
                //                               0                                     1
                Console.Write($"|               {arrayDeOpciones[0]}               |            PILAS Y COLAS           |\n");
                Console.Write("°------------------------------------°------------------------------------°\n");
                //                                2                                     3
                Console.Write("|               ARBOLES              |                 SALIR              |\n");
                Console.Write("°------------------------------------°------------------------------------°\n");
            }
        }
    }
}
