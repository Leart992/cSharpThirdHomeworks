using System;

namespace FirstTask
{
    class Program
    {

        static void FunWithStrings(string inputstr)
        {

            //print the reverse string
            char[] reverseArray = inputstr.ToCharArray();
            Array.Reverse(reverseArray);
            string reversedArray = new string(reverseArray);
           // Console.WriteLine("Array after reversing: " + reversedArray);

            //print total number of vowels
            int vowelsCount = 0;

            string toLow = inputstr.ToLower();

            for (int i = 0; i < toLow.Length; i++)
            {

                if (toLow[i] == 'a' || toLow[i] == 'e' || toLow[i] == 'i' || toLow[i] == 'o' || toLow[i] == 'u')
                {

                   vowelsCount++;
                }
            }
             //Console.WriteLine("Vowels found: " + vowelsCount);


            //check if string is palindrome
            string first = inputstr.Substring(0, inputstr.Length / 2);
            char[] arrPal = inputstr.ToCharArray();
            Array.Reverse(arrPal);
            string palindromed = new string(arrPal);
            string second = palindromed.Substring(0, palindromed.Length / 2);

            //Console.WriteLine(first.Equals(second));


            //print the largest word
            string[] words = inputstr.Split(new[] { " " }, StringSplitOptions.None);

            string word = "";
            int longestWord = 0;
           
            foreach (String str in words)
            {
                if (str.Length > longestWord)
                {
                    word = str;
                    longestWord = str.Length;
                }
                                
            }

            //Console.WriteLine("The longest word is: " + word);


            //print the smallest word
            string[] words2 = inputstr.Split(new[] { " " }, StringSplitOptions.None);

            string word2 = "";
            int smallesttWord = 0;

            foreach (String str in words2)
            {
                if (str.Length < longestWord)
                {
                    word2 = str;
                    smallesttWord = str.Length;
                }

            }
            //Console.WriteLine("The smallest word is: " + word2);




            //print the count of words
            int wordCount = 0;

            for (int i = 0; i < inputstr.Length - 1; i++)
            {
               
                if (inputstr[i] == ' ' && Char.IsLetter(inputstr[i + 1]) && (i > 0))
                {
                    wordCount++;
                }
            }
          
            wordCount++;

            //Console.WriteLine("Total number of words in the given string: " + wordCount);


            //print the most used character(not space obviously)
            int[] freq = new int[inputstr.Length];
            char minChar = inputstr[0], maxChar = inputstr[0];
            int q, j, min, max;

        
            char[] string1 = inputstr.ToCharArray();

            
            for (q = 0; q < string1.Length; q++)
            {
                freq[q] = 1;
                for (j = q + 1; j < string1.Length; j++)
                {
                    if (string1[q] == string1[j] && string1[q] != ' ' && string1[q] != '0')
                    {
                        freq[q]++;

                        
                        string1[j] = '0';
                    }
                }
            }

            
            min = max = freq[0];
            for (q = 0; q < freq.Length; q++)
            {

                
                if (min > freq[q] && freq[q] != '0')
                {
                    min = freq[q];
                    minChar = string1[q];
                }
                
                if (max < freq[q])
                {
                    max = freq[q];
                    maxChar = string1[q];
                }
            }

            Console.WriteLine("Minimum occurring character: " + minChar);
            Console.WriteLine("Maximum occurring character: " + maxChar);


            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //Create a new method called FunWithStrings that will have one input parameter(string) and it will have no return
            //In that method you should display in console the following tasks for the string:
            //print the reverse string
            //print total number of vowels
            //check if string is palindrome
            //print the largest word
            //print the smallest word
            //print the count of words
            //print the most used character(not space obviously)
            //Ask the user to enter a string and call the method with that string.

          
            Console.WriteLine("Enter a string: ");
            string userInput = Console.ReadLine();

            FunWithStrings(userInput);

            Console.ReadLine();

        }


        
    }
}
