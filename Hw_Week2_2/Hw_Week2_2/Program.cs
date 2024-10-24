Console.Write("Enter first string: ");
string str1 = Console.ReadLine();

Console.Write("Enter second string: ");
string str2 = Console.ReadLine();

int[,] dp = new int[str1.Length + 1, str2.Length + 1];
int maxLength = 0;
int endIndex = 0;

for (int i = 1; i <= str1.Length; i++)
{
    for (int j = 1; j <= str2.Length; j++)
    {
        // If characters match, increment length count
        if (str1[i - 1] == str2[j - 1])
        {
            dp[i, j] = dp[i - 1, j - 1] + 1;
            // Update maximum length and end index
            if (dp[i, j] > maxLength)
            {
                maxLength = dp[i, j];
                endIndex = i;
            }
        }
    }
}


string result = str1.Substring(endIndex - maxLength, maxLength);


if (maxLength > 0)
{
    Console.WriteLine("The largest common substring is: " + result);
}
else
{
    Console.WriteLine("There is no common substring.");
}