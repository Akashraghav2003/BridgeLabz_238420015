using System;
using System.Text;

namespace RemoveDuplicate
{
    internal class Remove
    {
        public StringBuilder RemoveDuplicates(StringBuilder str)
        {
            int newLength = 1;
            for (int i = 1; i < str.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < newLength; j++) // Only check within newLength
                {
                    if (str[i] == str[j]) // If duplicate found, mark it
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate) // If not duplicate, add to new position
                {
                    str[newLength] = str[i];
                    newLength++;
                }
            }

            // Trim excess characters
            while (str.Length > newLength)
            {
                str.Length--;
            }

            return str;
        }
    }
}
