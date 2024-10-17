using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.View
{
    public class Display
    {
        
        public void Input()
        {
            Model model = new Model();

            Console.WriteLine("vuvedi chas na izpit");
            model.chasnaizpita = int.Parse(Console.ReadLine());
            Console.WriteLine("vuvedi chas na pristgane");
            model.chasnapristigane = int.Parse(Console.ReadLine());
            Console.WriteLine("vuvedi minuti na izpit");
            model.minutinaizpita = int.Parse(Console.ReadLine());
            Console.WriteLine("vuvedi minuti na pristigane");
            model.minutinapristigane = int.Parse(Console.ReadLine());
            
        }
    }
}
