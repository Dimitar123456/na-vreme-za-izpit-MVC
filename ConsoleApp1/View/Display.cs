using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.View
{
    public class Display:Model
    {
        public string Message { get; set; }
        public void Input()
        {
           

            Console.WriteLine("vuvedi chas na izpit");
            Chasnaizpita = int.Parse(Console.ReadLine());
            Console.WriteLine("vuvedi chas na pristgane");
            Chasnapristigane = int.Parse(Console.ReadLine());
            Console.WriteLine("vuvedi minuti na izpit");
            Minutinaizpita = int.Parse(Console.ReadLine());
            Console.WriteLine("vuvedi minuti na pristigane");
            Minutinapristigane = int.Parse(Console.ReadLine());
            
        }
        public void Output() 
        {
            if (Chasnapristigane == Chasnaizpita && Minutinapristigane == Minutinaizpita)
            {
                this.Message = "student is just on time";
                
            }
            else if (Chasnapristigane == Chasnaizpita && Minutinapristigane <= Minutinaizpita - 31)
            {
                this.Message = "student is early";
            }
            else if (Chasnapristigane <= Chasnaizpita - 1)
            {
                this.Message = "student is early";
            }
            else if (Chasnapristigane == Chasnaizpita && Minutinapristigane >= Minutinaizpita + 1)
            {
                this.Message = "student is late";
            }
            else if (Chasnapristigane >= Chasnaizpita + 1)
            {
                this.Message = "student is late";
            }
            Console.WriteLine(this.Message);
        }
    }
}
