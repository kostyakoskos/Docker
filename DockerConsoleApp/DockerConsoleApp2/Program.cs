using System;
// docker build --file ./Dockerfile --no-cache --tag dotnetdocker:1.0 .
// docker ignore **/*.*proj.user
namespace DockerConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello console docker"); 
            Console.WriteLine("rebuild");
            //Console.ReadKey();
        }
    }
}
