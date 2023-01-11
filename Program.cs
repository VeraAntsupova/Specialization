System.Console.WriteLine("Введите слова через запятую:");

string[] words = Console.ReadLine().Split(',');

string[] results = new string[words.Length];
for (int i = 0; i < words.Length; i++)
{
    if (words[i].Length <= 3) {
        results[i] = words[i];
    }
    
}


foreach(var result in results)
    System.Console.WriteLine(result);