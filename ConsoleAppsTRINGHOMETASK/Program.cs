using System.Threading.Channels;

namespace ConsoleAppsSTRINGHOMETASK
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] values = { "Samaya", "Vugar", "Novruz", "Narmina", "Edward" };

            foreach (string value in values) 
            {
                Console.Write(value + ' ');
            }
         Array.Sort(values);
            Console.WriteLine("Sorted; ");
            foreach (string value in values)
            {
                Console.Write(value + ' ');
            }
            Console.WriteLine();
        }
        
    }
}