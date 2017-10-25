using System.Text;

namespace OhpenTest.Operations.Convert
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
