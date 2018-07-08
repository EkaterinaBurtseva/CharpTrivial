using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();
            methods.CreateAccountAttribute();           
            methods.EditAndAddNewNode();
            methods.EditAndUpdateNode();
            Console.ReadLine();
        }
    }
}
