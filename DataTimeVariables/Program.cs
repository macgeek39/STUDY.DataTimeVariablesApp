


//DateTime today = DateTime.Now;
//DateTime birthday = DateTime.Parse("6/11/1983");
//DateTime birthday = DateTime.ParseExact("6/11/1983", "d/M/yyyy", CultureInfo.InvariantCulture);
//Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz"));

//Date Only

DateTime today = DateTime.Now;
DateOnly birthday = DateOnly.Parse("5/17/2028");
Console.WriteLine(birthday.ToString("MMMM dd, yyyy"));

Console.WriteLine($"Today just date: {today.Date}");
Console.WriteLine($"Birthday full format: {birthday}");