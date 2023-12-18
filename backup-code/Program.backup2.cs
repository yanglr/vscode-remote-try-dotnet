// using System.Globalization;

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         var builder = WebApplication.CreateBuilder(args);
//         var app = builder.Build();

//         // Add test code here
//         DateTime dateValue;
//         if (DateTime.TryParse("2013/07/22", new CultureInfo("zh-TW"), DateTimeStyles.None, out dateValue))
//         {
//             Console.WriteLine(dateValue.ToString());
//         }
//         else
//         {
//             Console.WriteLine("fail");
//         }

//         app.Urls.Add("http://localhost:5000");
//         app.MapGet("/", () => "Hello World!");
//         app.Run();
//     }
// }