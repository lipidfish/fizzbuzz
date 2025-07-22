namespace FizzBuzzApp{
    class Program
    {
        // To run, use this command from the same folde as the .sln file: 
        // dotnet run --project FizzBuzzApp/FizzBuzzApp.csproj
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzz.GetFizzBuzz(2));
            }
        }
    }
}

