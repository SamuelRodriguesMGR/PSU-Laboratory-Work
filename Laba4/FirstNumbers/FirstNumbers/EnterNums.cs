
using System.Collections.Generic;


public class EnterNums
{
    public static List<T> RemoveAfterE<T>(List<T> list, T element)
    {
        List<T> result = new List<T>();
        for (int i = 0; i < list.Count; i++)
        {
            result.Add(list[i]);

            if (list[i].Equals(element) &&
                i + 1 < list.Count &&
                !list[i + 1].Equals(element))
            {
                i++;
            }
        }

        return result;
    }

    public static bool HasEqualNeighbors<T>(List<T> list)
    {
        // короче блин, если один элемент или меньше, то бан без объяснений
        if (list == null || list.Count <= 1)
            return false;

        for (int i = 0; i < list.Count; i++)
        {
            int nextIndex = (i + 1) % list.Count;
            if (list[i].Equals(list[nextIndex]))
                return true;
        }

        return false;
    }

    public static Dictionary<string, TouristStatus> AnalyzeTouristCountries(List<string> countries, Dictionary<string, List<string>> touristVisits)
    {
        Dictionary<string, TouristStatus> result = new Dictionary<string, TouristStatus>();
        int totalTourists = touristVisits.Count;

        foreach (string country in countries)
        {
            int visitorsCount = CountTouristsVisitedCountry(country, touristVisits); // АААА количество туристов посетивших эту страну
            // Console.WriteLine(visitorsCount);

            if (visitorsCount == totalTourists)
            {
                result[country] = TouristStatus.AllVisited;
            }
            else if (visitorsCount > 0)
            {
                result[country] = TouristStatus.SomeVisited;
            }
            else
            {
                result[country] = TouristStatus.NoneVisited;
            }
                
        }

        return result;
    }

    private static int CountTouristsVisitedCountry(string country, Dictionary<string, List<string>> touristVisits)
    {
        int count = 0;
        foreach (var visits in touristVisits.Values)
        {
            if (visits.Contains(country)) // содержится ли страна
                count++;
        }
        return count;
    }

    public static List<char> FindDeafConsonants(string filePath)
    {
        string text = File.ReadAllText(filePath).ToLower();
        char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '(', ')', '\n' };
        string[] words = text.Split(separators);

        HashSet<char> deafConsonants = new HashSet<char> { 'п', 'ф', 'к', 'т', 'ш', 'с', 'х', 'ц', 'ч', 'щ' };
        Dictionary<char, int> consonantWordCount = new Dictionary<char, int>();

        foreach (char consonant in deafConsonants)
        {
            consonantWordCount[consonant] = 0;
        }
        // Console.WriteLine(String.Join(", ", consonantWordCount));

        foreach (string word in words)
        {
            HashSet<char> consonantsInWord = new HashSet<char>();

            foreach (char c in word)
            {
                if (deafConsonants.Contains(c)) // есть еть глухая согласная
                {
                    consonantsInWord.Add(c);
                }
            }
            // Console.WriteLine(String.Join(", ", consonantsInWord));

            foreach (char consonant in consonantsInWord)
            {
                consonantWordCount[consonant]++;
            }
        }
        Console.WriteLine(String.Join(", ", consonantWordCount));

        List<char> result = new List<char>();
        foreach (var pair in consonantWordCount)
        {
            if (pair.Value != 1) // если согласная встречалось больше или меньше 1 раз в словах -> добавить в список
            {
                result.Add(pair.Key);
            }
        }

        result.Sort();

        return result;
    }

    public static void CreateTestDataFile(string filePath)
    {
        string[] testData = {
            "5",
            "Ветров Роман 68 59",
            "Анисимова Екатерина 64 88",
            "Петров Иван 25 45",
            "Сидорова Анна 35 28",
            "Козлов Дмитрий 20 25"
        };

        File.WriteAllLines(filePath, testData);
    }

    public static List<string> ProcessApplicants(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath); // чит файл
        List<Applicant> failedApplicants = new List<Applicant>();
        
        for (int i = 1; i < lines.Length; i++)
        {
            Applicant applicant = ParseApplicant(lines[i]);
            
            if (applicant.Score1 < 30 || applicant.Score2 < 30)
            {
                failedApplicants.Add(applicant);
            }
        }
        // Console.WriteLine(String.Join(", ", failedApplicants));

        List<string> result = new List<string>();

        foreach (var applicant in failedApplicants)
        {
            result.Add($"{applicant.LastName} {applicant.FirstName}");
        }

        result.Sort();
            
        return result;
    }


    private static Applicant ParseApplicant(string line) // Жоско делим абиатурента на части
    {
        string[] parts = line.Split(' ');
            
        return new Applicant
        {
            LastName = parts[0],
            FirstName = parts[1],
            Score1 = int.Parse(parts[2]),
            Score2 = int.Parse(parts[3])
        };
    }

    private class Applicant
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
    }


}

public enum TouristStatus
{
    AllVisited, // 0
    SomeVisited, // 1
    NoneVisited // 2
}

