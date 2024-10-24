
Console.WriteLine("enter numbers separated by spaces:");
string input = Console.ReadLine();
int[] numbers = new int[100];
int count = 0;
string currentNumber = "";

// Loop through each character in the input string
for (int i = 0; i < input.Length; i++)
{
    char currentChar = input[i];

    // If the character is a space, we consider the current number complete
    if (currentChar == ' ')
    {
        // If we have a current number to add to the array
        if (currentNumber.Length > 0)
        {
            // Convert the current number to an integer and store it in the array
            numbers[count] = int.Parse(currentNumber);
            count++; // Move to the next index in the array
            currentNumber = ""; // Reset the current number for the next input
        }
    }
    else
    {
        // If it's not a space, it's part of a number, so we add it to the current number string
        currentNumber += currentChar;
    }
}

// Add the last number if there is one
if (currentNumber.Length > 0)
{
    numbers[count] = int.Parse(currentNumber);
    count++; // Move to the next index
}

// Create a final array with the exact size of count
int[] finalNumbers = new int[count];
for (int i = 0; i < count; i++)
{
    finalNumbers[i] = numbers[i];
}

// Print the numbers in the array
Console.WriteLine("You entered the following numbers:");
for (int i = 0; i < finalNumbers.Length; i++)
{
    Console.Write(finalNumbers[i] + " ");
}