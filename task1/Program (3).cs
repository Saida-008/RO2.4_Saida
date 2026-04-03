using System;

class CoffeeOrder
{
    static void Main()
    {
     
        Console.Write("Enter Coffee Name: ");
        string coffeeName = Console.ReadLine();

        Console.Write("Enter Price per Cup: ");
        double pricePerCup = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Number of Cups: ");
        int numberOfCups = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Sugar Portions: ");
        int sugarPortions = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Extra Topping Price: ");
        double toppingPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter First Letter of Size: ");
        char sizeLetter = Convert.ToChar(Console.ReadLine());

        Console.Write("Is Takeaway (true/false): ");
        bool isTakeaway = Convert.ToBoolean(Console.ReadLine());

   
        double coffeeCost = pricePerCup * numberOfCups;
        double sugarCost = sugarPortions * 0.2;
        double totalOrderPrice = coffeeCost;

        totalOrderPrice += sugarCost;       
        totalOrderPrice += toppingPrice;    

        
        Console.WriteLine("\n--- Order Details ---");
        Console.WriteLine("Coffee Name: " + coffeeName);
        Console.WriteLine("Price per Cup: " + pricePerCup);
        Console.WriteLine("Number of Cups: " + numberOfCups);
        Console.WriteLine("Sugar Portions: " + sugarPortions);
        Console.WriteLine("Extra Topping Price: " + toppingPrice);
        Console.WriteLine("Size Letter: " + sizeLetter);
        Console.WriteLine("Takeaway: " + isTakeaway);

        Console.WriteLine("\n--- Calculated Results ---");
        Console.WriteLine("Coffee Cost: " + coffeeCost);
        Console.WriteLine("Sugar Cost: " + sugarCost);
        Console.WriteLine("Total Order Price: " + totalOrderPrice);
    }
}