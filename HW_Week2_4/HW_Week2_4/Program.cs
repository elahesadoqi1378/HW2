Console.WriteLine("enter a sentence:");
string str = Console.ReadLine();

// Initialize variables to track the most repeated character
char mostfrequented = ' ';
int maxCount = 0;

// Loop through each character in the input string
for (int i = 0; i < str.Length; i++)
{
    char currentChar = str[i];

    // Skip spaces
    if (currentChar == ' ')
        continue;

    int count = 0;

    // Count the occurrences of the current character
    for (int j = 0; j < str.Length; j++)
    {
        if (str[j] == currentChar)
        {
            count++;
        }
    }

    // Update the most repeated character if current count is higher
    if (count > maxCount)
    {
        maxCount = count;
        mostfrequented = currentChar;
    }
}

// Display the result
Console.WriteLine($"The most repeated character is '{mostfrequented}' with {maxCount} repetitions.");





