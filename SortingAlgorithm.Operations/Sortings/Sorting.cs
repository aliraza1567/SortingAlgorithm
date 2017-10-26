namespace SortingAlgorithm.Operations.Sortings
{
    public class Sorting : ISorting
    {
        public string[] SelectionSort(string[] textArray)
        {

            for (var i = 0; i < textArray.Length - 1; ++i)
            {
                var minIndex = i;
                for (var j = i + 1; j < textArray.Length; ++j)
                {
                    if (textArray[j].CompareTo(textArray[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                var temp = textArray[i];
                textArray[i] = textArray[minIndex];
                textArray[minIndex] = temp;
            }
            return textArray;
        }

        public string[] InsertionSort(string[] textArray)
        {
            for (var i = 1; i < textArray.Length; i++)
            {
                var temp = textArray[i];
                var j = i - 1;

                while (j >= 0 && textArray[j].CompareTo(temp) > 0)
                {
                    textArray[j + 1] = textArray[j];
                    j--;
                }
                textArray[j + 1] = temp;
            }
            return textArray;
        }

        public string[] BubbleSort(string[] textArray)
        {
            for (var j = 0; j <= textArray.Length - 2; j++)
            {
                for (var i = 0; i <= textArray.Length - 2; i++)
                {
                    if (textArray[i].CompareTo(textArray[i + 1]) <= 0) continue;
                    var t = textArray[i + 1];
                    textArray[i + 1] = textArray[i];
                    textArray[i] = t;
                }
            }
            return textArray;
        }
    }
}
