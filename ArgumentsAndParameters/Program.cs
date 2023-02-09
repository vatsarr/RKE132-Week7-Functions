
Console.WriteLine("Enter a word:");
string userInput = Console.ReadLine();

PrintWord(userInput);

static void PrintWord(string anyString)
{
	anyString = anyString.ToUpper();
	for (int i = 0; i < 5; i++)
	{
		Console.WriteLine(anyString);
	}
}