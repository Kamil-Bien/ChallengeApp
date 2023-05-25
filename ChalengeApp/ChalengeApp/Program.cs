int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
int[] countNumber = new int[10];



foreach (var oneNumber  in letters)
{	
    for (int i = 0; i < 10; i++)
	{
		string iString = i.ToString();
        string oneNumberString = oneNumber.ToString();
        if (iString == oneNumberString)
		{
			countNumber[i]++;
		}
	}
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + " => " + countNumber[i]);
}