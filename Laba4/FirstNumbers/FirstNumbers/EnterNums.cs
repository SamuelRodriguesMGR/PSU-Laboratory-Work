
using System.Collections.Generic;


public class EnterNums
{
    private List<dynamic> listL;

    public EnterNums(List<dynamic> listl)
    {
        listL = listl;
    }

    public string GetListL()
    {
        var array = listL.ToArray();
        return string.Join(", ", array);
    }

    public void RemoveAfterE(dynamic E)
    {
        int i = 0;
        while (i < listL.Count - 1)
        {
            if (listL[i] == E && listL[i + 1] != E)
            {
                // удаляем следущий элемент
                listL.RemoveAt(i + 1);
                break;
            }
            else
            {
                i += 1;
            }
        }
    }

    public bool ElementHaveCopy()
    {
        for (int i = 0; i < listL.Count - 1; i++)
        {
            if (listL[i] == listL[i + 1])
            {
                return true;
            }
        }
        Console.WriteLine(listL[0] + listL[listL.Count - 1]);
        if (listL[listL.Count - 1] == listL[0])
        {
            return true;
        }
        return false;
    }
    
    public void Deaf()
    {
        char[] deafConsonants = { 'п', 'ф', 'к', 'т', 'ш', 'с', 'х', 'ц', 'ч', 'щ' };
        char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '(', ')', '\n' };

        string text = File.ReadAllText("/home/marat/Development/C#/PSU-Laboratory-Work/Laba4/FirstNumbers/FirstNumbers/Num4.txt").ToLower();
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<char, int> letterCount = new Dictionary<char, int>();

        foreach (string word in words)
        {
            HashSet<char> lettersInWord = new HashSet<char>();

            foreach (char letter in word)
            {
                if (deafConsonants.Contains(letter))
                {
                    lettersInWord.Add(letter);
                }
            }

            // Увеличиваем счетчик для каждой уникальной буквы в слове
            foreach (char letter in lettersInWord)
            {
                if (letterCount.ContainsKey(letter))
                {
                    letterCount[letter] += 1;
                }
                else
                {
                    letterCount[letter] = 1;
                }
            }
        }
        
        // Отбираем буквы, которые не входят ровно в одно слово
        List<char> resultLetters = new List<char>();
        foreach (var pair in letterCount)
        {
            if (pair.Value != 1)
            {
                resultLetters.Add(pair.Key);
            }
        }

        // Сортируем результат в алфавитном порядке
        resultLetters.Sort();

        // Выводим результат
        Console.WriteLine("Глухие согласные, которые не входят ровно в одно слово:");
        foreach (char letter in resultLetters)
        {
            Console.Write(letter + " ");
        }
    }
}

