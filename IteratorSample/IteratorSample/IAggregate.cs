using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSample
{
    public interface IAggregate<T>
    {
        IIterator GetIterator();
        int Count { get; set; }
        T this[int index] { get; set; }
    }
}
