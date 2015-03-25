namespace Test
{
    using System;
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder stringBuilder, int index, int lenght)
        {
            StringBuilder result = new StringBuilder();

            if (index < 0 || index > lenght)
            {
                throw new IndexOutOfRangeException();
            }

            if (lenght < 0)
            {
                throw new ArgumentException();
            }

            if (index + lenght > stringBuilder.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = index; i < lenght + index; i++)
            {
                result.Append(stringBuilder[i]);
            }

            return result;
        }

        public static StringBuilder Substring(this StringBuilder stringBuilder, int index)
        {
            StringBuilder result = new StringBuilder();

            if (index > stringBuilder.Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < stringBuilder.Length; i++)
            {
                result.Append(stringBuilder[i]);
            }

            return result;
        }
        //public static StringBuilder SubstringBuilder(this StringBuilder stringBuilder, int position)
        //{
        //    string result = stringBuilder.ToString().Substring(position, stringBuilder.Length - position);
        //    StringBuilder resultSb = new StringBuilder(result);
        //    return resultSb;
        //}

        //public static StringBuilder SubstringBuilder(this StringBuilder sb, int position, int length)
        //{
        //    string result = sb.ToString().Substring(position, length);
        //    StringBuilder resultSb = new StringBuilder(result);
        //    return resultSb;
        //}
    }
}
