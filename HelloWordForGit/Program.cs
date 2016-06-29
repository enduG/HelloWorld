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
            foreach (var comm in GitBasicCommands())
            {
                Console.WriteLine(comm);
            }
            

            Console.ReadKey();
        }

    public static string[]  GitBasicCommands()
        {
          string [] gitCommands = { "Git Clone", "Git Status", "Git Add", "Git Commit", "Git Push", "git Pull" };

          return gitCommands;
           
        }
    }
}
