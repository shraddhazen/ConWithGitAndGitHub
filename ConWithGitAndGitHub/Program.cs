using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConWithGitAndGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,Welcome to Git...");
            Person pobj = new Person();
            pobj.Id = 100;
            pobj.Name = "Shraddha";
            Console.WriteLine($"Id : {pobj.Id} and Name : {pobj.Name}");
         
        }
    }
}
