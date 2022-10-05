var now = DateTime.Today;


DateTime newYear2023 = new DateTime(2023, 01, 01 ) ;

DateTime newYear2022 = new (2022, 01, 01 );

Console.WriteLine(now - newYear2022 + "days passed from New Year");

Console.WriteLine(newYear2023 - now + "days left to New Year");

Console.ReadKey();




