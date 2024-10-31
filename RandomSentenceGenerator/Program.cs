using System.Globalization;

namespace RandomSentenceGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Peter", "Michell", "Jane", "Steve" };
            string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
            string[] details = { "near the river", "at home", "in the park" };

            Console.WriteLine("Hello, this is your first random-generated sentence:");

            while (true)
            {
                string randomName = GetRandomWord(names);
                string randomPlace = GetRandomWord(places);
                string randomVerb = GetRandomWord(verbs);
                string randomNoun = GetRandomWord(nouns);
                string randomAdverb = GetRandomWord(adverbs);
                string randomDetail = GetRandomWord(details);

                string sentence = GetRandomSentence(randomName, randomDetail, randomNoun, randomAdverb, randomPlace, randomVerb);
                Console.WriteLine(sentence);
                Console.WriteLine("Click [Enter] to generate a new one.");
                Console.ReadLine();
            }
        }

        static string GetRandomSentence(string name, string detail, string noun, string adverb, string place, string verb)
        {
            string who = $"{name} from {place}";
            string action = $"{adverb} {verb} {noun}";
            return $"{who} {action} {detail}.";
        }

        static string GetRandomWord(string[] words)
        {
            Random random = new Random();
            int index = random.Next(words.Length);
            string word = words[index];
            return word;
        }
    }
}
