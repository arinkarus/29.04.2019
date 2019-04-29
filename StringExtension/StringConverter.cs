using System;
using System.Text;

namespace StringExtension
{
    public class StringConverter
    {
        public string Convert(string source, int count)
        {
            ValidateParams(source, count);
            var stringBuilder = new StringBuilder(source);
            var oddNumbers = new StringBuilder();
            var evenNumbers = new StringBuilder();
            int period = count % source.Length;
            int iterationCountForSource = source.Length / 2;
            for (int j = 0; j < period; j++)
            {               
                for (int i = 0; i < iterationCountForSource; i++)
                {
                    evenNumbers.Append(stringBuilder[2 * i]);
                    oddNumbers.Append(stringBuilder[2 * i + 1]);
                }

                stringBuilder.Clear();
                stringBuilder.Append(evenNumbers).Append(oddNumbers);
                oddNumbers.Clear();
                evenNumbers.Clear();
            }

            return stringBuilder.ToString();
        }

        private void ValidateParams(string source, int count)
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
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}