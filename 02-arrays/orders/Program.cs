﻿string[] fraudulentOrderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach(string order in fraudulentOrderIDs) 
{
  if (order.StartsWith("B"))
  {
    Console.WriteLine($"The name {order} starts with 'B'!");
  }
}