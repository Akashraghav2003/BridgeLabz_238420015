//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Review1
//{
//    internal class StringCharacter
//    {
//        public  void CountCharacter(string input)
//        {
            

//            for (int i = 0; i < input.Length; i++)
//            {
//                char currentChar = input[i];

//                bool alreadyCounted = false;
//                for (int j = 0; j < i; j++)
//                {
//                    if (input[j] == currentChar)
//                    {
//                        alreadyCounted = true;
//                        break;
//                    }
//                }

//                if (alreadyCounted) 
//                {
//                    continue;
//                }

//                int count = 0;
//                for (int j = 0; j < input.Length; j++)
//                {
//                    if (input[j] == currentChar)
//                    {
//                        count++;
//                    }
//                }

//                Console.WriteLine($"Character '{currentChar}' occurs {count} times.");
//            }
//        }
//    }

//}

