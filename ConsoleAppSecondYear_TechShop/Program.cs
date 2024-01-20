using ConsoleAppSecondYear_TechShop;

Phone phone = new Phone("Samsung", "400$", "Galaxy", 8, 288, 47);
Phone phone2 = new Phone("iPhone", "1000$", "14Pro MAX", 16, 288, 25);

phone.Price = "550$";
phone.Quantity -= 4; // 4-ით შემცირება

phone.Print();

phone.Price = "400$";
phone.Quantity /= 2; // 2-ჯერ შემცირება

// phone-ის მონაცემების ბეჭდვა
phone.Print();

phone2.Print();