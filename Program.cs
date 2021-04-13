using System;

namespace NonRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test1 -- ExpOut = 1
            string string1 = "abcdcaf";
            FirstNonRepeatingCharacter(string1);

            // Test2
            string string2 = "faadabcbbebdf";
            FirstNonRepeatingCharacter(string2);
        }
        public static void FirstNonRepeatingCharacter(string str)
        {
            // Declare pointers and loop condition
            int nonRepeatIndex = 0;
            int traverser = 0;
            bool foundDuplicate = false;

            // Type conversion required to iterate
            char[] charArr = str.ToCharArray();

            // While Iteration - Loop while nonRepeatIndex < overall length
            while(nonRepeatIndex < charArr.Length)
            {
                // Assume no duplicates found when entering the general loop
                foundDuplicate = false;
                // Iterative Evaluation
                for (traverser =0; traverser < charArr.Length; traverser++)
                {
                    if (charArr[nonRepeatIndex] == charArr[traverser] && nonRepeatIndex != traverser)
                    {
                        foundDuplicate = true;
                    }
                }
                if (!foundDuplicate)
                {
                    Console.WriteLine($"The index of non-repeating character is: {nonRepeatIndex}");
                }
                // Increment nonRepeatIndex to continue loop
                nonRepeatIndex++;
            }
            Console.WriteLine("There are no repeating characters in your array");
        }
    }
}
