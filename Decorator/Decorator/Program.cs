using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPainter painter = new BoardPainter();
            painter.Draw();
            Console.WriteLine(new string('*', 30));

            IPaintDecorator decorator = new CartoonDecorator(painter);
            decorator.Draw();
            Console.WriteLine(new string('*', 30));

            IPaintDecorator decoratorNext = new WallDecorator(painter);
            decoratorNext.Draw();
            Console.WriteLine(new string('*', 30));

            IPaintDecorator godDecore = new CartoonDecorator(decorator);
            godDecore.Draw();
            Console.WriteLine(new string('*', 30));
            Console.ReadKey();
        }
    }
}
