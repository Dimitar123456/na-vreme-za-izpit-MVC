using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Model
    {
        public int chasnaizpita { get; set; }
        public int minutinaizpita { get; set; }
        public int chasnapristigane {  get; set; }
        public int minutinapristigane { get; set; }

        public void Navremelisum()
        { 
            if(chasnapristigane == chasnaizpita && minutinapristigane == minutinaizpita)
            {
                if (chasnaizpita > 24 || chasnapristigane > 24)
                {
                    Console.WriteLine("wrong input for hours");
                }
                else
                {
                    if (minutinaizpita > 60 || minutinapristigane > 60)
                    {
                        Console.WriteLine("wrong input for minutes");
                    }
                    else
                    {
                        Console.WriteLine("student is just on time");
                    }
                }

            }
            else if (chasnapristigane == chasnaizpita && minutinapristigane <= minutinaizpita-30)
            {
                if (chasnaizpita > 24 || chasnapristigane > 24)
                {
                    Console.WriteLine("wrong input for hours");
                }
                else
                {
                    if (minutinaizpita > 60 || minutinapristigane > 60)
                    {
                        Console.WriteLine("wrong input for minutes");
                    }
                    else
                    {
                        Console.WriteLine("student is early");
                    }
                }
            }
            else if(chasnapristigane <= chasnaizpita - 1)
            {
                if (chasnaizpita > 24 || chasnapristigane > 24)
                {
                    Console.WriteLine("wrong input for hours");
                }
                else
                {
                    if (minutinaizpita > 60 || minutinapristigane > 60)
                    {
                        Console.WriteLine("wrong input for minutes");
                    }
                    else
                    {
                        Console.WriteLine("student is early");
                    }
                }
            }
            else if (chasnapristigane == chasnaizpita && minutinapristigane >= minutinaizpita+30)
            {
                if (chasnaizpita > 24 || chasnapristigane > 24)
                {
                    Console.WriteLine("wrong input for hours");
                }
                else
                {
                    if (minutinaizpita > 60 || minutinapristigane > 60)
                    {
                        Console.WriteLine("wrong input for minutes");
                    }
                    else
                    {
                        Console.WriteLine("student is late");
                    }
                }
            }
            else if(chasnapristigane >= chasnaizpita + 1)
            {
                if (chasnaizpita > 24 || chasnapristigane > 24)
                {
                    Console.WriteLine("wrong input for hours");
                }
                else
                {
                    if (minutinaizpita > 60 || minutinapristigane > 60)
                    {
                        Console.WriteLine("wrong input for minutes");
                    }
                    else
                    {
                        Console.WriteLine("student is late");
                    }
                }
            }
            
            
        }

    }
}
