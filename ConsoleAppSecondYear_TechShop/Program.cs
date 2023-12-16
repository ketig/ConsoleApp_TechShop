using ConsoleAppSecondYear_TechShop;

Phone phone = new Phone("Samsung", "400$", "Galaxy",
    8, 288, 47);

Console.WriteLine($"Quantity of phone is {phone.GetQuantity()}");
Console.WriteLine($"Brand of phone is {phone.GetBrand()}");
Console.WriteLine($"Price of phone is {phone.GetPrice()}");

phone.SetPrice("550$");