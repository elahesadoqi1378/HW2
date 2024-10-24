using System.Drawing;

Console.WriteLine("enter the number of elements in array:");
int measure = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[measure];
Console.WriteLine($"Enter {measure} numbers:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("element " + (i + 1) + ":");
    numbers[i] = Convert.ToInt32((Console.ReadLine()));
}


int smallest = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < smallest)
    {
        smallest = numbers[i];
    }

}
Console.WriteLine("smallest number is:" + smallest);
int largest = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > largest)
    {
        largest = numbers[i];
    }
}
Console.WriteLine("largest number is:" + largest);
int[] numbers2 = new int[measure];

for (int i = 0; i < numbers.Length; i++)
{
    numbers2[i] = numbers[numbers.Length - 1 - i];
}
Console.WriteLine("reversed array is:");
foreach (int i in numbers2)
{
    Console.WriteLine(i + " "); 
}
Array.Sort(numbers);
Console.WriteLine("sorted arrey is:");
foreach (int i in numbers)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nRepeated elements with their counts and indices:");
for (int i = 0; i < measure; i++)
{
    // Check if the element has already been counted
    bool isDuplicate = false;

    for (int j = 0; j < i; j++)
    {
        if (numbers[i] == numbers[j])
        {
            isDuplicate = true;
            break;
        }
    }

    // If it's not a duplicate, count the repetitions
    if (!isDuplicate)
    {
        int count = 1;
        Console.Write($"Element {numbers[i]}: ");
        Console.Write("Indices: " + i);

        // Count how many times the element is repeated
        for (int k = i + 1; k < measure; k++)
        {
            if (numbers[k] == numbers[i])
            {
                count++;
                Console.Write($", {k}"); // Print the index of the repeat
            }
        }

        // Print the count of repetitions
        if (count > 1)
        {
            Console.WriteLine($" | Count: {count}");
        }

        Console.WriteLine("enter the measure of the second array:");
        int measure2 = int.Parse(Console.ReadLine());
        int[] array2 = new int[measure2];

        Console.WriteLine("enter the elements of the second array:");
        for (int m = 0; m < measure2; m++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Common members between two arrays:");

        bool foundCommon = false; // To track if any common element is found

        for (int n = 0; n < measure; n++)
        {
            for (int l = 0; l < measure; l++)
            {
                if (numbers[n] == array2[l])
                {
                    Console.WriteLine(numbers[n]); // Print the common element
                    foundCommon = true; // Set flag to true
                    break; // Exit inner loop to avoid printing duplicates
                }
            }
        }

        if (!foundCommon)
        {
            Console.WriteLine("No common members found.");
        }
    }
}


