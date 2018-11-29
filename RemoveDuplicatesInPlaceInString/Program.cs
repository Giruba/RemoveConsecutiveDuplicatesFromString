using System;

namespace RemoveDuplicatesInPlaceInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove consecutive duplicates from string in place!");
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Enter the string containing duplicates");
            String inputString = Console.ReadLine();
            String resultString = GetDuplicatesRemovedString(inputString);
            if (!string.IsNullOrEmpty(resultString))
            {
                Console.WriteLine();
                Console.WriteLine("---The resultant string---");
                Console.WriteLine(resultString);
            }
            else {
                Console.WriteLine("Input and resultant strings are empty!");
            }

            Console.ReadLine();
        }

        private static String GetDuplicatesRemovedString(string inputString) {
            if (string.IsNullOrEmpty(inputString)) {
                return inputString;
            }
            Char[] charArray = new Char[inputString.Length];
            int count = 0;
            for (int i = 0; i < inputString.Length; i++) {
                charArray[count++] = inputString[i];
                while (i + 1 < inputString.Length && inputString[i] == inputString[i + 1]) {
                    i++;
                }
            }
            return new String(charArray);
        }
    }
}
