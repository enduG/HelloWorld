using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWordForGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Welcome to the Git Tutorial");
            Console.WriteLine("GIT COMMANDS");
            Console.WriteLine("============");
            foreach (var comm in GitCommands())
            {
                Console.WriteLine(comm);
            }
            

            Console.ReadKey();
        }

    public static string[]  GitCommands()
        {
          string [] gitCommands = { "Git Clone", "Git status", "Git Add", "Git commit", "Git push", "git pull" };

          return gitCommands;
           
        }
    }
}
