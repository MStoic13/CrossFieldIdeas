using System;

namespace CommonLibrary
{
    public static class EnglishPronounceableWordGenerator
    {
        private static string Vowels = "aeiouy";
        private static string Consonants = "bcdfghjklmnpqrstvwxz";

        public static string GetWord()
        {
            string result = string.Empty;

            Random random = new Random();

            // word length between 1 and 12
            int wordSize = random.Next(2, 13);
            bool isPreviousConsonant = false;

            for(int index = 0; index < wordSize; index++)
            {
                bool isConsonant = random.Next(2) == 0;
                if(isConsonant && !isPreviousConsonant)
                {
                    result += Consonants[random.Next(0, Consonants.Length)];
                    isPreviousConsonant = true;
                }
                else
                {
                    result += Vowels[random.Next(0, Vowels.Length)];
                    isPreviousConsonant = false;
                }
            }

            return result;
        }
    }
}
