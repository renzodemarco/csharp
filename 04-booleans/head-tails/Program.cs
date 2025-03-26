Random coin = new Random();

int number = coin.Next(0, 2);
string coinSide = number == 0 ? "heads" : "tails";

Console.WriteLine($"Number is {number} so the coin landed on {coinSide}");