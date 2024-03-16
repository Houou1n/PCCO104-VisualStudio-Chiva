namespace PCCO104_VisualStudio_Chiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] names = { "name1", "name2"};

            foreach(var name in names)
            {
                Console.WriteLine($"{name}");
            }
            Console.ReadKey();
        }
    }
}
