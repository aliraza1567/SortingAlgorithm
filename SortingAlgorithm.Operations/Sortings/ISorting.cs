namespace SortingAlgorithm.Operations.Sortings
{
    public interface ISorting
    {
        string[] SelectionSort(string[] textArray);
        string[] InsertionSort(string[] text);
        string[] BubbleSort(string[] text);
    }
}
