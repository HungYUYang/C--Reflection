using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_IL_metadata;
namespace Benz
{
    public class Benz_Class:Car
    {
        public override void Run()
        {            
            Console.WriteLine(hashtable["Parm"].ToString() + " run 500 km!!");
        }
    }
}
