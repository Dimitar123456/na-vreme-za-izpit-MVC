using ConsoleApp1;
using ConsoleApp1.Controllers;
using ConsoleApp1.View;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.Start();
        }
    }
}
