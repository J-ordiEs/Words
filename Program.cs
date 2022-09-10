string[] words =
{
    "home",
    "programming",
    "victory",
    "C#",
    "football",
    "sport",
    "book",
    "learn",
    "dream",
    "fun"
};

string newWords = String.Join(" ", words);
string letter = Console.ReadLine();
int count = 0;

if (newWords.Contains(letter))
{    
    foreach (var item in words)
	{        
        if (words[count].Contains(letter))
	    {
            Console.WriteLine(item);
	    }
        count++;
	}    
}else
{
    Console.WriteLine("No match");
}