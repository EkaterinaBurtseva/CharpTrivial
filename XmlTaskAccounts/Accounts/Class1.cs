using Accounts.Model;
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

            var katerina = methods.GetAccount("Katerina");


            Account Anton = new Account() { FistName = "Anton" };
            methods.SaveAccount(Anton);

            methods.EditAndAddNewNode();
            methods.EditAndUpdateNode();
            Console.ReadLine();
        }
    }
}
