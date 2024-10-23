using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Model
    {
        private int chasnaizpita;
        private int minutinaizpita;
        private int chasnapristigane;
        private int minutinapristigane;
        public string Message { get; set; }
        public int Chasnaizpita
        {
            get { return this.chasnaizpita; }
            set 
            { 
                if (value > 24) 
                {
                    this.Message="greshen chas";
                }
                else { chasnaizpita = value; }
            }
        }
        public int Minutinaizpita
        {
            get { return this.minutinaizpita; }
            set
            {
                if (value > 60)
                {
                    Console.WriteLine("greshni minuti");
                }
                else
                {
                    minutinaizpita = value;
                }
            }
        }
        public int Chasnapristigane
        {
            get { return this.chasnapristigane; }
            set
            {
                if (value > 24)
                {
                    Console.WriteLine("greshen chas");
                }
                else { chasnapristigane = value; }
                
            }
        }
        public int Minutinapristigane
        {
            get { return this.minutinapristigane; }
            set
            {
                if (value > 60)
                {
                    Console.WriteLine("greshni minuti");
                }
                else
                {
                    minutinapristigane = value;
                }
                
            }
        }

        //public void Navremelisum()
        //{ 
        //    if(chasnapristigane == chasnaizpita && minutinapristigane == minutinaizpita)
        //    {
        //        this.Message = "student is just on time";
        //    }
        //    else if (chasnapristigane == chasnaizpita && minutinapristigane <= minutinaizpita-31)
        //    {
        //        this.Message = "student is early";
        //    }
        //    else if (chasnapristigane <= chasnaizpita - 1)
        //    {
        //        this.Message = "student is early";
        //    }
        //    else if (chasnapristigane == chasnaizpita && minutinapristigane >= minutinaizpita+1)
        //    {
        //        this.Message = "student is late";
        //    }
        //    else if (chasnapristigane >= chasnaizpita + 1)
        //    {
        //                this.Message="student is late";
        //    }
            
            
        //}

    }
}
