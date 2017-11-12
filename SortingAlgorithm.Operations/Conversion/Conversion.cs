using System.Text;

namespace SortingAlgorithm.Operations.Conversion
{
    public static class Conversion
    {
        public static string[] StringToArray(string text)
        {
            return text.Split(' ');
        }

        public static string ArrayToString(string[] textArray)
        {
            var strBuilder = new StringBuilder();

            foreach (var part in textArray)
            {
                strBuilder.Append(part);
                strBuilder.Append(' ');
            }
            return strBuilder.ToString().Trim();
        }
    }
}
