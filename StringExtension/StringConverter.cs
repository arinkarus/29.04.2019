using System;
using System.Text;

namespace StringExtension
{
    public class StringConverter
    {
        public string Convert(string source, int count)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            if (source == string.Empty)
            {
                throw new ArgumentException();
            }
            if (source.Trim().Length == 0)
            {
                throw new ArgumentException();
            }
            if (count < 0)
            {
                throw new ArgumentException();
            }
            var stringBuilder = new StringBuilder();

            for (int j = 0; j < count; j++)
            {
                  for (int i = 0; i < source.Length; i = i + 2)
                  {
                      stringBuilder.Append(source[i]);
                  }
                  for (int i = 1; i < source.Length; i = i + 2)
                  {
                      stringBuilder.Append(source[i]);
                  }

                  source = stringBuilder.ToString();
                  stringBuilder.Clear();
            }

            return source;
        }
    }
}