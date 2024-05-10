string[] array = { "Hello", "2", "world", ":-)" };

int count = 0;
foreach (string str in array)
{
    if (str.Length <= 3)
    {
        count++;
    }
}

string[] newArray = new string[count];

int index = 0;
foreach (string str in array)
{
    if (str.Length <= 3)
    {
        newArray[index] = str;
        index++;
    }
}

Console.WriteLine("[" + string.Join(", ", newArray) + "]");