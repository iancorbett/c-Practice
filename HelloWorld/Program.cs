// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// namespace Shape //namesapce seems to be a way of containing code, for example if i created another shape namespace it would not conflict but there would is there were two classes with the same name
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello, y'all!");

//             //Console.ReadLine();

            
//             Console.WriteLine("  /|");
//             //Console.ReadLine();
//             Console.WriteLine(" / |");
//             Console.WriteLine("/__|");
//         }
//     }
// }

namespace Story
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John";
            int characterAge;
            characterAge = 35;

            Console.WriteLine("Hello, my name is " + characterName + "!");
            Console.WriteLine("I am " + characterAge + " years old!");           
            Console.WriteLine("  /|");            
            Console.WriteLine(" / |");
            Console.WriteLine("/__|");
        }
    }
}