using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace dll_IL_metadata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please key in dll name (Benz/BMW):");
            string dllname = Console.ReadLine();
            string dllpath= @"E:\C#\studying\dll-IL-metadata\dll-IL-metadata\bin\x64\DLL\";

            try {
                Assembly oa = Assembly.LoadFile(dllpath + dllname + ".dll");
                Type t = oa.GetType("Benz." + dllname + "_Class");
                var tcb = (Car)Activator.CreateInstance(t);
                tcb.hashtable.Add("Parm", dllname);
                tcb.Run();
            }
            catch {
                Console.Write("dll name[{0}] is not exists", dllname);
            }
            Console.ReadLine();

        }
    }
}
