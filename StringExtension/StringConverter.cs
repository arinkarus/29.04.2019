using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
    /// <summary>
    /// Non static class that implements String converts. 
    /// </summary>
    public class StringConverter
    {
        #region private fields
        private readonly StringBuilder _startOddPart = new StringBuilder();
        private readonly StringBuilder _endEvenPart = new StringBuilder();
        private string _source;
        private int _count;
        #endregion

        #region public method
        /// <summary>
        /// Public method that takes 2 inputs, checks it on validness,
        /// and calls the private recursive method "RecursiveConvert".
        /// </summary>
        /// <param name="source"> String that needs to be converted. </param>
        /// <param name="count"> Iteration times. </param>
        /// <returns></returns>
        public string Convert(string source, int count)
        {
            CheckInputs(source, count);
            _source = source;
            _count = count;

            return NonRecursiveConvert(source, count);
        }
        #endregion

        #region private methods
        /// <summary>
        /// Private non-recursive method that converts a string.
        /// </summary>
        /// <param name="str"> Input string for converts. </param>
        /// <param name="n"></param>
        /// <returns></returns>
        private string NonRecursiveConvert(string str, int n)
        {
            while (n > 0)
            {
                for (var i = 0; i < str.Length; i++)
                {

                    if ((i & 1) != 0)
                    {
                        _endEvenPart.Append(str[i]);
                    }
                    else
                    {
                        _startOddPart.Append(str[i]);
                    }
                }

                str = _startOddPart.Append(_endEvenPart).ToString();
                ClearStringBuilders();
                n--;

                if (_source != str) continue;
                n %= _count - n;
                _source = null;
            }
            return str;
        }

        /// <summary>
        /// Method that clears StringBuilders.
        /// </summary>
        private void ClearStringBuilders()
        {
            _startOddPart.Clear();
            _endEvenPart.Clear();
        }

        /// <summary>
        /// Private inputs validator method.
        /// </summary>
        /// <param name="str"> Input String that needs to be checked. </param>
        /// <param name="n"> Input iteration count that needs to be checked. </param>
        /// <exception cref="ArgumentException"></exception>
        private void CheckInputs(string str, int n)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str), " string can not be null!");
            }

            if (str == string.Empty)
            {
                throw new ArgumentException(nameof(str), " string can not be Empty!");
            }

            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(nameof(str), " string can not be full WhiteSpaced!");
            }

            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), " count must be grater that zero!");
            }
        }
        #endregion
    }

}
