using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Calculator_RepositoryPattern
{
    class Program
    {
        //Cover after creating the UI in the static void Main so that the 
        static void Main(string[] args)
        {
            ProgramUI program = new ProgramUI();
            program.Run();
        }
    }
}
