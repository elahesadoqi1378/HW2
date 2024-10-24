
Console.WriteLine("enter cost of the item:");
int cost = Convert.ToInt32((Console.ReadLine()));
int fiftyCoins = 0;
int tenCoins = 0;
int fiveCoins = 0;
int oneCoins = 0;

// Calculate the number of 50 Toman coins
if (cost >= 50)
{
    fiftyCoins = cost / 50;
    cost %= 50; // Update the amount to remainder
}

// Calculate the number of 10 Toman coins
if (cost >= 10)
{
    tenCoins = cost / 10;
    cost %= 10; // Update the amount to remainder
}

// Calculate the number of 5 Toman coins
if (cost >= 5)
{
    fiveCoins = cost / 5;
    cost %= 5; // Update the amount to remainder
}

// The remainder is the number of 1 Toman coins
oneCoins = cost;

// Print the result
Console.WriteLine("min number of coins needed is");
Console.WriteLine("50 Toman coins: " + fiftyCoins);
Console.WriteLine("10 Toman coins: " + tenCoins);
Console.WriteLine("5 Toman coins: " + fiveCoins);
Console.WriteLine("1 Toman coins: " + oneCoins);
    
