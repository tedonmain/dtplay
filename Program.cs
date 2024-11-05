// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DateTime timeHereNow = new DateTime();
timeHereNow = DateTime.Now;
Console.WriteLine("Time here now: " + timeHereNow);

Thread.Sleep(5000);

DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(
    timeHereNow,
    TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")
);
Console.WriteLine("Convert Time here now to Pacific Standard Time: " + pstTime);

DateTime utcTime = DateTime.UtcNow;
Console.WriteLine("UTC Time: " + utcTime.ToString("yyyy-MM-dd HH:mm:ss.fff"));

DateTimeOffset pstTime2 = TimeZoneInfo.ConvertTime(
    utcTime,
    TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")
);
Console.WriteLine("Convert UTC Time to Pacific Standard Time: " + pstTime2.ToString("yyyy-MM-dd HH:mm:ss.fff"));

String dt1 = pstTime2.ToString("yyyy-MM-dd HH:mm:ss.fff");
Console.WriteLine("dt1 - Pacific Standard Time string: " + dt1);

DateTime dt2 = DateTime.ParseExact(dt1, "yyyy-MM-dd HH:mm:ss.fff", null);
Console.WriteLine("dt2 - dt1 converted to dateteime: " + dt2.ToString("dddd, MMMM dd, yyyy HH:mm:ss.tt"));
Console.WriteLine("dt2 - dt1 converted to dateteime: " + dt2.ToString("yyyy-MM-dd HH:mm:ss.fff"));

Console.WriteLine("Press any key to exit.");
Console.ReadLine();
