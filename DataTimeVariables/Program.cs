


//DateTime today = DateTime.Now;
//DateTime birthday = DateTime.Parse("6/11/1983");
//DateTime birthday = DateTime.ParseExact("6/11/1983", "d/M/yyyy", CultureInfo.InvariantCulture);
//Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz"));

//Date Only
//DateTime today = DateTime.Now;
//DateOnly birthday = DateOnly.Parse("5/17/2028");
//Console.WriteLine(birthday.ToString("MMMM dd, yyyy"));
//Console.WriteLine($"Today just date: {today.Date}");
//Console.WriteLine($"Birthday full format: {birthday}");

//Time Only
//TimeOnly openAt = TimeOnly.Parse("9:00 AM");
//TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);
//Console.WriteLine(openAt);
//Console.WriteLine(rightNow);

// Type Conversions
Console.Write("What is your First Name: ");
string? firstName = Console.ReadLine();
Console.Write("What is your Last Name: ");
string? lastName = Console.ReadLine();

Console.Write($"Hi {firstName} {lastName}, How old are you?");

string? ageText = Console.ReadLine();

int age = int.Parse(ageText);

Console.WriteLine($"{firstName} {lastName}, you will be {age + 20} in 20 years!");