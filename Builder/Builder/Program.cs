using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IGudgetBuilder phoneBuilder = new PhoneBuilder();
            IUser user = new User(phoneBuilder);
            Console.WriteLine(user.Construct());

            IGudgetBuilder noteBuilder = new NotebookBuilder();
            IUser user2 = new User(noteBuilder);
            Console.WriteLine(user2.Construct());
            Console.ReadKey();
        }
    }
}
