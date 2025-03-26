Random coin = new Random();

int number = coin.Next(0, 9);
string coinSide = number >= 5 ? "heads" : "tails";

Console.WriteLine($"Number is {number} so the coin landed on {coinSide}");