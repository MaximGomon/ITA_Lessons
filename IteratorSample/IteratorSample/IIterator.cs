using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSample
{
    public interface IIterator
    {
        object First();
        object Next();
        bool IsDone();
        object CurrentItem();
    }
}
