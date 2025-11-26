

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = "/home/marat/Development/C#/PSU-Laboratory-Work/Laba4/FirstNumbers/FirstNumbers/";
            Console.WriteLine(string.Join(", ", EnterNums.RemoveAfterE([1, 1, 3, 4], 1)));
            Console.WriteLine(EnterNums.HasEqualNeighbors([1, 2, 3, 1]));

            var tourists = new Dictionary<string, List<string>>()
            {
                { "anna" , ["Angola", "Columbia"]},
                { "ben" , ["Angola", "Columbia"]},
                { "tom" , ["Angola"]}
            };
            Console.WriteLine(String.Join(", ", EnterNums.AnalyzeTouristCountries(["Angola", "Belgia", "Columbia"], tourists)));
            Console.WriteLine(String.Join(", ", EnterNums.FindDeafConsonants(path + "Num4.txt")));

            EnterNums.CreateTestDataFile(path + "Num5.txt");
            var result = EnterNums.ProcessApplicants(path + "Num5.txt");
            foreach (var applicant in result)
            {
                Console.WriteLine(applicant);
            }
        }
    }
}