using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhpenTest.Operations.Sorting
{
    public interface ISorting
    {
        string[] SelectionSort(string[] textArray);
        string[] InsertionSort(string[] text);
        string[] BubbleSort(string[] text);
    }
}
