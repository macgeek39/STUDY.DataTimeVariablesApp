


DateTime today = DateTime.Now;

//DateTime birthday = DateTime.Parse("6/11/1983");

//DateTime birthday = DateTime.ParseExact("6/11/1983", "d/M/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(today.ToString(format: "MMMM dd, yyyy hh:mm tt zzz"));