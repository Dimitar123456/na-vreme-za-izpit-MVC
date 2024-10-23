using ConsoleApp1.Models;
using ConsoleApp1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controllers
{
     public class Controller
     {
       //dobur den
        Display display = new Display();
        Model model = new Model();
        public void Start()
        {
            display.Input();
            model.Chasnapristigane=display.Chasnapristigane;
            model.Chasnaizpita=display.Chasnaizpita;
            model.Minutinapristigane =display.Minutinapristigane;
            model.Minutinaizpita=display.Minutinaizpita;
            display.Output();
        }
                
     }
}
