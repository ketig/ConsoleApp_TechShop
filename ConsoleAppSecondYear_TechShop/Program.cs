using ConsoleAppSecondYear_TechShop;

Phone phone = new Phone("Samsung", "400$", "Galaxy", 8, 288, 47);

phone.Price = "550$";
phone.Quantity -= 4; // 4-ით შემცირება

Console.WriteLine($"Brand of phone is {phone.Brand}");
Console.WriteLine($"Price of phone is {phone.Price}");
Console.WriteLine($"Model of phone is {phone.Model}");
Console.WriteLine($"RAM of phone is {phone.RAM}");
Console.WriteLine($"Memory of phone is {phone.Memory}");
Console.WriteLine($"Quantity of phone is {phone.Quantity}");

phone.Price = "400$";
phone.Quantity /= 2; // 2-ჯერ შემცირება

Console.WriteLine($"Brand of phone is {phone.Brand}");
Console.WriteLine($"Price of phone is {phone.Price}");
Console.WriteLine($"Model of phone is {phone.Model}");
Console.WriteLine($"RAM of phone is {phone.RAM}");
Console.WriteLine($"Memory of phone is {phone.Memory}");
Console.WriteLine($"Quantity of phone is {phone.Quantity}");